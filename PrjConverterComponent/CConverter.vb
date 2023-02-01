Public Class CConverter
    Implements IConverter

    Const KM2MI = 1.609344

    Public Function ConvertKilometersToMiles(km As Double) As Double Implements IConverter.ConvertKilometersToMiles
        Dim answer = km / KM2MI
        Return answer
    End Function
End Class
