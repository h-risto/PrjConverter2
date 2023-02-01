Public Class FormConverter
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim converter As PrjConverterComponent.IConverter
        converter = New PrjConverterComponent.CConverter

        Try
            Dim result = converter.ConvertKilometersToMiles(txtKilometers.Text)
            txtMiles.Text = Math.Round(result, 3)
        Catch ex As Exception
            txtMiles.Text = "Sisesta vaid numbrid!"
        End Try

    End Sub

    Private Sub FormConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMiles.ReadOnly = True
        timerClock.Enabled = True

        ' timer ticks once a second
        timerClock.Interval = 1000
    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        lblTime.Text = DateTime.Now
    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click
        timerClock.Enabled = Not timerClock.Enabled
    End Sub

    Private Sub SulgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SulgeToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
