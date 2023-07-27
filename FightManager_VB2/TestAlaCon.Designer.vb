<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestAlaCon
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
        lblUn = New Label()
        lblDeux = New Label()
        lblTrois = New Label()
        btnTest = New Button()
        lblSix = New Label()
        lblCinq = New Label()
        lblQuatre = New Label()
        SuspendLayout()
        ' 
        ' lblUn
        ' 
        lblUn.AutoSize = True
        lblUn.BorderStyle = BorderStyle.FixedSingle
        lblUn.Location = New Point(150, 100)
        lblUn.MinimumSize = New Size(100, 0)
        lblUn.Name = "lblUn"
        lblUn.Size = New Size(100, 17)
        lblUn.TabIndex = 0
        ' 
        ' lblDeux
        ' 
        lblDeux.AutoSize = True
        lblDeux.BorderStyle = BorderStyle.FixedSingle
        lblDeux.Location = New Point(150, 146)
        lblDeux.MinimumSize = New Size(100, 0)
        lblDeux.Name = "lblDeux"
        lblDeux.Size = New Size(100, 17)
        lblDeux.TabIndex = 1
        ' 
        ' lblTrois
        ' 
        lblTrois.AutoSize = True
        lblTrois.BorderStyle = BorderStyle.FixedSingle
        lblTrois.Location = New Point(150, 201)
        lblTrois.MinimumSize = New Size(100, 0)
        lblTrois.Name = "lblTrois"
        lblTrois.Size = New Size(100, 17)
        lblTrois.TabIndex = 2
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(610, 46)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(75, 23)
        btnTest.TabIndex = 3
        btnTest.Text = "go test"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' lblSix
        ' 
        lblSix.AutoSize = True
        lblSix.BorderStyle = BorderStyle.FixedSingle
        lblSix.Location = New Point(150, 354)
        lblSix.MinimumSize = New Size(100, 0)
        lblSix.Name = "lblSix"
        lblSix.Size = New Size(100, 17)
        lblSix.TabIndex = 6
        ' 
        ' lblCinq
        ' 
        lblCinq.AutoSize = True
        lblCinq.BorderStyle = BorderStyle.FixedSingle
        lblCinq.Location = New Point(150, 299)
        lblCinq.MinimumSize = New Size(100, 0)
        lblCinq.Name = "lblCinq"
        lblCinq.Size = New Size(100, 17)
        lblCinq.TabIndex = 5
        ' 
        ' lblQuatre
        ' 
        lblQuatre.AutoSize = True
        lblQuatre.BorderStyle = BorderStyle.FixedSingle
        lblQuatre.Location = New Point(150, 253)
        lblQuatre.MinimumSize = New Size(100, 0)
        lblQuatre.Name = "lblQuatre"
        lblQuatre.Size = New Size(100, 17)
        lblQuatre.TabIndex = 4
        ' 
        ' TestAlaCon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblSix)
        Controls.Add(lblCinq)
        Controls.Add(lblQuatre)
        Controls.Add(btnTest)
        Controls.Add(lblTrois)
        Controls.Add(lblDeux)
        Controls.Add(lblUn)
        Name = "TestAlaCon"
        Text = "TestAlaCon"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUn As Label
    Friend WithEvents lblDeux As Label
    Friend WithEvents lblTrois As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents lblSix As Label
    Friend WithEvents lblCinq As Label
    Friend WithEvents lblQuatre As Label
End Class
