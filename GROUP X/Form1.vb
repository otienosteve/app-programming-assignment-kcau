Imports System.Data.OleDb

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTeachers.Click
        frmTeacher.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAccounts.Click
        frmAccounts.Show()
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click
        studentsForm.Show()
    End Sub

    Private Sub btnAssets_Click(sender As Object, e As EventArgs) Handles btnAssets.Click
        frmAssets.Show()
    End Sub

    Private Sub btnCourses_Click(sender As Object, e As EventArgs) Handles btnCourses.Click
        frmCourses.Show()
    End Sub

    Private Sub btnBioData_Click(sender As Object, e As EventArgs) Handles btnBioData.Click
        frmBioData.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnPayslip.Click
        frmPaylsip.Show()
    End Sub

    Private Sub btnExponent_Click(sender As Object, e As EventArgs) Handles btnExponent.Click
        frmExponent.Show()
    End Sub

    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click
        frmRectangle.Show()
    End Sub
End Class
