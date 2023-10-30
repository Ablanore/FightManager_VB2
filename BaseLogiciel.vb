Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class BaseLogiciel
    Private Sub CréerUnPersonnageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnPersonnageToolStripMenuItem.Click
        Dim formEnvoi As New formCreatePerso()
        OuvrirUnForm(formEnvoi)
    End Sub
    Private Sub InitiativeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InitiativeToolStripMenuItem.Click
        Dim formEnvoi As New formInitiative()
        OuvrirUnForm(formEnvoi)
    End Sub

    Private Sub FaireDesTestsÀLaConToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireDesTestsÀLaConToolStripMenuItem.Click
        Dim formEnvoi As New TestAlaCon()
        OuvrirUnForm(formEnvoi)
    End Sub
    Private Sub LesCombatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LesCombatsToolStripMenuItem.Click
        Dim formEnvoi As New formCombat()
        OuvrirUnForm(formEnvoi)
    End Sub
    Private Sub CréerDesMobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerDesMobsToolStripMenuItem.Click
        Dim formEnvoi As New formCreateMob()
        OuvrirUnForm(formEnvoi)
    End Sub
    Private Sub LesFeuillesPersoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LesFeuillesPersoToolStripMenuItem.Click
        Dim formEnvoi As New formFeuillePerso()
        OuvrirUnForm(formEnvoi)
    End Sub
    Private Sub OuvrirUnForm(leForm As Object)
        ' Définissez le formulaire comme enfant du formulaire BaseLogiciel
        With leForm
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.FixedDialog
            '.Dock = DockStyle.Fill
            .Dock = DockStyle.None
        End With

        ' Ajoutez le formulaire au contrôle Panel (ou autre contrôle de votre choix) du formulaire BaseLogiciel
        Me.Controls.Add(leForm)

        ' Affichez le formulaire 
        leForm.Show()
    End Sub
End Class