<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccounts
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
        Me.lblAccounts = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAccounts
        '
        Me.lblAccounts.AutoSize = True
        Me.lblAccounts.Location = New System.Drawing.Point(299, 76)
        Me.lblAccounts.Name = "lblAccounts"
        Me.lblAccounts.Size = New System.Drawing.Size(101, 25)
        Me.lblAccounts.TabIndex = 0
        Me.lblAccounts.Text = "Accounts"
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAccounts)
        Me.Name = "frmAccounts"
        Me.Text = "frmAccounts"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAccounts As Label
End Class
