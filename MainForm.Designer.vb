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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(createrForm))
        lbApkFilePath = New Label()
        tbApkFilePath = New TextBox()
        btnSelectApkFile = New Button()
        lbBuiltInPath = New Label()
        cbBuildInPath = New ComboBox()
        Label1 = New Label()
        rbSystemSignature = New RadioButton()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        systemSignalSplitter1 = New Splitter()
        rbNotSystemSignature = New RadioButton()
        lbSystemType = New Label()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        rbArm64V8a = New RadioButton()
        systemTypeSplitter1 = New Splitter()
        rbArmeabi = New RadioButton()
        systemTypeSplitter2 = New Splitter()
        rbArmeabiV7a = New RadioButton()
        lbDependsCheck = New Label()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        rbAllow = New RadioButton()
        dependenceSplitter = New Splitter()
        rbDisallow = New RadioButton()
        btStartCreate = New Button()
        ofdSelectFile = New OpenFileDialog()
        lbName = New Label()
        tbAppName = New TextBox()
        FlowLayoutPanel4 = New FlowLayoutPanel()
        rbCreateOdex = New RadioButton()
        odexSplitter = New Splitter()
        rbNotCreateOdex = New RadioButton()
        lbOdex = New Label()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        FlowLayoutPanel3.SuspendLayout()
        FlowLayoutPanel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbApkFilePath
        ' 
        lbApkFilePath.AutoSize = True
        lbApkFilePath.Location = New Point(12, 24)
        lbApkFilePath.Name = "lbApkFilePath"
        lbApkFilePath.Size = New Size(95, 17)
        lbApkFilePath.TabIndex = 0
        lbApkFilePath.Text = "Apk 文件路径："
        ' 
        ' tbApkFilePath
        ' 
        tbApkFilePath.Location = New Point(113, 21)
        tbApkFilePath.Name = "tbApkFilePath"
        tbApkFilePath.Size = New Size(461, 23)
        tbApkFilePath.TabIndex = 1
        ' 
        ' btnSelectApkFile
        ' 
        btnSelectApkFile.Location = New Point(580, 21)
        btnSelectApkFile.Name = "btnSelectApkFile"
        btnSelectApkFile.Size = New Size(75, 23)
        btnSelectApkFile.TabIndex = 2
        btnSelectApkFile.Text = "选择..."
        btnSelectApkFile.UseVisualStyleBackColor = True
        ' 
        ' lbBuiltInPath
        ' 
        lbBuiltInPath.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbBuiltInPath.AutoSize = True
        lbBuiltInPath.Location = New Point(12, 109)
        lbBuiltInPath.Name = "lbBuiltInPath"
        lbBuiltInPath.Size = New Size(68, 17)
        lbBuiltInPath.TabIndex = 3
        lbBuiltInPath.Text = "内置路径："
        ' 
        ' cbBuildInPath
        ' 
        cbBuildInPath.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        cbBuildInPath.FormattingEnabled = True
        cbBuildInPath.Items.AddRange(New Object() {"system/priv-app", "system/app", "product/app", "product/priv-app"})
        cbBuildInPath.Location = New Point(113, 106)
        cbBuildInPath.Name = "cbBuildInPath"
        cbBuildInPath.Size = New Size(542, 25)
        cbBuildInPath.TabIndex = 4
        cbBuildInPath.Text = "system/app"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Location = New Point(12, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(68, 17)
        Label1.TabIndex = 5
        Label1.Text = "系统签名："
        ' 
        ' rbSystemSignature
        ' 
        rbSystemSignature.AutoSize = True
        rbSystemSignature.Location = New Point(3, 3)
        rbSystemSignature.Name = "rbSystemSignature"
        rbSystemSignature.Size = New Size(74, 21)
        rbSystemSignature.TabIndex = 6
        rbSystemSignature.Text = "系统签名"
        rbSystemSignature.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.Controls.Add(rbSystemSignature)
        FlowLayoutPanel1.Controls.Add(systemSignalSplitter1)
        FlowLayoutPanel1.Controls.Add(rbNotSystemSignature)
        FlowLayoutPanel1.Location = New Point(113, 194)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(542, 27)
        FlowLayoutPanel1.TabIndex = 7
        ' 
        ' systemSignalSplitter1
        ' 
        systemSignalSplitter1.Location = New Point(83, 3)
        systemSignalSplitter1.Name = "systemSignalSplitter1"
        systemSignalSplitter1.Size = New Size(47, 21)
        systemSignalSplitter1.TabIndex = 9
        systemSignalSplitter1.TabStop = False
        ' 
        ' rbNotSystemSignature
        ' 
        rbNotSystemSignature.AutoSize = True
        rbNotSystemSignature.Checked = True
        rbNotSystemSignature.Location = New Point(136, 3)
        rbNotSystemSignature.Name = "rbNotSystemSignature"
        rbNotSystemSignature.Size = New Size(86, 21)
        rbNotSystemSignature.TabIndex = 8
        rbNotSystemSignature.TabStop = True
        rbNotSystemSignature.Text = "非系统签名"
        rbNotSystemSignature.UseVisualStyleBackColor = True
        ' 
        ' lbSystemType
        ' 
        lbSystemType.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbSystemType.AutoSize = True
        lbSystemType.Location = New Point(12, 155)
        lbSystemType.Name = "lbSystemType"
        lbSystemType.Size = New Size(68, 17)
        lbSystemType.TabIndex = 8
        lbSystemType.Text = "系统类型："
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel2.Controls.Add(rbArm64V8a)
        FlowLayoutPanel2.Controls.Add(systemTypeSplitter1)
        FlowLayoutPanel2.Controls.Add(rbArmeabi)
        FlowLayoutPanel2.Controls.Add(systemTypeSplitter2)
        FlowLayoutPanel2.Controls.Add(rbArmeabiV7a)
        FlowLayoutPanel2.Location = New Point(114, 148)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(541, 27)
        FlowLayoutPanel2.TabIndex = 9
        ' 
        ' rbArm64V8a
        ' 
        rbArm64V8a.AutoSize = True
        rbArm64V8a.Checked = True
        rbArm64V8a.Location = New Point(3, 3)
        rbArm64V8a.Name = "rbArm64V8a"
        rbArm64V8a.Size = New Size(88, 21)
        rbArm64V8a.TabIndex = 0
        rbArm64V8a.TabStop = True
        rbArm64V8a.Text = "arm64-v8a"
        rbArm64V8a.UseVisualStyleBackColor = True
        ' 
        ' systemTypeSplitter1
        ' 
        systemTypeSplitter1.Location = New Point(97, 3)
        systemTypeSplitter1.Name = "systemTypeSplitter1"
        systemTypeSplitter1.Size = New Size(34, 21)
        systemTypeSplitter1.TabIndex = 1
        systemTypeSplitter1.TabStop = False
        ' 
        ' rbArmeabi
        ' 
        rbArmeabi.AutoSize = True
        rbArmeabi.Location = New Point(137, 3)
        rbArmeabi.Name = "rbArmeabi"
        rbArmeabi.Size = New Size(74, 21)
        rbArmeabi.TabIndex = 2
        rbArmeabi.Text = "armeabi"
        rbArmeabi.UseVisualStyleBackColor = True
        ' 
        ' systemTypeSplitter2
        ' 
        systemTypeSplitter2.Location = New Point(217, 3)
        systemTypeSplitter2.Name = "systemTypeSplitter2"
        systemTypeSplitter2.Size = New Size(33, 21)
        systemTypeSplitter2.TabIndex = 3
        systemTypeSplitter2.TabStop = False
        ' 
        ' rbArmeabiV7a
        ' 
        rbArmeabiV7a.AutoSize = True
        rbArmeabiV7a.Location = New Point(256, 3)
        rbArmeabiV7a.Name = "rbArmeabiV7a"
        rbArmeabiV7a.Size = New Size(99, 21)
        rbArmeabiV7a.TabIndex = 2
        rbArmeabiV7a.Text = "armeabi-v7a"
        rbArmeabiV7a.UseVisualStyleBackColor = True
        ' 
        ' lbDependsCheck
        ' 
        lbDependsCheck.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbDependsCheck.AutoSize = True
        lbDependsCheck.Location = New Point(12, 246)
        lbDependsCheck.Name = "lbDependsCheck"
        lbDependsCheck.Size = New Size(68, 17)
        lbDependsCheck.TabIndex = 10
        lbDependsCheck.Text = "依赖检查："
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel3.Controls.Add(rbAllow)
        FlowLayoutPanel3.Controls.Add(dependenceSplitter)
        FlowLayoutPanel3.Controls.Add(rbDisallow)
        FlowLayoutPanel3.Location = New Point(113, 242)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(542, 27)
        FlowLayoutPanel3.TabIndex = 9
        ' 
        ' rbAllow
        ' 
        rbAllow.AutoSize = True
        rbAllow.Checked = True
        rbAllow.Location = New Point(3, 3)
        rbAllow.Name = "rbAllow"
        rbAllow.Size = New Size(50, 21)
        rbAllow.TabIndex = 0
        rbAllow.TabStop = True
        rbAllow.Text = "允许"
        rbAllow.UseVisualStyleBackColor = True
        ' 
        ' dependenceSplitter
        ' 
        dependenceSplitter.Location = New Point(59, 3)
        dependenceSplitter.Name = "dependenceSplitter"
        dependenceSplitter.Size = New Size(68, 21)
        dependenceSplitter.TabIndex = 1
        dependenceSplitter.TabStop = False
        ' 
        ' rbDisallow
        ' 
        rbDisallow.AutoSize = True
        rbDisallow.Location = New Point(133, 3)
        rbDisallow.Name = "rbDisallow"
        rbDisallow.Size = New Size(50, 21)
        rbDisallow.TabIndex = 2
        rbDisallow.Text = "禁止"
        rbDisallow.UseVisualStyleBackColor = True
        ' 
        ' btStartCreate
        ' 
        btStartCreate.Location = New Point(251, 335)
        btStartCreate.Name = "btStartCreate"
        btStartCreate.Size = New Size(157, 40)
        btStartCreate.TabIndex = 11
        btStartCreate.Text = "开始生成"
        btStartCreate.UseVisualStyleBackColor = True
        ' 
        ' ofdSelectFile
        ' 
        ofdSelectFile.FileName = "OpenFileDialog1"
        ofdSelectFile.Filter = "Android Application|*.apk"
        ' 
        ' lbName
        ' 
        lbName.AutoSize = True
        lbName.Location = New Point(12, 65)
        lbName.Name = "lbName"
        lbName.Size = New Size(68, 17)
        lbName.TabIndex = 12
        lbName.Text = "应用名称："
        ' 
        ' tbAppName
        ' 
        tbAppName.Location = New Point(113, 62)
        tbAppName.Name = "tbAppName"
        tbAppName.Size = New Size(542, 23)
        tbAppName.TabIndex = 13
        ' 
        ' FlowLayoutPanel4
        ' 
        FlowLayoutPanel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel4.Controls.Add(rbCreateOdex)
        FlowLayoutPanel4.Controls.Add(odexSplitter)
        FlowLayoutPanel4.Controls.Add(rbNotCreateOdex)
        FlowLayoutPanel4.Location = New Point(113, 287)
        FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        FlowLayoutPanel4.Size = New Size(542, 27)
        FlowLayoutPanel4.TabIndex = 9
        ' 
        ' rbCreateOdex
        ' 
        rbCreateOdex.AutoSize = True
        rbCreateOdex.Location = New Point(3, 3)
        rbCreateOdex.Name = "rbCreateOdex"
        rbCreateOdex.Size = New Size(50, 21)
        rbCreateOdex.TabIndex = 0
        rbCreateOdex.Text = "生成"
        rbCreateOdex.UseVisualStyleBackColor = True
        ' 
        ' odexSplitter
        ' 
        odexSplitter.Location = New Point(59, 3)
        odexSplitter.Name = "odexSplitter"
        odexSplitter.Size = New Size(68, 21)
        odexSplitter.TabIndex = 1
        odexSplitter.TabStop = False
        ' 
        ' rbNotCreateOdex
        ' 
        rbNotCreateOdex.AutoSize = True
        rbNotCreateOdex.Checked = True
        rbNotCreateOdex.Location = New Point(133, 3)
        rbNotCreateOdex.Name = "rbNotCreateOdex"
        rbNotCreateOdex.Size = New Size(62, 21)
        rbNotCreateOdex.TabIndex = 2
        rbNotCreateOdex.TabStop = True
        rbNotCreateOdex.Text = "不生成"
        rbNotCreateOdex.UseVisualStyleBackColor = True
        ' 
        ' lbOdex
        ' 
        lbOdex.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbOdex.AutoSize = True
        lbOdex.Location = New Point(12, 291)
        lbOdex.Name = "lbOdex"
        lbOdex.Size = New Size(82, 17)
        lbOdex.TabIndex = 10
        lbOdex.Text = "生成 ODEX："
        ' 
        ' createrForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(667, 395)
        Controls.Add(tbAppName)
        Controls.Add(lbName)
        Controls.Add(btStartCreate)
        Controls.Add(lbOdex)
        Controls.Add(FlowLayoutPanel4)
        Controls.Add(lbDependsCheck)
        Controls.Add(FlowLayoutPanel3)
        Controls.Add(FlowLayoutPanel2)
        Controls.Add(lbSystemType)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Label1)
        Controls.Add(cbBuildInPath)
        Controls.Add(lbBuiltInPath)
        Controls.Add(btnSelectApkFile)
        Controls.Add(tbApkFilePath)
        Controls.Add(lbApkFilePath)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "createrForm"
        Text = "ApkMakefileCreater"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel1.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        FlowLayoutPanel2.PerformLayout()
        FlowLayoutPanel3.ResumeLayout(False)
        FlowLayoutPanel3.PerformLayout()
        FlowLayoutPanel4.ResumeLayout(False)
        FlowLayoutPanel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
