﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseLogiciel
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
        MenuStrip1 = New MenuStrip()
        FichierToolStripMenuItem = New ToolStripMenuItem()
        MenuGeneral = New ToolStripMenuItem()
        ActionsToolStripMenuItem = New ToolStripMenuItem()
        CréerUnPersonnageToolStripMenuItem = New ToolStripMenuItem()
        FaireDesTestsÀLaConToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FichierToolStripMenuItem, MenuGeneral, ActionsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1184, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FichierToolStripMenuItem
        ' 
        FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        FichierToolStripMenuItem.Size = New Size(54, 20)
        FichierToolStripMenuItem.Text = "Fichier"
        ' 
        ' MenuGeneral
        ' 
        MenuGeneral.Name = "MenuGeneral"
        MenuGeneral.Size = New Size(56, 20)
        MenuGeneral.Text = "Edition"
        ' 
        ' ActionsToolStripMenuItem
        ' 
        ActionsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CréerUnPersonnageToolStripMenuItem, FaireDesTestsÀLaConToolStripMenuItem})
        ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        ActionsToolStripMenuItem.Size = New Size(59, 20)
        ActionsToolStripMenuItem.Text = "Actions"
        ' 
        ' CréerUnPersonnageToolStripMenuItem
        ' 
        CréerUnPersonnageToolStripMenuItem.Name = "CréerUnPersonnageToolStripMenuItem"
        CréerUnPersonnageToolStripMenuItem.Size = New Size(191, 22)
        CréerUnPersonnageToolStripMenuItem.Text = "Créer un personnage"
        ' 
        ' FaireDesTestsÀLaConToolStripMenuItem
        ' 
        FaireDesTestsÀLaConToolStripMenuItem.Name = "FaireDesTestsÀLaConToolStripMenuItem"
        FaireDesTestsÀLaConToolStripMenuItem.Size = New Size(191, 22)
        FaireDesTestsÀLaConToolStripMenuItem.Text = "Faire des tests à la con"
        ' 
        ' BaseLogiciel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 761)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        Name = "BaseLogiciel"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fight Manager"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuGeneral As ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréerUnPersonnageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaireDesTestsÀLaConToolStripMenuItem As ToolStripMenuItem
End Class
