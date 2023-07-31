Public Class TestAlaCon
    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        'Dim TabCarac(6) As Short
        'TabCarac = {10, 11, 12, 13, 14, 15}
        'Dim unPersonnage As New Personnage("Ablanore", "Guerrier", "Elfe", TabCarac, 2650)

        'Dim laClasse As New Classe("Guerrier")
        lblUn.Text = LaGrandeClasse.Jetdes(4)
        lblDeux.Text = LaGrandeClasse.Jetdes(6)
        lblTrois.Text = LaGrandeClasse.Jetdes(8)
        lblQuatre.Text = LaGrandeClasse.Jetdes(10)
        lblCinq.Text = LaGrandeClasse.Jetdes(12)
        lblSix.Text = LaGrandeClasse.Jetdes(20)

    End Sub
End Class