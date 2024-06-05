<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssets
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
        Me.lblAssets = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAssets
        '
        Me.lblAssets.AutoSize = True
        Me.lblAssets.Location = New System.Drawing.Point(358, 90)
        Me.lblAssets.Name = "lblAssets"
        Me.lblAssets.Size = New System.Drawing.Size(77, 25)
        Me.lblAssets.TabIndex = 0
        Me.lblAssets.Text = "Assets"
        '
        'frmAssets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAssets)
        Me.Name = "frmAssets"
        Me.Text = "frmAssets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAssets As Label
End Class
