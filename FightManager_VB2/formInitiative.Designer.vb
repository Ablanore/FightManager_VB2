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
        SuspendLayout()
        ' 
        ' ddlPersonnage
        ' 
        ddlPersonnage.FormattingEnabled = True
        ddlPersonnage.Location = New Point(12, 12)
        ddlPersonnage.Name = "ddlPersonnage"
        ddlPersonnage.Size = New Size(221, 28)
        ddlPersonnage.TabIndex = 0
        ' 
        ' lblTest
        ' 
        lblTest.AutoSize = True
        lblTest.BorderStyle = BorderStyle.FixedSingle
        lblTest.Location = New Point(12, 495)
        lblTest.MinimumSize = New Size(30, 0)
        lblTest.Name = "lblTest"
        lblTest.Size = New Size(30, 22)
        lblTest.TabIndex = 2
        ' 
        ' flpPersonnage
        ' 
        flpPersonnage.BorderStyle = BorderStyle.FixedSingle
        flpPersonnage.FlowDirection = FlowDirection.TopDown
        flpPersonnage.Location = New Point(116, 73)
        flpPersonnage.Name = "flpPersonnage"
        flpPersonnage.Size = New Size(469, 392)
        flpPersonnage.TabIndex = 3
        ' 
        ' btnLancerInititiative
        ' 
        btnLancerInititiative.Location = New Point(468, 16)
        btnLancerInititiative.Name = "btnLancerInititiative"
        btnLancerInititiative.Size = New Size(94, 29)
        btnLancerInititiative.TabIndex = 4
        btnLancerInititiative.Text = "Lancer"
        btnLancerInititiative.UseVisualStyleBackColor = True
        ' 
        ' formInitiative
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 569)
        Controls.Add(btnLancerInititiative)
        Controls.Add(flpPersonnage)
        Controls.Add(lblTest)
        Controls.Add(ddlPersonnage)
        Name = "formInitiative"
        Text = "formInitiative"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ddlPersonnage As ComboBox
    Friend WithEvents lblTest As Label
    Friend WithEvents flpPersonnage As FlowLayoutPanel
    Friend WithEvents btnLancerInititiative As Button
End Class
