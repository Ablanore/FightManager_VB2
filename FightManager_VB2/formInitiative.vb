Imports System.Text.Json
Imports System.IO
Imports System.Globalization
Imports System.Collections.ObjectModel

Public Class formInitiative
    Private tabPerso(-1) As Personnage
    Private Sub formInitiative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ddlPersonnage.DataSource = My.Computer.FileSystem.GetDirectories(LaGrandeClasse.DossierDesPerso)
        ddlPersonnage.DisplayMember = "NomDossier"
    End Sub

    Private Sub btnLancerInititiative_Click(sender As Object, e As EventArgs) Handles btnLancerInititiative.Click
        Dim ListInitiative As New List(Of KeyValuePair(Of String, Integer))()

        For Each p In tabPerso
            Dim lbl As Label = Me.Controls.Find("lblInitPerso" & p.Nom, True)(0)
            Dim txt As TextBox = Me.Controls.Find("txtInit" & p.Nom, True)(0)
            If txt.Text = "" Then
                lbl.Text = p.Initiative + LaGrandeClasse.Jetdes(20)
            Else
                lbl.Text = p.Initiative + txt.Text
            End If
            ListInitiative.Add(New KeyValuePair(Of String, Integer)(p.Nom & " " & p.CaracteristiquesPerso.Dexterite.Valeur, CInt(lbl.Text)))
        Next

        ListInitiative = ListInitiative.OrderByDescending(Function(item) item.Value).ToList()
        flpResultat.Controls.Clear()
        For Each entry As KeyValuePair(Of String, Integer) In ListInitiative
            Dim lbl As New Label
            lbl.Text = entry.Value & " : " & entry.Key
            lbl.Width = 500
            flpResultat.Controls.Add(lbl)
        Next
    End Sub
    Private Sub ChargerPerso(Dossier As ReadOnlyCollection(Of String))
        For Each perso In Dossier
            Dim unPerso As RecordPerso = JsonSerializer.Deserialize(Of RecordPerso)(File.ReadAllText(perso))
            Dim lePerso As New Personnage(unPerso.NomPerso, unPerso.ClassePerso, unPerso.RacePerso, unPerso.TabCarac, unPerso.PointExperiencePerso)
            Array.Resize(tabPerso, tabPerso.Length + 1)
            tabPerso(tabPerso.Length - 1) = lePerso

            Dim floLigne As New FlowLayoutPanel
            floLigne.Name = "flo" & lePerso.Nom
            floLigne.FlowDirection = FlowDirection.LeftToRight
            floLigne.AutoSize = True
            floLigne.AutoSizeMode = AutoSizeMode.GrowOnly

            Dim lblNomPerso As New Label
            lblNomPerso.Text = lePerso.Nom
            lblNomPerso.Name = "lblNomPerso" & lePerso.Nom

            Dim txtScorDes As New TextBox
            txtScorDes.Name = "txtInit" & lePerso.Nom

            Dim lblInitPerso As New Label
            lblInitPerso.Name = "lblInitPerso" & lePerso.Nom
            lblInitPerso.BorderStyle = BorderStyle.FixedSingle
            lblInitPerso.MinimumSize = New Size(30, 0)

            floLigne.Controls.Add(lblNomPerso)
            floLigne.Controls.Add(txtScorDes)
            floLigne.Controls.Add(lblInitPerso)
            flpPersonnage.Controls.Add(floLigne)
        Next
    End Sub

    Private Sub ddlPersonnage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPersonnage.SelectedIndexChanged
        flpPersonnage.Controls.Clear()

        tabPerso = Array.Empty(Of Personnage)
        ChargerPerso(My.Computer.FileSystem.GetFiles(LaGrandeClasse.DossierDesPerso))
        ChargerPerso(My.Computer.FileSystem.GetFiles(ddlPersonnage.SelectedItem))
    End Sub
End Class