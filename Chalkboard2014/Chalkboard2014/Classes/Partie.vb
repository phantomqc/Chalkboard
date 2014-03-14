Imports MySql.Data.MySqlClient
Structure Shift
    Public _joueur As Joueur
    Public _debut As Double
    Public _fin As Double
End Structure
Public Class Partie

    Private _adversaire As String
    Private _date As Date
    Private _alignement As List(Of Joueur)
    Private _actions As List(Of Action)
    Private _shifts As List(Of Shift)
    Private _eq As Equipe

#Region "Get/Set"
    Public Property Adversaire() As String
        Get
            Return _adversaire
        End Get
        Set(ByVal value As String)
            _adversaire = value
        End Set
    End Property

    Public Property DatePartie() As Date
        Get
            Return _date
        End Get
        Set(ByVal value As Date)
            _date = value
        End Set
    End Property

    Public Property Alignement() As List(Of Joueur)
        Get
            Return _alignement
        End Get
        Set(ByVal value As List(Of Joueur))
            _alignement = value
        End Set
    End Property

    Public Property Actions() As List(Of Action)
        Get
            Return _actions
        End Get
        Set(ByVal value As List(Of Action))
            _actions = value
        End Set
    End Property

    Public Property Equipe() As Equipe
        Get
            Return _eq
        End Get
        Set(ByVal value As Equipe)
            _eq = value
        End Set
    End Property
#End Region

    Public Sub New(eq As Equipe, adv As String, datepartie As Date)
        _adversaire = adv
        _date = datepartie
        _alignement = New List(Of Joueur)
        _actions = New List(Of Action)
        _shifts = New List(Of Shift)
        _eq = eq
    End Sub


    Public Overrides Function ToString() As String
        Return _adversaire & " - " & _date.ToString
    End Function

    Public Function TrouverJoueur(pNum As Integer) As Joueur
        For Each pla In _alignement
            If pla.No = pNum Then Return pla
        Next
        Return Nothing
    End Function

    Public Sub SaveToSQL()
        Dim myc As New MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim SQL As String
        Dim idPartie As Integer
        Dim idAction As Integer
        Dim temps As String

        Try
            myc.ConnectionString = "server=localhost; user id=root; password=root; database=chalkboard"
            myc.Open()

            'Ajout de la partie
            SQL = "INSERT INTO `chalkboard`.`chalkboard_partie` (`partiedate`, `partieadv`, `equipe`) VALUES ('" & _
                DatePartie.ToString("yyyy-MM-dd") & "','" & Adversaire & "','" & Equipe.Id & "');"
            command = New MySqlCommand(SQL, myc)
            command.ExecuteNonQuery()

            'Obtention de l'id de la partie
            SQL = "SELECT idpartie FROM chalkboard.chalkboard_partie where partiedate = '" & DatePartie.ToString("yyyy-MM-dd") & "' AND partieadv = '" & Adversaire & "' AND partie.equipe = '" & Equipe.Id & "';"
            command = New MySqlCommand(SQL, myc)
            reader = command.ExecuteReader()
            While reader.Read()
                idPartie = reader.GetInt32("idPartie")
            End While
            reader.Close()

            'Ajout de l'alignement
            For Each player As Joueur In Alignement
                SQL = "INSERT INTO `chalkboard`.`chalkboard_alignement` (`joueur`, `partie`, `joueurNo`) VALUES ('" & _
                player.Passport & "','" & idPartie & "','" & player.No & "');"
                command = New MySqlCommand(SQL, myc)
                command.ExecuteNonQuery()
            Next

            'Ajout des actions
            For Each act In Actions
                temps = FormatTime(act.Temps)
                idAction = TrouverIdAction(act.Nom)
                Select Case idAction
                    Case 1, 2, 4, 7, 8, 16
                        SQL = "INSERT INTO `chalkboard`.`chalkboard_event` (`joueur`, `action`, `partie`, `temps`, `debutx`, `debuty`) VALUES ('" & _
                            act.Joueur.Passport & "', '" & idAction & "', '" & idPartie & "', '" & temps & "', '" & act.Depart.X & "', '" & act.Depart.Y & "');"
                    Case 5, 13, 14, 15
                        SQL = "INSERT INTO `chalkboard`.`chalkboard_event` (`joueur`, `action`, `partie`, `temps`, `debutx`, `debuty`, `finx`, `finy`) VALUES ('" & _
                         act.Joueur.Passport & "', '" & idAction & "', '" & idPartie & "', '" & temps & "', '" & act.Depart.X & "', '" & act.Depart.Y & "', '" & act.Fin.X & "', '" & act.Fin.Y & "');"
                    Case 3, 6, 9, 10, 11, 12
                        SQL = "INSERT INTO `chalkboard`.`chalkboard_event` (`joueur`, `action`, `partie`, `temps`, `debutx`, `debuty`, `finx`, `finy`, `cible`) VALUES ('" & _
                            act.Joueur.Passport & "', '" & idAction & "', '" & idPartie & "', '" & temps & "', '" & act.Depart.X & "', '" & act.Depart.Y & "', '" & act.Fin.X & "', '" & act.Fin.Y & "', '" & act.Cible.Passport & "');"
                End Select
                command = New MySqlCommand(SQL, myc)
                command.ExecuteNonQuery()
            Next

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            myc.Close()
            myc.Dispose()
        End Try
    End Sub

    Private Function TrouverIdAction(actionNom As String) As Integer
        Select Case actionNom
            Case "Ballon récupéré"
                Return 1
            Case "Ballon conquis"
                Return 2
            Case "Remise en jeu"
                Return 3
            Case "Neutre"
                Return 4
            Case "Dégagement"
                Return 5
            Case "Perte sur passe"
                Return 6
            Case "Perte technique"
                Return 7
            Case "Perte sur duel"
                Return 8
            Case "Perte sur remise en jeu"
                Return 9
            Case "Passe"
                Return 10
            Case "Passe clé"
                Return 11
            Case "Passe décisive"
                Return 12
            Case "Tir non-cadré"
                Return 13
            Case "Tir cadré"
                Return 14
            Case "But"
                Return 15
            Case "Ballon reçu"
                Return 16
            Case Else
                Return -1
        End Select
    End Function

    Private Function FormatTime(temps As Double) As String
        Dim retour As String
        temps = Math.Floor(temps)
        If temps > 3600 Then
            retour = "01:"
            retour += Math.Floor((temps - 3600) / 60).ToString("00") & ":"
            retour += (temps Mod 60).ToString("00")
        Else
            retour = "00:"
            If temps < 360 Then
                retour += "0"
            End If
            retour += Math.Floor(temps / 60).ToString("00") & ":"
            retour += (temps Mod 60).ToString("00")
        End If
        Return retour
    End Function
End Class
