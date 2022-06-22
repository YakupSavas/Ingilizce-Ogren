Imports MySql.Data.MySqlClient
Public Class kullaniciekrani
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("server=localhost; userid=root; password=; database=giris; charset=utf8")
        Dim cmd As New MySqlCommand()
        Dim dr As MySqlDataReader
        TextBox2.UseSystemPasswordChar = True
        Try
        con.Open()
            cmd.Connection = con
            cmd.CommandText = "SELECT kadi, kSifre FROM kullanicilar WHERE kAdi='" & TextBox1.Text & "' AND kSifre='" & TextBox2.Text & "'"
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                MsgBox("Giriş Yapıldı")
                AnaSayfa.Show()
                Close()
            Else
                MsgBox("Kullacı Adı veya Şifre Yanlış")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Sifreunuttum.ShowDialog()
    End Sub
End Class