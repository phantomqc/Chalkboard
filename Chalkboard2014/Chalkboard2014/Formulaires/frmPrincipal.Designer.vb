<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CréationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterUnePartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréerUneÉquipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierUneÉquipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnnulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefaireLaDernièreActionAnnuléeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbField = New System.Windows.Forms.PictureBox()
        Me.cbInvert = New System.Windows.Forms.CheckBox()
        Me.cmsPrincipal = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.lbLog = New System.Windows.Forms.ListBox()
        Me.gbAlignement = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlBanc = New System.Windows.Forms.Panel()
        Me.pnlTerrain = New System.Windows.Forms.Panel()
        Me.btnAlign = New System.Windows.Forms.Button()
        Me.cbDemie = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbAlignement.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CréationToolStripMenuItem, Me.ÉditionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1014, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CréationToolStripMenuItem
        '
        Me.CréationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterUnePartieToolStripMenuItem, Me.TerminerToolStripMenuItem, Me.CréerUneÉquipeToolStripMenuItem, Me.ModifierUneÉquipeToolStripMenuItem})
        Me.CréationToolStripMenuItem.Name = "CréationToolStripMenuItem"
        Me.CréationToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CréationToolStripMenuItem.Text = "Création"
        '
        'AjouterUnePartieToolStripMenuItem
        '
        Me.AjouterUnePartieToolStripMenuItem.Name = "AjouterUnePartieToolStripMenuItem"
        Me.AjouterUnePartieToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AjouterUnePartieToolStripMenuItem.Text = "Ajouter une partie"
        '
        'TerminerToolStripMenuItem
        '
        Me.TerminerToolStripMenuItem.Name = "TerminerToolStripMenuItem"
        Me.TerminerToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.TerminerToolStripMenuItem.Text = "Terminer la saisie d'une partie"
        '
        'CréerUneÉquipeToolStripMenuItem
        '
        Me.CréerUneÉquipeToolStripMenuItem.Name = "CréerUneÉquipeToolStripMenuItem"
        Me.CréerUneÉquipeToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.CréerUneÉquipeToolStripMenuItem.Text = "Créer une équipe"
        '
        'ModifierUneÉquipeToolStripMenuItem
        '
        Me.ModifierUneÉquipeToolStripMenuItem.Name = "ModifierUneÉquipeToolStripMenuItem"
        Me.ModifierUneÉquipeToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ModifierUneÉquipeToolStripMenuItem.Text = "Modifier une équipe"
        '
        'ÉditionToolStripMenuItem
        '
        Me.ÉditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnnulToolStripMenuItem, Me.RefaireLaDernièreActionAnnuléeToolStripMenuItem})
        Me.ÉditionToolStripMenuItem.Name = "ÉditionToolStripMenuItem"
        Me.ÉditionToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ÉditionToolStripMenuItem.Text = "Édition"
        '
        'AnnulToolStripMenuItem
        '
        Me.AnnulToolStripMenuItem.Name = "AnnulToolStripMenuItem"
        Me.AnnulToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.AnnulToolStripMenuItem.Text = "Annuler la dernière action"
        '
        'RefaireLaDernièreActionAnnuléeToolStripMenuItem
        '
        Me.RefaireLaDernièreActionAnnuléeToolStripMenuItem.Name = "RefaireLaDernièreActionAnnuléeToolStripMenuItem"
        Me.RefaireLaDernièreActionAnnuléeToolStripMenuItem.Size = New System.Drawing.Size(249, 22)
        Me.RefaireLaDernièreActionAnnuléeToolStripMenuItem.Text = "Refaire la dernière action annulée"
        '
        'pbField
        '
        Me.pbField.BackgroundImage = Global.Chalkboard2014.My.Resources.Resources.soccer_field_550_350
        Me.pbField.Location = New System.Drawing.Point(12, 76)
        Me.pbField.Name = "pbField"
        Me.pbField.Size = New System.Drawing.Size(560, 350)
        Me.pbField.TabIndex = 1
        Me.pbField.TabStop = False
        '
        'cbInvert
        '
        Me.cbInvert.AutoSize = True
        Me.cbInvert.Location = New System.Drawing.Point(12, 38)
        Me.cbInvert.Name = "cbInvert"
        Me.cbInvert.Size = New System.Drawing.Size(64, 17)
        Me.cbInvert.TabIndex = 2
        Me.cbInvert.Text = "Inverser"
        Me.cbInvert.UseVisualStyleBackColor = True
        '
        'cmsPrincipal
        '
        Me.cmsPrincipal.Name = "cmsPrincipal"
        Me.cmsPrincipal.Size = New System.Drawing.Size(61, 4)
        '
        'lbLog
        '
        Me.lbLog.FormattingEnabled = True
        Me.lbLog.Location = New System.Drawing.Point(22, 441)
        Me.lbLog.Name = "lbLog"
        Me.lbLog.Size = New System.Drawing.Size(272, 147)
        Me.lbLog.TabIndex = 3
        '
        'gbAlignement
        '
        Me.gbAlignement.Controls.Add(Me.Label2)
        Me.gbAlignement.Controls.Add(Me.Label1)
        Me.gbAlignement.Controls.Add(Me.pnlBanc)
        Me.gbAlignement.Controls.Add(Me.pnlTerrain)
        Me.gbAlignement.Controls.Add(Me.btnAlign)
        Me.gbAlignement.Location = New System.Drawing.Point(597, 76)
        Me.gbAlignement.Name = "gbAlignement"
        Me.gbAlignement.Size = New System.Drawing.Size(389, 443)
        Me.gbAlignement.TabIndex = 4
        Me.gbAlignement.TabStop = False
        Me.gbAlignement.Text = "Alignement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Terrain"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(277, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Banc"
        '
        'pnlBanc
        '
        Me.pnlBanc.Location = New System.Drawing.Point(198, 40)
        Me.pnlBanc.Name = "pnlBanc"
        Me.pnlBanc.Size = New System.Drawing.Size(185, 362)
        Me.pnlBanc.TabIndex = 2
        '
        'pnlTerrain
        '
        Me.pnlTerrain.Location = New System.Drawing.Point(6, 40)
        Me.pnlTerrain.Name = "pnlTerrain"
        Me.pnlTerrain.Size = New System.Drawing.Size(186, 362)
        Me.pnlTerrain.TabIndex = 1
        '
        'btnAlign
        '
        Me.btnAlign.Location = New System.Drawing.Point(137, 408)
        Me.btnAlign.Name = "btnAlign"
        Me.btnAlign.Size = New System.Drawing.Size(113, 23)
        Me.btnAlign.TabIndex = 0
        Me.btnAlign.Text = "Changement"
        Me.btnAlign.UseVisualStyleBackColor = True
        '
        'cbDemie
        '
        Me.cbDemie.AutoSize = True
        Me.cbDemie.Location = New System.Drawing.Point(82, 38)
        Me.cbDemie.Name = "cbDemie"
        Me.cbDemie.Size = New System.Drawing.Size(98, 17)
        Me.cbDemie.TabIndex = 5
        Me.cbDemie.Text = "Première demie"
        Me.cbDemie.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1014, 628)
        Me.ContextMenuStrip = Me.cmsPrincipal
        Me.Controls.Add(Me.cbDemie)
        Me.Controls.Add(Me.gbAlignement)
        Me.Controls.Add(Me.lbLog)
        Me.Controls.Add(Me.cbInvert)
        Me.Controls.Add(Me.pbField)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Chalkboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbField, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbAlignement.ResumeLayout(False)
        Me.gbAlignement.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CréationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterUnePartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CréerUneÉquipeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifierUneÉquipeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÉditionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnnulToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RefaireLaDernièreActionAnnuléeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pbField As System.Windows.Forms.PictureBox
    Friend WithEvents cbInvert As System.Windows.Forms.CheckBox
    Friend WithEvents cmsPrincipal As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lbLog As System.Windows.Forms.ListBox
    Friend WithEvents gbAlignement As System.Windows.Forms.GroupBox
    Friend WithEvents btnAlign As System.Windows.Forms.Button
    Friend WithEvents pnlTerrain As System.Windows.Forms.Panel
    Friend WithEvents pnlBanc As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDemie As System.Windows.Forms.CheckBox

End Class
