Public Class loading_screen
    Public DEVMODE As Boolean = True
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Close()
        End If

    End Sub

    Private Sub loading_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DEVMODE_Button()
        Cursor.Hide()
        Timer1.Start()

    End Sub

    Private Sub DEVMODE_Button()
        If DEVMODE = True Then
            Form1.Show()
            MsgBox("DEVMODE has been activated.")
            Me.Close()
        End If
    End Sub
End Class