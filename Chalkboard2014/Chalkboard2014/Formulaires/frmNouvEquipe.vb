Imports MySql.Data.MySqlClient
Public Class frmNouvEquipe
    Private Sub frmNouvEquipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbJoueur.Enabled = False
        btnSave.Enabled = False
    End Sub

    Private Sub btnAjoutEq_Click(sender As Object, e As EventArgs) Handles btnAjoutEq.Click
        If txtNom.Text = String.Empty Then
            MessageBox.Show("Veuillez entrer un nom d'équipe")
        ElseIf cmbAge.SelectedItem = String.Empty Then
            MessageBox.Show("Veuillez sélectionner un age")
        ElseIf cmbSexe.SelectedItem = String.Empty Then
            MessageBox.Show("Veuillez sélectionner un sexe")
        ElseIf cmbCat.SelectedItem = String.Empty Then
            MessageBox.Show("Veuillez sélectionner une catégorie")
        Else
                gbJoueur.Enabled = True
                btnSave.Enabled = True
                gbEquipe.Enabled = False
        End If
    End Sub

    Private Sub btnAjoutJoueur_Click(sender As Object, e As EventArgs) Handles btnAjoutJoueur.Click
        Dim passport As Integer
        Dim no As Integer
        Dim existe As Boolean = True

        If txtNomJoueur.Text = String.Empty Then
            MessageBox.Show("Veuillez entrer un nom de joueur")
        ElseIf Integer.TryParse(txtPassport.Text, passport) AndAlso passport.ToString.Length = 6 Then
            no = 0
            Integer.TryParse(txtNo.Text, no)
            lbJoueur.Items.Add(New Joueur(CInt(txtPassport.Text), txtNomJoueur.Text, no))
            txtPassport.Text = String.Empty
            txtNomJoueur.Text = String.Empty
            txtNo.Text = String.Empty
            txtNomJoueur.Focus()
        Else
            MessageBox.Show("Veuillez entrer un numéro de passport valide.")
        End If
    End Sub

    Private Sub btnRetirer_Click(sender As Object, e As EventArgs) Handles btnRetirer.Click
        If lbJoueur.SelectedIndex <> -1 Then
            lbJoueur.Items.RemoveAt(lbJoueur.SelectedIndex)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim myc As New MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim idEq As Integer
        Dim SQL As String
        SQL = "SELECT idequipe FROM chalkboard.chalkboard_equipe WHERE equipenom='" & txtNom.Text & "' AND equipeage='" & cmbAge.SelectedItem & "` AND equipesexe=`" & cmbSexe.SelectedItem & "' AND equipecat=`" & cmbCat.SelectedItem & "';"

        Try
            myc.ConnectionString = "server=localhost; user id=root; password=root; database=chalkboard"
            myc.Open()

            'Ajout de l'équipe
            SQL = "INSERT INTO `chalkboard`.`chalkboard_equipe` (`equipenom`, `equipeage`, `equipesexe`, `equipecat`) VALUES ('" & _
                txtNom.Text & "','" & cmbAge.SelectedItem & "','" & cmbSexe.SelectedItem & "','" & cmbCat.SelectedItem & "');"
            command = New MySqlCommand(SQL, myc)
            command.ExecuteNonQuery()

            'Obtention de l'id de l'équipe
            SQL = "SELECT idequipe FROM chalkboard.chalkboard_equipe WHERE equipenom='" & txtNom.Text & "' AND equipeage='" & cmbAge.SelectedItem & "' AND equipesexe='" & cmbSexe.SelectedItem & "' AND equipecat='" & cmbCat.SelectedItem & "';"
            command = New MySqlCommand(SQL, myc)
            reader = command.ExecuteReader()
            While reader.Read()
                idEq = reader.GetInt32("idequipe")
            End While
            reader.Close()

            'Ajout des joueurs
            For Each player As Joueur In lbJoueur.Items
                SQL = "INSERT INTO `chalkboard`.`chalkboard_joueur` (`idjoueur`, `joueurnom`, `equipe`, `joueurno`) VALUES ('" & _
                player.Passport & "','" & player.NomJoueur & "','" & idEq.ToString & "','" & player.No & "');"
                command = New MySqlCommand(SQL, myc)
                command.ExecuteNonQuery()
            Next
        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            myc.Close()
            myc.Dispose()
            Me.Close()
        End Try
    End Sub



End Class