Public Class testler
    Dim oku As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oku = My.Computer.FileSystem.ReadAllText("C:\SPTtest.txt")
        TextBox1.Text = oku
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        oku = My.Computer.FileSystem.ReadAllText("C:\PCTtest.txt")
        TextBox1.Text = oku
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        oku = My.Computer.FileSystem.ReadAllText("C:\SpastTtest.txt")
        TextBox1.Text = oku
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        oku = My.Computer.FileSystem.ReadAllText("C:\PastCTtest.txt")
        TextBox1.Text = oku
    End Sub
End Class