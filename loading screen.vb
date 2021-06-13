Public Class loading_screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Form1.Show()
            Me.Close()
        End If

    End Sub

    Private Sub loading_screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
End Class