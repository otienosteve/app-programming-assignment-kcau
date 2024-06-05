
Public Class studentsForm


    Private Sub lblStudents_Click(sender As Object, e As EventArgs) Handles lblStudents.Click
        Me.Show()
    End Sub

    Private Sub studentsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFirstName.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstName.TextChanged

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click
        MessageBox.Show("Student Added Successfully")
    End Sub
End Class