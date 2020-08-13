<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudent_Payment
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
        Me.tabStudentPayment = New System.Windows.Forms.TabControl()
        Me.tabSchoolPayment = New System.Windows.Forms.TabPage()
        Me.radResidenceFee = New System.Windows.Forms.RadioButton()
        Me.radSchoolFee = New System.Windows.Forms.RadioButton()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.txtYearBlock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMakePayment = New System.Windows.Forms.Button()
        Me.mstxtAmount = New System.Windows.Forms.MaskedTextBox()
        Me.mstxtAcaYear = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tabOtherPayment = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbOthers = New System.Windows.Forms.ComboBox()
        Me.cmbTerBlock = New System.Windows.Forms.ComboBox()
        Me.cmbYeaBlock = New System.Windows.Forms.ComboBox()
        Me.cmAcadYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnMakeOtherPay = New System.Windows.Forms.Button()
        Me.mstxtOtherAmount = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tabStudentPayment.SuspendLayout()
        Me.tabSchoolPayment.SuspendLayout()
        Me.tabOtherPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabStudentPayment
        '
        Me.tabStudentPayment.Controls.Add(Me.tabSchoolPayment)
        Me.tabStudentPayment.Controls.Add(Me.tabOtherPayment)
        Me.tabStudentPayment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabStudentPayment.Location = New System.Drawing.Point(0, 0)
        Me.tabStudentPayment.Name = "tabStudentPayment"
        Me.tabStudentPayment.SelectedIndex = 0
        Me.tabStudentPayment.Size = New System.Drawing.Size(715, 444)
        Me.tabStudentPayment.TabIndex = 0
        '
        'tabSchoolPayment
        '
        Me.tabSchoolPayment.Controls.Add(Me.radResidenceFee)
        Me.tabSchoolPayment.Controls.Add(Me.radSchoolFee)
        Me.tabSchoolPayment.Controls.Add(Me.txtTerm)
        Me.tabSchoolPayment.Controls.Add(Me.txtYearBlock)
        Me.tabSchoolPayment.Controls.Add(Me.Label5)
        Me.tabSchoolPayment.Controls.Add(Me.Label1)
        Me.tabSchoolPayment.Controls.Add(Me.Label6)
        Me.tabSchoolPayment.Controls.Add(Me.Label7)
        Me.tabSchoolPayment.Controls.Add(Me.Label8)
        Me.tabSchoolPayment.Controls.Add(Me.btnMakePayment)
        Me.tabSchoolPayment.Controls.Add(Me.mstxtAmount)
        Me.tabSchoolPayment.Controls.Add(Me.mstxtAcaYear)
        Me.tabSchoolPayment.Controls.Add(Me.Label9)
        Me.tabSchoolPayment.Location = New System.Drawing.Point(4, 26)
        Me.tabSchoolPayment.Name = "tabSchoolPayment"
        Me.tabSchoolPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSchoolPayment.Size = New System.Drawing.Size(707, 414)
        Me.tabSchoolPayment.TabIndex = 0
        Me.tabSchoolPayment.Text = "School and Residence Payment"
        Me.tabSchoolPayment.UseVisualStyleBackColor = True
        '
        'radResidenceFee
        '
        Me.radResidenceFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radResidenceFee.AutoSize = True
        Me.radResidenceFee.Location = New System.Drawing.Point(441, 133)
        Me.radResidenceFee.Name = "radResidenceFee"
        Me.radResidenceFee.Size = New System.Drawing.Size(115, 21)
        Me.radResidenceFee.TabIndex = 1
        Me.radResidenceFee.TabStop = True
        Me.radResidenceFee.Text = "Residence Fees"
        Me.radResidenceFee.UseVisualStyleBackColor = True
        '
        'radSchoolFee
        '
        Me.radSchoolFee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radSchoolFee.AutoSize = True
        Me.radSchoolFee.Location = New System.Drawing.Point(325, 133)
        Me.radSchoolFee.Name = "radSchoolFee"
        Me.radSchoolFee.Size = New System.Drawing.Size(95, 21)
        Me.radSchoolFee.TabIndex = 0
        Me.radSchoolFee.TabStop = True
        Me.radSchoolFee.Text = "School Fees"
        Me.radSchoolFee.UseVisualStyleBackColor = True
        '
        'txtTerm
        '
        Me.txtTerm.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTerm.Enabled = False
        Me.txtTerm.Location = New System.Drawing.Point(488, 63)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(185, 25)
        Me.txtTerm.TabIndex = 0
        '
        'txtYearBlock
        '
        Me.txtYearBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtYearBlock.Enabled = False
        Me.txtYearBlock.Location = New System.Drawing.Point(272, 63)
        Me.txtYearBlock.Name = "txtYearBlock"
        Me.txtYearBlock.Size = New System.Drawing.Size(185, 25)
        Me.txtYearBlock.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(269, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Year Block"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Enter amount*"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 17)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Select what you paying for:*"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(485, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 17)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Term Block"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 17)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Academic Year (yyyy-yyyy)"
        '
        'btnMakePayment
        '
        Me.btnMakePayment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMakePayment.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMakePayment.Location = New System.Drawing.Point(491, 320)
        Me.btnMakePayment.Name = "btnMakePayment"
        Me.btnMakePayment.Size = New System.Drawing.Size(171, 34)
        Me.btnMakePayment.TabIndex = 3
        Me.btnMakePayment.Text = "Make Payment"
        Me.btnMakePayment.UseVisualStyleBackColor = True
        '
        'mstxtAmount
        '
        Me.mstxtAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mstxtAmount.HidePromptOnLeave = True
        Me.mstxtAmount.Location = New System.Drawing.Point(289, 193)
        Me.mstxtAmount.Mask = "0000000"
        Me.mstxtAmount.Name = "mstxtAmount"
        Me.mstxtAmount.Size = New System.Drawing.Size(231, 25)
        Me.mstxtAmount.TabIndex = 2
        Me.mstxtAmount.ValidatingType = GetType(Integer)
        '
        'mstxtAcaYear
        '
        Me.mstxtAcaYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mstxtAcaYear.Enabled = False
        Me.mstxtAcaYear.Location = New System.Drawing.Point(48, 63)
        Me.mstxtAcaYear.Mask = "0000-0000"
        Me.mstxtAcaYear.Name = "mstxtAcaYear"
        Me.mstxtAcaYear.Size = New System.Drawing.Size(185, 25)
        Me.mstxtAcaYear.TabIndex = 0
        Me.mstxtAcaYear.ValidatingType = GetType(Integer)
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(161, -69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(395, 32)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Pay for School and Residence Fee"
        '
        'tabOtherPayment
        '
        Me.tabOtherPayment.Controls.Add(Me.Label12)
        Me.tabOtherPayment.Controls.Add(Me.cmbOthers)
        Me.tabOtherPayment.Controls.Add(Me.cmbTerBlock)
        Me.tabOtherPayment.Controls.Add(Me.cmbYeaBlock)
        Me.tabOtherPayment.Controls.Add(Me.cmAcadYear)
        Me.tabOtherPayment.Controls.Add(Me.Label2)
        Me.tabOtherPayment.Controls.Add(Me.Label3)
        Me.tabOtherPayment.Controls.Add(Me.Label4)
        Me.tabOtherPayment.Controls.Add(Me.Label10)
        Me.tabOtherPayment.Controls.Add(Me.btnMakeOtherPay)
        Me.tabOtherPayment.Controls.Add(Me.mstxtOtherAmount)
        Me.tabOtherPayment.Controls.Add(Me.Label11)
        Me.tabOtherPayment.Location = New System.Drawing.Point(4, 26)
        Me.tabOtherPayment.Name = "tabOtherPayment"
        Me.tabOtherPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOtherPayment.Size = New System.Drawing.Size(707, 442)
        Me.tabOtherPayment.TabIndex = 1
        Me.tabOtherPayment.Text = "Other Payment"
        Me.tabOtherPayment.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(216, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "Enter amount*"
        '
        'cmbOthers
        '
        Me.cmbOthers.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbOthers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOthers.FormattingEnabled = True
        Me.cmbOthers.Location = New System.Drawing.Point(322, 146)
        Me.cmbOthers.Name = "cmbOthers"
        Me.cmbOthers.Size = New System.Drawing.Size(208, 25)
        Me.cmbOthers.Sorted = True
        Me.cmbOthers.TabIndex = 3
        '
        'cmbTerBlock
        '
        Me.cmbTerBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbTerBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTerBlock.FormattingEnabled = True
        Me.cmbTerBlock.Location = New System.Drawing.Point(488, 77)
        Me.cmbTerBlock.Name = "cmbTerBlock"
        Me.cmbTerBlock.Size = New System.Drawing.Size(174, 25)
        Me.cmbTerBlock.Sorted = True
        Me.cmbTerBlock.TabIndex = 2
        '
        'cmbYeaBlock
        '
        Me.cmbYeaBlock.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbYeaBlock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYeaBlock.FormattingEnabled = True
        Me.cmbYeaBlock.Location = New System.Drawing.Point(272, 77)
        Me.cmbYeaBlock.Name = "cmbYeaBlock"
        Me.cmbYeaBlock.Size = New System.Drawing.Size(174, 25)
        Me.cmbYeaBlock.Sorted = True
        Me.cmbYeaBlock.TabIndex = 1
        '
        'cmAcadYear
        '
        Me.cmAcadYear.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmAcadYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmAcadYear.FormattingEnabled = True
        Me.cmAcadYear.Location = New System.Drawing.Point(48, 77)
        Me.cmAcadYear.Name = "cmAcadYear"
        Me.cmAcadYear.Size = New System.Drawing.Size(174, 25)
        Me.cmAcadYear.Sorted = True
        Me.cmAcadYear.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Year Block"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 17)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Select what you paying for:*"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(485, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "Term Block"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(45, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 17)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "Select Academic Year (yyyy-yyyy)"
        '
        'btnMakeOtherPay
        '
        Me.btnMakeOtherPay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMakeOtherPay.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMakeOtherPay.Location = New System.Drawing.Point(491, 356)
        Me.btnMakeOtherPay.Name = "btnMakeOtherPay"
        Me.btnMakeOtherPay.Size = New System.Drawing.Size(171, 34)
        Me.btnMakeOtherPay.TabIndex = 5
        Me.btnMakeOtherPay.Text = "Make Payment"
        Me.btnMakeOtherPay.UseVisualStyleBackColor = True
        '
        'mstxtOtherAmount
        '
        Me.mstxtOtherAmount.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.mstxtOtherAmount.HidePromptOnLeave = True
        Me.mstxtOtherAmount.Location = New System.Drawing.Point(322, 207)
        Me.mstxtOtherAmount.Mask = "0000000"
        Me.mstxtOtherAmount.Name = "mstxtOtherAmount"
        Me.mstxtOtherAmount.Size = New System.Drawing.Size(208, 25)
        Me.mstxtOtherAmount.TabIndex = 4
        Me.mstxtOtherAmount.ValidatingType = GetType(Integer)
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(161, -55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(289, 32)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Pay Other Academic Fee"
        '
        'frmStudent_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 444)
        Me.Controls.Add(Me.tabStudentPayment)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStudent_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Newman College - Student (Payment Page)"
        Me.tabStudentPayment.ResumeLayout(False)
        Me.tabSchoolPayment.ResumeLayout(False)
        Me.tabSchoolPayment.PerformLayout()
        Me.tabOtherPayment.ResumeLayout(False)
        Me.tabOtherPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabStudentPayment As TabControl
    Friend WithEvents tabSchoolPayment As TabPage
    Friend WithEvents tabOtherPayment As TabPage
    Friend WithEvents radResidenceFee As RadioButton
    Friend WithEvents radSchoolFee As RadioButton
    Friend WithEvents txtYearBlock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMakePayment As Button
    Friend WithEvents mstxtAcaYear As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents mstxtAmount As MaskedTextBox
    Friend WithEvents cmAcadYear As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnMakeOtherPay As Button
    Friend WithEvents mstxtOtherAmount As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbTerBlock As ComboBox
    Friend WithEvents cmbYeaBlock As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbOthers As ComboBox
    Friend WithEvents txtTerm As TextBox
End Class
