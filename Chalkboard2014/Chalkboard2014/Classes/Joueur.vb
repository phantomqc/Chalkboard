Public Class Joueur

    Private _passport As Integer
    Private _nom As String
    Private _no As Integer
    Private _terrain As Boolean
    Private _action As List(Of Action)

#Region "Get/Set"
    Public Property NewProperty() As Boolean
        Get
            Return _terrain
        End Get
        Set(ByVal value As Boolean)
            _terrain = value
        End Set
    End Property

    Public Property Passport() As Integer
        Get
            Return _passport
        End Get
        Set(ByVal value As Integer)
            _passport = value
        End Set
    End Property

    Public Property NomJoueur() As String
        Get
            Return _nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property ActionJoueur() As List(Of Action)
        Get
            Return _action
        End Get
        Set(ByVal value As List(Of Action))
            _action = value
        End Set
    End Property

    Public Property No() As Integer
        Get
            Return _no
        End Get
        Set(ByVal value As Integer)
            _no = value
        End Set
    End Property
#End Region

    Public Sub New(passport As Integer, nom As String)
        _passport = passport
        _nom = nom
    End Sub

    Public Sub New(passport As Integer, nom As String, no As Integer)
        _passport = passport
        _nom = nom
        _no = no
        _action = New List(Of Action)
    End Sub

    Public Overrides Function ToString() As String
        Return _no & " - " & _nom
    End Function
End Class
