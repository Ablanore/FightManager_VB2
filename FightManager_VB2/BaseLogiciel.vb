Public Class BaseLogiciel
    Private Sub CréerUnPersonnageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CréerUnPersonnageToolStripMenuItem.Click
        formCreatePerso.ShowDialog()
    End Sub

    Private Sub FaireDesTestsÀLaConToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FaireDesTestsÀLaConToolStripMenuItem.Click
        TestAlaCon.ShowDialog()

    End Sub
End Class