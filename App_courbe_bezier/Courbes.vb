Public Class Courbes
    Public Cname As String
    Public x_deb, x_tg_deb, x_tg_fin, x_fin As Decimal
    Public y_deb, y_tg_deb, y_fin, y_tg_fin As Decimal
    Public nbSeg As Int16

    Public Sub New()
        x_deb = -1
        y_deb = -1
        x_tg_deb = 1
        y_tg_deb = 0
        x_tg_fin = 0
        y_tg_fin = 1
        x_fin = 1
        y_fin = 1
        nbSeg = 4
    End Sub

    Public Property name As String
        Get
            Return Me.Cname
        End Get
        Set(value As String)
            Cname = value
        End Set
    End Property

End Class
