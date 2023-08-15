Imports System.Collections.ObjectModel
Imports System.Text.Json
Imports System.IO

Public Class formCombat
    Private tabJoueurs(-1) As Personnage
    Private tabMobs(-1) As Personnage
    Private Sub formCombat_Load(sender As Object, e As EventArgs) Handles Me.Load
        ddlPersonnage.DataSource = My.Computer.FileSystem.GetDirectories(LaGrandeClasse.DossierDesPerso)
        ddlPersonnage.DisplayMember = "NomDossier"
    End Sub

    Private Sub ChargerPerso(Dossier As ReadOnlyCollection(Of String), Destination As String)
        Dim tabPerso(-1) As Personnage
        If Destination = "joueur" Then
            tabPerso = tabJoueurs
        Else
            tabPerso = tabMobs
        End If

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

            Dim ddlPower As New ComboBox
            ddlPower.DataSource = lePerso.PowerPersonnage


            floLigne.Controls.Add(lblNomPerso)
            floLigne.Controls.Add(ddlPower)
            'floLigne.Controls.Add(lblInitPerso)
            If Destination = "joueur" Then
                flpLesjoueurs.Controls.Add(floLigne)
            Else
                flpLesMobs.Controls.Add(floLigne)
            End If

        Next
    End Sub

    Private Sub ddlPersonnage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPersonnage.SelectedIndexChanged
        flpLesjoueurs.Controls.Clear()
        flpLesMobs.Controls.Clear()
        'tabPerso = Array.Empty(Of Personnage)
        ChargerPerso(My.Computer.FileSystem.GetFiles(LaGrandeClasse.DossierDesPerso), "joueur")
        ChargerPerso(My.Computer.FileSystem.GetFiles(ddlPersonnage.SelectedItem), "mob")
    End Sub
End Class