<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourses
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
        Me.lblCourses = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCourses
        '
        Me.lblCourses.AutoSize = True
        Me.lblCourses.Location = New System.Drawing.Point(335, 85)
        Me.lblCourses.Name = "lblCourses"
        Me.lblCourses.Size = New System.Drawing.Size(92, 25)
        Me.lblCourses.TabIndex = 0
        Me.lblCourses.Text = "Courses"
        '
        'frmCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblCourses)
        Me.Name = "frmCourses"
        Me.Text = "frmCourses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCourses As Label
End Class
