Imports MySql.Data.MySqlClient
Structure JoueurUITerrain
    Public _rb As RadioButton
    Public _txtnom As TextBox
    Public _txtNo As TextBox
End Structure
Public Class frmPrincipal
    Private _partie As Partie
    Private _depart As Point
    Private _fin As Point
    Private _video As frmVideo
    Private _blnArrow As Boolean
    Private _passe As Boolean
    Private _actionTempo As Action
    Private _cible As Joueur

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TerminerToolStripMenuItem.Enabled = False
    End Sub

#Region "Toolstripmenu"
    Private Sub CréerUneÉquipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUneÉquipeToolStripMenuItem.Click
        Dim frmNouvEq As frmNouvEquipe = New frmNouvEquipe()
        frmNouvEq.ShowDialog()
    End Sub

    Private Sub ModifierUneÉquipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierUneÉquipeToolStripMenuItem.Click
        Dim frmModifEq As frmModifEquipe = New frmModifEquipe()
        frmModifEq.Show()
    End Sub

    Private Sub AjouterUnePartieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterUnePartieToolStripMenuItem.Click
        Dim frmNp As frmAjoutPartie = New frmAjoutPartie()
        If frmNp.ShowDialog() = Windows.Forms.DialogResult.OK Then
            _partie = frmNp.Partie
            For Each player In _partie.Alignement
                Dim context As New ToolStripMenuItem
                context.Text = player.ToString()
                cmsPrincipal.Items.Add(context)
                CreerContext(cmsPrincipal.Items(cmsPrincipal.Items.Count - 1))
            Next

            Dim ofd As OpenFileDialog = New OpenFileDialog()
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Try
                    _video = New frmVideo(ofd.FileName)
                    _video.Show()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
            TerminerToolStripMenuItem.Enabled = True
            CréerUneÉquipeToolStripMenuItem.Enabled = False
            AjouterUnePartieToolStripMenuItem.Enabled = False
            ModifierUneÉquipeToolStripMenuItem.Enabled = False

            InitAlignement()

        End If
    End Sub

    Private Sub InitAlignement()
        Dim jui As JoueurUITerrain
        Dim indice = 0
        For Each pl In _partie.Alignement
            jui._rb = New RadioButton()
            jui._rb.Name = "cb" & indice.ToString
            jui._rb.Size = New Size(20, 20)
            jui._rb.Location = New Point(10, (indice + 1) * 22)
            jui._rb.Checked = False
            jui._rb.TabIndex = indice
            pnlBanc.Controls.Add(jui._rb)

            jui._txtnom = New TextBox()
            jui._txtnom.Name = "txtNom" & indice.ToString
            jui._txtnom.Size = New Size(100, 20)
            jui._txtnom.Location = New Point(34, (indice + 1) * 22)
            jui._txtnom.Text = pl.NomJoueur
            jui._txtnom.Enabled = False
            pnlBanc.Controls.Add(jui._txtnom)

            jui._txtNo = New TextBox()
            jui._txtNo.Name = "txtNo" & indice.ToString
            jui._txtNo.Size = New Size(45, 20)
            jui._txtNo.Location = New Point(138, (indice + 1) * 22)
            jui._txtNo.Text = pl.No
            jui._txtNo.Enabled = False
            pnlBanc.Controls.Add(jui._txtNo)

            indice += 1
        Next
    End Sub

    Private Sub btnAlign_Click(sender As Object, e As EventArgs) Handles btnAlign.Click
        Dim rBox As RadioButton
        Dim jEntre As Joueur
        Dim jSort As Joueur
        For Each ctrl In pnlBanc.Controls
            If TypeOf (ctrl) Is RadioButton Then
                rBox = CType(ctrl, RadioButton)
                If rBox.Checked Then
                    jEntre = _partie.TrouverJoueur(CInt(CType(pnlBanc.Controls("txtNo" & rBox.Name.Substring(2)), TextBox).Text))
                End If
            End If
        Next
        For Each ctrl In pnlTerrain.Controls
            If TypeOf (ctrl) Is RadioButton Then
                rBox = CType(ctrl, RadioButton)
                If rBox.Checked Then
                    jSort = _partie.TrouverJoueur(CInt(CType(pnlTerrain.Controls("txtNo" & rBox.Name.Substring(2)), TextBox).Text))
                End If
            End If
        Next
        If jSort Is Nothing Then
            'remove ui
            'add le shift dans partie
        End If
    End Sub

    Private Sub AnnulToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnnulToolStripMenuItem.Click
        If _partie.Actions.Count > 0 Then
            _partie.Actions.RemoveAt(_partie.Actions.Count - 1)
            lbLog.Items.RemoveAt(lbLog.Items.Count - 1)
        End If

    End Sub

    Private Sub TerminerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminerToolStripMenuItem.Click
        _partie.SaveToSQL()
        _partie = Nothing
        TerminerToolStripMenuItem.Enabled = False
        CréerUneÉquipeToolStripMenuItem.Enabled = True
        AjouterUnePartieToolStripMenuItem.Enabled = True
        ModifierUneÉquipeToolStripMenuItem.Enabled = True
        'lbLog.Items.Clear()
    End Sub
