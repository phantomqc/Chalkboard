Imports MySql.Data.MySqlClient
Public Class frmModifEquipe

    Private Sub frmModifEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbEquipe.Enabled = False
        gbJoueur.Enabled = False
        cmbEquipe.Items.Clear()
        InitCmb()
    End Sub

    Private Sub InitCmb()
        Dim myc As New MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim SQL As String
        Dim eq As Equipe
        SQL = "SELECT idequipe, equipenom, equipeage, equipesexe, equipecat FROM chalkboard.equipe;"

        Try
            myc.ConnectionString = "server=localhost; user id=root; password=root; database=chalkboard"
            myc.Open()
            command = New MySqlCommand(SQL, myc)
            reader = command.ExecuteReader()
            While reader.Read()
                eq = New Equipe
                eq.Id = reader.GetInt32("idequipe")
                eq.NomEquipe = reader.GetString("equipenom")
                eq.Age = reader.GetString("equipeage")
                eq.Categorie = reader.GetString("equipecat")
                eq.Sexe = reader.GetChar("equipesexe")
                cmbEquipe.Items.Add(eq)
            End While
            reader.Close()
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            myc.Close()
            myc.Dispose()
        End Try
    End Sub

    Private Sub cmbEquipe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEquipe.SelectedIndexChanged

    End Sub


End Class