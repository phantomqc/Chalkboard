Imports MySql.Data.MySqlClient
Structure JoueurUI
    Public _cb As CheckBox
    Public _txtPass As TextBox
    Public _txtnom As TextBox
    Public _txtNo As TextBox
End Structure

Public Class frmAjoutPartie
    Private _joueurs As List(Of JoueurUI)

    Private _partie As Partie
    Public ReadOnly Property Partie() As Partie
        Get
            Return _partie
        End Get
    End Property


    Private Sub frmAjoutPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCreer.Enabled = False
        InitCmb()
        GroupBox1.Enabled = False
    End Sub

    Private Sub InitCmb()
        Dim myc As New MySqlConnection
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim SQL As String
        Dim eq As Equipe
        SQL = "SELECT idequipe, equipenom, equipeage, equipesexe, equipecat FROM chalkboard.chalkboard_equipe;"

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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If cmbEquipe.SelectedIndex <> -1 Then
            Dim myc As New MySqlConnection
            Dim command As MySqlCommand
            Dim reader As MySqlDataReader
            Dim SQL As String
            Dim jui As JoueurUI
            Dim indice As Integer = 0
            SQL = "SELECT idjoueur, joueurnom, joueurno FROM chalkboard.chalkboard_joueur WHERE equipe = '" & CType(cmbEquipe.SelectedItem, Equipe).Id & "';"

            Try
                myc.ConnectionString = "server=localhost; user id=root; password=root; database=chalkboard"
                myc.Open()
                command = New MySqlCommand(SQL, myc)
                reader = command.ExecuteReader()
                While reader.Read()
                    jui._cb = New CheckBox()
                    jui._cb.Name = "cb" & indice.ToString
                    jui._cb.Size = New Size(20, 20)
                    jui._cb.Location = New Point(10, (indice + 1) * 22)
                    jui._cb.Checked = True
                    jui._cb.TabIndex = indice
                    pnlJoueur.Controls.Add(jui._cb)

                    jui._txtPass = New TextBox()
                    jui._txtPass.Name = "txtPass" & indice.ToString
                    jui._txtPass.Size = New Size(60, 20)
                    jui._txtPass.Location = New Point(42, (indice + 1) * 22)
                    jui._txtPass.Text = reader.GetString("idjoueur")
                    jui._txtPass.Enabled = False
                    pnlJoueur.Controls.Add(jui._txtPass)

                    jui._txtnom = New TextBox()
                    jui._txtnom.Name = "txtNom" & indice.ToString
                    jui._txtnom.Size = New Size(100, 20)
                    jui._txtnom.Location = New Point(109, (indice + 1) * 22)
                    jui._txtnom.Text = reader.GetString("joueurnom")
                    jui._txtnom.Enabled = False
                    pnlJoueur.Controls.Add(jui._txtnom)

                    jui._txtNo = New TextBox()
                    jui._txtNo.Name = "txtNo" & indice.ToString
                    jui._txtNo.Size = New Size(45, 20)
                    jui._txtNo.Location = New Point(216, (indice + 1) * 22)
                    jui._txtNo.Text = reader.GetString("joueurno")
                    pnlJoueur.Controls.Add(jui._txtNo)

                    indice += 1
                End While
                btnCreer.Enabled = True
                GroupBox1.Enabled = True
                btnSelect.Enabled = False
                cmbEquipe.Enabled = False
                reader.Close()
            Catch myerror As MySqlException
                MessageBox.Show("Cannot connect to database: " & myerror.Message)
            Finally
                myc.Close()
                myc.Dispose()
            End Try
        End If
    End Sub

    Private Sub btnCreer_Click(sender As Object, e As EventArgs) Handles btnCreer.Click
        If txtAdv.Text = String.Empty Then
            MessageBox.Show("Veuillez entrer l'adversaire")
        ElseIf ValiderAlignement() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ValiderAlignement() As Boolean
        Dim cbox As CheckBox
        Dim txtPass As TextBox
        Dim txtName As TextBox
        Dim txtNo As TextBox
        _partie = New Partie(CType(cmbEquipe.SelectedItem, Equipe), txtAdv.Text, dtpDatePartie.Value)
        For Each ctrl In pnlJoueur.Controls
            If TypeOf (ctrl) Is CheckBox Then
                cbox = CType(ctrl, CheckBox)
                If cbox.Checked Then
                    txtPass = CType(pnlJoueur.Controls("txtPass" & cbox.Name.Substring(2)), TextBox)
                    txtName = CType(pnlJoueur.Controls("txtNom" & cbox.Name.Substring(2)), TextBox)
                    txtNo = CType(pnlJoueur.Controls("txtNo" & cbox.Name.Substring(2)), TextBox)
                    If txtNo.Text = String.Empty Then
                        MessageBox.Show("Veuillez entrer un numéro pour chaque joueur actif")
                        Return False
                    Else
                        _partie.Alignement.Add(New Joueur(txtPass.Text, txtName.Text, txtNo.Text))
                    End If
                End If
            End If
        Next
        If _partie.Alignement.Count >= 7 Then
            Return True
        Else
            MessageBox.Show("Vous devez avoir un minimum de 7 joueurs actifs")
            Return False
        End If
    End Function
End Class