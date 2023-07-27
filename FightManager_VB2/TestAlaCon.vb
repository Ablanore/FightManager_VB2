Public Class TestAlaCon
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim TabCarac(6) As Short
        TabCarac = {10, 11, 12, 13, 14, 15}
        Dim unPersonnage As New Personnage("Ablanore", "Guerrier", "Elfe", TabCarac, 2650)
        'lblForce.Text = unPersonnage.Caracteristiques.valeur
        'lblConstitution.Text = unPersonnage.Caracteristiques.valeur
        'lblPV.Text = unPersonnage.pv

        'Dim laClasse As New Classe("Guerrier")
        lblUn.Text = unPersonnage.CompetencesPersonnage(3).Valeur
        lblDeux.Text = unPersonnage.CompetencesPersonnage(4).Valeur
        lblTrois.Text = unPersonnage.CompetencesPersonnage(5).Valeur
        lblQuatre.Text = unPersonnage.CompetencesPersonnage(9).Valeur
        lblCinq.Text = unPersonnage.CompetencesPersonnage(15).Valeur
        lblSix.Text = unPersonnage.CompetencesPersonnage(16).Valeur

    End Sub
End Class