Public Class frmWindows

    Const half As Decimal = 6D
    Const whole As Decimal = 8D
    Const two As Decimal = 8D

    Dim outVal As Decimal
    Dim inVal As Decimal

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        inVal = -500

        If Decimal.TryParse(txtInput.Text, inVal) Then
            inVal = Convert.ToDecimal(txtInput.Text)
        Else
            MsgBox("Please Enter A Number.", , "Input Error")
            txtInput.Text = ""
            txtInput.Focus()
            AcceptButton = btnCalcCost
            radOvernight.Checked = False
        End If

        If inVal > 0 Then
            If radHalf.Checked Then
                outVal = half
            ElseIf radWhole.Checked Then
                outVal = whole
            ElseIf radTwo.Checked Then
                outVal = two
            End If

            If inVal > 5 Then
                outVal *= 1.25
            End If

            If radOvernight.Checked Then
                outVal *= 2
            End If

            If inVal > 20 Then
                MsgBox("Please Enter A Number Less Than 20.", , "Input Error")
                txtInput.Text = ""
                txtInput.Focus()
                AcceptButton = btnCalcCost
                radOvernight.Checked = False
            Else
                lblOutput.Text = "Shipping Fee:     " + outVal.ToString("C")
                AcceptButton = btnClear
            End If

        ElseIf Decimal.TryParse(txtInput.Text, inVal) Then
            MsgBox("Please Enter A Positive Number.", , "Input Error")
            txtInput.Text = ""
            txtInput.Focus()
            AcceptButton = btnCalcCost
            radOvernight.Checked = False
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = "Shipping Fee:"
        txtInput.Text = ""
        txtInput.Focus()
        AcceptButton = btnCalcCost
        radOvernight.Checked = False
    End Sub

    Private Sub grpSelection_Enter(sender As Object, e As EventArgs) Handles grpSelection.Enter

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
