Public Class Form1
    'Attempted to embed CC Wild Words thanks to this commenter: https://stackoverflow.com/a/9590832
    Const _cdecCon As Decimal = 209.0
    Const _cdecConAu As Decimal = 275.0
    Const _cdecConSu As Decimal = 380.0

    Dim decPriceModi As Decimal = 0
    Dim intGroupNum As Integer = 0
    Dim strGroupNum As String

    Private Sub tbxInput_TextChanged(sender As Object, e As EventArgs) Handles tbxInput.TextChanged
        AutoSize = False
        If tbxInput.TextLength > 0 Then
            btnCalc.Enabled = True
            btnClear.Enabled = True
            strGroupNum = tbxInput.Text
        End If
        If tbxInput.TextLength = 0 Then
            btnCalc.Enabled = False
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tbxInput.Text = ""
        lblPrice.Text = ""
        btnClear.Enabled = False
        rdiCon1.PerformClick()
        tbxInput.Select()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        If Integer.TryParse(strGroupNum, intGroupNum) Then
            If (intGroupNum > 0 And intGroupNum <= 20) Then
                If rdiCon1.Checked Then
                    decPriceModi = _cdecCon
                ElseIf rdiConAu.Checked Then
                    decPriceModi = _cdecConAu
                ElseIf rdiConSu.Checked Then
                    decPriceModi = _cdecConSu
                End If
                lblPrice.Text = "$" + (decPriceModi * intGroupNum).ToString("N2")
            Else
                If (intGroupNum <= 0) Then
                    MessageBox.Show("There needs to be at least one person!")
                End If
                If (intGroupNum > 20) Then
                    MessageBox.Show("That's too many people!")
                End If
            End If
        Else
            MessageBox.Show("Can't calculate that, sorry!")
        End If
    End Sub

    'Private Sub rdiCon1_CheckedChanged(sender As Object, e As EventArgs) Handles rdiCon1.CheckedChanged
    '    decPriceModi = _cdecCon
    'End Sub

    'Private Sub rdiConAu_CheckedChanged(sender As Object, e As EventArgs) Handles rdiConAu.CheckedChanged
    '    decPriceModi = _cdecConAu
    'End Sub

    'Private Sub rdiConSu_CheckedChanged(sender As Object, e As EventArgs) Handles rdiConSu.CheckedChanged
    '    decPriceModi = _cdecConSu
    'End Sub
End Class
