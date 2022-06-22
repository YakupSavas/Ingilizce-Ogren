Public Class AnaSayfa

    Sub gecis(acilanform As Form)
        Panel1.Controls.Clear()
        acilanform.TopLevel = False
        Panel1.Controls.Add(acilanform)
        acilanform.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gecis(konular)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        gecis(testler)
    End Sub
End Class