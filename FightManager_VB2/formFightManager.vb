Imports System.Text.Json
Imports System.IO
Imports System.Linq
'Imports System.Configuration

Public Class FormFightManager
    Private RaceData As LesRaces = JsonSerializer.Deserialize(Of LesRaces)(File.ReadAllText(LaGrandeClasse.RaceDataAdresse))
    Private ClasseData As LesClasses = JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse))
    Private jaifini As Boolean = False
    Private Sub formFightManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lesTrucsDeDepart()
        jaifini = True
    End Sub

    Sub lesTrucsDeDepart()
        'Chargement de la DDL des Classes
        Dim lstClasses = (From lstClasse In ClasseData.Classes
                          Select New With {lstClasse.IdClasse, lstClasse.NomClasse}).ToList()
        ddlClassePersonnage.DataSource = lstClasses
        ddlClassePersonnage.DisplayMember = "NomClasse"
        ddlClassePersonnage.ValueMember = "IdClasse"
        ddlClassePersonnage.SelectedIndex = -1

        'Chargement de la DDL des Races
        Dim lstRaces = (From lstRace In RaceData.Races
                        Select New With {lstRace.IdRace, lstRace.NomRaces}).ToList()
        ddlRacePersonnage.DataSource = lstRaces
        ddlRacePersonnage.DisplayMember = "NomRace"
        ddlRacePersonnage.ValueMember = "IdRace"
        ddlRacePersonnage.SelectedIndex = -1
        CalculCaracteristique()
    End Sub

    Function ModRacial(IndexCarac As Int16)
        If ddlRacePersonnage.SelectedIndex = -1 Then
            Return 0
        Else
            Return (From leMod In RaceData.Races
                    Where leMod.IdRace = ddlRacePersonnage.SelectedValue).First().Caracteristiques(IndexCarac).Valeur
        End If
    End Function
    Function ModRacialCompetence(IndexCarac As Int16)
        If ddlRacePersonnage.SelectedIndex = -1 Then
            Return 0
        Else
            Return (From leMod In RaceData.Races
                    Where leMod.IdRace = ddlRacePersonnage.SelectedValue).First().Competences(IndexCarac).Valeur
        End If
    End Function

    Sub ValeurBase(valeurCarac As Label, testTB As TextBox, modRacial As Label)
        If IsNumeric(testTB.Text) Then
            valeurCarac.Text = CInt(testTB.Text) + CInt(modRacial.Text)
        Else
            valeurCarac.Text = 10 + CInt(modRacial.Text)
        End If
    End Sub
    Sub CalculCaracteristique()
        'Remontée de mod Raciaux pour les caractéristiques
        lblModRaceForce.Text = ModRacial(0)
        lblModRaceConstitution.Text = ModRacial(1)
        lblModRaceDexterite.Text = ModRacial(2)
        lblModRaceIntelligence.Text = ModRacial(3)
        lblModRaceSagesse.Text = ModRacial(4)
        lblModRaceCharisme.Text = ModRacial(5)

        'Calcul de la caractéristique
        ValeurBase(lblValCalculForce, txtBaseForce, lblModRaceForce)
        ValeurBase(lblValCalculConstitution, txtBaseConstitution, lblModRaceConstitution)
        ValeurBase(lblValCalculDexterite, txtBaseDexterite, lblModRaceDexterite)
        ValeurBase(lblValCalculIntelligence, txtBaseIntelligence, lblModRaceIntelligence)
        ValeurBase(lblValCalculSagesse, txtBaseSagesse, lblModRaceSagesse)
        ValeurBase(lblValCalculCharisme, txtBaseCharisme, lblModRaceCharisme)

        'Calcul du modificateur final de la caractéristique
        lblModCalculForce.Text = Math.Floor((lblValCalculForce.Text - 10) / 2)
        lblModCalculConstitution.Text = Math.Floor((lblValCalculConstitution.Text - 10) / 2)
        lblModCalculDexterite.Text = Math.Floor((lblValCalculDexterite.Text - 10) / 2)
        lblModCalculIntelligence.Text = Math.Floor((lblValCalculIntelligence.Text - 10) / 2)
        lblModCalculSagesse.Text = Math.Floor((lblValCalculSagesse.Text - 10) / 2)
        lblModCalculCharisme.Text = Math.Floor((lblValCalculCharisme.Text - 10) / 2)
    End Sub
    Sub CalculCompetence()
        lblModRacialAcrobaties.Text = ModRacialCompetence(0)
        lblModRacialArcanes.Text = ModRacialCompetence(1)
        lblModRacialAthletisme.Text = ModRacialCompetence(2)
        lblModRacialBluff.Text = ModRacialCompetence(3)
        lblModRacialConnDeLarue.Text = ModRacialCompetence(4)
        lblModRacialDiplomatie.Text = ModRacialCompetence(5)
        lblModRacialDiscretion.Text = ModRacialCompetence(6)
        lblModRacialEndurance.Text = ModRacialCompetence(7)
        lblModRacialExploration.Text = ModRacialCompetence(8)
        lblModRacialHistoire.Text = ModRacialCompetence(9)
        lblModRacialIntimidation.Text = ModRacialCompetence(10)
        lblModRacialIntuition.Text = ModRacialCompetence(11)
        lblModRacialLarcin.Text = ModRacialCompetence(12)
        lblModRacialNature.Text = ModRacialCompetence(13)
        lblModRacialPerception.Text = ModRacialCompetence(14)
        lblModRacialReligion.Text = ModRacialCompetence(15)
        lblModRacialSoins.Text = ModRacialCompetence(16)
    End Sub

    Private Sub txtBaseForce_TextChanged(sender As Object, e As EventArgs) Handles txtBaseForce.TextChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub txtBaseConstitution_TextChanged(sender As Object, e As EventArgs) Handles txtBaseConstitution.TextChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub txtBaseDexterite_TextChanged(sender As Object, e As EventArgs) Handles txtBaseDexterite.TextChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub txtBaseIntelligence_TextChanged(sender As Object, e As EventArgs) Handles txtBaseIntelligence.TextChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub txtBaseSagesse_TextChanged(sender As Object, e As EventArgs) Handles txtBaseSagesse.TextChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub txtBaseCharisme_TextChanged(sender As Object, e As EventArgs) Handles txtBaseCharisme.TextChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub ddlRacePersonnage_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlRacePersonnage.SelectedValueChanged
        If jaifini Then
            CalculCaracteristique()
        End If
    End Sub
    Private Sub ddlClassePersonnage_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlClassePersonnage.SelectedValueChanged
        If jaifini Then

        End If
    End Sub
End Class