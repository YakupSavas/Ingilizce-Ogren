Public Class Form1
   

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        If ProgressBar1.Value <= 100 Then
            Label1.Text = "Yükleniyor..."
        End If
        If ProgressBar1.Value = 100 Then
            Timer1.Dispose()
            Me.Hide()
            kullaniciekrani.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class
