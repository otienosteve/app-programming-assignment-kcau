<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaylsip
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtJobGroup = New System.Windows.Forms.TextBox()
        Me.txtBankDetails = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPaye = New System.Windows.Forms.Label()
        Me.lblNhif = New System.Windows.Forms.Label()
        Me.lblNssf = New System.Windows.Forms.Label()
        Me.lblHelb = New System.Windows.Forms.Label()
        Me.lblHousing = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Job Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bank Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Company"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(165, 351)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gross Pay"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(419, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(284, 31)
        Me.txtName.TabIndex = 5
        '
        'txtJobGroup
        '
        Me.txtJobGroup.Location = New System.Drawing.Point(419, 118)
        Me.txtJobGroup.Name = "txtJobGroup"
        Me.txtJobGroup.Size = New System.Drawing.Size(284, 31)
        Me.txtJobGroup.TabIndex = 6
        '
        'txtBankDetails
        '
        Me.txtBankDetails.Location = New System.Drawing.Point(419, 184)
        Me.txtBankDetails.Name = "txtBankDetails"
        Me.txtBankDetails.Size = New System.Drawing.Size(284, 31)
        Me.txtBankDetails.TabIndex = 7
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(419, 274)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(284, 31)
        Me.txtCompany.TabIndex = 8
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(419, 351)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(284, 31)
        Me.txtGrossPay.TabIndex = 9
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(418, 442)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(285, 57)
        Me.btnGenerate.TabIndex = 10
        Me.btnGenerate.Text = "Generate Pay Slip"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1067, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Payslip "
        '
        'lblPaye
        '
        Me.lblPaye.AutoSize = True
        Me.lblPaye.Location = New System.Drawing.Point(933, 89)
        Me.lblPaye.Name = "lblPaye"
        Me.lblPaye.Size = New System.Drawing.Size(61, 25)
        Me.lblPaye.TabIndex = 12
        Me.lblPaye.Text = "Paye"
        '
        'lblNhif
        '
        Me.lblNhif.AutoSize = True
        Me.lblNhif.Location = New System.Drawing.Point(933, 139)
        Me.lblNhif.Name = "lblNhif"
        Me.lblNhif.Size = New System.Drawing.Size(60, 25)
        Me.lblNhif.TabIndex = 13
        Me.lblNhif.Text = "NHIF"
        '
        'lblNssf
        '
        Me.lblNssf.AutoSize = True
        Me.lblNssf.Location = New System.Drawing.Point(933, 190)
        Me.lblNssf.Name = "lblNssf"
        Me.lblNssf.Size = New System.Drawing.Size(68, 25)
        Me.lblNssf.TabIndex = 14
        Me.lblNssf.Text = "NSSF"
        '
        'lblHelb
        '
        Me.lblHelb.AutoSize = True
        Me.lblHelb.Location = New System.Drawing.Point(934, 235)
        Me.lblHelb.Name = "lblHelb"
        Me.lblHelb.Size = New System.Drawing.Size(67, 25)
        Me.lblHelb.TabIndex = 15
        Me.lblHelb.Text = "HELB"
        '
        'lblHousing
        '
        Me.lblHousing.AutoSize = True
        Me.lblHousing.Location = New System.Drawing.Point(934, 290)
        Me.lblHousing.Name = "lblHousing"
        Me.lblHousing.Size = New System.Drawing.Size(137, 25)
        Me.lblHousing.TabIndex = 16
        Me.lblHousing.Text = "HousingLevy"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Location = New System.Drawing.Point(934, 354)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(88, 25)
        Me.lblNetPay.TabIndex = 17
        Me.lblNetPay.Text = "Net Pay"
        '
        'frmPaylsip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1869, 826)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblHousing)
        Me.Controls.Add(Me.lblHelb)
        Me.Controls.Add(Me.lblNssf)
        Me.Controls.Add(Me.lblNhif)
        Me.Controls.Add(Me.lblPaye)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.txtBankDetails)
        Me.Controls.Add(Me.txtJobGroup)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPaylsip"
        Me.Text = "frmPaylsip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtJobGroup As TextBox
    Friend WithEvents txtBankDetails As TextBox
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPaye As Label
    Friend WithEvents lblNhif As Label
    Friend WithEvents lblNssf As Label
    Friend WithEvents lblHelb As Label
    Friend WithEvents lblHousing As Label
    Friend WithEvents lblNetPay As Label
End Class
