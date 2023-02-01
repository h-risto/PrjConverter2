Public Class FormConverter

    Private Const KM2MI = 1.609344

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Try
            txtMiles.Text = txtKilometers.Text / KM2MI
        Catch ex As Exception
            ' MsgBox("Vigane sisestus!", MsgBoxStyle.Critical)
            txtMiles.Text = "Viga!"
        End Try


    End Sub

    Private Sub FormConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMiles.ReadOnly = True
    End Sub
End Class
