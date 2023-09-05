Public Class Form1
    Private Sub txtCalculate_Click(sender As Object, e As EventArgs) Handles txtCalculate.Click

        Dim iNumber1 As Integer
        Dim iNumber2 As Integer
        Dim iResult As Double

        iNumber1 = txtNumber1.Text
        iNumber2 = txtNumber2.Text

        iResult = iNumber1 + iNumber2

        MsgBox(iNumber1 & " + " & iNumber2 & " = " & iResult)

        iResult = iNumber1 * iNumber2

        MsgBox(iNumber1 & " * " & iNumber2 & " = " & iResult)

        iResult = iNumber1 / iNumber2

        MsgBox(iNumber1 & " / " & iNumber2 & " = " & iResult)

        iResult = iNumber1 - iNumber2

        MsgBox(iNumber1 & " - " & iNumber2 & " = " & iResult)





    End Sub
End Class
