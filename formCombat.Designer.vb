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
        flpPersonnages = New FlowLayoutPanel()
        zzz = New CheckedListBox()
        SuspendLayout()
        ' 
        ' flpPersonnages
        ' 
        flpPersonnages.BorderStyle = BorderStyle.FixedSingle
        flpPersonnages.FlowDirection = FlowDirection.TopDown
        flpPersonnages.Location = New Point(150, 0)
        flpPersonnages.Margin = New Padding(3, 2, 3, 2)
        flpPersonnages.MaximumSize = New Size(1300, 750)
        flpPersonnages.MinimumSize = New Size(1300, 750)
        flpPersonnages.Name = "flpPersonnages"
        flpPersonnages.Size = New Size(1300, 750)
        flpPersonnages.TabIndex = 5
        ' 
        ' zzz
        ' 
        zzz.CheckOnClick = True
        zzz.Location = New Point(0, 50)
        zzz.Name = "zzz"
        zzz.Size = New Size(150, 688)
        zzz.TabIndex = 6
        zzz.Visible = False
        ' 
        ' formCombat
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1484, 761)
        Controls.Add(zzz)
        Controls.Add(flpPersonnages)
        Location = New Point(430, 20)
        MaximumSize = New Size(1500, 800)
        MinimumSize = New Size(1500, 800)
        Name = "formCombat"
        StartPosition = FormStartPosition.Manual
        Text = "Combat"
        ResumeLayout(False)
    End Sub

    Friend WithEvents flpPersonnages As FlowLayoutPanel
    Friend WithEvents zzz As CheckedListBox
End Class
