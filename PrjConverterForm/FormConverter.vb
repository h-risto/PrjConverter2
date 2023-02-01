Public Class FormConverter
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim converter As PrjConverterComponent.IConverter
        converter = New PrjConverterComponent.CConverter

        Try
            Dim result = converter.ConvertKilometersToMiles(txtKilometers.Text)
            txtMiles.Text = result
        Catch ex As Exception
            txtMiles.Text = "Sisesta vaid numbrid!"
        End Try

    End Sub

    Private Sub FormConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMiles.ReadOnly = True
    End Sub
End Class
