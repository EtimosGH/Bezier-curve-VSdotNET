Public Class Courbes
    Public Function ptX(x_deb As Decimal, x_tg_deb As Decimal, x_fin As Decimal, x_tg_fin As Decimal, t As Decimal) As Decimal
        Dim x As Decimal
        Return x = ((1 - t) ^ 3) * x_deb + 3 * t * ((1 - t) ^ 2) * x_tg_deb + 3 * (t ^ 2) * (1 - t) * x_tg_fin + (t ^ 3) * x_fin
    End Function

    Public Function ptY(y_deb As Decimal, y_tg_deb As Decimal, y_fin As Decimal, y_tg_fin As Decimal, t As Decimal) As Decimal
        Dim y As Decimal
        Return y = ((1 - t) ^ 3) * y_deb + 3 * t * ((1 - t) ^ 2) * y_tg_deb + 3 * (t ^ 2) * (1 - t) * y_tg_fin + (t ^ 3) * y_fin
    End Function

End Class
