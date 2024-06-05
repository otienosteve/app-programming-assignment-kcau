<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRectangle
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
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.btnPerimeter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(168, 113)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(67, 25)
        Me.lblWidth.TabIndex = 0
        Me.lblWidth.Text = "Width"
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(168, 202)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(78, 25)
        Me.lblLength.TabIndex = 1
        Me.lblLength.Text = "Length"
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(379, 106)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(220, 31)
        Me.txtWidth.TabIndex = 2
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(379, 196)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(220, 31)
        Me.txtLength.TabIndex = 3
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(709, 151)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(73, 25)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Result"
        '
        'btnArea
        '
        Me.btnArea.Location = New System.Drawing.Point(248, 301)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(119, 57)
        Me.btnArea.TabIndex = 5
        Me.btnArea.Text = "Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'btnPerimeter
        '
        Me.btnPerimeter.Location = New System.Drawing.Point(462, 301)
        Me.btnPerimeter.Name = "btnPerimeter"
        Me.btnPerimeter.Size = New System.Drawing.Size(137, 55)
        Me.btnPerimeter.TabIndex = 6
        Me.btnPerimeter.Text = "Perimeter"
        Me.btnPerimeter.UseVisualStyleBackColor = True
        '
        'frmRectangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 652)
        Me.Controls.Add(Me.btnPerimeter)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblWidth)
        Me.Name = "frmRectangle"
        Me.Text = "frmRectangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWidth As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtLength As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnArea As Button
    Friend WithEvents btnPerimeter As Button
End Class
