Public Class Form1
    Dim mouse As Icon = My.Resources.cursor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = New Cursor(mouse.Handle)
        Cursor.Show()
        dummy_screen.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("PINGnul Display Text", MsgBoxStyle.Information, "PINGnul App Title")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("I have not yet put this in, build 0.7 should have it :)", MsgBoxStyle.Information, "PINGnul App Title")
        window_test.MdiParent = Me
        window_test.Show()
        HideAll()
    End Sub

    Private Sub HideAll()
        Label1.Hide()
        Button1.Hide()
        Button2.Hide()
        Button4.Hide()
    End Sub
End Class
