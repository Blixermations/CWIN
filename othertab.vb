Public Class othertab
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        MsgBox("build 1 version 0.6 prototype", MsgBoxStyle.Information, "PINGnul App Title")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class