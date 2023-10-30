<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        InitiativeToolStripMenuItem = New ToolStripMenuItem()
        LesCombatsToolStripMenuItem = New ToolStripMenuItem()
        CréerDesMobsToolStripMenuItem = New ToolStripMenuItem()
        LesFeuillesPersoToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.GripStyle = ToolStripGripStyle.Visible
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FichierToolStripMenuItem, MenuGeneral, ActionsToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.MdiWindowListItem = MenuGeneral
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(6, 2, 0, 2)
        MenuStrip1.Size = New Size(1584, 24)
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
        ActionsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CréerUnPersonnageToolStripMenuItem, FaireDesTestsÀLaConToolStripMenuItem, InitiativeToolStripMenuItem, LesCombatsToolStripMenuItem, CréerDesMobsToolStripMenuItem, LesFeuillesPersoToolStripMenuItem})
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
        ' InitiativeToolStripMenuItem
        ' 
        InitiativeToolStripMenuItem.Name = "InitiativeToolStripMenuItem"
        InitiativeToolStripMenuItem.Size = New Size(191, 22)
        InitiativeToolStripMenuItem.Text = "Initiative"
        ' 
        ' LesCombatsToolStripMenuItem
        ' 
        LesCombatsToolStripMenuItem.Name = "LesCombatsToolStripMenuItem"
        LesCombatsToolStripMenuItem.Size = New Size(191, 22)
        LesCombatsToolStripMenuItem.Text = "Les combats"
        ' 
        ' CréerDesMobsToolStripMenuItem
        ' 
        CréerDesMobsToolStripMenuItem.Name = "CréerDesMobsToolStripMenuItem"
        CréerDesMobsToolStripMenuItem.Size = New Size(191, 22)
        CréerDesMobsToolStripMenuItem.Text = "Créer des mobs"
        ' 
        ' LesFeuillesPersoToolStripMenuItem
        ' 
        LesFeuillesPersoToolStripMenuItem.Name = "LesFeuillesPersoToolStripMenuItem"
        LesFeuillesPersoToolStripMenuItem.Size = New Size(191, 22)
        LesFeuillesPersoToolStripMenuItem.Text = "Les feuilles perso"
        ' 
        ' BaseLogiciel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1584, 861)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "BaseLogiciel"
        Text = "Fight Manager"
        WindowState = FormWindowState.Maximized
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
    Friend WithEvents InitiativeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LesCombatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréerDesMobsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LesFeuillesPersoToolStripMenuItem As ToolStripMenuItem
End Class
