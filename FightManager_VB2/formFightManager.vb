Imports System.Text.Json
Imports System.IO
Imports System.Linq
'Imports System.Configuration

Public Class formCreatePerso
    Private RaceData As LesRaces = JsonSerializer.Deserialize(Of LesRaces)(File.ReadAllText(LaGrandeClasse.RaceDataAdresse))
    Private ClasseData As LesClasses = JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse))
    Private jaifini As Boolean = False
    Private unPersonnage As Personnage
    Private tabCarac As Short()
    Private Sub formFightManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNomPersonnage.Text = "JeuneDragonBlanc"
        txtPointExperience.Text = 2300
        lesTrucsDeDepart()
        jaifini = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVoirPerso.Click
        If jaifini Then
            ChargeLabel()
        End If
    End Sub

    Private Sub btnSavePerso_Click(sender As Object, e As EventArgs) Handles btnSavePerso.Click
        tabCarac = {txtBaseForce.Text, txtBaseConstitution.Text, txtBaseDexterite.Text, txtBaseIntelligence.Text, txtBaseSagesse.Text, txtBaseCharisme.Text}
        Dim unRecordPerso As New RecordPerso()
        unRecordPerso.NomPerso = txtNomPersonnage.Text
        unRecordPerso.ClassePerso = ddlClassePersonnage.SelectedValue
        unRecordPerso.RacePerso = ddlRacePersonnage.SelectedValue
        unRecordPerso.PointExperiencePerso = txtPointExperience.Text
        unRecordPerso.TabCarac = tabCarac

        File.WriteAllText(LaGrandeClasse.DossierDesPerso & txtNomPersonnage.Text & ".json", JsonSerializer.Serialize(unRecordPerso))
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
    End Sub

    Sub ChargeLabel()
        tabCarac = {txtBaseForce.Text, txtBaseConstitution.Text, txtBaseDexterite.Text, txtBaseIntelligence.Text, txtBaseSagesse.Text, txtBaseCharisme.Text}
        unPersonnage = New Personnage(txtNomPersonnage.Text, ddlClassePersonnage.SelectedValue, ddlRacePersonnage.SelectedValue, tabCarac, txtPointExperience.Text)

        'Le niveau
        lblNiveauCalcul.Text = unPersonnage.Niveau

        'L'initiative
        lblInitiativeValeur.Text = unPersonnage.Initiative

        'Les Points de vie
        lblPVValeur.Text = unPersonnage.PV

        'Remontée de mod Raciaux pour les caractéristiques
        lblModRaceForce.Text = unPersonnage.CaracteristiquesPerso.Force.ModificateurRacial
        lblModRaceConstitution.Text = unPersonnage.CaracteristiquesPerso.Constitution.ModificateurRacial
        lblModRaceDexterite.Text = unPersonnage.CaracteristiquesPerso.Dexterite.ModificateurRacial
        lblModRaceIntelligence.Text = unPersonnage.CaracteristiquesPerso.Intelligence.ModificateurRacial
        lblModRaceSagesse.Text = unPersonnage.CaracteristiquesPerso.Sagesse.ModificateurRacial
        lblModRaceCharisme.Text = unPersonnage.CaracteristiquesPerso.Charisme.ModificateurRacial

        'Calcul final de la caractéristique (ATTENTION, il faut penser au Talent)
        lblValCalculForce.Text = unPersonnage.CaracteristiquesPerso.Force.Valeur
        lblValCalculConstitution.Text = unPersonnage.CaracteristiquesPerso.Constitution.Valeur
        lblValCalculDexterite.Text = unPersonnage.CaracteristiquesPerso.Dexterite.Valeur
        lblValCalculIntelligence.Text = unPersonnage.CaracteristiquesPerso.Intelligence.Valeur
        lblValCalculSagesse.Text = unPersonnage.CaracteristiquesPerso.Sagesse.Valeur
        lblValCalculCharisme.Text = unPersonnage.CaracteristiquesPerso.Charisme.Valeur

        'Modificateur de la caractéristique
        lblModCalculForce.Text = unPersonnage.CaracteristiquesPerso.Force.ModificateurRacial
        lblModCalculConstitution.Text = unPersonnage.CaracteristiquesPerso.Constitution.ModificateurRacial
        lblModCalculDexterite.Text = unPersonnage.CaracteristiquesPerso.Dexterite.ModificateurRacial
        lblModCalculIntelligence.Text = unPersonnage.CaracteristiquesPerso.Intelligence.ModificateurRacial
        lblModCalculSagesse.Text = unPersonnage.CaracteristiquesPerso.Sagesse.ModificateurRacial
        lblModCalculCharisme.Text = unPersonnage.CaracteristiquesPerso.Charisme.ModificateurRacial

        'Valeur finale de la compétence
        lblTotalAcrobaties.Text = unPersonnage.CompetencesPersonnage.Acrobaties.Valeur
        lblTotalArcanes.Text = unPersonnage.CompetencesPersonnage.Arcanes.Valeur
        lblTotalAthletisme.Text = unPersonnage.CompetencesPersonnage.Athletisme.Valeur
        lblTotalBluff.Text = unPersonnage.CompetencesPersonnage.Bluff.Valeur
        lblTotalConnDeLaRue.Text = unPersonnage.CompetencesPersonnage.ConnDeLaRue.Valeur
        lblTotalDiplomatie.Text = unPersonnage.CompetencesPersonnage.Diplomatie.Valeur
        lblTotalDiscretion.Text = unPersonnage.CompetencesPersonnage.Discretion.Valeur
        lblTotalEndurance.Text = unPersonnage.CompetencesPersonnage.Endurance.Valeur
        lblTotalExploration.Text = unPersonnage.CompetencesPersonnage.Exploration.Valeur
        lblTotalHistoire.Text = unPersonnage.CompetencesPersonnage.Histoire.Valeur
        lblTotalIntimidation.Text = unPersonnage.CompetencesPersonnage.Intimidation.Valeur
        lblTotalIntuition.Text = unPersonnage.CompetencesPersonnage.Intimidation.Valeur
        lblTotalLarcin.Text = unPersonnage.CompetencesPersonnage.Larcin.Valeur
        lblTotalNature.Text = unPersonnage.CompetencesPersonnage.Nature.Valeur
        lblTotalPerception.Text = unPersonnage.CompetencesPersonnage.Perception.Valeur
        lblTotalReligion.Text = unPersonnage.CompetencesPersonnage.Religion.Valeur
        lblTotalSoins.Text = unPersonnage.CompetencesPersonnage.Soins.Valeur

        'Valeur du demi niveau
        lblDemiNiveauAcrobaties.Text = unPersonnage.DemiNiveau
        lblDemiNiveauArcanes.Text = unPersonnage.DemiNiveau
        lblDemiNiveauAthletisme.Text = unPersonnage.DemiNiveau
        lblDemiNiveauBluff.Text = unPersonnage.CompetencesPersonnage.Bluff.Valeur
        lblDemiNiveauConnDeLaRue.Text = unPersonnage.DemiNiveau
        lblDemiNiveauDiplomatie.Text = unPersonnage.DemiNiveau
        lblDemiNiveauDiscretion.Text = unPersonnage.DemiNiveau
        lblDemiNiveauEndurance.Text = unPersonnage.DemiNiveau
        lblDemiNiveauExploration.Text = unPersonnage.DemiNiveau
        lblDemiNiveauHistoire.Text = unPersonnage.DemiNiveau
        lblDemiNiveauIntimidation.Text = unPersonnage.DemiNiveau
        lblDemiNiveauIntuition.Text = unPersonnage.DemiNiveau
        lblDemiNiveauLarcin.Text = unPersonnage.DemiNiveau
        lblDemiNiveauNature.Text = unPersonnage.DemiNiveau
        lblDemiNiveauPerception.Text = unPersonnage.DemiNiveau
        lblDemiNiveauReligion.Text = unPersonnage.DemiNiveau
        lblDemiNiveauSoins.Text = unPersonnage.DemiNiveau

        'Modificateur Carac
        lblModCaracAcrobaties.Text = unPersonnage.CompetencesPersonnage.Acrobaties.ModCarac
        lblModCaracArcanes.Text = unPersonnage.CompetencesPersonnage.Arcanes.ModCarac
        lblModCaracAthletisme.Text = unPersonnage.CompetencesPersonnage.Athletisme.ModCarac
        lblModCaracBluff.Text = unPersonnage.CompetencesPersonnage.Bluff.ModCarac
        lblModCaracConnDeLaRue.Text = unPersonnage.CompetencesPersonnage.ConnDeLaRue.ModCarac
        lblModCaracDiplomatie.Text = unPersonnage.CompetencesPersonnage.Diplomatie.ModCarac
        lblModCaracDiscretion.Text = unPersonnage.CompetencesPersonnage.Discretion.ModCarac
        lblModCaracEndurance.Text = unPersonnage.CompetencesPersonnage.Endurance.ModCarac
        lblModCaracExploration.Text = unPersonnage.CompetencesPersonnage.Exploration.ModCarac
        lblModCaracHistoire.Text = unPersonnage.CompetencesPersonnage.Histoire.ModCarac
        lblModCaracIntimidation.Text = unPersonnage.CompetencesPersonnage.Intimidation.ModCarac
        lblModCaracIntuition.Text = unPersonnage.CompetencesPersonnage.Intimidation.ModCarac
        lblModCaracLarcin.Text = unPersonnage.CompetencesPersonnage.Larcin.ModCarac
        lblModCaracNature.Text = unPersonnage.CompetencesPersonnage.Nature.ModCarac
        lblModCaracPerception.Text = unPersonnage.CompetencesPersonnage.Perception.ModCarac
        lblModCaracReligion.Text = unPersonnage.CompetencesPersonnage.Religion.ModCarac
        lblModCaracSoins.Text = unPersonnage.CompetencesPersonnage.Soins.ModCarac

        'Modificateur Racial
        lblModRacialAcrobaties.Text = unPersonnage.CompetencesPersonnage.Acrobaties.ModRacial
        lblModRacialArcanes.Text = unPersonnage.CompetencesPersonnage.Arcanes.ModRacial
        lblModRacialAthletisme.Text = unPersonnage.CompetencesPersonnage.Athletisme.ModRacial
        lblModRacialBluff.Text = unPersonnage.CompetencesPersonnage.Bluff.ModRacial
        lblModRacialConnDeLarue.Text = unPersonnage.CompetencesPersonnage.ConnDeLaRue.ModRacial
        lblModRacialDiplomatie.Text = unPersonnage.CompetencesPersonnage.Diplomatie.ModRacial
        lblModRacialDiscretion.Text = unPersonnage.CompetencesPersonnage.Discretion.ModRacial
        lblModRacialEndurance.Text = unPersonnage.CompetencesPersonnage.Endurance.ModRacial
        lblModRacialExploration.Text = unPersonnage.CompetencesPersonnage.Exploration.ModRacial
        lblModRacialHistoire.Text = unPersonnage.CompetencesPersonnage.Histoire.ModRacial
        lblModRacialIntimidation.Text = unPersonnage.CompetencesPersonnage.Intimidation.ModRacial
        lblModRacialIntuition.Text = unPersonnage.CompetencesPersonnage.Intimidation.ModRacial
        lblModRacialLarcin.Text = unPersonnage.CompetencesPersonnage.Larcin.ModRacial
        lblModRacialNature.Text = unPersonnage.CompetencesPersonnage.Nature.ModRacial
        lblModRacialPerception.Text = unPersonnage.CompetencesPersonnage.Perception.ModRacial
        lblModRacialReligion.Text = unPersonnage.CompetencesPersonnage.Religion.ModRacial
        lblModRacialSoins.Text = unPersonnage.CompetencesPersonnage.Soins.ModRacial

        'Les sauvegardes
        'Total sauvegardes
        lblTotalCA.Text = unPersonnage.SauvegardesPersonnage.ClasseArmure.Valeur
        lblTotalReflexes.Text = unPersonnage.SauvegardesPersonnage.Reflexes.Valeur
        lblTotalVigueur.Text = unPersonnage.SauvegardesPersonnage.Vigueur.Valeur
        lblTotalVolonte.Text = unPersonnage.SauvegardesPersonnage.Volonté.Valeur

        'Demi niveau de la sauvegarde
        lblDemiNiveauCA.Text = unPersonnage.DemiNiveau
        lblDemiNiveauReflexes.Text = unPersonnage.DemiNiveau
        lblDemiNiveauVigueur.Text = unPersonnage.DemiNiveau
        lblDemiNiveauVolonte.Text = unPersonnage.DemiNiveau

        'Mod carac de la sauvegarde
        lblModCaracCA.Text = unPersonnage.SauvegardesPersonnage.ClasseArmure.ModCarac
        lblModCaracReflexes.Text = unPersonnage.SauvegardesPersonnage.Reflexes.ModCarac
        lblModCaracVigueur.Text = unPersonnage.SauvegardesPersonnage.Vigueur.ModCarac
        lblModCaracVolonte.Text = unPersonnage.SauvegardesPersonnage.Volonté.ModCarac

        'Mod racial de la sauvegarde
        lblModRacialCA.Text = unPersonnage.SauvegardesPersonnage.ClasseArmure.ModRacial
        lblModRacialReflexes.Text = unPersonnage.SauvegardesPersonnage.Reflexes.ModRacial
        lblModRacialVigueur.Text = unPersonnage.SauvegardesPersonnage.Vigueur.ModRacial
        lblModRacialVolonte.Text = unPersonnage.SauvegardesPersonnage.Volonté.ModRacial

        'Mod classe de la sauvegarde
        lblModClasseCA.Text = unPersonnage.SauvegardesPersonnage.ClasseArmure.ModClasse
        lblModClasseReflexes.Text = unPersonnage.SauvegardesPersonnage.Reflexes.ModClasse
        lblModClasseVigueur.Text = unPersonnage.SauvegardesPersonnage.Vigueur.ModClasse
        lblModClasseVolonte.Text = unPersonnage.SauvegardesPersonnage.Volonté.ModClasse
    End Sub


    'Function ModRacial(IndexCarac As Int16)
    '    If ddlRacePersonnage.SelectedIndex = -1 Then
    '        Return 0
    '    Else
    '        Return (From leMod In RaceData.Races
    '                Where leMod.IdRace = ddlRacePersonnage.SelectedValue).First().Caracteristiques(IndexCarac).Valeur
    '    End If
    'End Function
    'Function ModRacialCompetence(IndexCarac As Int16)
    '    If ddlRacePersonnage.SelectedIndex = -1 Then
    '        Return 0
    '    Else
    '        Return (From leMod In RaceData.Races
    '                Where leMod.IdRace = ddlRacePersonnage.SelectedValue).First().Competences(IndexCarac).Valeur
    '    End If
    'End Function

    'Sub ValeurBase(valeurCarac As Label, testTB As TextBox, modRacial As Label)
    '    If IsNumeric(testTB.Text) Then
    '        valeurCarac.Text = CInt(testTB.Text) + CInt(modRacial.Text)
    '    Else
    '        valeurCarac.Text = 10 + CInt(modRacial.Text)
    '    End If
    'End Sub
    'Sub CalculCaracteristique()
    '    'Remontée de mod Raciaux pour les caractéristiques
    '    lblModRaceForce.Text = ModRacial(0)
    '    lblModRaceConstitution.Text = ModRacial(1)
    '    lblModRaceDexterite.Text = ModRacial(2)
    '    lblModRaceIntelligence.Text = ModRacial(3)
    '    lblModRaceSagesse.Text = ModRacial(4)
    '    lblModRaceCharisme.Text = ModRacial(5)

    '    'Calcul de la caractéristique
    '    ValeurBase(lblValCalculForce, txtBaseForce, lblModRaceForce)
    '    ValeurBase(lblValCalculConstitution, txtBaseConstitution, lblModRaceConstitution)
    '    ValeurBase(lblValCalculDexterite, txtBaseDexterite, lblModRaceDexterite)
    '    ValeurBase(lblValCalculIntelligence, txtBaseIntelligence, lblModRaceIntelligence)
    '    ValeurBase(lblValCalculSagesse, txtBaseSagesse, lblModRaceSagesse)
    '    ValeurBase(lblValCalculCharisme, txtBaseCharisme, lblModRaceCharisme)

    '    'Calcul du modificateur final de la caractéristique
    '    lblModCalculForce.Text = Math.Floor((lblValCalculForce.Text - 10) / 2)
    '    lblModCalculConstitution.Text = Math.Floor((lblValCalculConstitution.Text - 10) / 2)
    '    lblModCalculDexterite.Text = Math.Floor((lblValCalculDexterite.Text - 10) / 2)
    '    lblModCalculIntelligence.Text = Math.Floor((lblValCalculIntelligence.Text - 10) / 2)
    '    lblModCalculSagesse.Text = Math.Floor((lblValCalculSagesse.Text - 10) / 2)
    '    lblModCalculCharisme.Text = Math.Floor((lblValCalculCharisme.Text - 10) / 2)
    'End Sub
    'Sub CalculCompetence()
    '    lblModRacialAcrobaties.Text = ModRacialCompetence(0)
    '    lblModRacialArcanes.Text = ModRacialCompetence(1)
    '    lblModRacialAthletisme.Text = ModRacialCompetence(2)
    '    lblModRacialBluff.Text = ModRacialCompetence(3)
    '    lblModRacialConnDeLarue.Text = ModRacialCompetence(4)
    '    lblModRacialDiplomatie.Text = ModRacialCompetence(5)
    '    lblModRacialDiscretion.Text = ModRacialCompetence(6)
    '    lblModRacialEndurance.Text = ModRacialCompetence(7)
    '    lblModRacialExploration.Text = ModRacialCompetence(8)
    '    lblModRacialHistoire.Text = ModRacialCompetence(9)
    '    lblModRacialIntimidation.Text = ModRacialCompetence(10)
    '    lblModRacialIntuition.Text = ModRacialCompetence(11)
    '    lblModRacialLarcin.Text = ModRacialCompetence(12)
    '    lblModRacialNature.Text = ModRacialCompetence(13)
    '    lblModRacialPerception.Text = ModRacialCompetence(14)
    '    lblModRacialReligion.Text = ModRacialCompetence(15)
    '    lblModRacialSoins.Text = ModRacialCompetence(16)
    'End Sub

    'Private Sub txtBaseForce_TextChanged(sender As Object, e As EventArgs) Handles txtBaseForce.TextChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub txtBaseConstitution_TextChanged(sender As Object, e As EventArgs) Handles txtBaseConstitution.TextChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub txtBaseDexterite_TextChanged(sender As Object, e As EventArgs) Handles txtBaseDexterite.TextChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub txtBaseIntelligence_TextChanged(sender As Object, e As EventArgs) Handles txtBaseIntelligence.TextChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub txtBaseSagesse_TextChanged(sender As Object, e As EventArgs) Handles txtBaseSagesse.TextChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub txtBaseCharisme_TextChanged(sender As Object, e As EventArgs) Handles txtBaseCharisme.TextChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub ddlRacePersonnage_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlRacePersonnage.SelectedValueChanged
    '    If jaifini Then
    '        CalculCaracteristique()
    '    End If
    'End Sub
    'Private Sub ddlClassePersonnage_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddlClassePersonnage.SelectedValueChanged
    '    If jaifini Then

    '    End If
    'End Sub
End Class