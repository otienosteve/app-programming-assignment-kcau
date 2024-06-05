<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTeacher
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
        Me.lblTeachers = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblQualification = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.txtQualification = New System.Windows.Forms.TextBox()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbnMale = New System.Windows.Forms.RadioButton()
        Me.rbnFemale = New System.Windows.Forms.RadioButton()
        Me.btnAddTeacher = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTeachers
        '
        Me.lblTeachers.AutoSize = True
        Me.lblTeachers.Location = New System.Drawing.Point(414, 65)
        Me.lblTeachers.Name = "lblTeachers"
        Me.lblTeachers.Size = New System.Drawing.Size(135, 25)
        Me.lblTeachers.TabIndex = 0
        Me.lblTeachers.Text = "Add Teacher"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(152, 172)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(116, 25)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(152, 247)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(115, 25)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name"
        '
        'lblDepartment
        '
        Me.lblDepartment.AutoSize = True
        Me.lblDepartment.Location = New System.Drawing.Point(152, 329)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(123, 25)
        Me.lblDepartment.TabIndex = 3
        Me.lblDepartment.Text = "Department"
        '
        'lblQualification
        '
        Me.lblQualification.AutoSize = True
        Me.lblQualification.Location = New System.Drawing.Point(152, 423)
        Me.lblQualification.Name = "lblQualification"
        Me.lblQualification.Size = New System.Drawing.Size(131, 25)
        Me.lblQualification.TabIndex = 4
        Me.lblQualification.Text = "Qualification"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(374, 166)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(265, 31)
        Me.txtFirstName.TabIndex = 6
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(374, 244)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(265, 31)
        Me.txtLastName.TabIndex = 7
        '
        'txtDepartment
        '
        Me.txtDepartment.Location = New System.Drawing.Point(374, 329)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(265, 31)
        Me.txtDepartment.TabIndex = 8
        '
        'txtQualification
        '
        Me.txtQualification.Location = New System.Drawing.Point(374, 417)
        Me.txtQualification.Name = "txtQualification"
        Me.txtQualification.Size = New System.Drawing.Size(265, 31)
        Me.txtQualification.TabIndex = 9
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(152, 506)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(83, 25)
        Me.lblGender.TabIndex = 5
        Me.lblGender.Text = "Gender"
        '
        'rbnMale
        '
        Me.rbnMale.AutoSize = True
        Me.rbnMale.Location = New System.Drawing.Point(374, 506)
        Me.rbnMale.Name = "rbnMale"
        Me.rbnMale.Size = New System.Drawing.Size(90, 29)
        Me.rbnMale.TabIndex = 10
        Me.rbnMale.TabStop = True
        Me.rbnMale.Text = "Male"
        Me.rbnMale.UseVisualStyleBackColor = True
        '
        'rbnFemale
        '
        Me.rbnFemale.AutoSize = True
        Me.rbnFemale.Location = New System.Drawing.Point(374, 560)
        Me.rbnFemale.Name = "rbnFemale"
        Me.rbnFemale.Size = New System.Drawing.Size(114, 29)
        Me.rbnFemale.TabIndex = 11
        Me.rbnFemale.TabStop = True
        Me.rbnFemale.Text = "Female"
        Me.rbnFemale.UseVisualStyleBackColor = True
        '
        'btnAddTeacher
        '
        Me.btnAddTeacher.Location = New System.Drawing.Point(407, 623)
        Me.btnAddTeacher.Name = "btnAddTeacher"
        Me.btnAddTeacher.Size = New System.Drawing.Size(191, 51)
        Me.btnAddTeacher.TabIndex = 12
        Me.btnAddTeacher.Text = "Add Teacher"
        Me.btnAddTeacher.UseVisualStyleBackColor = True
        '
        'frmTeacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 803)
        Me.Controls.Add(Me.btnAddTeacher)
        Me.Controls.Add(Me.rbnFemale)
        Me.Controls.Add(Me.rbnMale)
        Me.Controls.Add(Me.txtQualification)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblQualification)
        Me.Controls.Add(Me.lblDepartment)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblTeachers)
        Me.Name = "frmTeacher"
        Me.Text = "frmTeacher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTeachers As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblQualification As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtQualification As TextBox
    Friend WithEvents lblGender As Label
    Friend WithEvents rbnMale As RadioButton
    Friend WithEvents rbnFemale As RadioButton
    Friend WithEvents btnAddTeacher As Button
End Class
