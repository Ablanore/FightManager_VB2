Imports System.Text.Json
Imports System.IO
Imports System.Linq
'Imports System.Configuration

Public Class FormFightManager

    Private Sub formFightManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Chargement de la DDL des Classes
        Dim lstClasses = (From lstClasse In JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse)).Classes
                          Select New With {lstClasse.IdClasse, lstClasse.NomClasse}).ToList()
        ddlClassePersonnage.DataSource = lstClasses
        ddlClassePersonnage.DisplayMember = "NomClasse"
        ddlClassePersonnage.ValueMember = "IdClasse"
        ddlClassePersonnage.SelectedIndex = -1

        'Chargement de la DDL des Races
        Dim lstRaces = (From lstRace In JsonSerializer.Deserialize(Of LesRaces)(File.ReadAllText(LaGrandeClasse.RaceDataAdresse)).Races
                        Select New With {lstRace.IdRace, lstRace.NomRaces}).ToList()
        ddlRacePersonnage.DataSource = lstRaces
        ddlRacePersonnage.DisplayMember = "NomRace"
        ddlRacePersonnage.ValueMember = "IdRace"
        ddlRacePersonnage.SelectedIndex = -1
    End Sub
End Class
