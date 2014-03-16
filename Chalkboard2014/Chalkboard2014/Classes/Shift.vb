Public Class Shift

    Private _joueur As Joueur
    Private _debut As Double
    Private _fin As Double

#Region "Get/Set"

    Public Property Fin() As Double
        Get
            Return _fin
        End Get
        Set(ByVal value As Double)
            _fin = value
        End Set
    End Property

    Public Property Debut() As Double
        Get
            Return _debut
        End Get
        Set(ByVal value As Double)
            _debut = value
        End Set
    End Property

    Public Property Joueur() As Joueur
        Get
            Return _joueur
        End Get
        Set(ByVal value As Joueur)
            _joueur = value
        End Set
    End Property

#End Region

        Public Sub New(pJoueur As Joueur, pDebut As Double)
            _joueur = pJoueur
            _debut = pDebut
        End Sub

End Class
