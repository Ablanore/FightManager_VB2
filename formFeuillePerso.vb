Imports System.Text.Json
Imports System.IO
Imports System.Linq
Imports System.Data.SqlClient
'Imports System.Configuration

Public Class formFeuillePerso
    Private RaceData As LesRaces = JsonSerializer.Deserialize(Of LesRaces)(File.ReadAllText(LaGrandeClasse.RaceDataAdresse))
    Private ClasseData As LesClasses = JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse))
    Private StuffData As LesStuffs = JsonSerializer.Deserialize(Of LesStuffs)(File.ReadAllText(LaGrandeClasse.StuffDataAdresse))
    Private unPersonnage As Personnage
    Private unPerso As RecordPerso
    Private tabStuff As New List(Of String)
    Private tabPower As New List(Of String)
    Private Sub formFightManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Chargement de la DDL des stuff
        Dim lstStuffs = (From lstStuff In StuffData.Stuffs
                         Select New StuffDef(lstStuff.IdStuff, lstStuff.NomStuff)).ToList()
        ddlStuff.DataSource = lstStuffs
        ddlStuff.DisplayMember = "NomStuff"
        ddlStuff.ValueMember = "IdStuff"

        'Chargement ddl des zones de scénario
        ddlListePerso.DataSource = My.Computer.FileSystem.GetFiles(LaGrandeClasse.DossierDesPerso)
    End Sub
    Private Sub btnVoirPerso_Click(sender As Object, e As EventArgs) Handles btnVoirPerso.Click
        unPerso = JsonSerializer.Deserialize(Of RecordPerso)(File.ReadAllText(ddlListePerso.SelectedItem))
        unPersonnage = New Personnage(unPerso.NomPerso, unPerso.TypePerso, unPerso.ClassePerso, unPerso.RacePerso, unPerso.TabCarac, unPerso.LesStuff, unPerso.LesPower, unPerso.PointExperiencePerso)
        ChargeLabel()
    End Sub
    Sub ChargeStuff()
        'Chargement des stuff sélectionnés dans le tableau de String pour le New du personnage ou le save du RecordPerso
        tabStuff.Clear()

        For Each checkItem As Object In ddlStuff.CheckedItems
            Dim stuffItem As StuffDef = DirectCast(checkItem, StuffDef)
            tabStuff.Add(stuffItem.IdStuff.ToString())
        Next
    End Sub
    Sub ChargeLabel()
        'ChargeStuff()
        lblNomPersonnageAffichage.Text = unPersonnage.Nom
        lblClassePersoAffichage.Text = unPersonnage.Classe.NomClasse
        lblRacePersoAffichage.Text = unPersonnage.Race.NomRace
        lblPointExperienceAffichage.Text = unPersonnage.PointsExperience
        lblNiveauCalcul.Text = unPersonnage.Niveau
        lblInitiativeValeur.Text = unPersonnage.Initiative
        lblPVValeur.Text = unPersonnage.PV
        lblPerilAffichage.Text = unPersonnage.Peril

        'Affichage carac du JSON
        lblForceAffichage.Text = unPerso.TabCarac(0)
        lblConstitutionAffichage.Text = unPerso.TabCarac(1)
        lblDexteriteAffichage.Text = unPerso.TabCarac(2)
        lblIntelligenceAffichage.Text = unPerso.TabCarac(3)
        lblSagesseAffichage.Text = unPerso.TabCarac(4)
        lblCharismeAffichage.Text = unPerso.TabCarac(5)

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
        lblTotalIntuition.Text = unPersonnage.CompetencesPersonnage.Intuition.Valeur
        lblTotalLarcin.Text = unPersonnage.CompetencesPersonnage.Larcin.Valeur
        lblTotalNature.Text = unPersonnage.CompetencesPersonnage.Nature.Valeur
        lblTotalPerception.Text = unPersonnage.CompetencesPersonnage.Perception.Valeur
        lblTotalReligion.Text = unPersonnage.CompetencesPersonnage.Religion.Valeur
        lblTotalSoins.Text = unPersonnage.CompetencesPersonnage.Soins.Valeur

        'Valeur du demi niveau
        lblDemiNiveauAcrobaties.Text = unPersonnage.DemiNiveau
        lblDemiNiveauArcanes.Text = unPersonnage.DemiNiveau
        lblDemiNiveauAthletisme.Text = unPersonnage.DemiNiveau
        lblDemiNiveauBluff.Text = unPersonnage.DemiNiveau
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
        lblModCaracIntuition.Text = unPersonnage.CompetencesPersonnage.Intuition.ModCarac
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
        lblModRacialIntuition.Text = unPersonnage.CompetencesPersonnage.Intuition.ModRacial
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
End Class