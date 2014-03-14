<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutPartie
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
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.cmbEquipe = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnlJoueur = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDatePartie = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnCreer = New System.Windows.Forms.Button()
        Me.txtAdv = New System.Windows.Forms.TextBox()
        Me.lblAdv = New System.Windows.Forms.Label()
        Me.lblAlig = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.pnlJoueur.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(256, 12)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(145, 23)
        Me.btnSelect.TabIndex = 17
        Me.btnSelect.Text = "Sélectionner l'équipe"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'cmbEquipe
        '
        Me.cmbEquipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEquipe.FormattingEnabled = True
        Me.cmbEquipe.Location = New System.Drawing.Point(12, 12)
        Me.cmbEquipe.Name = "cmbEquipe"
        Me.cmbEquipe.Size = New System.Drawing.Size(214, 21)
        Me.cmbEquipe.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnlJoueur)
        Me.GroupBox1.Controls.Add(Me.dtpDatePartie)
        Me.GroupBox1.Controls.Add(Me.lblDate)
        Me.GroupBox1.Controls.Add(Me.btnCreer)
        Me.GroupBox1.Controls.Add(Me.txtAdv)
        Me.GroupBox1.Controls.Add(Me.lblAdv)
        Me.GroupBox1.Controls.Add(Me.lblAlig)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(673, 400)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information partie"
        '
        'pnlJoueur
        '
        Me.pnlJoueur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlJoueur.Controls.Add(Me.Label4)
        Me.pnlJoueur.Controls.Add(Me.Label3)
        Me.pnlJoueur.Controls.Add(Me.Label1)
        Me.pnlJoueur.Controls.Add(Me.Label2)
        Me.pnlJoueur.Location = New System.Drawing.Point(6, 36)
        Me.pnlJoueur.Name = "pnlJoueur"
        Me.pnlJoueur.Size = New System.Drawing.Size(425, 352)
        Me.pnlJoueur.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Actif"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Passport"
        '
        'dtpDatePartie
        '
        Me.dtpDatePartie.Location = New System.Drawing.Point(459, 143)
        Me.dtpDatePartie.Name = "dtpDatePartie"
        Me.dtpDatePartie.Size = New System.Drawing.Size(200, 20)
        Me.dtpDatePartie.TabIndex = 10
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(516, 109)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(85, 13)
        Me.lblDate.TabIndex = 14
        Me.lblDate.Text = "Date de la partie"
        '
        'btnCreer
        '
        Me.btnCreer.Location = New System.Drawing.Point(550, 365)
        Me.btnCreer.Name = "btnCreer"
        Me.btnCreer.Size = New System.Drawing.Size(75, 23)
        Me.btnCreer.TabIndex = 7
        Me.btnCreer.Text = "Creer"
        Me.btnCreer.UseVisualStyleBackColor = True
        '
        'txtAdv
        '
        Me.txtAdv.Location = New System.Drawing.Point(458, 62)
        Me.txtAdv.Name = "txtAdv"
        Me.txtAdv.Size = New System.Drawing.Size(200, 20)
        Me.txtAdv.TabIndex = 11
        '
        'lblAdv
        '
        Me.lblAdv.AutoSize = True
        Me.lblAdv.Location = New System.Drawing.Point(525, 36)
        Me.lblAdv.Name = "lblAdv"
        Me.lblAdv.Size = New System.Drawing.Size(57, 13)
        Me.lblAdv.TabIndex = 12
        Me.lblAdv.Text = "Adversaire"
        '
        'lblAlig
        '
        Me.lblAlig.AutoSize = True
        Me.lblAlig.Location = New System.Drawing.Point(84, 20)
        Me.lblAlig.Name = "lblAlig"
        Me.lblAlig.Size = New System.Drawing.Size(59, 13)
        Me.lblAlig.TabIndex = 13
        Me.lblAlig.Text = "Alignement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nom"
        '
        'frmAjoutPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 505)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.cmbEquipe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAjoutPartie"
        Me.Text = "frmAjoutPartie"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnlJoueur.ResumeLayout(False)
        Me.pnlJoueur.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents cmbEquipe As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDatePartie As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnCreer As System.Windows.Forms.Button
    Friend WithEvents txtAdv As System.Windows.Forms.TextBox
    Friend WithEvents lblAdv As System.Windows.Forms.Label
    Friend WithEvents lblAlig As System.Windows.Forms.Label
    Friend WithEvents pnlJoueur As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
