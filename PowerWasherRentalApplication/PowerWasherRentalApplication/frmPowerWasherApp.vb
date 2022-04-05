Public Class frmPowerWasherApp

    Const half As Decimal = 24D
    Const whole As Decimal = 35D
    Const two As Decimal = 50D

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        If radHalf.Checked Then
            lblOutput.Text = "Rental Cost:     " + half.ToString("C")
        ElseIf radWhole.Checked Then
            lblOutput.Text = "Rental Cost:     " + whole.ToString("C")
        ElseIf radTwo.Checked Then
            lblOutput.Text = "Rental Cost:     " + two.ToString("C")
        End If
        AcceptButton = btnClear
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.Text = "Rental Cost:"
        AcceptButton = btnCalcCost
    End Sub

End Class
