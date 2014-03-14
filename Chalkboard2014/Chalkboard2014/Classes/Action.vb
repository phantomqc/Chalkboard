Public Class Action
    Private _nom As String
    Private _temps As Double
    Private _joueur As Joueur
    Private _cible As Joueur
    Private _depart As Point
    Private _fin As Point

#Region "Get/Set"
    Public Property Fin() As Point
        Get
            Return _fin
        End Get
        Set(ByVal value As Point)
            _fin = value
        End Set
    End Property

    Public Property Depart() As Point
        Get
            Return _depart
        End Get
        Set(ByVal value As Point)
            _depart = value
        End Set
    End Property


    Public Property Cible() As Joueur
        Get
            Return _cible
        End Get
        Set(ByVal value As Joueur)
            _cible = value
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

    Public Property Temps() As Double
        Get
            Return _temps
        End Get
        Set(ByVal value As Double)
            _temps = value
        End Set
    End Property

    Public Property Nom() As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property
#End Region

    Public Sub New(pNom As String, pTemps As Double, pJoueur As Joueur, pDepart As Point)
        _nom = pNom
        _temps = pTemps
        _joueur = pJoueur
        _depart = pDepart
    End Sub

    Public Overrides Function ToString() As String
        Return _temps.ToString & " - " & _joueur.NomJoueur & " - " & _nom & " - " & _depart.X & " " & _depart.Y
    End Function
End Class
