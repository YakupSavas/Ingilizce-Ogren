Imports System.Net.Mail
Public Class Sifreunuttum


    Dim s As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rnd As New Random
        Dim i As Integer

        Dim onay As Integer
        Dim mailMsj As New MailMessage()


        For i = 1 To 6
            onay = rnd.Next(1, 9)
            s = s + onay.ToString()
        Next

        Try
            MsgBox(s)

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        TextBox1.Visible = False
        Label1.Visible = False
        Button1.Visible = False
        Timer1.Start()
        TextBox2.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Button2.Visible = True

    End Sub

    Dim saniye As Integer = 60
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If saniye <> 0 Then
            saniye = saniye - 1
            Label3.Text = "Kalan saniye : " + saniye.ToString()
        Else
            Timer1.Stop()
            MsgBox("Zaman aşımına uğradı.")
            TextBox2.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Button2.Visible = False

            TextBox1.Visible = True
            Label1.Visible = True
            Button1.Visible = True

        End If



    End Sub
    Public eposta As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = s Then
            TextBox1.Visible = True
            Label1.Visible = True
            Button1.Visible = True
            eposta = TextBox1.Text
            sifreyenile.Show()
            Me.Close()

        Else
            MsgBox("Onay kodu yanlış.")
            TextBox1.Visible = True
            Label1.Visible = True
            Button1.Visible = True
            kullaniciekrani.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Sifreunuttum_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Button2.Visible = False
    End Sub
End Class