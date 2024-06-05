<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStudents = New System.Windows.Forms.Button()
        Me.btnTeachers = New System.Windows.Forms.Button()
        Me.btnCourses = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnBioData = New System.Windows.Forms.Button()
        Me.btnAssets = New System.Windows.Forms.Button()
        Me.btnExponent = New System.Windows.Forms.Button()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnPayslip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStudents
        '
        Me.btnStudents.Location = New System.Drawing.Point(32, 75)
        Me.btnStudents.Name = "btnStudents"
        Me.btnStudents.Size = New System.Drawing.Size(202, 52)
        Me.btnStudents.TabIndex = 0
        Me.btnStudents.Text = "Add Students"
        Me.btnStudents.UseVisualStyleBackColor = True
        '
        'btnTeachers
        '
        Me.btnTeachers.Location = New System.Drawing.Point(293, 75)
        Me.btnTeachers.Name = "btnTeachers"
        Me.btnTeachers.Size = New System.Drawing.Size(202, 52)
        Me.btnTeachers.TabIndex = 1
        Me.btnTeachers.Text = "Add Teachers"
        Me.btnTeachers.UseVisualStyleBackColor = True
        '
        'btnCourses
        '
        Me.btnCourses.Location = New System.Drawing.Point(567, 75)
        Me.btnCourses.Name = "btnCourses"
        Me.btnCourses.Size = New System.Drawing.Size(202, 52)
        Me.btnCourses.TabIndex = 2
        Me.btnCourses.Text = "Add Courses"
        Me.btnCourses.UseVisualStyleBackColor = True
        '
        'btnAccounts
        '
        Me.btnAccounts.Location = New System.Drawing.Point(832, 75)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(202, 52)
        Me.btnAccounts.TabIndex = 3
        Me.btnAccounts.Text = "Add Fee payment"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'btnBioData
        '
        Me.btnBioData.Location = New System.Drawing.Point(1085, 75)
        Me.btnBioData.Name = "btnBioData"
        Me.btnBioData.Size = New System.Drawing.Size(202, 52)
        Me.btnBioData.TabIndex = 4
        Me.btnBioData.Text = "Add BioData"
        Me.btnBioData.UseVisualStyleBackColor = True
        '
        'btnAssets
        '
        Me.btnAssets.Location = New System.Drawing.Point(1364, 75)
        Me.btnAssets.Name = "btnAssets"
        Me.btnAssets.Size = New System.Drawing.Size(202, 52)
        Me.btnAssets.TabIndex = 5
        Me.btnAssets.Text = "Add Assets"
        Me.btnAssets.UseVisualStyleBackColor = True
        '
        'btnExponent
        '
        Me.btnExponent.Location = New System.Drawing.Point(32, 263)
        Me.btnExponent.Name = "btnExponent"
        Me.btnExponent.Size = New System.Drawing.Size(202, 64)
        Me.btnExponent.TabIndex = 6
        Me.btnExponent.Text = "Exponenet"
        Me.btnExponent.UseVisualStyleBackColor = True
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(310, 263)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(202, 64)
        Me.btnRectangle.TabIndex = 7
        Me.btnRectangle.Text = "Rectangle"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'btnPayslip
        '
        Me.btnPayslip.Location = New System.Drawing.Point(581, 263)
        Me.btnPayslip.Name = "btnPayslip"
        Me.btnPayslip.Size = New System.Drawing.Size(202, 64)
        Me.btnPayslip.TabIndex = 8
        Me.btnPayslip.Text = "Payslip generator"
        Me.btnPayslip.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1774, 865)
        Me.Controls.Add(Me.btnPayslip)
        Me.Controls.Add(Me.btnRectangle)
        Me.Controls.Add(Me.btnExponent)
        Me.Controls.Add(Me.btnAssets)
        Me.Controls.Add(Me.btnBioData)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.btnCourses)
        Me.Controls.Add(Me.btnTeachers)
        Me.Controls.Add(Me.btnStudents)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnStudents As Button
    Friend WithEvents btnTeachers As Button
    Friend WithEvents btnCourses As Button
    Friend WithEvents btnAccounts As Button
    Friend WithEvents btnBioData As Button
    Friend WithEvents btnAssets As Button
    Friend WithEvents btnExponent As Button
    Friend WithEvents btnRectangle As Button
    Friend WithEvents btnPayslip As Button
End Class