#End Region

#Region "Menu Contextuel"

    Private Sub CreerContext(ByVal context As ToolStripMenuItem)
        Dim acquisition As New ToolStripMenuItem
        Dim separation As New ToolStripMenuItem
        Dim pertes As New ToolStripMenuItem
        Dim actionoff As New ToolStripMenuItem
        Dim passeOff As New ToolStripMenuItem
        Dim passeKey As New ToolStripMenuItem
        Dim passeDec As New ToolStripMenuItem
        Dim pertesPasse As New ToolStripMenuItem
        Dim remiseJeu As New ToolStripMenuItem
        Dim pertesRemiseJeu As New ToolStripMenuItem
        acquisition.Text = "Acquistion"
        separation.Text = "Séparation"
        pertes.Text = "Pertes"
        actionoff.Text = "Actions offensives"
        passeOff.Text = "Passe"
        passeKey.Text = "Passe clé"
        passeDec.Text = "Passe décisive"
        pertesPasse.Text = "Perte sur passe"
        remiseJeu.Text = "Remise en jeu"
        pertesRemiseJeu.Text = "Perte sur remise en jeu"
        acquisition.DropDownItems.Add("Ballon conquis", Nothing, New System.EventHandler(AddressOf actionSimple_OnClick))
        acquisition.DropDownItems.Add("Ballon récupéré", Nothing, New System.EventHandler(AddressOf actionSimple_OnClick))
        acquisition.DropDownItems.Add(remiseJeu)
        For Each player In _partie.Alignement
            remiseJeu.DropDownItems.Add(player.ToString, Nothing, New System.EventHandler(AddressOf actionRemiseJeu_OnClick))
        Next
        pertes.DropDownItems.Add(pertesPasse)
        For Each player In _partie.Alignement
            pertesPasse.DropDownItems.Add(player.ToString, Nothing, New System.EventHandler(AddressOf actionPasse_OnClick))
        Next
        pertes.DropDownItems.Add("Perte sur duel", Nothing, New System.EventHandler(AddressOf actionPerteDuelTech_OnClick))
        pertes.DropDownItems.Add("Perte technique", Nothing, New System.EventHandler(AddressOf actionPerteDuelTech_OnClick))
        pertes.DropDownItems.Add(pertesRemiseJeu)
        For Each player In _partie.Alignement
            pertesRemiseJeu.DropDownItems.Add(player.ToString, Nothing, New System.EventHandler(AddressOf actionPasse_OnClick))
        Next
        actionoff.DropDownItems.Add(passeOff)
        For Each player In _partie.Alignement
            passeOff.DropDownItems.Add(player.ToString, Nothing, New System.EventHandler(AddressOf actionPasse_OnClick))
        Next
        actionoff.DropDownItems.Add(passeKey)
        For Each player In _partie.Alignement
            passeKey.DropDownItems.Add(player.ToString, Nothing, New System.EventHandler(AddressOf actionPasse_OnClick))
        Next
        actionoff.DropDownItems.Add(passeDec)
        For Each player In _partie.Alignement
            passeDec.DropDownItems.Add(player.ToString, Nothing, New System.EventHandler(AddressOf actionPasse_OnClick))
        Next
        actionoff.DropDownItems.Add("Tir non-cadré", Nothing, New System.EventHandler(AddressOf action_OnClick))
        actionoff.DropDownItems.Add("Tir cadré", Nothing, New System.EventHandler(AddressOf action_OnClick))
        actionoff.DropDownItems.Add("But", Nothing, New System.EventHandler(AddressOf action_OnClick))
        separation.DropDownItems.Add(pertes)
        separation.DropDownItems.Add("Neutre", Nothing, New System.EventHandler(AddressOf actionSimple_OnClick))
        separation.DropDownItems.Add("Dégagement", Nothing, New System.EventHandler(AddressOf actionDeg_OnClick))
        separation.DropDownItems.Add(actionoff)
        context.DropDownItems.Add(acquisition)
        context.DropDownItems.Add(separation)
    End Sub

    Private Sub action_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim maker As Joueur = TrouverJoueur(CType(sender, ToolStripMenuItem).OwnerItem.OwnerItem.OwnerItem.Text)
        _actionTempo = New Action(sender.ToString, _video.Temps, maker, _depart)
        _blnArrow = True
    End Sub

    Private Sub actionDeg_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim maker As Joueur = TrouverJoueur(CType(sender, ToolStripMenuItem).OwnerItem.OwnerItem.Text)
        _actionTempo = New Action(sender.ToString, _video.Temps, maker, _depart)
        _blnArrow = True
    End Sub

    Private Sub actionRemiseJeu_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim maker As Joueur = TrouverJoueur(CType(sender, ToolStripMenuItem).OwnerItem.OwnerItem.OwnerItem.Text)
        _cible = TrouverJoueur(sender.ToString())
        _actionTempo = New Action(CType(sender, ToolStripMenuItem).OwnerItem.Text, _video.Temps, maker, _depart)
        _blnArrow = True
        _passe = True
    End Sub
    Private Sub actionPasse_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim maker As Joueur = TrouverJoueur(CType(sender, ToolStripMenuItem).OwnerItem.OwnerItem.OwnerItem.OwnerItem.Text)
        _cible = TrouverJoueur(sender.ToString())
        _actionTempo = New Action(CType(sender, ToolStripMenuItem).OwnerItem.Text, _video.Temps, maker, _depart)
        _blnArrow = True
        _passe = True
    End Sub

    Private Sub actionSimple_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim maker As Joueur = TrouverJoueur(CType(sender, ToolStripMenuItem).OwnerItem.OwnerItem.Text)
        If cbInvert.Checked Then
            _depart.X = pbField.Size.Width - _depart.X
            _depart.Y = pbField.Size.Height - _depart.Y
        End If
        _actionTempo = New Action(sender.ToString, _video.Temps, maker, _depart)
        _partie.Actions.Add(_actionTempo)
        lbLog.Items.Add(_actionTempo)
    End Sub

    Private Sub actionPerteDuelTech_OnClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim maker As Joueur = TrouverJoueur(CType(sender, ToolStripMenuItem).OwnerItem.OwnerItem.OwnerItem.Text)
        If cbInvert.Checked Then
            _depart.X = pbField.Size.Width - _depart.X
            _depart.Y = pbField.Size.Height - _depart.Y
        End If
        _actionTempo = New Action(sender.ToString, _video.Temps, maker, _depart)
        _partie.Actions.Add(_actionTempo)
        lbLog.Items.Add(_actionTempo)
    End Sub

    Private Function TrouverJoueur(ByVal infoJoueur As String) As Joueur
        Dim noJoueur As Integer = CInt(infoJoueur.Split("-")(0).Trim)
        For Each pl In _partie.Alignement
            If pl.No = noJoueur Then Return pl
        Next
        Return Nothing
    End Function

