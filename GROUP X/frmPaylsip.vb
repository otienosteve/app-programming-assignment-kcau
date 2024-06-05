Public Class frmPaylsip
    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim name As String = txtName.Text
        Dim jobGroup As String = txtJobGroup.Text
        Dim bankDetails As String = txtBankDetails.Text
        Dim company As String = txtCompany.Text
        Dim grossPay As String = Convert.ToDecimal(txtGrossPay.Text)

        Dim deductions As Decimal
        Dim nhif As Decimal = grossPay * 0.02
        Dim nssf As Decimal = grossPay * 0.05
        Dim hlevy As Decimal = grossPay * 0.015
        Dim paye As Decimal = grossPay * 0.15
        Dim helb As Decimal = grossPay * 0.05

        deductions = nhif + nssf + hlevy + paye + helb
        Dim netPay As Decimal = grossPay - deductions


        lblNetPay.Text = "Paye :" + paye.ToString()
        lblHelb.Text = "HELB: " + helb.ToString()
        lblHousing.Text = "Housing Levy" + hlevy.ToString()
        lblNhif.Text = "NHIF: " + nhif.ToString()
        lblPaye.Text = "Paye: " + paye.ToString()
        lblNssf.Text = "NSSF:" + nssf.ToString()




    End Sub
End Class