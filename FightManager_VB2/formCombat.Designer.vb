<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCombat
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
        ddlPersonnage = New ComboBox()
        flpLesMobs = New FlowLayoutPanel()
        flpLesjoueurs = New FlowLayoutPanel()
        lblLesMobs = New Label()
        lblLesJoueurs = New Label()
        SuspendLayout()
        ' 
        ' ddlPersonnage
        ' 
        ddlPersonnage.FormattingEnabled = True
        ddlPersonnage.Location = New Point(308, 24)
        ddlPersonnage.Margin = New Padding(3, 2, 3, 2)
        ddlPersonnage.Name = "ddlPersonnage"
        ddlPersonnage.Size = New Size(194, 23)
        ddlPersonnage.TabIndex = 9
        ' 
        ' flpLesMobs
        ' 
        flpLesMobs.Location = New Point(536, 66)
        flpLesMobs.Name = "flpLesMobs"
        flpLesMobs.Size = New Size(231, 245)
        flpLesMobs.TabIndex = 8
        ' 
        ' flpLesjoueurs
        ' 
        flpLesjoueurs.Location = New Point(28, 66)
        flpLesjoueurs.Name = "flpLesjoueurs"
        flpLesjoueurs.Size = New Size(231, 245)
        flpLesjoueurs.TabIndex = 7
        ' 
        ' lblLesMobs
        ' 
        lblLesMobs.AutoSize = True
        lblLesMobs.Location = New Point(610, 39)
        lblLesMobs.Name = "lblLesMobs"
        lblLesMobs.Size = New Size(57, 15)
        lblLesMobs.TabIndex = 6
        lblLesMobs.Text = "Les mobs"
        ' 
        ' lblLesJoueurs
        ' 
        lblLesJoueurs.AutoSize = True
        lblLesJoueurs.Location = New Point(70, 39)
        lblLesJoueurs.Name = "lblLesJoueurs"
        lblLesJoueurs.Size = New Size(66, 15)
        lblLesJoueurs.TabIndex = 5
        lblLesJoueurs.Text = "Les joueurs"
        ' 
        ' formCombat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ddlPersonnage)
        Controls.Add(flpLesMobs)
        Controls.Add(flpLesjoueurs)
        Controls.Add(lblLesMobs)
        Controls.Add(lblLesJoueurs)
        Name = "formCombat"
        Text = "Combat"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ddlPersonnage As ComboBox
    Friend WithEvents flpLesMobs As FlowLayoutPanel
    Friend WithEvents flpLesjoueurs As FlowLayoutPanel
    Friend WithEvents lblLesMobs As Label
    Friend WithEvents lblLesJoueurs As Label
End Class
