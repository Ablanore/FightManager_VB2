Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class BaseLogiciel
    Private Sub CréerUnPersonnageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnPersonnageToolStripMenuItem.Click
        Dim formPerso As New formCreatePerso()
        OuvrirUnForm(formPerso)
    End Sub
    Private Sub InitiativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InitiativeToolStripMenuItem.Click
        Dim formInit As New formInitiative()
        OuvrirUnForm(formInit)
    End Sub

    Private Sub FaireDesTestsÀLaConToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireDesTestsÀLaConToolStripMenuItem.Click
        Dim formCon As New TestAlaCon()
        OuvrirUnForm(formCon)
    End Sub
    Private Sub OuvrirUnForm(leForm As Object)
        ' Définissez le formulaire comme enfant du formulaire BaseLogiciel
        leForm.TopLevel = False
        leForm.FormBorderStyle = FormBorderStyle.FixedDialog
        leForm.Dock = DockStyle.Fill

        ' Ajoutez le formulaire au contrôle Panel (ou autre contrôle de votre choix) du formulaire BaseLogiciel
        Me.Controls.Add(leForm)

        ' Affichez le formulaire 
        leForm.Show()
    End Sub
End Class