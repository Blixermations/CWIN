Public Class othertab
    Dim mouse As Icon = My.Resources.cursor
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        MsgBox("build 2 version 0.6 prototype", MsgBoxStyle.Information, "PINGnul App Title")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub othertab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = New Cursor(mouse.Handle)
    End Sub
End Class