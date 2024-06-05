<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExponent
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
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.btnSquare = New System.Windows.Forms.Button()
        Me.btnSquareRoot = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(163, 89)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(87, 25)
        Me.lblNumber.TabIndex = 0
        Me.lblNumber.Text = "Number"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(332, 89)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(210, 31)
        Me.txtNumber.TabIndex = 1
        '
        'btnSquare
        '
        Me.btnSquare.Location = New System.Drawing.Point(144, 157)
        Me.btnSquare.Name = "btnSquare"
        Me.btnSquare.Size = New System.Drawing.Size(195, 59)
        Me.btnSquare.TabIndex = 2
        Me.btnSquare.Text = "Square"
        Me.btnSquare.UseVisualStyleBackColor = True
        '
        'btnSquareRoot
        '
        Me.btnSquareRoot.Location = New System.Drawing.Point(384, 157)
        Me.btnSquareRoot.Name = "btnSquareRoot"
        Me.btnSquareRoot.Size = New System.Drawing.Size(195, 59)
        Me.btnSquareRoot.TabIndex = 3
        Me.btnSquareRoot.Text = "SquareRoot"
        Me.btnSquareRoot.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(661, 89)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(83, 25)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Answer"
        '
        'frmExponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1413, 644)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnSquareRoot)
        Me.Controls.Add(Me.btnSquare)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Name = "frmExponent"
        Me.Text = "frmExponent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnSquare As Button
    Friend WithEvents btnSquareRoot As Button
    Friend WithEvents lblResult As Label
End Class
