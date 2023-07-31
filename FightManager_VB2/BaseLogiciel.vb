Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class BaseLogiciel
    Private Sub CréerUnPersonnageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnPersonnageToolStripMenuItem.Click
        'formCreatePerso.ShowDialog()
        OuvrirFormCreatePerso()
    End Sub

    Private Sub FaireDesTestsÀLaConToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireDesTestsÀLaConToolStripMenuItem.Click
        TestAlaCon.ShowDialog()

    End Sub

    Private Sub OuvrirFormCreatePerso()
        ' Créez une instance du formulaire formCreatePerso
        Dim formPerso As New formCreatePerso()

        ' Définissez le formulaire formCreatePerso comme enfant du formulaire BaseLogiciel
        formPerso.TopLevel = False
        formPerso.FormBorderStyle = FormBorderStyle.FixedDialog
        formPerso.Dock = DockStyle.Fill

        ' Ajoutez le formulaire formCreatePerso au contrôle Panel (ou autre contrôle de votre choix) du formulaire BaseLogiciel
        Me.Controls.Add(formPerso)

        ' Affichez le formulaire formCreatePerso
        formPerso.Show()
    End Sub
End Class