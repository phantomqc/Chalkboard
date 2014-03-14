<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModifEquipe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbJoueur = New System.Windows.Forms.GroupBox()
        Me.btnSuppJoueur = New System.Windows.Forms.Button()
        Me.lbJoueur = New System.Windows.Forms.ListBox()
        Me.txtNoJoueur = New System.Windows.Forms.TextBox()
        Me.lblNoJoueur = New System.Windows.Forms.Label()
        Me.btnAjoutJoueur = New System.Windows.Forms.Button()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        Me.txtNomJoueur = New System.Windows.Forms.TextBox()
        Me.gbEquipe = New System.Windows.Forms.GroupBox()
        Me.btnAjoutEq = New System.Windows.Forms.Button()
        Me.cmbSexe = New System.Windows.Forms.ComboBox()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.cmbEquipe = New System.Windows.Forms.ComboBox()
        Me.gbJoueur.SuspendLayout()
        Me.gbEquipe.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(14, 482)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Annuler"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(200, 482)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(179, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Sauvegarder les changements"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbJoueur
        '
        Me.gbJoueur.Controls.Add(Me.btnSuppJoueur)
        Me.gbJoueur.Controls.Add(Me.lbJoueur)
        Me.gbJoueur.Controls.Add(Me.txtNoJoueur)
        Me.gbJoueur.Controls.Add(Me.lblNoJoueur)
        Me.gbJoueur.Controls.Add(Me.btnAjoutJoueur)
        Me.gbJoueur.Controls.Add(Me.lblNomJoueur)
        Me.gbJoueur.Controls.Add(Me.txtNomJoueur)
        Me.gbJoueur.Location = New System.Drawing.Point(12, 206)
        Me.gbJoueur.Name = "gbJoueur"
        Me.gbJoueur.Size = New System.Drawing.Size(381, 262)
        Me.gbJoueur.TabIndex = 11
        Me.gbJoueur.TabStop = False
        Me.gbJoueur.Text = "Information sur les joueurs"
        '
        'btnSuppJoueur
        '
        Me.btnSuppJoueur.Location = New System.Drawing.Point(248, 222)
        Me.btnSuppJoueur.Name = "btnSuppJoueur"
        Me.btnSuppJoueur.Size = New System.Drawing.Size(119, 23)
        Me.btnSuppJoueur.TabIndex = 11
        Me.btnSuppJoueur.Text = "Supprimer le joueur"
        Me.btnSuppJoueur.UseVisualStyleBackColor = True
        '
        'lbJoueur
        '
        Me.lbJoueur.FormattingEnabled = True
        Me.lbJoueur.Location = New System.Drawing.Point(42, 105)
        Me.lbJoueur.Name = "lbJoueur"
        Me.lbJoueur.Size = New System.Drawing.Size(286, 108)
        Me.lbJoueur.TabIndex = 10
        '
        'txtNoJoueur
        '
        Me.txtNoJoueur.Location = New System.Drawing.Point(101, 68)
        Me.txtNoJoueur.Name = "txtNoJoueur"
        Me.txtNoJoueur.Size = New System.Drawing.Size(48, 20)
        Me.txtNoJoueur.TabIndex = 9
        '
        'lblNoJoueur
        '
        Me.lblNoJoueur.AutoSize = True
        Me.lblNoJoueur.Location = New System.Drawing.Point(46, 71)
        Me.lblNoJoueur.Name = "lblNoJoueur"
        Me.lblNoJoueur.Size = New System.Drawing.Size(27, 13)
        Me.lblNoJoueur.TabIndex = 8
        Me.lblNoJoueur.Text = "No :"
        '
        'btnAjoutJoueur
        '
        Me.btnAjoutJoueur.Location = New System.Drawing.Point(248, 66)
        Me.btnAjoutJoueur.Name = "btnAjoutJoueur"
        Me.btnAjoutJoueur.Size = New System.Drawing.Size(119, 23)
        Me.btnAjoutJoueur.TabIndex = 7
        Me.btnAjoutJoueur.Text = "Ajouter le joueur"
        Me.btnAjoutJoueur.UseVisualStyleBackColor = True
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.Location = New System.Drawing.Point(39, 38)
        Me.lblNomJoueur.Name = "lblNomJoueur"
        Me.lblNomJoueur.Size = New System.Drawing.Size(35, 13)
        Me.lblNomJoueur.TabIndex = 2
        Me.lblNomJoueur.Text = "Nom :"
        '
        'txtNomJoueur
        '
        Me.txtNomJoueur.Location = New System.Drawing.Point(101, 35)
        Me.txtNomJoueur.Name = "txtNomJoueur"
        Me.txtNomJoueur.Size = New System.Drawing.Size(157, 20)
        Me.txtNomJoueur.TabIndex = 1
        '
        'gbEquipe
        '
        Me.gbEquipe.Controls.Add(Me.btnAjoutEq)
        Me.gbEquipe.Controls.Add(Me.cmbSexe)
        Me.gbEquipe.Controls.Add(Me.lblSexe)
        Me.gbEquipe.Controls.Add(Me.lblCat)
        Me.gbEquipe.Controls.Add(Me.cmbCat)
        Me.gbEquipe.Controls.Add(Me.lblNom)
        Me.gbEquipe.Controls.Add(Me.txtNom)
        Me.gbEquipe.Location = New System.Drawing.Point(12, 39)
        Me.gbEquipe.Name = "gbEquipe"
        Me.gbEquipe.Size = New System.Drawing.Size(381, 150)
        Me.gbEquipe.TabIndex = 10
        Me.gbEquipe.TabStop = False
        Me.gbEquipe.Text = "Information sur l'équipe"
        '
        'btnAjoutEq
        '
        Me.btnAjoutEq.Location = New System.Drawing.Point(269, 116)
        Me.btnAjoutEq.Name = "btnAjoutEq"
        Me.btnAjoutEq.Size = New System.Drawing.Size(98, 23)
        Me.btnAjoutEq.TabIndex = 6
        Me.btnAjoutEq.Text = "Modifier l'équipe"
        Me.btnAjoutEq.UseVisualStyleBackColor = True
        '
        'cmbSexe
        '
        Me.cmbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexe.FormattingEnabled = True
        Me.cmbSexe.Items.AddRange(New Object() {"F", "M"})
        Me.cmbSexe.Location = New System.Drawing.Point(104, 99)
        Me.cmbSexe.Name = "cmbSexe"
        Me.cmbSexe.Size = New System.Drawing.Size(121, 21)
        Me.cmbSexe.TabIndex = 5
        '
        'lblSexe
        '
        Me.lblSexe.AutoSize = True
        Me.lblSexe.Location = New System.Drawing.Point(40, 102)
        Me.lblSexe.Name = "lblSexe"
        Me.lblSexe.Size = New System.Drawing.Size(37, 13)
        Me.lblSexe.TabIndex = 4
        Me.lblSexe.Text = "Sexe :"
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(19, 63)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(58, 13)
        Me.lblCat.TabIndex = 3
        Me.lblCat.Text = "Catégorie :"
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Items.AddRange(New Object() {"U12", "U13", "U14", "U15", "U16", "U17", "U18", "U21", "SEN"})
        Me.cmbCat.Location = New System.Drawing.Point(104, 60)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(121, 21)
        Me.cmbCat.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(42, 28)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(35, 13)
        Me.lblNom.TabIndex = 1
        Me.lblNom.Text = "Nom :"
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(104, 28)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(157, 20)
        Me.txtNom.TabIndex = 0
        '
        'cmbEquipe
        '
        Me.cmbEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEquipe.FormattingEnabled = True
        Me.cmbEquipe.Location = New System.Drawing.Point(82, 12)
        Me.cmbEquipe.Name = "cmbEquipe"
        Me.cmbEquipe.Size = New System.Drawing.Size(214, 21)
        Me.cmbEquipe.TabIndex = 8
        '
        'frmModifEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 585)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbJoueur)
        Me.Controls.Add(Me.gbEquipe)
        Me.Controls.Add(Me.cmbEquipe)
        Me.Name = "frmModifEquipe"
        Me.Text = "Modifier une équipe"
        Me.gbJoueur.ResumeLayout(False)
        Me.gbJoueur.PerformLayout()
        Me.gbEquipe.ResumeLayout(False)
        Me.gbEquipe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbJoueur As System.Windows.Forms.GroupBox
    Friend WithEvents btnSuppJoueur As System.Windows.Forms.Button
    Friend WithEvents lbJoueur As System.Windows.Forms.ListBox
    Friend WithEvents txtNoJoueur As System.Windows.Forms.TextBox
    Friend WithEvents lblNoJoueur As System.Windows.Forms.Label
    Friend WithEvents btnAjoutJoueur As System.Windows.Forms.Button
    Friend WithEvents lblNomJoueur As System.Windows.Forms.Label
    Friend WithEvents txtNomJoueur As System.Windows.Forms.TextBox
    Friend WithEvents gbEquipe As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjoutEq As System.Windows.Forms.Button
    Friend WithEvents cmbSexe As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexe As System.Windows.Forms.Label
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents cmbEquipe As System.Windows.Forms.ComboBox
End Class
