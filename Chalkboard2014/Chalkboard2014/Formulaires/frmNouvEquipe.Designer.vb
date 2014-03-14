<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNouvEquipe
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbJoueur = New System.Windows.Forms.GroupBox()
        Me.txtNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRetirer = New System.Windows.Forms.Button()
        Me.lbJoueur = New System.Windows.Forms.ListBox()
        Me.txtPassport = New System.Windows.Forms.TextBox()
        Me.lblNoJoueur = New System.Windows.Forms.Label()
        Me.btnAjoutJoueur = New System.Windows.Forms.Button()
        Me.lblNomJoueur = New System.Windows.Forms.Label()
        Me.txtNomJoueur = New System.Windows.Forms.TextBox()
        Me.gbEquipe = New System.Windows.Forms.GroupBox()
        Me.cmbCat = New System.Windows.Forms.ComboBox()
        Me.lblCat = New System.Windows.Forms.Label()
        Me.btnAjoutEq = New System.Windows.Forms.Button()
        Me.cmbSexe = New System.Windows.Forms.ComboBox()
        Me.lblSexe = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.cmbAge = New System.Windows.Forms.ComboBox()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.gbJoueur.SuspendLayout()
        Me.gbEquipe.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(325, 635)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(139, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Sauvegarder l'équipe"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'gbJoueur
        '
        Me.gbJoueur.Controls.Add(Me.txtNo)
        Me.gbJoueur.Controls.Add(Me.Label1)
        Me.gbJoueur.Controls.Add(Me.btnRetirer)
        Me.gbJoueur.Controls.Add(Me.lbJoueur)
        Me.gbJoueur.Controls.Add(Me.txtPassport)
        Me.gbJoueur.Controls.Add(Me.lblNoJoueur)
        Me.gbJoueur.Controls.Add(Me.btnAjoutJoueur)
        Me.gbJoueur.Controls.Add(Me.lblNomJoueur)
        Me.gbJoueur.Controls.Add(Me.txtNomJoueur)
        Me.gbJoueur.Location = New System.Drawing.Point(24, 228)
        Me.gbJoueur.Name = "gbJoueur"
        Me.gbJoueur.Size = New System.Drawing.Size(377, 388)
        Me.gbJoueur.TabIndex = 4
        Me.gbJoueur.TabStop = False
        Me.gbJoueur.Text = "Information sur les joueurs"
        '
        'txtNo
        '
        Me.txtNo.Location = New System.Drawing.Point(101, 90)
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Size = New System.Drawing.Size(84, 20)
        Me.txtNo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "No :"
        '
        'btnRetirer
        '
        Me.btnRetirer.Location = New System.Drawing.Point(266, 225)
        Me.btnRetirer.Name = "btnRetirer"
        Me.btnRetirer.Size = New System.Drawing.Size(98, 23)
        Me.btnRetirer.TabIndex = 11
        Me.btnRetirer.Text = "Retirer le joueur"
        Me.btnRetirer.UseVisualStyleBackColor = True
        '
        'lbJoueur
        '
        Me.lbJoueur.FormattingEnabled = True
        Me.lbJoueur.Location = New System.Drawing.Point(27, 138)
        Me.lbJoueur.Name = "lbJoueur"
        Me.lbJoueur.Size = New System.Drawing.Size(230, 212)
        Me.lbJoueur.TabIndex = 10
        '
        'txtPassport
        '
        Me.txtPassport.Location = New System.Drawing.Point(101, 61)
        Me.txtPassport.Name = "txtPassport"
        Me.txtPassport.Size = New System.Drawing.Size(84, 20)
        Me.txtPassport.TabIndex = 2
        '
        'lblNoJoueur
        '
        Me.lblNoJoueur.AutoSize = True
        Me.lblNoJoueur.Location = New System.Drawing.Point(24, 64)
        Me.lblNoJoueur.Name = "lblNoJoueur"
        Me.lblNoJoueur.Size = New System.Drawing.Size(54, 13)
        Me.lblNoJoueur.TabIndex = 8
        Me.lblNoJoueur.Text = "Passport :"
        '
        'btnAjoutJoueur
        '
        Me.btnAjoutJoueur.Location = New System.Drawing.Point(266, 94)
        Me.btnAjoutJoueur.Name = "btnAjoutJoueur"
        Me.btnAjoutJoueur.Size = New System.Drawing.Size(98, 23)
        Me.btnAjoutJoueur.TabIndex = 3
        Me.btnAjoutJoueur.Text = "Ajouter le joueur"
        Me.btnAjoutJoueur.UseVisualStyleBackColor = True
        '
        'lblNomJoueur
        '
        Me.lblNomJoueur.AutoSize = True
        Me.lblNomJoueur.Location = New System.Drawing.Point(43, 38)
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
        Me.gbEquipe.Controls.Add(Me.cmbCat)
        Me.gbEquipe.Controls.Add(Me.lblCat)
        Me.gbEquipe.Controls.Add(Me.btnAjoutEq)
        Me.gbEquipe.Controls.Add(Me.cmbSexe)
        Me.gbEquipe.Controls.Add(Me.lblSexe)
        Me.gbEquipe.Controls.Add(Me.lblAge)
        Me.gbEquipe.Controls.Add(Me.cmbAge)
        Me.gbEquipe.Controls.Add(Me.lblNom)
        Me.gbEquipe.Controls.Add(Me.txtNom)
        Me.gbEquipe.Location = New System.Drawing.Point(20, 16)
        Me.gbEquipe.Name = "gbEquipe"
        Me.gbEquipe.Size = New System.Drawing.Size(381, 197)
        Me.gbEquipe.TabIndex = 3
        Me.gbEquipe.TabStop = False
        Me.gbEquipe.Text = "Information sur l'équipe"
        '
        'cmbCat
        '
        Me.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCat.FormattingEnabled = True
        Me.cmbCat.Items.AddRange(New Object() {"A", "AA", "AAA"})
        Me.cmbCat.Location = New System.Drawing.Point(104, 135)
        Me.cmbCat.Name = "cmbCat"
        Me.cmbCat.Size = New System.Drawing.Size(121, 21)
        Me.cmbCat.TabIndex = 8
        '
        'lblCat
        '
        Me.lblCat.AutoSize = True
        Me.lblCat.Location = New System.Drawing.Point(24, 138)
        Me.lblCat.Name = "lblCat"
        Me.lblCat.Size = New System.Drawing.Size(58, 13)
        Me.lblCat.TabIndex = 7
        Me.lblCat.Text = "Catégorie :"
        '
        'btnAjoutEq
        '
        Me.btnAjoutEq.Location = New System.Drawing.Point(270, 166)
        Me.btnAjoutEq.Name = "btnAjoutEq"
        Me.btnAjoutEq.Size = New System.Drawing.Size(98, 23)
        Me.btnAjoutEq.TabIndex = 6
        Me.btnAjoutEq.Text = "Ajouter l'équipe"
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
        Me.lblSexe.Location = New System.Drawing.Point(45, 102)
        Me.lblSexe.Name = "lblSexe"
        Me.lblSexe.Size = New System.Drawing.Size(37, 13)
        Me.lblSexe.TabIndex = 4
        Me.lblSexe.Text = "Sexe :"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(50, 63)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(32, 13)
        Me.lblAge.TabIndex = 3
        Me.lblAge.Text = "Age :"
        '
        'cmbAge
        '
        Me.cmbAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAge.FormattingEnabled = True
        Me.cmbAge.Items.AddRange(New Object() {"U12", "U13", "U14", "U15", "U16", "U17", "U18", "U21", "SEN"})
        Me.cmbAge.Location = New System.Drawing.Point(104, 60)
        Me.cmbAge.Name = "cmbAge"
        Me.cmbAge.Size = New System.Drawing.Size(121, 21)
        Me.cmbAge.TabIndex = 2
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Location = New System.Drawing.Point(47, 28)
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
        'frmNouvEquipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 668)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbJoueur)
        Me.Controls.Add(Me.gbEquipe)
        Me.Name = "frmNouvEquipe"
        Me.Text = "Ajout d'une équipe"
        Me.gbJoueur.ResumeLayout(False)
        Me.gbJoueur.PerformLayout()
        Me.gbEquipe.ResumeLayout(False)
        Me.gbEquipe.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbJoueur As System.Windows.Forms.GroupBox
    Friend WithEvents lbJoueur As System.Windows.Forms.ListBox
    Friend WithEvents txtPassport As System.Windows.Forms.TextBox
    Friend WithEvents lblNoJoueur As System.Windows.Forms.Label
    Friend WithEvents btnAjoutJoueur As System.Windows.Forms.Button
    Friend WithEvents lblNomJoueur As System.Windows.Forms.Label
    Friend WithEvents txtNomJoueur As System.Windows.Forms.TextBox
    Friend WithEvents gbEquipe As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjoutEq As System.Windows.Forms.Button
    Friend WithEvents cmbSexe As System.Windows.Forms.ComboBox
    Friend WithEvents lblSexe As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents cmbAge As System.Windows.Forms.ComboBox
    Friend WithEvents lblNom As System.Windows.Forms.Label
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents cmbCat As System.Windows.Forms.ComboBox
    Friend WithEvents lblCat As System.Windows.Forms.Label
    Friend WithEvents btnRetirer As System.Windows.Forms.Button
    Friend WithEvents txtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
