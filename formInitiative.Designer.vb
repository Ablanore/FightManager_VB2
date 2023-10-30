<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formInitiative
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
        lblTest = New Label()
        flpPersonnage = New FlowLayoutPanel()
        btnLancerInititiative = New Button()
        flpResultat = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' ddlPersonnage
        ' 
        ddlPersonnage.FormattingEnabled = True
        ddlPersonnage.Location = New Point(10, 10)
        ddlPersonnage.Margin = New Padding(3, 2, 3, 2)
        ddlPersonnage.Name = "ddlPersonnage"
        ddlPersonnage.Size = New Size(220, 23)
        ddlPersonnage.TabIndex = 0
        ' 
        ' lblTest
        ' 
        lblTest.AutoSize = True
        lblTest.BorderStyle = BorderStyle.FixedSingle
        lblTest.Location = New Point(330, 10)
        lblTest.MinimumSize = New Size(26, 2)
        lblTest.Name = "lblTest"
        lblTest.Size = New Size(26, 17)
        lblTest.TabIndex = 2
        ' 
        ' flpPersonnage
        ' 
        flpPersonnage.BorderStyle = BorderStyle.FixedSingle
        flpPersonnage.FlowDirection = FlowDirection.TopDown
        flpPersonnage.Location = New Point(10, 40)
        flpPersonnage.Margin = New Padding(3, 2, 3, 2)
        flpPersonnage.Name = "flpPersonnage"
        flpPersonnage.Size = New Size(300, 710)
        flpPersonnage.TabIndex = 3
        ' 
        ' btnLancerInititiative
        ' 
        btnLancerInititiative.Location = New Point(240, 10)
        btnLancerInititiative.Margin = New Padding(3, 2, 3, 2)
        btnLancerInititiative.Name = "btnLancerInititiative"
        btnLancerInititiative.Size = New Size(70, 20)
        btnLancerInititiative.TabIndex = 4
        btnLancerInititiative.Text = "Lancer"
        btnLancerInititiative.UseVisualStyleBackColor = True
        ' 
        ' flpResultat
        ' 
        flpResultat.BorderStyle = BorderStyle.FixedSingle
        flpResultat.FlowDirection = FlowDirection.TopDown
        flpResultat.Location = New Point(10, 40)
        flpResultat.Margin = New Padding(3, 2, 3, 2)
        flpResultat.Name = "flpResultat"
        flpResultat.Size = New Size(350, 710)
        flpResultat.TabIndex = 4
        ' 
        ' formInitiative
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 761)
        Controls.Add(flpResultat)
        Controls.Add(btnLancerInititiative)
        Controls.Add(flpPersonnage)
        Controls.Add(lblTest)
        Controls.Add(ddlPersonnage)
        HelpButton = True
        Location = New Point(20, 20)
        Margin = New Padding(3, 2, 3, 2)
        MaximumSize = New Size(400, 800)
        MinimumSize = New Size(400, 800)
        Name = "formInitiative"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.Manual
        Text = "Gestion de l'initiative"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ddlPersonnage As ComboBox
    Friend WithEvents lblTest As Label
    Friend WithEvents flpPersonnage As FlowLayoutPanel
    Friend WithEvents btnLancerInititiative As Button
    Friend WithEvents flpResultat As FlowLayoutPanel
End Class
