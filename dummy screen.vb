Public Class dummy_screen
    Private Sub dummy_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 10 Then
            Me.Hide()
        End If

        If ProgressBar1.Value = 1 Then
            loading_screen.Show()
        End If
    End Sub
End Class