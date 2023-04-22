<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class createrForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbApkFilePath = New System.Windows.Forms.Label()
        Me.tbApkFilePath = New System.Windows.Forms.TextBox()
        Me.btnSelectApkFile = New System.Windows.Forms.Button()
        Me.lbBuiltInPath = New System.Windows.Forms.Label()
        Me.cbBuildInPath = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbSystemSignature = New System.Windows.Forms.RadioButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.systemSignalSplitter1 = New System.Windows.Forms.Splitter()
        Me.rbNotSystemSignature = New System.Windows.Forms.RadioButton()
        Me.lbSystemType = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbArm64V8a = New System.Windows.Forms.RadioButton()
        Me.systemTypeSplitter1 = New System.Windows.Forms.Splitter()
        Me.rbArmeabi = New System.Windows.Forms.RadioButton()
        Me.systemTypeSplitter2 = New System.Windows.Forms.Splitter()
        Me.rbArmeabiV7a = New System.Windows.Forms.RadioButton()
        Me.lbDependsCheck = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbAllow = New System.Windows.Forms.RadioButton()
        Me.dependenceSplitter = New System.Windows.Forms.Splitter()
        Me.rbDisallow = New System.Windows.Forms.RadioButton()
        Me.btStartCreate = New System.Windows.Forms.Button()
        Me.ofdSelectFile = New System.Windows.Forms.OpenFileDialog()
        Me.lbName = New System.Windows.Forms.Label()
        Me.tbAppName = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbCreateOdex = New System.Windows.Forms.RadioButton()
        Me.odexSplitter = New System.Windows.Forms.Splitter()
        Me.rbNotCreateOdex = New System.Windows.Forms.RadioButton()
        Me.lbOdex = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbApkFilePath
        '
        Me.lbApkFilePath.AutoSize = True
        Me.lbApkFilePath.Location = New System.Drawing.Point(12, 24)
        Me.lbApkFilePath.Name = "lbApkFilePath"
        Me.lbApkFilePath.Size = New System.Drawing.Size(95, 17)
        Me.lbApkFilePath.TabIndex = 0
        Me.lbApkFilePath.Text = "Apk 文件路径："
        '
        'tbApkFilePath
        '
        Me.tbApkFilePath.Location = New System.Drawing.Point(113, 21)
        Me.tbApkFilePath.Name = "tbApkFilePath"
        Me.tbApkFilePath.Size = New System.Drawing.Size(461, 23)
        Me.tbApkFilePath.TabIndex = 1
        '
        'btnSelectApkFile
        '
        Me.btnSelectApkFile.Location = New System.Drawing.Point(580, 21)
        Me.btnSelectApkFile.Name = "btnSelectApkFile"
        Me.btnSelectApkFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectApkFile.TabIndex = 2
        Me.btnSelectApkFile.Text = "选择..."
        Me.btnSelectApkFile.UseVisualStyleBackColor = True
        '
        'lbBuiltInPath
        '
        Me.lbBuiltInPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbBuiltInPath.AutoSize = True
        Me.lbBuiltInPath.Location = New System.Drawing.Point(12, 109)
        Me.lbBuiltInPath.Name = "lbBuiltInPath"
        Me.lbBuiltInPath.Size = New System.Drawing.Size(68, 17)
        Me.lbBuiltInPath.TabIndex = 3
        Me.lbBuiltInPath.Text = "内置路径："
        '
        'cbBuildInPath
        '
        Me.cbBuildInPath.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbBuildInPath.FormattingEnabled = True
        Me.cbBuildInPath.Items.AddRange(New Object() {"system/priv-app", "system/app", "product/app", "product/priv-app"})
        Me.cbBuildInPath.Location = New System.Drawing.Point(113, 106)
        Me.cbBuildInPath.Name = "cbBuildInPath"
        Me.cbBuildInPath.Size = New System.Drawing.Size(542, 25)
        Me.cbBuildInPath.TabIndex = 4
        Me.cbBuildInPath.Text = "system/app"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "系统签名："
        '
        'rbSystemSignature
        '
        Me.rbSystemSignature.AutoSize = True
        Me.rbSystemSignature.Location = New System.Drawing.Point(3, 3)
        Me.rbSystemSignature.Name = "rbSystemSignature"
        Me.rbSystemSignature.Size = New System.Drawing.Size(74, 21)
        Me.rbSystemSignature.TabIndex = 6
        Me.rbSystemSignature.Text = "系统签名"
        Me.rbSystemSignature.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.rbSystemSignature)
        Me.FlowLayoutPanel1.Controls.Add(Me.systemSignalSplitter1)
        Me.FlowLayoutPanel1.Controls.Add(Me.rbNotSystemSignature)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(113, 194)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(542, 27)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'systemSignalSplitter1
        '
        Me.systemSignalSplitter1.Location = New System.Drawing.Point(83, 3)
        Me.systemSignalSplitter1.Name = "systemSignalSplitter1"
        Me.systemSignalSplitter1.Size = New System.Drawing.Size(47, 21)
        Me.systemSignalSplitter1.TabIndex = 9
        Me.systemSignalSplitter1.TabStop = False
        '
        'rbNotSystemSignature
        '
        Me.rbNotSystemSignature.AutoSize = True
        Me.rbNotSystemSignature.Checked = True
        Me.rbNotSystemSignature.Location = New System.Drawing.Point(136, 3)
        Me.rbNotSystemSignature.Name = "rbNotSystemSignature"
        Me.rbNotSystemSignature.Size = New System.Drawing.Size(86, 21)
        Me.rbNotSystemSignature.TabIndex = 8
        Me.rbNotSystemSignature.TabStop = True
        Me.rbNotSystemSignature.Text = "非系统签名"
        Me.rbNotSystemSignature.UseVisualStyleBackColor = True
        '
        'lbSystemType
        '
        Me.lbSystemType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbSystemType.AutoSize = True
        Me.lbSystemType.Location = New System.Drawing.Point(12, 155)
        Me.lbSystemType.Name = "lbSystemType"
        Me.lbSystemType.Size = New System.Drawing.Size(68, 17)
        Me.lbSystemType.TabIndex = 8
        Me.lbSystemType.Text = "系统类型："
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.Controls.Add(Me.rbArm64V8a)
        Me.FlowLayoutPanel2.Controls.Add(Me.systemTypeSplitter1)
        Me.FlowLayoutPanel2.Controls.Add(Me.rbArmeabi)
        Me.FlowLayoutPanel2.Controls.Add(Me.systemTypeSplitter2)
        Me.FlowLayoutPanel2.Controls.Add(Me.rbArmeabiV7a)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(114, 148)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(541, 27)
        Me.FlowLayoutPanel2.TabIndex = 9
        '
        'rbArm64V8a
        '
        Me.rbArm64V8a.AutoSize = True
        Me.rbArm64V8a.Checked = True
        Me.rbArm64V8a.Location = New System.Drawing.Point(3, 3)
        Me.rbArm64V8a.Name = "rbArm64V8a"
        Me.rbArm64V8a.Size = New System.Drawing.Size(88, 21)
        Me.rbArm64V8a.TabIndex = 0
        Me.rbArm64V8a.TabStop = True
        Me.rbArm64V8a.Text = "arm64-v8a"
        Me.rbArm64V8a.UseVisualStyleBackColor = True
        '
        'systemTypeSplitter1
        '
        Me.systemTypeSplitter1.Location = New System.Drawing.Point(97, 3)
        Me.systemTypeSplitter1.Name = "systemTypeSplitter1"
        Me.systemTypeSplitter1.Size = New System.Drawing.Size(34, 21)
        Me.systemTypeSplitter1.TabIndex = 1
        Me.systemTypeSplitter1.TabStop = False
        '
        'rbArmeabi
        '
        Me.rbArmeabi.AutoSize = True
        Me.rbArmeabi.Location = New System.Drawing.Point(137, 3)
        Me.rbArmeabi.Name = "rbArmeabi"
        Me.rbArmeabi.Size = New System.Drawing.Size(74, 21)
        Me.rbArmeabi.TabIndex = 2
        Me.rbArmeabi.Text = "armeabi"
        Me.rbArmeabi.UseVisualStyleBackColor = True
        '
        'systemTypeSplitter2
        '
        Me.systemTypeSplitter2.Location = New System.Drawing.Point(217, 3)
        Me.systemTypeSplitter2.Name = "systemTypeSplitter2"
        Me.systemTypeSplitter2.Size = New System.Drawing.Size(33, 21)
        Me.systemTypeSplitter2.TabIndex = 3
        Me.systemTypeSplitter2.TabStop = False
        '
        'rbArmeabiV7a
        '
        Me.rbArmeabiV7a.AutoSize = True
        Me.rbArmeabiV7a.Location = New System.Drawing.Point(256, 3)
        Me.rbArmeabiV7a.Name = "rbArmeabiV7a"
        Me.rbArmeabiV7a.Size = New System.Drawing.Size(99, 21)
        Me.rbArmeabiV7a.TabIndex = 2
        Me.rbArmeabiV7a.Text = "armeabi-v7a"
        Me.rbArmeabiV7a.UseVisualStyleBackColor = True
        '
        'lbDependsCheck
        '
        Me.lbDependsCheck.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbDependsCheck.AutoSize = True
        Me.lbDependsCheck.Location = New System.Drawing.Point(12, 246)
        Me.lbDependsCheck.Name = "lbDependsCheck"
        Me.lbDependsCheck.Size = New System.Drawing.Size(68, 17)
        Me.lbDependsCheck.TabIndex = 10
        Me.lbDependsCheck.Text = "依赖检查："
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel3.Controls.Add(Me.rbAllow)
        Me.FlowLayoutPanel3.Controls.Add(Me.dependenceSplitter)
        Me.FlowLayoutPanel3.Controls.Add(Me.rbDisallow)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(113, 242)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(542, 27)
        Me.FlowLayoutPanel3.TabIndex = 9
        '
        'rbAllow
        '
        Me.rbAllow.AutoSize = True
        Me.rbAllow.Checked = True
        Me.rbAllow.Location = New System.Drawing.Point(3, 3)
        Me.rbAllow.Name = "rbAllow"
        Me.rbAllow.Size = New System.Drawing.Size(50, 21)
        Me.rbAllow.TabIndex = 0
        Me.rbAllow.TabStop = True
        Me.rbAllow.Text = "允许"
        Me.rbAllow.UseVisualStyleBackColor = True
        '
        'dependenceSplitter
        '
        Me.dependenceSplitter.Location = New System.Drawing.Point(59, 3)
        Me.dependenceSplitter.Name = "dependenceSplitter"
        Me.dependenceSplitter.Size = New System.Drawing.Size(68, 21)
        Me.dependenceSplitter.TabIndex = 1
        Me.dependenceSplitter.TabStop = False
        '
        'rbDisallow
        '
        Me.rbDisallow.AutoSize = True
        Me.rbDisallow.Location = New System.Drawing.Point(133, 3)
        Me.rbDisallow.Name = "rbDisallow"
        Me.rbDisallow.Size = New System.Drawing.Size(50, 21)
        Me.rbDisallow.TabIndex = 2
        Me.rbDisallow.Text = "禁止"
        Me.rbDisallow.UseVisualStyleBackColor = True
        '
        'btStartCreate
        '
        Me.btStartCreate.Location = New System.Drawing.Point(251, 335)
        Me.btStartCreate.Name = "btStartCreate"
        Me.btStartCreate.Size = New System.Drawing.Size(157, 40)
        Me.btStartCreate.TabIndex = 11
        Me.btStartCreate.Text = "开始生成"
        Me.btStartCreate.UseVisualStyleBackColor = True
        '
        'ofdSelectFile
        '
        Me.ofdSelectFile.FileName = "OpenFileDialog1"
        Me.ofdSelectFile.Filter = "Android Application|*.apk"
        '
        'lbName
        '
        Me.lbName.AutoSize = True
        Me.lbName.Location = New System.Drawing.Point(12, 65)
        Me.lbName.Name = "lbName"
        Me.lbName.Size = New System.Drawing.Size(68, 17)
        Me.lbName.TabIndex = 12
        Me.lbName.Text = "应用名称："
        '
        'tbAppName
        '
        Me.tbAppName.Location = New System.Drawing.Point(113, 62)
        Me.tbAppName.Name = "tbAppName"
        Me.tbAppName.Size = New System.Drawing.Size(542, 23)
        Me.tbAppName.TabIndex = 13
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel4.Controls.Add(Me.rbCreateOdex)
        Me.FlowLayoutPanel4.Controls.Add(Me.odexSplitter)
        Me.FlowLayoutPanel4.Controls.Add(Me.rbNotCreateOdex)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(113, 287)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(542, 27)
        Me.FlowLayoutPanel4.TabIndex = 9
        '
        'rbCreateOdex
        '
        Me.rbCreateOdex.AutoSize = True
        Me.rbCreateOdex.Location = New System.Drawing.Point(3, 3)
        Me.rbCreateOdex.Name = "rbCreateOdex"
        Me.rbCreateOdex.Size = New System.Drawing.Size(50, 21)
        Me.rbCreateOdex.TabIndex = 0
        Me.rbCreateOdex.Text = "生成"
        Me.rbCreateOdex.UseVisualStyleBackColor = True
        '
        'odexSplitter
        '
        Me.odexSplitter.Location = New System.Drawing.Point(59, 3)
        Me.odexSplitter.Name = "odexSplitter"
        Me.odexSplitter.Size = New System.Drawing.Size(68, 21)
        Me.odexSplitter.TabIndex = 1
        Me.odexSplitter.TabStop = False
        '
        'rbNotCreateOdex
        '
        Me.rbNotCreateOdex.AutoSize = True
        Me.rbNotCreateOdex.Checked = True
        Me.rbNotCreateOdex.Location = New System.Drawing.Point(133, 3)
        Me.rbNotCreateOdex.Name = "rbNotCreateOdex"
        Me.rbNotCreateOdex.Size = New System.Drawing.Size(62, 21)
        Me.rbNotCreateOdex.TabIndex = 2
        Me.rbNotCreateOdex.TabStop = True
        Me.rbNotCreateOdex.Text = "不生成"
        Me.rbNotCreateOdex.UseVisualStyleBackColor = True
        '
        'lbOdex
        '
        Me.lbOdex.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbOdex.AutoSize = True
        Me.lbOdex.Location = New System.Drawing.Point(12, 291)
        Me.lbOdex.Name = "lbOdex"
        Me.lbOdex.Size = New System.Drawing.Size(82, 17)
        Me.lbOdex.TabIndex = 10
        Me.lbOdex.Text = "生成 ODEX："
        '
        'createrForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 395)
        Me.Controls.Add(Me.tbAppName)
        Me.Controls.Add(Me.lbName)
        Me.Controls.Add(Me.btStartCreate)
        Me.Controls.Add(Me.lbOdex)
        Me.Controls.Add(Me.FlowLayoutPanel4)
        Me.Controls.Add(Me.lbDependsCheck)
        Me.Controls.Add(Me.FlowLayoutPanel3)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.lbSystemType)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbBuildInPath)
        Me.Controls.Add(Me.lbBuiltInPath)
        Me.Controls.Add(Me.btnSelectApkFile)
        Me.Controls.Add(Me.tbApkFilePath)
        Me.Controls.Add(Me.lbApkFilePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "createrForm"
        Me.Text = "ApkMakefileCreater"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbApkFilePath As Label
    Friend WithEvents tbApkFilePath As TextBox
    Friend WithEvents btnSelectApkFile As Button
    Friend WithEvents lbBuiltInPath As Label
    Friend WithEvents cbBuildInPath As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rbSystemSignature As RadioButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents systemSignalSplitter1 As Splitter
    Friend WithEvents rbNotSystemSignature As RadioButton
    Friend WithEvents lbSystemType As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents rbArm64V8a As RadioButton
    Friend WithEvents systemTypeSplitter1 As Splitter
    Friend WithEvents rbArmeabi As RadioButton
    Friend WithEvents lbDependsCheck As Label
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents rbAllow As RadioButton
    Friend WithEvents dependenceSplitter As Splitter
    Friend WithEvents rbDisallow As RadioButton
    Friend WithEvents btStartCreate As Button
    Friend WithEvents ofdSelectFile As OpenFileDialog
    Friend WithEvents lbName As Label
    Friend WithEvents tbAppName As TextBox
    Friend WithEvents systemTypeSplitter2 As Splitter
    Friend WithEvents rbArmeabiV7a As RadioButton
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents rbCreateOdex As RadioButton
    Friend WithEvents odexSplitter As Splitter
    Friend WithEvents rbNotCreateOdex As RadioButton
    Friend WithEvents lbOdex As Label
End Class
