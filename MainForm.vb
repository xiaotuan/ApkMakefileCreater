Imports System.IO
Imports System.IO.Compression

Public Class createrForm
    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSelectApkFile_Click(sender As Object, e As EventArgs) Handles btnSelectApkFile.Click
        If ofdSelectFile.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            tbApkFilePath.Text = ofdSelectFile.FileName
            Dim fileName = Path.GetFileNameWithoutExtension(ofdSelectFile.FileName)
            If fileName.Contains(" ") Then
                fileName = fileName.Replace(" ", "_")
            End If
            tbAppName.Text = fileName
            UpdateFormInfos()
        End If
    End Sub

    Private Sub btStartCreate_Click(sender As Object, e As EventArgs) Handles btStartCreate.Click
        Dim apkFilePath = tbApkFilePath.Text
        If apkFilePath.Trim.Length() > 0 Then
            If apkFilePath.Trim.ToLower.EndsWith(".apk") Then
                ' 获取 APK 文件目录路径
                Dim dirPath As String = Path.GetDirectoryName(tbApkFilePath.Text)

                ' 创建生成的目录
                Dim appName As String = tbAppName.Text
                If appName.Trim.Length <= 0 Then
                    appName = Path.GetFileNameWithoutExtension(apkFilePath)
                End If
                dirPath = dirPath + "\" + appName
                Debug.WriteLine("Directory path: " & dirPath)
                If System.IO.Directory.Exists(dirPath) Then
                    System.IO.Directory.Delete(dirPath, True)
                End If
                System.IO.Directory.CreateDirectory(dirPath)


                ' 拷贝 APK 文件
                System.IO.File.Copy(apkFilePath, dirPath + "\" + Path.GetFileName(apkFilePath).Replace(" ", "_"))

                Dim libDirName = "arm64-v8a"
                If rbArmeabi.Checked Then
                    libDirName = "armeabi"
                ElseIf rbArmeabiV7a.Checked Then
                    libDirName = "armeabi-v7a"
                End If
                Debug.WriteLine("libDirName: " & libDirName)

                ' 库文件存放路径
                Dim libDirPath = dirPath + "\lib\" + libDirName
                Debug.WriteLine("libDirPath: " & libDirPath)

                ' APK 文件安装路径
                Dim installPath = cbBuildInPath.Text
                If installPath.Trim.Length <= 0 Then
                    installPath = "system\app"
                End If
                Debug.WriteLine("installPath: " & installPath)

                ' 解压缩库文件                   
                Using archive As ZipArchive = ZipFile.OpenRead(tbApkFilePath.Text)
                    For Each entry As ZipArchiveEntry In archive.Entries
                        If entry.FullName.StartsWith("lib/") Then
                            Debug.WriteLine("Entry name: " & entry.FullName)
                            Dim names = entry.FullName.Split("/")
                            If libDirName.Equals(names(1)) Then
                                If Not System.IO.Directory.Exists(libDirPath) Then
                                    System.IO.Directory.CreateDirectory(libDirPath)
                                End If
                                entry.ExtractToFile(libDirPath + "/" + Path.GetFileName(entry.FullName))
                            End If
                        End If
                    Next
                End Using

                ' 生成 Android.mk 文件
                Dim mkFilePath As String = dirPath + "\Android.mk"
                System.IO.File.Create(mkFilePath).Close()
                Dim mkWriter = New System.IO.StreamWriter(mkFilePath)
                mkWriter.NewLine = vbLf
                mkWriter.WriteLine("LOCAL_PATH := $(call my-dir)")
                mkWriter.WriteLine("")
                mkWriter.WriteLine("include $(CLEAR_VARS)")
                mkWriter.WriteLine("LOCAL_MODULE := " & appName.Replace(" ", "_"))
                mkWriter.WriteLine("LOCAL_MODULE_CLASS := APPS")
                mkWriter.WriteLine("LOCAL_MODULE_TAGS := optional")
                mkWriter.WriteLine("LOCAL_MODULE_SUFFIX := $(COMMON_ANDROID_PACKAGE_SUFFIX)")
                If installPath.Equals("system/priv-app") Then
                    mkWriter.WriteLine("LOCAL_PRIVILEGED_MODULE := true")
                ElseIf installPath.Equals("product/app") Then
                    mkWriter.WriteLine("LOCAL_PRODUCT_MODULE := true")
                ElseIf installPath.Equals("product/priv-app") Then
                    mkWriter.WriteLine("LOCAL_PRIVILEGED_MODULE := true")
                    mkWriter.WriteLine("LOCAL_PRODUCT_MODULE := true")
                End If
                If rbSystemSignature.Checked Then
                    mkWriter.WriteLine("LOCAL_CERTIFICATE := platform")
                ElseIf rbNotSystemSignature.Checked Then
                    mkWriter.WriteLine("LOCAL_CERTIFICATE := PRESIGNED")
                End If
                mkWriter.WriteLine("LOCAL_REPLACE_PREBUILT_APK_INSTALLED := $(LOCAL_PATH)/" & Path.GetFileName(apkFilePath).Replace(" ", "_"))
                If rbCreateOdex.Checked Then
                    mkWriter.WriteLine("LOCAL_DEX_PREOPT := true")
                Else
                    mkWriter.WriteLine("LOCAL_DEX_PREOPT := false")
                End If
                If libDirName.Equals("arm64-v8a") Then
                    mkWriter.WriteLine("LOCAL_MULTILIB := 64")
                Else
                    mkWriter.WriteLine("LOCAL_MULTILIB := 32")
                End If
                If Not rbAllow.Checked Then
                    mkWriter.WriteLine("")
                    mkWriter.WriteLine("LOCAL_ENFORCE_USES_LIBRARIES := false")
                End If

                ' 遍历库文件，添加库文件依赖
                If System.IO.Directory.Exists(libDirPath) Then
                    mkWriter.WriteLine("")
                    mkWriter.WriteLine("LOCAL_PREBUILT_JNI_LIBS := \")
                    Dim files = System.IO.Directory.EnumerateFiles(libDirPath)
                    Dim index = 0
                    For Each f In files
                        Debug.WriteLine("File path: " + f)
                        If (index + 1) < files.Count Then
                            mkWriter.WriteLine("    lib/" & libDirName + "/" & Path.GetFileName(f) & " \")
                        Else
                            mkWriter.WriteLine("    lib/" & libDirName + "/" & Path.GetFileName(f))
                        End If
                        index += 1
                    Next
                End If
                mkWriter.WriteLine("")
                mkWriter.WriteLine("include $(BUILD_PREBUILT)")
                mkWriter.WriteLine("include $(call all-makefiles-under,$(LOCAL_PATH))")
                mkWriter.Close()
                MessageBox.Show("生成成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(apkFilePath + " 不是一个合法的 Android 应用文件", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("请先选择 Android 应用文件。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If
    End Sub

    Private Sub tbApkFilePath_TextChanged(sender As Object, e As EventArgs) Handles tbApkFilePath.TextChanged
        Dim filePath = tbApkFilePath.Text
        If Path.GetExtension(filePath).ToLower.Equals(".apk") And File.Exists(filePath) Then
            UpdateFormInfos()
        End If
    End Sub

    Private Sub UpdateFormInfos()
        Dim filePath = tbApkFilePath.Text
        Dim hasArm64v8a As Boolean = False
        Dim hasArmeabiv7a As Boolean = False
        Dim hasArmeabi As Boolean = False
        Using archive As ZipArchive = ZipFile.OpenRead(tbApkFilePath.Text)
            For Each entry As ZipArchiveEntry In archive.Entries
                Debug.WriteLine("UpdateFormInfos=>Entry name: " & entry.FullName)
                If Not hasArm64v8a And entry.FullName.StartsWith("lib/arm64-v8a/") Then
                    hasArm64v8a = True
                ElseIf Not hasArmeabiv7a And entry.FullName.StartsWith("lib/armeabi-v7a/") Then
                    hasArmeabiv7a = True
                ElseIf Not hasArmeabi And entry.FullName.StartsWith("lib/armeabi/") Then
                    hasArmeabi = True
                End If
            Next
        End Using
        If Not hasArmeabiv7a And Not hasArmeabi And Not hasArm64v8a Then
            lbSystemType.Enabled = False
            rbArm64V8a.Enabled = False
            rbArmeabi.Enabled = False
            rbArmeabiV7a.Enabled = False
        Else
            lbSystemType.Enabled = True
            If hasArm64v8a Then
                rbArm64V8a.Enabled = True
                rbArm64V8a.Checked = True
            Else
                rbArm64V8a.Enabled = False
            End If
            If hasArmeabiv7a Then
                rbArmeabiV7a.Enabled = True
                If Not hasArm64v8a Then
                    rbArmeabiV7a.Checked = True
                End If
            Else
                rbArmeabiV7a.Enabled = False
            End If
            If hasArmeabi Then
                rbArmeabi.Enabled = True
                If Not hasArm64v8a And Not hasArmeabiv7a Then
                    rbArmeabi.Checked = True
                End If
            Else
                rbArmeabi.Enabled = False
            End If
        End If
    End Sub

    Private Sub tbAppName_TextChanged(sender As Object, e As EventArgs) Handles tbAppName.TextChanged
        Dim text As String = tbAppName.Text
        If text.Contains(" ") Then
            text = text.Replace(" ", "_")
        End If
        tbAppName.Text = text
    End Sub
End Class
