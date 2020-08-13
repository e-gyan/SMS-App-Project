<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabLogin = New System.Windows.Forms.TabControl()
        Me.tabSystem = New System.Windows.Forms.TabPage()
        Me.mtxtPassword = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtUsername = New System.Windows.Forms.MaskedTextBox()
        Me.linkForget = New System.Windows.Forms.LinkLabel()
        Me.linkPin = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radAdmin = New System.Windows.Forms.RadioButton()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.systemLabel = New System.Windows.Forms.Label()
        Me.checkShowPass = New System.Windows.Forms.CheckBox()
        Me.tabChange = New System.Windows.Forms.TabPage()
        Me.mtxtNewPass = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtOldPass = New System.Windows.Forms.MaskedTextBox()
        Me.mtxtUsername1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radStudent1 = New System.Windows.Forms.RadioButton()
        Me.radStaff1 = New System.Windows.Forms.RadioButton()
        Me.radAdmin1 = New System.Windows.Forms.RadioButton()
        Me.checkShow = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabForget = New System.Windows.Forms.TabPage()
        Me.mtxtUserID = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnRedeem = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtForgetEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radForgetAdmin = New System.Windows.Forms.RadioButton()
        Me.radForgetStaff = New System.Windows.Forms.RadioButton()
        Me.radForgetStudent = New System.Windows.Forms.RadioButton()
        Me.tabLogin.SuspendLayout()
        Me.tabSystem.SuspendLayout()
        Me.tabChange.SuspendLayout()
        Me.tabForget.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabLogin
        '
        Me.tabLogin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabLogin.Controls.Add(Me.tabSystem)
        Me.tabLogin.Controls.Add(Me.tabChange)
        Me.tabLogin.Controls.Add(Me.tabForget)
        Me.tabLogin.Location = New System.Drawing.Point(0, 0)
        Me.tabLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabLogin.Multiline = True
        Me.tabLogin.Name = "tabLogin"
        Me.tabLogin.SelectedIndex = 0
        Me.tabLogin.Size = New System.Drawing.Size(627, 517)
        Me.tabLogin.TabIndex = 0
        '
        'tabSystem
        '
        Me.tabSystem.Controls.Add(Me.mtxtPassword)
        Me.tabSystem.Controls.Add(Me.mtxtUsername)
        Me.tabSystem.Controls.Add(Me.linkForget)
        Me.tabSystem.Controls.Add(Me.linkPin)
        Me.tabSystem.Controls.Add(Me.Label1)
        Me.tabSystem.Controls.Add(Me.radAdmin)
        Me.tabSystem.Controls.Add(Me.radStaff)
        Me.tabSystem.Controls.Add(Me.radStudent)
        Me.tabSystem.Controls.Add(Me.Label3)
        Me.tabSystem.Controls.Add(Me.btnLogin)
        Me.tabSystem.Controls.Add(Me.btnCancel)
        Me.tabSystem.Controls.Add(Me.Label2)
        Me.tabSystem.Controls.Add(Me.systemLabel)
        Me.tabSystem.Controls.Add(Me.checkShowPass)
        Me.tabSystem.Location = New System.Drawing.Point(4, 26)
        Me.tabSystem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabSystem.Name = "tabSystem"
        Me.tabSystem.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabSystem.Size = New System.Drawing.Size(619, 487)
        Me.tabSystem.TabIndex = 0
        Me.tabSystem.Text = "System Login"
        Me.tabSystem.UseVisualStyleBackColor = True
        '
        'mtxtPassword
        '
        Me.mtxtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtPassword.HidePromptOnLeave = True
        Me.mtxtPassword.Location = New System.Drawing.Point(230, 245)
        Me.mtxtPassword.Mask = "00000"
        Me.mtxtPassword.Name = "mtxtPassword"
        Me.mtxtPassword.Size = New System.Drawing.Size(212, 25)
        Me.mtxtPassword.TabIndex = 4
        Me.mtxtPassword.UseSystemPasswordChar = True
        Me.mtxtPassword.ValidatingType = GetType(Integer)
        '
        'mtxtUsername
        '
        Me.mtxtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtUsername.HidePromptOnLeave = True
        Me.mtxtUsername.Location = New System.Drawing.Point(230, 185)
        Me.mtxtUsername.Mask = "00000000"
        Me.mtxtUsername.Name = "mtxtUsername"
        Me.mtxtUsername.Size = New System.Drawing.Size(212, 25)
        Me.mtxtUsername.TabIndex = 3
        Me.mtxtUsername.ValidatingType = GetType(Integer)
        '
        'linkForget
        '
        Me.linkForget.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.linkForget.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linkForget.AutoSize = True
        Me.linkForget.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkForget.LinkColor = System.Drawing.Color.DodgerBlue
        Me.linkForget.Location = New System.Drawing.Point(344, 326)
        Me.linkForget.Name = "linkForget"
        Me.linkForget.Size = New System.Drawing.Size(98, 17)
        Me.linkForget.TabIndex = 8
        Me.linkForget.TabStop = True
        Me.linkForget.Text = "Forgotten Pin?"
        '
        'linkPin
        '
        Me.linkPin.ActiveLinkColor = System.Drawing.Color.DodgerBlue
        Me.linkPin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.linkPin.AutoSize = True
        Me.linkPin.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.linkPin.LinkColor = System.Drawing.Color.DodgerBlue
        Me.linkPin.Location = New System.Drawing.Point(227, 326)
        Me.linkPin.Name = "linkPin"
        Me.linkPin.Size = New System.Drawing.Size(83, 17)
        Me.linkPin.TabIndex = 7
        Me.linkPin.TabStop = True
        Me.linkPin.Text = "Change Pin?"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(117, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Who are you?"
        '
        'radAdmin
        '
        Me.radAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radAdmin.AutoSize = True
        Me.radAdmin.Location = New System.Drawing.Point(216, 132)
        Me.radAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radAdmin.Name = "radAdmin"
        Me.radAdmin.Size = New System.Drawing.Size(112, 21)
        Me.radAdmin.TabIndex = 0
        Me.radAdmin.Text = "Admininstrator"
        Me.radAdmin.UseVisualStyleBackColor = True
        '
        'radStaff
        '
        Me.radStaff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radStaff.AutoSize = True
        Me.radStaff.Location = New System.Drawing.Point(342, 132)
        Me.radStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(52, 21)
        Me.radStaff.TabIndex = 1
        Me.radStaff.Text = "Staff"
        Me.radStaff.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(409, 132)
        Me.radStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(70, 21)
        Me.radStudent.TabIndex = 2
        Me.radStudent.Text = "Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(281, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 32)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Login"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnLogin.Location = New System.Drawing.Point(289, 407)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(87, 30)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCancel.Location = New System.Drawing.Point(392, 407)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(87, 30)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pin:"
        '
        'systemLabel
        '
        Me.systemLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.systemLabel.AutoSize = True
        Me.systemLabel.Location = New System.Drawing.Point(146, 188)
        Me.systemLabel.Name = "systemLabel"
        Me.systemLabel.Size = New System.Drawing.Size(54, 17)
        Me.systemLabel.TabIndex = 6
        Me.systemLabel.Text = "User ID:"
        '
        'checkShowPass
        '
        Me.checkShowPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkShowPass.AutoSize = True
        Me.checkShowPass.Location = New System.Drawing.Point(230, 276)
        Me.checkShowPass.Name = "checkShowPass"
        Me.checkShowPass.Size = New System.Drawing.Size(80, 21)
        Me.checkShowPass.TabIndex = 9
        Me.checkShowPass.Text = "Show pin"
        Me.checkShowPass.UseVisualStyleBackColor = True
        '
        'tabChange
        '
        Me.tabChange.Controls.Add(Me.mtxtNewPass)
        Me.tabChange.Controls.Add(Me.mtxtOldPass)
        Me.tabChange.Controls.Add(Me.mtxtUsername1)
        Me.tabChange.Controls.Add(Me.Label8)
        Me.tabChange.Controls.Add(Me.radStudent1)
        Me.tabChange.Controls.Add(Me.radStaff1)
        Me.tabChange.Controls.Add(Me.radAdmin1)
        Me.tabChange.Controls.Add(Me.checkShow)
        Me.tabChange.Controls.Add(Me.Label4)
        Me.tabChange.Controls.Add(Me.btnChange)
        Me.tabChange.Controls.Add(Me.btnClear)
        Me.tabChange.Controls.Add(Me.Label7)
        Me.tabChange.Controls.Add(Me.Label5)
        Me.tabChange.Controls.Add(Me.Label6)
        Me.tabChange.Location = New System.Drawing.Point(4, 26)
        Me.tabChange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabChange.Name = "tabChange"
        Me.tabChange.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabChange.Size = New System.Drawing.Size(619, 487)
        Me.tabChange.TabIndex = 1
        Me.tabChange.Text = "Change Pin"
        Me.tabChange.UseVisualStyleBackColor = True
        '
        'mtxtNewPass
        '
        Me.mtxtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtNewPass.HidePromptOnLeave = True
        Me.mtxtNewPass.Location = New System.Drawing.Point(249, 306)
        Me.mtxtNewPass.Mask = "00000"
        Me.mtxtNewPass.Name = "mtxtNewPass"
        Me.mtxtNewPass.Size = New System.Drawing.Size(212, 25)
        Me.mtxtNewPass.TabIndex = 5
        Me.mtxtNewPass.UseSystemPasswordChar = True
        Me.mtxtNewPass.ValidatingType = GetType(Integer)
        '
        'mtxtOldPass
        '
        Me.mtxtOldPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtOldPass.HidePromptOnLeave = True
        Me.mtxtOldPass.Location = New System.Drawing.Point(249, 258)
        Me.mtxtOldPass.Mask = "00000"
        Me.mtxtOldPass.Name = "mtxtOldPass"
        Me.mtxtOldPass.Size = New System.Drawing.Size(212, 25)
        Me.mtxtOldPass.TabIndex = 4
        Me.mtxtOldPass.UseSystemPasswordChar = True
        Me.mtxtOldPass.ValidatingType = GetType(Integer)
        '
        'mtxtUsername1
        '
        Me.mtxtUsername1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtUsername1.HidePromptOnLeave = True
        Me.mtxtUsername1.Location = New System.Drawing.Point(249, 208)
        Me.mtxtUsername1.Mask = "00000000"
        Me.mtxtUsername1.Name = "mtxtUsername1"
        Me.mtxtUsername1.Size = New System.Drawing.Size(212, 25)
        Me.mtxtUsername1.TabIndex = 3
        Me.mtxtUsername1.ValidatingType = GetType(Integer)
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(136, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Who are you?"
        '
        'radStudent1
        '
        Me.radStudent1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radStudent1.AutoSize = True
        Me.radStudent1.Location = New System.Drawing.Point(428, 155)
        Me.radStudent1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radStudent1.Name = "radStudent1"
        Me.radStudent1.Size = New System.Drawing.Size(70, 21)
        Me.radStudent1.TabIndex = 2
        Me.radStudent1.Text = "Student"
        Me.radStudent1.UseVisualStyleBackColor = True
        '
        'radStaff1
        '
        Me.radStaff1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radStaff1.AutoSize = True
        Me.radStaff1.Location = New System.Drawing.Point(361, 155)
        Me.radStaff1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radStaff1.Name = "radStaff1"
        Me.radStaff1.Size = New System.Drawing.Size(52, 21)
        Me.radStaff1.TabIndex = 1
        Me.radStaff1.Text = "Staff"
        Me.radStaff1.UseVisualStyleBackColor = True
        '
        'radAdmin1
        '
        Me.radAdmin1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radAdmin1.AutoSize = True
        Me.radAdmin1.Location = New System.Drawing.Point(235, 155)
        Me.radAdmin1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radAdmin1.Name = "radAdmin1"
        Me.radAdmin1.Size = New System.Drawing.Size(112, 21)
        Me.radAdmin1.TabIndex = 0
        Me.radAdmin1.Text = "Admininstrator"
        Me.radAdmin1.UseVisualStyleBackColor = True
        '
        'checkShow
        '
        Me.checkShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.checkShow.AutoSize = True
        Me.checkShow.Location = New System.Drawing.Point(249, 337)
        Me.checkShow.Name = "checkShow"
        Me.checkShow.Size = New System.Drawing.Size(80, 21)
        Me.checkShow.TabIndex = 20
        Me.checkShow.Text = "Show pin"
        Me.checkShow.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(251, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 32)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Change Pin"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnChange
        '
        Me.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChange.Location = New System.Drawing.Point(272, 391)
        Me.btnChange.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(87, 30)
        Me.btnChange.TabIndex = 6
        Me.btnChange.Text = "Change Pin"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClear.Location = New System.Drawing.Point(374, 391)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(124, 30)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "<< Back to Login"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(151, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Confirm Pin:"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 261)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "New Pin:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(165, 211)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "User ID:"
        '
        'tabForget
        '
        Me.tabForget.Controls.Add(Me.mtxtUserID)
        Me.tabForget.Controls.Add(Me.Label12)
        Me.tabForget.Controls.Add(Me.Label11)
        Me.tabForget.Controls.Add(Me.btnRedeem)
        Me.tabForget.Controls.Add(Me.btnBack)
        Me.tabForget.Controls.Add(Me.Label10)
        Me.tabForget.Controls.Add(Me.txtForgetEmail)
        Me.tabForget.Controls.Add(Me.Label9)
        Me.tabForget.Controls.Add(Me.radForgetAdmin)
        Me.tabForget.Controls.Add(Me.radForgetStaff)
        Me.tabForget.Controls.Add(Me.radForgetStudent)
        Me.tabForget.Location = New System.Drawing.Point(4, 26)
        Me.tabForget.Name = "tabForget"
        Me.tabForget.Padding = New System.Windows.Forms.Padding(3)
        Me.tabForget.Size = New System.Drawing.Size(619, 487)
        Me.tabForget.TabIndex = 2
        Me.tabForget.Text = "Forgotten Pin"
        Me.tabForget.UseVisualStyleBackColor = True
        '
        'mtxtUserID
        '
        Me.mtxtUserID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mtxtUserID.HidePromptOnLeave = True
        Me.mtxtUserID.Location = New System.Drawing.Point(263, 208)
        Me.mtxtUserID.Mask = "00000000"
        Me.mtxtUserID.Name = "mtxtUserID"
        Me.mtxtUserID.Size = New System.Drawing.Size(212, 25)
        Me.mtxtUserID.TabIndex = 1
        Me.mtxtUserID.ValidatingType = GetType(Integer)
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(165, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 17)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Email Address:"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(207, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(270, 32)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Redeem Forgotten Pin"
        '
        'btnRedeem
        '
        Me.btnRedeem.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnRedeem.Location = New System.Drawing.Point(272, 391)
        Me.btnRedeem.Name = "btnRedeem"
        Me.btnRedeem.Size = New System.Drawing.Size(87, 30)
        Me.btnRedeem.TabIndex = 3
        Me.btnRedeem.Text = "Redeem Pin"
        Me.btnRedeem.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBack.Location = New System.Drawing.Point(374, 391)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(135, 30)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "<< Back to Login"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(165, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "User ID:"
        '
        'txtForgetEmail
        '
        Me.txtForgetEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtForgetEmail.Location = New System.Drawing.Point(263, 269)
        Me.txtForgetEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtForgetEmail.Name = "txtForgetEmail"
        Me.txtForgetEmail.Size = New System.Drawing.Size(212, 25)
        Me.txtForgetEmail.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(136, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 17)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Who are you?"
        '
        'radForgetAdmin
        '
        Me.radForgetAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radForgetAdmin.AutoSize = True
        Me.radForgetAdmin.Location = New System.Drawing.Point(235, 155)
        Me.radForgetAdmin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radForgetAdmin.Name = "radForgetAdmin"
        Me.radForgetAdmin.Size = New System.Drawing.Size(112, 21)
        Me.radForgetAdmin.TabIndex = 0
        Me.radForgetAdmin.Text = "Admininstrator"
        Me.radForgetAdmin.UseVisualStyleBackColor = True
        '
        'radForgetStaff
        '
        Me.radForgetStaff.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radForgetStaff.AutoSize = True
        Me.radForgetStaff.Location = New System.Drawing.Point(361, 155)
        Me.radForgetStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radForgetStaff.Name = "radForgetStaff"
        Me.radForgetStaff.Size = New System.Drawing.Size(52, 21)
        Me.radForgetStaff.TabIndex = 0
        Me.radForgetStaff.Text = "Staff"
        Me.radForgetStaff.UseVisualStyleBackColor = True
        '
        'radForgetStudent
        '
        Me.radForgetStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radForgetStudent.AutoSize = True
        Me.radForgetStudent.Location = New System.Drawing.Point(428, 155)
        Me.radForgetStudent.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.radForgetStudent.Name = "radForgetStudent"
        Me.radForgetStudent.Size = New System.Drawing.Size(70, 21)
        Me.radForgetStudent.TabIndex = 0
        Me.radForgetStudent.Text = "Student"
        Me.radForgetStudent.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 517)
        Me.Controls.Add(Me.tabLogin)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College"
        Me.tabLogin.ResumeLayout(False)
        Me.tabSystem.ResumeLayout(False)
        Me.tabSystem.PerformLayout()
        Me.tabChange.ResumeLayout(False)
        Me.tabChange.PerformLayout()
        Me.tabForget.ResumeLayout(False)
        Me.tabForget.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabLogin As TabControl
    Friend WithEvents tabSystem As TabPage
    Friend WithEvents tabChange As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents systemLabel As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents checkShow As CheckBox
    Friend WithEvents radAdmin1 As RadioButton
    Friend WithEvents radStaff1 As RadioButton
    Friend WithEvents radStudent1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents btnChange As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents radAdmin As RadioButton
    Friend WithEvents radStaff As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents linkForget As LinkLabel
    Friend WithEvents linkPin As LinkLabel
    Friend WithEvents tabForget As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents radForgetAdmin As RadioButton
    Friend WithEvents radForgetStaff As RadioButton
    Friend WithEvents radForgetStudent As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents btnRedeem As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtForgetEmail As TextBox
    Friend WithEvents mtxtPassword As MaskedTextBox
    Friend WithEvents mtxtUsername As MaskedTextBox
    Friend WithEvents mtxtUsername1 As MaskedTextBox
    Friend WithEvents mtxtNewPass As MaskedTextBox
    Friend WithEvents mtxtOldPass As MaskedTextBox
    Friend WithEvents mtxtUserID As MaskedTextBox
    Friend WithEvents checkShowPass As CheckBox
End Class
