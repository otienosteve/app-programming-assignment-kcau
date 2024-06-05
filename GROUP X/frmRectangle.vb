Public Class frmRectangle
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim width As Integer = Convert.ToInt32(txtWidth.Text)
        Dim length As Integer = Convert.ToInt32(txtLength.Text)

        lblResult.Text = width * length

    End Sub

    Private Sub btnPerimeter_Click(sender As Object, e As EventArgs) Handles btnPerimeter.Click
        Dim width As Integer = Convert.ToInt32(txtWidth.Text)
        Dim length As Integer = Convert.ToInt32(txtLength.Text)

        lblResult.Text = (width + length) * 2
    End Sub
End Class