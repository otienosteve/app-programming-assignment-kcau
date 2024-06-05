Public Class frmExponent
    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        Dim number As Integer = Convert.ToInt32(txtNumber.Text)

        lblResult.Text = number * number
    End Sub

    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        Dim number As Integer = Convert.ToInt32(txtNumber.Text)

        lblResult.Text = number ^ 0.5
    End Sub
End Class