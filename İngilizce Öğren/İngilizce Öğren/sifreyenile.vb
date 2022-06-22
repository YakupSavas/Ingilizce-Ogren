Imports MySql.Data.MySqlClient
Public Class sifreyenile
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            Try
                Dim con As New MySqlConnection("server=localhost; userid=root; password=; database=giris; charset=utf8")
                Dim cmd As New MySqlCommand()
                con.Open()
                cmd.Connection = con
                cmd.CommandText = "UPDATE kullanicilar SET kSifre='" & TextBox1.Text & "' WHERE ePosta='" & Sifreunuttum.eposta & "'"
                cmd.ExecuteNonQuery()
                MsgBox("Şifreniz Başarıyla Değiştirilmiştir.")
                kullaniciekrani.Show()
                Me.Close()
            Catch ex As Exception

            End Try
        Else
            MsgBox("Şifreler Uyuşmuyor ! ")
        End If
    End Sub
End Class