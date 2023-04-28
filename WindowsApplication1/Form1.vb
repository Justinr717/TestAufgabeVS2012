Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Versicherungssumme, Prozentsatz, Praemie As Single

        Versicherungssumme = tVSumme.Text


        If Versicherungssumme <= 5000 Then
            Prozentsatz = 16.8
        ElseIf Versicherungssumme <= 10000 Then
            Prozentsatz = 12.6
        Else
            Prozentsatz = 8.4
        End If

        Praemie = (Versicherungssumme / 100) * Prozentsatz

        tAusgabePrämie.Text = FormatCurrency(Praemie)
        tAusgabeSatz.Text = Prozentsatz & "%"
    End Sub
End Class
