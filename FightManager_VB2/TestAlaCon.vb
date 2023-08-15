Public Class TestAlaCon
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'Dim TabCarac(6) As Short
        'TabCarac = {10, 11, 12, 13, 14, 15}
        Dim unPersonnage As New Personnage("Ablanore", "Guerrier", "Elfe", {10, 10, 10, 10, 10, 10}, 2650)

        'Dim laClasse As New Classe("Guerrier")
        'lblUn.Text = LaGrandeClasse.Jetdes(4)
        lblUn.Text = unPersonnage.SauvegardesPersonnage.ClasseArmure.Valeur
        lblDeux.Text = unPersonnage.SauvegardesPersonnage.Reflexes.Valeur
        lblTrois.Text = unPersonnage.SauvegardesPersonnage.Vigueur.Valeur
        lblQuatre.Text = unPersonnage.SauvegardesPersonnage.Volonté.Valeur
        lblCinq.Text = "patate"
        lblSix.Text = "patate"

    End Sub
End Class