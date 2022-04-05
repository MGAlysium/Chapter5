Public Class frmGameing

    Const half As Decimal = 12D
    Const whole As Decimal = 28D
    Const two As Decimal = 7D

    Dim outVal As Decimal
    Dim inVal As Decimal

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        inVal = -500

        If txtName.Text = "" Then
            MsgBox("Please Enter A Name.", , "Input Error")
            txtName.Text = ""
            txtInput.Text = ""
            txtName.Focus()
            AcceptButton = btnCalcCost
        End If

        If Decimal.TryParse(txtInput.Text, inVal) Then
            inVal = Convert.ToDecimal(txtInput.Text)
        Else
            MsgBox("Please Enter A Number.", , "Input Error")
            txtInput.Text = ""
            txtInput.Focus()
            AcceptButton = btnCalcCost
        End If

        If inVal > 0 Then
            If radHalf.Checked Then
                outVal = inVal * half
            ElseIf radWhole.Checked Then
                outVal = inVal * whole
            ElseIf radTwo.Checked Then
                outVal = inVal * two
            End If

            lblOutput.Text = "Prepaid Amount:     " + outVal.ToString("C")
            AcceptButton = btnClear
        ElseIf Decimal.TryParse(txtInput.Text, inVal) Then
            MsgBox("Please Enter A Positive Number.", , "Input Error")
            txtInput.Text = ""
            txtInput.Focus()
            AcceptButton = btnCalcCost
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = "Prepaid Amount:"
        txtName.Text = ""
        txtInput.Text = ""
        txtName.Focus()
        AcceptButton = btnCalcCost
    End Sub

    Private Sub grpSelection_Enter(sender As Object, e As EventArgs) Handles grpSelection.Enter

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
