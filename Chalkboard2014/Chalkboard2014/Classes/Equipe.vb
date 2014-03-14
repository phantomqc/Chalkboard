Public Class Equipe
    Private _id As Integer
    Private _nom As String
    Private _categorie As String
    Private _sexe As Char
    Private _age As String
    Private _joueur As List(Of Joueur)

#Region "Get/Set"
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Age() As String
        Get
            Return _age
        End Get
        Set(ByVal value As String)
            _age = value
        End Set
    End Property

    Public Property Sexe() As Char
        Get
            Return _sexe
        End Get
        Set(ByVal value As Char)
            _sexe = value
        End Set
    End Property
    Public Property Categorie() As String
        Get
            Return _categorie
        End Get
        Set(ByVal value As String)
            _categorie = value
        End Set
    End Property
    Public Property NomEquipe() As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property Joueur() As List(Of Joueur)
        Get
            Return _joueur
        End Get
        Set(ByVal value As List(Of Joueur))
            _joueur = value
        End Set
    End Property
#End Region

    Public Sub New()

    End Sub
    Public Sub New(id As Integer, nom As String, age As String, cat As Integer, sexe As Char)
        _id = id
        _nom = nom
        _age = age
        _categorie = cat
        _sexe = sexe
    End Sub

    Public Overrides Function ToString() As String
        Return _nom & " - " & _sexe.ToString.ToUpper() & _age & _categorie
    End Function
End Class
