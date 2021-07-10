Public Class Form1
    Dim apptitle As String = "CWIN Message Box"
    Dim mouse As Icon = My.Resources.cursor

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cursor = New Cursor(mouse.Handle)
        Cursor.Show()
        dummy_screen.Close()
        If loading_screen.DEVMODE = True Then
            loading_screen.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("PINGnul Display Text", MsgBoxStyle.Information, apptitle)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("I have not yet put this in, build 0.7 should have it :)", MsgBoxStyle.Information, apptitle)
        window_test.MdiParent = Me
        window_test.Show()
        HideAll()
    End Sub

    Private Sub HideAll()
        Label1.Hide()
        Button1.Hide()
        Button2.Hide()
        Button4.Hide()
        Button3.Hide()
    End Sub

    Public Sub ShowAll()
        Label1.Show()
        Button1.Show()
        Button2.Show()
        Button4.Show()
        Button3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        othertab.Show()
    End Sub
End Class