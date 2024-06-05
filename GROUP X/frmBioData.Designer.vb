<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBioData
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
        Me.lblBioData = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBioData
        '
        Me.lblBioData.AutoSize = True
        Me.lblBioData.Location = New System.Drawing.Point(330, 68)
        Me.lblBioData.Name = "lblBioData"
        Me.lblBioData.Size = New System.Drawing.Size(88, 25)
        Me.lblBioData.TabIndex = 0
        Me.lblBioData.Text = "BioData"
        '
        'frmBioData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblBioData)
        Me.Name = "frmBioData"
        Me.Text = "frmBioData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBioData As Label
End Class