#End Region

#Region "Event Pbox"


    Private Sub pbField_MouseDown(sender As Object, e As MouseEventArgs) Handles pbField.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left AndAlso _blnArrow Then
            _blnArrow = False
            Dim ptFin As Point = e.Location
            If cbInvert.Checked Then
                ptFin.X = pbField.Size.Width - ptFin.X
                ptFin.Y = pbField.Size.Height - ptFin.Y
                _depart.X = pbField.Size.Width - _depart.X
                _depart.Y = pbField.Size.Height - _depart.Y
                _actionTempo.Depart = _depart
            End If

            If _passe Then
                _passe = False
                _actionTempo.Fin = ptFin
                _actionTempo.Cible = _cible
                _partie.Actions.Add(_actionTempo)
                lbLog.Items.Add(_actionTempo)
                If _actionTempo.Nom <> "Perte sur passe" AndAlso _actionTempo.Nom <> "Perte sur remise en jeu" Then
                    _actionTempo = New Action("Ballon reçu", _actionTempo.Temps + 1, _cible, ptFin)
                    _partie.Actions.Add(_actionTempo)
                    lbLog.Items.Add(_actionTempo)
                End If
            Else
                _actionTempo.Fin = ptFin
                _partie.Actions.Add(_actionTempo)
                lbLog.Items.Add(_actionTempo)
            End If
            _blnArrow = False
            pbField.Invalidate()
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            _depart = e.Location
        End If
    End Sub

    Private Sub pbField_Paint(sender As Object, e As PaintEventArgs) Handles pbField.Paint
        Dim g As Graphics = e.Graphics
        Dim p As Pen = New Pen(Brushes.Blue)
        If _blnArrow Then
            p.EndCap = Drawing2D.LineCap.ArrowAnchor
            p.Width = 2
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.DrawLine(p, _depart, _fin)
        End If
    End Sub

    Private Sub pbField_MouseMove(sender As Object, e As MouseEventArgs) Handles pbField.MouseMove
        If _blnArrow Then
            _fin = e.Location
            pbField.Invalidate()
        End If
    End Sub
#End Region


End Class
