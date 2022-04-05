Public Class frmCabinet
    Const pine As Decimal = 300D
    Const oak As Decimal = 500D
    Const cherry As Decimal = 650D

    Dim inVal As Decimal
    Dim outVal As Decimal

    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        inVal = -500

        If Decimal.TryParse(txtInput.Text, inVal) Then
            inVal = Convert.ToDecimal(txtInput.Text)
        Else
            Dim errorWindow As New frmInvalid
            errorWindow.Show()
            errorWindow.lblError.Location = New System.Drawing.Point(24, 42)
            errorWindow.lblError.Text = "Please Enter A Number"
        End If

        If inVal > 0 Then
            If radPine.Checked Then
                outVal = inVal * pine
            ElseIf radOak.Checked Then
                outVal = inVal * oak
            ElseIf radCherry.Checked Then
                outVal = inVal * cherry
            End If
            lblOutput.Text = "Cost Estimate: " + outVal.ToString("C")
        ElseIf Decimal.TryParse(txtInput.Text, inVal) Then
            Dim errorWindow As New frmInvalid
            errorWindow.Show()
            errorWindow.lblError.Location = New System.Drawing.Point(24, 32)
            errorWindow.lblError.Text = "Please Enter A Positive" + vbNewLine + "Integer"
        End If

        AcceptButton = btnClear
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtInput.Text = ""
        lblOutput.Text = "Cost Estimate:"

        txtInput.Focus()

        AcceptButton = btnCalcCost
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        AcceptButton = btnCalcCost
    End Sub
End Class
