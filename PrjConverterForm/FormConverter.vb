Public Class FormConverter

    Private Const KM2MI = 1.609344

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        txtMiles.Text = txtKilometers.Text / KM2MI
    End Sub
End Class
