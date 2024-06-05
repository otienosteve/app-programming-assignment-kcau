<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentsForm
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
        Me.lblStudents = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCourse = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.rbnMale = New System.Windows.Forms.RadioButton()
        Me.rbnFemale = New System.Windows.Forms.RadioButton()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStudents
        '
        Me.lblStudents.AutoSize = True
        Me.lblStudents.Location = New System.Drawing.Point(483, 44)
        Me.lblStudents.Name = "lblStudents"
        Me.lblStudents.Size = New System.Drawing.Size(141, 25)
        Me.lblStudents.TabIndex = 0
        Me.lblStudents.Text = "Add Students"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFirstName.Location = New System.Drawing.Point(241, 119)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(116, 25)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(419, 116)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(281, 31)
        Me.TxtFirstName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLastName.Location = New System.Drawing.Point(242, 185)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(115, 25)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(419, 185)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(281, 31)
        Me.txtLastName.TabIndex = 4
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(267, 248)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(65, 25)
        Me.lblEmail.TabIndex = 5
        Me.lblEmail.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(419, 248)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(281, 31)
        Me.txtEmail.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(419, 320)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 31)
        Me.TextBox1.TabIndex = 7
        '
        'lblCourse
        '
        Me.lblCourse.AutoSize = True
        Me.lblCourse.Location = New System.Drawing.Point(267, 320)
        Me.lblCourse.Name = "lblCourse"
        Me.lblCourse.Size = New System.Drawing.Size(81, 25)
        Me.lblCourse.TabIndex = 9
        Me.lblCourse.Text = "Course"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(274, 421)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(83, 25)
        Me.lblGender.TabIndex = 10
        Me.lblGender.Text = "Gender"
        '
        'rbnMale
        '
        Me.rbnMale.AutoSize = True
        Me.rbnMale.Location = New System.Drawing.Point(501, 395)
        Me.rbnMale.Name = "rbnMale"
        Me.rbnMale.Size = New System.Drawing.Size(90, 29)
        Me.rbnMale.TabIndex = 11
        Me.rbnMale.TabStop = True
        Me.rbnMale.Text = "Male"
        Me.rbnMale.UseVisualStyleBackColor = True
        '
        'rbnFemale
        '
        Me.rbnFemale.AutoSize = True
        Me.rbnFemale.Location = New System.Drawing.Point(501, 440)
        Me.rbnFemale.Name = "rbnFemale"
        Me.rbnFemale.Size = New System.Drawing.Size(114, 29)
        Me.rbnFemale.TabIndex = 12
        Me.rbnFemale.TabStop = True
        Me.rbnFemale.Text = "Female"
        Me.rbnFemale.UseVisualStyleBackColor = True
        '
        'btnAddStudent
        '
        Me.btnAddStudent.Location = New System.Drawing.Point(452, 496)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(222, 55)
        Me.btnAddStudent.TabIndex = 13
        Me.btnAddStudent.Text = "Add Student"
        Me.btnAddStudent.UseVisualStyleBackColor = True
        '
        'studentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 712)
        Me.Controls.Add(Me.btnAddStudent)
        Me.Controls.Add(Me.rbnFemale)
        Me.Controls.Add(Me.rbnMale)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblCourse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblStudents)
        Me.Name = "studentsForm"
        Me.Text = "studentsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStudents As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents TxtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents rbnMale As RadioButton
    Friend WithEvents rbnFemale As RadioButton
    Friend WithEvents btnAddStudent As Button
End Class
