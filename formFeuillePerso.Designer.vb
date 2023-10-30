<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formFeuillePerso
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNomPersonnage = New Label()
        lblClassePersonnage = New Label()
        lblRacePersonnage = New Label()
        lblPointExperience = New Label()
        lblNiveau = New Label()
        lblNiveauCalcul = New Label()
        btnVoirPerso = New Button()
        lblInitiative = New Label()
        lblInitiativeValeur = New Label()
        lblPVValeur = New Label()
        lblPV = New Label()
        ddlListePerso = New ComboBox()
        ddlStuff = New CheckedListBox()
        tabCompetences = New TabPage()
        chkFormAcrobaties = New CheckBox()
        chkFormArcanes = New CheckBox()
        chkFormAthletisme = New CheckBox()
        chkFormBluff = New CheckBox()
        chkFormConnDeLaRue = New CheckBox()
        chkFormDiplomatie = New CheckBox()
        chkFormDiscretion = New CheckBox()
        chkFormEndurance = New CheckBox()
        chkFormExploration = New CheckBox()
        chkFormHistoire = New CheckBox()
        chkFormIntimidation = New CheckBox()
        chkFormIntuition = New CheckBox()
        chkFormLarcin = New CheckBox()
        chkFormNature = New CheckBox()
        chkFormPerception = New CheckBox()
        chkFormReligion = New CheckBox()
        chkFormSoins = New CheckBox()
        lblTotalSoins = New Label()
        lblTotalReligion = New Label()
        lblTotalPerception = New Label()
        lblTotalNature = New Label()
        lblTotalLarcin = New Label()
        lblTotalIntuition = New Label()
        lblTotalIntimidation = New Label()
        lblTotalHistoire = New Label()
        lblTotalExploration = New Label()
        lblTotalEndurance = New Label()
        lblTotalDiscretion = New Label()
        lblTotalDiplomatie = New Label()
        lblTotalConnDeLaRue = New Label()
        lblTotalBluff = New Label()
        lblTotalAthletisme = New Label()
        lblTotalAcrobaties = New Label()
        lblTotalArcanes = New Label()
        lblTotal = New Label()
        lblPenArmureSoins = New Label()
        lblDiversSoins = New Label()
        lblModRacialSoins = New Label()
        lblModCaracSoins = New Label()
        lblDemiNiveauSoins = New Label()
        lblPenArmureReligion = New Label()
        lblDiversReligion = New Label()
        lblModRacialReligion = New Label()
        lblModCaracReligion = New Label()
        lblDemiNiveauReligion = New Label()
        lblPenArmurePerception = New Label()
        lblDiversPerception = New Label()
        lblModRacialPerception = New Label()
        lblModCaracPerception = New Label()
        lblDemiNiveauPerception = New Label()
        lblPenArmureNature = New Label()
        lblDiversNature = New Label()
        lblModRacialNature = New Label()
        lblModCaracNature = New Label()
        lblDemiNiveauNature = New Label()
        lblPenArmureLarcin = New Label()
        lblDiversLarcin = New Label()
        lblModRacialLarcin = New Label()
        lblModCaracLarcin = New Label()
        lblDemiNiveauLarcin = New Label()
        lblPenArmureIntuition = New Label()
        lblDiversIntuition = New Label()
        lblModRacialIntuition = New Label()
        lblModCaracIntuition = New Label()
        lblDemiNiveauIntuition = New Label()
        lblPenArmureIntimidation = New Label()
        lblDiversIntimidation = New Label()
        lblModRacialIntimidation = New Label()
        lblModCaracIntimidation = New Label()
        lblDemiNiveauIntimidation = New Label()
        lblPenArmureHistoire = New Label()
        lblDiversHistoire = New Label()
        lblModRacialHistoire = New Label()
        lblModCaracHistoire = New Label()
        lblDemiNiveauHistoire = New Label()
        lblPenArmureExploration = New Label()
        lblDiversExploration = New Label()
        lblModRacialExploration = New Label()
        lblModCaracExploration = New Label()
        lblDemiNiveauExploration = New Label()
        lblPenArmureEndurance = New Label()
        lblDiversEndurance = New Label()
        lblModRacialEndurance = New Label()
        lblModCaracEndurance = New Label()
        lblDemiNiveauEndurance = New Label()
        lblPenArmureDiscretion = New Label()
        lblDiversDiscretion = New Label()
        lblModRacialDiscretion = New Label()
        lblModCaracDiscretion = New Label()
        lblDemiNiveauDiscretion = New Label()
        lblPenArmureDiplomatie = New Label()
        lblDiversDiplomatie = New Label()
        lblModRacialDiplomatie = New Label()
        lblPenArmureConnDeLaRue = New Label()
        lblDiversConnDeLaRue = New Label()
        lblModRacialConnDeLarue = New Label()
        lblPenArmureBluff = New Label()
        lblDiversBluff = New Label()
        lblModRacialBluff = New Label()
        lblPenArmureAthletisme = New Label()
        lblDiversAthletisme = New Label()
        lblModRacialAthletisme = New Label()
        lblPenArmureArcanes = New Label()
        lblDiversArcanes = New Label()
        lblModRacialArcanes = New Label()
        lblPenArmureAcrobaties = New Label()
        lblDiversAcrobaties = New Label()
        lblModRacialAcrobaties = New Label()
        lblSoins = New Label()
        lblReligion = New Label()
        lblPerception = New Label()
        lblNature = New Label()
        lblLarcin = New Label()
        lblIntuition = New Label()
        lblIntimidation = New Label()
        lblHistoire = New Label()
        lblExploration = New Label()
        lblEndurance = New Label()
        lblDiscretion = New Label()
        lblPenArmure = New Label()
        lblDivers = New Label()
        lblModRacial = New Label()
        lblModCaracDiplomatie = New Label()
        lblModCaracConnDeLaRue = New Label()
        lblModCaracBluff = New Label()
        lblModCaracAthletisme = New Label()
        lblModCaracAcrobaties = New Label()
        lblModCaracArcanes = New Label()
        lblDemiNiveauDiplomatie = New Label()
        lblDemiNiveauConnDeLaRue = New Label()
        lblDemiNiveauBluff = New Label()
        lblDemiNiveauAthletisme = New Label()
        lblDemiNiveauAcrobaties = New Label()
        lblDemiNiveauArcanes = New Label()
        lblFormation = New Label()
        Label21 = New Label()
        lblDemiNiveau = New Label()
        lblDiplomatie = New Label()
        lblConnDeLaRue = New Label()
        lblBluff = New Label()
        lblAthletisme = New Label()
        lblArcanes = New Label()
        lblAcrobaties = New Label()
        tabCaracteristique = New TabPage()
        lblCharismeAffichage = New Label()
        lblSagesseAffichage = New Label()
        lblIntelligenceAffichage = New Label()
        lblDexteriteAffichage = New Label()
        lblForceAffichage = New Label()
        lblConstitutionAffichage = New Label()
        lblModClasseVolonte = New Label()
        lblModClasseVigueur = New Label()
        lblModClasseReflexes = New Label()
        lblModClasseCA = New Label()
        lblModClasseSauvegardes = New Label()
        lblTotalVolonte = New Label()
        lblTotalVigueur = New Label()
        lblTotalCA = New Label()
        lblTotalReflexes = New Label()
        lblTotalSauvegardes = New Label()
        lblPenArmureVolonte = New Label()
        lblDiversVolonte = New Label()
        lblModRacialVolonte = New Label()
        lblPenArmureVigueur = New Label()
        lblDiversVigueur = New Label()
        lblModRacialVigueur = New Label()
        lblPenArmureReflexes = New Label()
        lblDiversReflexes = New Label()
        lblModRacialReflexes = New Label()
        lblPenArmureCA = New Label()
        lblDiversCA = New Label()
        lblModRacialCA = New Label()
        lblPenArmureSauvegardes = New Label()
        lblDiversSauvegardes = New Label()
        lblModRacialSauvegardes = New Label()
        lblModCaracVolonte = New Label()
        lblModCaracVigueur = New Label()
        lblModCaracCA = New Label()
        lblModCaracReflexes = New Label()
        lblDemiNiveauVolonte = New Label()
        lblDemiNiveauVigueur = New Label()
        lblDemiNiveauCA = New Label()
        lblDemiNiveauReflexes = New Label()
        lblModCaracSauvegardes = New Label()
        lblDemiNiveauSauvegardes = New Label()
        lblVolonte = New Label()
        lblVigueur = New Label()
        lblReflexes = New Label()
        lblClasseArmure = New Label()
        lblModCalculCharisme = New Label()
        lblModCalculSagesse = New Label()
        lblModCalculIntelligence = New Label()
        lblModCalculDexterite = New Label()
        lblModCalculForce = New Label()
        lblModCalculConstitution = New Label()
        lblValCalculCharisme = New Label()
        lblValCalculSagesse = New Label()
        lblValCalculIntelligence = New Label()
        lblValCalculDexterite = New Label()
        lblValCalculForce = New Label()
        lblValCalculConstitution = New Label()
        lblModRaceCharisme = New Label()
        lblModRaceSagesse = New Label()
        lblModRaceIntelligence = New Label()
        lblModRaceDexterite = New Label()
        lblModRaceForce = New Label()
        lblModRaceConstitution = New Label()
        Label1 = New Label()
        lblValeurCalcul = New Label()
        lblModRace = New Label()
        lblBase = New Label()
        lblCharisme = New Label()
        lblSagesse = New Label()
        lblIntelligence = New Label()
        lblDexterite = New Label()
        lblConstitution = New Label()
        lblForce = New Label()
        tabGlobal = New TabControl()
        lblPointExperienceAffichage = New Label()
        lblNomPersonnageAffichage = New Label()
        lblClassePersoAffichage = New Label()
        lblRacePersoAffichage = New Label()
        lblPerilAffichage = New Label()
        lblPeril = New Label()
        tabCompetences.SuspendLayout()
        tabCaracteristique.SuspendLayout()
        tabGlobal.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblNomPersonnage
        ' 
        lblNomPersonnage.AutoSize = True
        lblNomPersonnage.Location = New Point(15, 42)
        lblNomPersonnage.Name = "lblNomPersonnage"
        lblNomPersonnage.Size = New Size(116, 15)
        lblNomPersonnage.TabIndex = 1
        lblNomPersonnage.Text = "Nom du Personnage"
        ' 
        ' lblClassePersonnage
        ' 
        lblClassePersonnage.AutoSize = True
        lblClassePersonnage.Location = New Point(15, 70)
        lblClassePersonnage.Name = "lblClassePersonnage"
        lblClassePersonnage.Size = New Size(122, 15)
        lblClassePersonnage.TabIndex = 2
        lblClassePersonnage.Text = "Classe du Personnage"
        ' 
        ' lblRacePersonnage
        ' 
        lblRacePersonnage.AutoSize = True
        lblRacePersonnage.Location = New Point(349, 70)
        lblRacePersonnage.Name = "lblRacePersonnage"
        lblRacePersonnage.Size = New Size(114, 15)
        lblRacePersonnage.TabIndex = 3
        lblRacePersonnage.Text = "Race du Personnage"
        ' 
        ' lblPointExperience
        ' 
        lblPointExperience.AutoSize = True
        lblPointExperience.Location = New Point(489, 42)
        lblPointExperience.Name = "lblPointExperience"
        lblPointExperience.Size = New Size(105, 15)
        lblPointExperience.TabIndex = 11
        lblPointExperience.Text = "Point d'expérience"
        ' 
        ' lblNiveau
        ' 
        lblNiveau.AutoSize = True
        lblNiveau.Location = New Point(350, 42)
        lblNiveau.Name = "lblNiveau"
        lblNiveau.Size = New Size(93, 15)
        lblNiveau.TabIndex = 12
        lblNiveau.Text = "Niveau du perso"
        ' 
        ' lblNiveauCalcul
        ' 
        lblNiveauCalcul.AutoSize = True
        lblNiveauCalcul.Location = New Point(450, 42)
        lblNiveauCalcul.Name = "lblNiveauCalcul"
        lblNiveauCalcul.Size = New Size(13, 15)
        lblNiveauCalcul.TabIndex = 13
        lblNiveauCalcul.Text = "1"
        ' 
        ' btnVoirPerso
        ' 
        btnVoirPerso.Location = New Point(882, 173)
        btnVoirPerso.Margin = New Padding(3, 2, 3, 2)
        btnVoirPerso.Name = "btnVoirPerso"
        btnVoirPerso.Size = New Size(89, 24)
        btnVoirPerso.TabIndex = 14
        btnVoirPerso.Text = "Voir le perso"
        btnVoirPerso.UseVisualStyleBackColor = True
        ' 
        ' lblInitiative
        ' 
        lblInitiative.AutoSize = True
        lblInitiative.Location = New Point(882, 42)
        lblInitiative.Name = "lblInitiative"
        lblInitiative.Size = New Size(52, 15)
        lblInitiative.TabIndex = 16
        lblInitiative.Text = "Initiative"
        ' 
        ' lblInitiativeValeur
        ' 
        lblInitiativeValeur.AutoSize = True
        lblInitiativeValeur.Location = New Point(1005, 43)
        lblInitiativeValeur.Name = "lblInitiativeValeur"
        lblInitiativeValeur.Size = New Size(13, 15)
        lblInitiativeValeur.TabIndex = 16
        lblInitiativeValeur.Text = "0"
        ' 
        ' lblPVValeur
        ' 
        lblPVValeur.AutoSize = True
        lblPVValeur.Location = New Point(1005, 74)
        lblPVValeur.Name = "lblPVValeur"
        lblPVValeur.Size = New Size(13, 15)
        lblPVValeur.TabIndex = 17
        lblPVValeur.Text = "0"
        ' 
        ' lblPV
        ' 
        lblPV.AutoSize = True
        lblPV.Location = New Point(882, 73)
        lblPV.Name = "lblPV"
        lblPV.Size = New Size(69, 15)
        lblPV.TabIndex = 18
        lblPV.Text = "Point de vie"
        ' 
        ' ddlListePerso
        ' 
        ddlListePerso.FormattingEnabled = True
        ddlListePerso.Location = New Point(489, 9)
        ddlListePerso.Margin = New Padding(3, 2, 3, 2)
        ddlListePerso.Name = "ddlListePerso"
        ddlListePerso.Size = New Size(713, 23)
        ddlListePerso.TabIndex = 20
        ' 
        ' ddlStuff
        ' 
        ddlStuff.CheckOnClick = True
        ddlStuff.FormattingEnabled = True
        ddlStuff.Location = New Point(867, 288)
        ddlStuff.Name = "ddlStuff"
        ddlStuff.Size = New Size(287, 292)
        ddlStuff.TabIndex = 5
        ' 
        ' tabCompetences
        ' 
        tabCompetences.Controls.Add(chkFormAcrobaties)
        tabCompetences.Controls.Add(chkFormArcanes)
        tabCompetences.Controls.Add(chkFormAthletisme)
        tabCompetences.Controls.Add(chkFormBluff)
        tabCompetences.Controls.Add(chkFormConnDeLaRue)
        tabCompetences.Controls.Add(chkFormDiplomatie)
        tabCompetences.Controls.Add(chkFormDiscretion)
        tabCompetences.Controls.Add(chkFormEndurance)
        tabCompetences.Controls.Add(chkFormExploration)
        tabCompetences.Controls.Add(chkFormHistoire)
        tabCompetences.Controls.Add(chkFormIntimidation)
        tabCompetences.Controls.Add(chkFormIntuition)
        tabCompetences.Controls.Add(chkFormLarcin)
        tabCompetences.Controls.Add(chkFormNature)
        tabCompetences.Controls.Add(chkFormPerception)
        tabCompetences.Controls.Add(chkFormReligion)
        tabCompetences.Controls.Add(chkFormSoins)
        tabCompetences.Controls.Add(lblTotalSoins)
        tabCompetences.Controls.Add(lblTotalReligion)
        tabCompetences.Controls.Add(lblTotalPerception)
        tabCompetences.Controls.Add(lblTotalNature)
        tabCompetences.Controls.Add(lblTotalLarcin)
        tabCompetences.Controls.Add(lblTotalIntuition)
        tabCompetences.Controls.Add(lblTotalIntimidation)
        tabCompetences.Controls.Add(lblTotalHistoire)
        tabCompetences.Controls.Add(lblTotalExploration)
        tabCompetences.Controls.Add(lblTotalEndurance)
        tabCompetences.Controls.Add(lblTotalDiscretion)
        tabCompetences.Controls.Add(lblTotalDiplomatie)
        tabCompetences.Controls.Add(lblTotalConnDeLaRue)
        tabCompetences.Controls.Add(lblTotalBluff)
        tabCompetences.Controls.Add(lblTotalAthletisme)
        tabCompetences.Controls.Add(lblTotalAcrobaties)
        tabCompetences.Controls.Add(lblTotalArcanes)
        tabCompetences.Controls.Add(lblTotal)
        tabCompetences.Controls.Add(lblPenArmureSoins)
        tabCompetences.Controls.Add(lblDiversSoins)
        tabCompetences.Controls.Add(lblModRacialSoins)
        tabCompetences.Controls.Add(lblModCaracSoins)
        tabCompetences.Controls.Add(lblDemiNiveauSoins)
        tabCompetences.Controls.Add(lblPenArmureReligion)
        tabCompetences.Controls.Add(lblDiversReligion)
        tabCompetences.Controls.Add(lblModRacialReligion)
        tabCompetences.Controls.Add(lblModCaracReligion)
        tabCompetences.Controls.Add(lblDemiNiveauReligion)
        tabCompetences.Controls.Add(lblPenArmurePerception)
        tabCompetences.Controls.Add(lblDiversPerception)
        tabCompetences.Controls.Add(lblModRacialPerception)
        tabCompetences.Controls.Add(lblModCaracPerception)
        tabCompetences.Controls.Add(lblDemiNiveauPerception)
        tabCompetences.Controls.Add(lblPenArmureNature)
        tabCompetences.Controls.Add(lblDiversNature)
        tabCompetences.Controls.Add(lblModRacialNature)
        tabCompetences.Controls.Add(lblModCaracNature)
        tabCompetences.Controls.Add(lblDemiNiveauNature)
        tabCompetences.Controls.Add(lblPenArmureLarcin)
        tabCompetences.Controls.Add(lblDiversLarcin)
        tabCompetences.Controls.Add(lblModRacialLarcin)
        tabCompetences.Controls.Add(lblModCaracLarcin)
        tabCompetences.Controls.Add(lblDemiNiveauLarcin)
        tabCompetences.Controls.Add(lblPenArmureIntuition)
        tabCompetences.Controls.Add(lblDiversIntuition)
        tabCompetences.Controls.Add(lblModRacialIntuition)
        tabCompetences.Controls.Add(lblModCaracIntuition)
        tabCompetences.Controls.Add(lblDemiNiveauIntuition)
        tabCompetences.Controls.Add(lblPenArmureIntimidation)
        tabCompetences.Controls.Add(lblDiversIntimidation)
        tabCompetences.Controls.Add(lblModRacialIntimidation)
        tabCompetences.Controls.Add(lblModCaracIntimidation)
        tabCompetences.Controls.Add(lblDemiNiveauIntimidation)
        tabCompetences.Controls.Add(lblPenArmureHistoire)
        tabCompetences.Controls.Add(lblDiversHistoire)
        tabCompetences.Controls.Add(lblModRacialHistoire)
        tabCompetences.Controls.Add(lblModCaracHistoire)
        tabCompetences.Controls.Add(lblDemiNiveauHistoire)
        tabCompetences.Controls.Add(lblPenArmureExploration)
        tabCompetences.Controls.Add(lblDiversExploration)
        tabCompetences.Controls.Add(lblModRacialExploration)
        tabCompetences.Controls.Add(lblModCaracExploration)
        tabCompetences.Controls.Add(lblDemiNiveauExploration)
        tabCompetences.Controls.Add(lblPenArmureEndurance)
        tabCompetences.Controls.Add(lblDiversEndurance)
        tabCompetences.Controls.Add(lblModRacialEndurance)
        tabCompetences.Controls.Add(lblModCaracEndurance)
        tabCompetences.Controls.Add(lblDemiNiveauEndurance)
        tabCompetences.Controls.Add(lblPenArmureDiscretion)
        tabCompetences.Controls.Add(lblDiversDiscretion)
        tabCompetences.Controls.Add(lblModRacialDiscretion)
        tabCompetences.Controls.Add(lblModCaracDiscretion)
        tabCompetences.Controls.Add(lblDemiNiveauDiscretion)
        tabCompetences.Controls.Add(lblPenArmureDiplomatie)
        tabCompetences.Controls.Add(lblDiversDiplomatie)
        tabCompetences.Controls.Add(lblModRacialDiplomatie)
        tabCompetences.Controls.Add(lblPenArmureConnDeLaRue)
        tabCompetences.Controls.Add(lblDiversConnDeLaRue)
        tabCompetences.Controls.Add(lblModRacialConnDeLarue)
        tabCompetences.Controls.Add(lblPenArmureBluff)
        tabCompetences.Controls.Add(lblDiversBluff)
        tabCompetences.Controls.Add(lblModRacialBluff)
        tabCompetences.Controls.Add(lblPenArmureAthletisme)
        tabCompetences.Controls.Add(lblDiversAthletisme)
        tabCompetences.Controls.Add(lblModRacialAthletisme)
        tabCompetences.Controls.Add(lblPenArmureArcanes)
        tabCompetences.Controls.Add(lblDiversArcanes)
        tabCompetences.Controls.Add(lblModRacialArcanes)
        tabCompetences.Controls.Add(lblPenArmureAcrobaties)
        tabCompetences.Controls.Add(lblDiversAcrobaties)
        tabCompetences.Controls.Add(lblModRacialAcrobaties)
        tabCompetences.Controls.Add(lblSoins)
        tabCompetences.Controls.Add(lblReligion)
        tabCompetences.Controls.Add(lblPerception)
        tabCompetences.Controls.Add(lblNature)
        tabCompetences.Controls.Add(lblLarcin)
        tabCompetences.Controls.Add(lblIntuition)
        tabCompetences.Controls.Add(lblIntimidation)
        tabCompetences.Controls.Add(lblHistoire)
        tabCompetences.Controls.Add(lblExploration)
        tabCompetences.Controls.Add(lblEndurance)
        tabCompetences.Controls.Add(lblDiscretion)
        tabCompetences.Controls.Add(lblPenArmure)
        tabCompetences.Controls.Add(lblDivers)
        tabCompetences.Controls.Add(lblModRacial)
        tabCompetences.Controls.Add(lblModCaracDiplomatie)
        tabCompetences.Controls.Add(lblModCaracConnDeLaRue)
        tabCompetences.Controls.Add(lblModCaracBluff)
        tabCompetences.Controls.Add(lblModCaracAthletisme)
        tabCompetences.Controls.Add(lblModCaracAcrobaties)
        tabCompetences.Controls.Add(lblModCaracArcanes)
        tabCompetences.Controls.Add(lblDemiNiveauDiplomatie)
        tabCompetences.Controls.Add(lblDemiNiveauConnDeLaRue)
        tabCompetences.Controls.Add(lblDemiNiveauBluff)
        tabCompetences.Controls.Add(lblDemiNiveauAthletisme)
        tabCompetences.Controls.Add(lblDemiNiveauAcrobaties)
        tabCompetences.Controls.Add(lblDemiNiveauArcanes)
        tabCompetences.Controls.Add(lblFormation)
        tabCompetences.Controls.Add(Label21)
        tabCompetences.Controls.Add(lblDemiNiveau)
        tabCompetences.Controls.Add(lblDiplomatie)
        tabCompetences.Controls.Add(lblConnDeLaRue)
        tabCompetences.Controls.Add(lblBluff)
        tabCompetences.Controls.Add(lblAthletisme)
        tabCompetences.Controls.Add(lblArcanes)
        tabCompetences.Controls.Add(lblAcrobaties)
        tabCompetences.Location = New Point(4, 24)
        tabCompetences.Name = "tabCompetences"
        tabCompetences.Padding = New Padding(3)
        tabCompetences.Size = New Size(798, 496)
        tabCompetences.TabIndex = 1
        tabCompetences.Text = "Compétences"
        tabCompetences.UseVisualStyleBackColor = True
        ' 
        ' chkFormAcrobaties
        ' 
        chkFormAcrobaties.AutoSize = True
        chkFormAcrobaties.Location = New Point(423, 38)
        chkFormAcrobaties.Margin = New Padding(3, 2, 3, 2)
        chkFormAcrobaties.Name = "chkFormAcrobaties"
        chkFormAcrobaties.Size = New Size(15, 14)
        chkFormAcrobaties.TabIndex = 219
        chkFormAcrobaties.UseVisualStyleBackColor = True
        ' 
        ' chkFormArcanes
        ' 
        chkFormArcanes.AutoSize = True
        chkFormArcanes.Location = New Point(423, 65)
        chkFormArcanes.Margin = New Padding(3, 2, 3, 2)
        chkFormArcanes.Name = "chkFormArcanes"
        chkFormArcanes.Size = New Size(15, 14)
        chkFormArcanes.TabIndex = 220
        chkFormArcanes.UseVisualStyleBackColor = True
        ' 
        ' chkFormAthletisme
        ' 
        chkFormAthletisme.AutoSize = True
        chkFormAthletisme.Location = New Point(423, 94)
        chkFormAthletisme.Margin = New Padding(3, 2, 3, 2)
        chkFormAthletisme.Name = "chkFormAthletisme"
        chkFormAthletisme.Size = New Size(15, 14)
        chkFormAthletisme.TabIndex = 221
        chkFormAthletisme.UseVisualStyleBackColor = True
        ' 
        ' chkFormBluff
        ' 
        chkFormBluff.AutoSize = True
        chkFormBluff.Location = New Point(423, 122)
        chkFormBluff.Margin = New Padding(3, 2, 3, 2)
        chkFormBluff.Name = "chkFormBluff"
        chkFormBluff.Size = New Size(15, 14)
        chkFormBluff.TabIndex = 222
        chkFormBluff.UseVisualStyleBackColor = True
        ' 
        ' chkFormConnDeLaRue
        ' 
        chkFormConnDeLaRue.AutoSize = True
        chkFormConnDeLaRue.Location = New Point(423, 150)
        chkFormConnDeLaRue.Margin = New Padding(3, 2, 3, 2)
        chkFormConnDeLaRue.Name = "chkFormConnDeLaRue"
        chkFormConnDeLaRue.Size = New Size(15, 14)
        chkFormConnDeLaRue.TabIndex = 222
        chkFormConnDeLaRue.UseVisualStyleBackColor = True
        ' 
        ' chkFormDiplomatie
        ' 
        chkFormDiplomatie.AutoSize = True
        chkFormDiplomatie.Location = New Point(423, 178)
        chkFormDiplomatie.Margin = New Padding(3, 2, 3, 2)
        chkFormDiplomatie.Name = "chkFormDiplomatie"
        chkFormDiplomatie.Size = New Size(15, 14)
        chkFormDiplomatie.TabIndex = 222
        chkFormDiplomatie.UseVisualStyleBackColor = True
        ' 
        ' chkFormDiscretion
        ' 
        chkFormDiscretion.AutoSize = True
        chkFormDiscretion.Location = New Point(423, 204)
        chkFormDiscretion.Margin = New Padding(3, 2, 3, 2)
        chkFormDiscretion.Name = "chkFormDiscretion"
        chkFormDiscretion.Size = New Size(15, 14)
        chkFormDiscretion.TabIndex = 222
        chkFormDiscretion.UseVisualStyleBackColor = True
        ' 
        ' chkFormEndurance
        ' 
        chkFormEndurance.AutoSize = True
        chkFormEndurance.Location = New Point(423, 231)
        chkFormEndurance.Margin = New Padding(3, 2, 3, 2)
        chkFormEndurance.Name = "chkFormEndurance"
        chkFormEndurance.Size = New Size(15, 14)
        chkFormEndurance.TabIndex = 222
        chkFormEndurance.UseVisualStyleBackColor = True
        ' 
        ' chkFormExploration
        ' 
        chkFormExploration.AutoSize = True
        chkFormExploration.Location = New Point(423, 258)
        chkFormExploration.Margin = New Padding(3, 2, 3, 2)
        chkFormExploration.Name = "chkFormExploration"
        chkFormExploration.Size = New Size(15, 14)
        chkFormExploration.TabIndex = 222
        chkFormExploration.UseVisualStyleBackColor = True
        ' 
        ' chkFormHistoire
        ' 
        chkFormHistoire.AutoSize = True
        chkFormHistoire.Location = New Point(423, 283)
        chkFormHistoire.Margin = New Padding(3, 2, 3, 2)
        chkFormHistoire.Name = "chkFormHistoire"
        chkFormHistoire.Size = New Size(15, 14)
        chkFormHistoire.TabIndex = 222
        chkFormHistoire.UseVisualStyleBackColor = True
        ' 
        ' chkFormIntimidation
        ' 
        chkFormIntimidation.AutoSize = True
        chkFormIntimidation.Location = New Point(423, 307)
        chkFormIntimidation.Margin = New Padding(3, 2, 3, 2)
        chkFormIntimidation.Name = "chkFormIntimidation"
        chkFormIntimidation.Size = New Size(15, 14)
        chkFormIntimidation.TabIndex = 222
        chkFormIntimidation.UseVisualStyleBackColor = True
        ' 
        ' chkFormIntuition
        ' 
        chkFormIntuition.AutoSize = True
        chkFormIntuition.Location = New Point(423, 332)
        chkFormIntuition.Margin = New Padding(3, 2, 3, 2)
        chkFormIntuition.Name = "chkFormIntuition"
        chkFormIntuition.Size = New Size(15, 14)
        chkFormIntuition.TabIndex = 222
        chkFormIntuition.UseVisualStyleBackColor = True
        ' 
        ' chkFormLarcin
        ' 
        chkFormLarcin.AutoSize = True
        chkFormLarcin.Location = New Point(423, 359)
        chkFormLarcin.Margin = New Padding(3, 2, 3, 2)
        chkFormLarcin.Name = "chkFormLarcin"
        chkFormLarcin.Size = New Size(15, 14)
        chkFormLarcin.TabIndex = 222
        chkFormLarcin.UseVisualStyleBackColor = True
        ' 
        ' chkFormNature
        ' 
        chkFormNature.AutoSize = True
        chkFormNature.Location = New Point(423, 382)
        chkFormNature.Margin = New Padding(3, 2, 3, 2)
        chkFormNature.Name = "chkFormNature"
        chkFormNature.Size = New Size(15, 14)
        chkFormNature.TabIndex = 222
        chkFormNature.UseVisualStyleBackColor = True
        ' 
        ' chkFormPerception
        ' 
        chkFormPerception.AutoSize = True
        chkFormPerception.Location = New Point(423, 409)
        chkFormPerception.Margin = New Padding(3, 2, 3, 2)
        chkFormPerception.Name = "chkFormPerception"
        chkFormPerception.Size = New Size(15, 14)
        chkFormPerception.TabIndex = 222
        chkFormPerception.UseVisualStyleBackColor = True
        ' 
        ' chkFormReligion
        ' 
        chkFormReligion.AutoSize = True
        chkFormReligion.Location = New Point(423, 431)
        chkFormReligion.Margin = New Padding(3, 2, 3, 2)
        chkFormReligion.Name = "chkFormReligion"
        chkFormReligion.Size = New Size(15, 14)
        chkFormReligion.TabIndex = 222
        chkFormReligion.UseVisualStyleBackColor = True
        ' 
        ' chkFormSoins
        ' 
        chkFormSoins.AutoSize = True
        chkFormSoins.Location = New Point(423, 459)
        chkFormSoins.Margin = New Padding(3, 2, 3, 2)
        chkFormSoins.Name = "chkFormSoins"
        chkFormSoins.Size = New Size(15, 14)
        chkFormSoins.TabIndex = 222
        chkFormSoins.UseVisualStyleBackColor = True
        ' 
        ' lblTotalSoins
        ' 
        lblTotalSoins.AutoSize = True
        lblTotalSoins.Location = New Point(181, 459)
        lblTotalSoins.Name = "lblTotalSoins"
        lblTotalSoins.Size = New Size(13, 15)
        lblTotalSoins.TabIndex = 218
        lblTotalSoins.Text = "0"
        ' 
        ' lblTotalReligion
        ' 
        lblTotalReligion.AutoSize = True
        lblTotalReligion.Location = New Point(181, 431)
        lblTotalReligion.Name = "lblTotalReligion"
        lblTotalReligion.Size = New Size(13, 15)
        lblTotalReligion.TabIndex = 217
        lblTotalReligion.Text = "0"
        ' 
        ' lblTotalPerception
        ' 
        lblTotalPerception.AutoSize = True
        lblTotalPerception.Location = New Point(181, 409)
        lblTotalPerception.Name = "lblTotalPerception"
        lblTotalPerception.Size = New Size(13, 15)
        lblTotalPerception.TabIndex = 216
        lblTotalPerception.Text = "0"
        ' 
        ' lblTotalNature
        ' 
        lblTotalNature.AutoSize = True
        lblTotalNature.Location = New Point(181, 382)
        lblTotalNature.Name = "lblTotalNature"
        lblTotalNature.Size = New Size(13, 15)
        lblTotalNature.TabIndex = 215
        lblTotalNature.Text = "0"
        ' 
        ' lblTotalLarcin
        ' 
        lblTotalLarcin.AutoSize = True
        lblTotalLarcin.Location = New Point(181, 359)
        lblTotalLarcin.Name = "lblTotalLarcin"
        lblTotalLarcin.Size = New Size(13, 15)
        lblTotalLarcin.TabIndex = 214
        lblTotalLarcin.Text = "0"
        ' 
        ' lblTotalIntuition
        ' 
        lblTotalIntuition.AutoSize = True
        lblTotalIntuition.Location = New Point(181, 332)
        lblTotalIntuition.Name = "lblTotalIntuition"
        lblTotalIntuition.Size = New Size(13, 15)
        lblTotalIntuition.TabIndex = 213
        lblTotalIntuition.Text = "0"
        ' 
        ' lblTotalIntimidation
        ' 
        lblTotalIntimidation.AutoSize = True
        lblTotalIntimidation.Location = New Point(181, 307)
        lblTotalIntimidation.Name = "lblTotalIntimidation"
        lblTotalIntimidation.Size = New Size(13, 15)
        lblTotalIntimidation.TabIndex = 212
        lblTotalIntimidation.Text = "0"
        ' 
        ' lblTotalHistoire
        ' 
        lblTotalHistoire.AutoSize = True
        lblTotalHistoire.Location = New Point(181, 283)
        lblTotalHistoire.Name = "lblTotalHistoire"
        lblTotalHistoire.Size = New Size(13, 15)
        lblTotalHistoire.TabIndex = 211
        lblTotalHistoire.Text = "0"
        ' 
        ' lblTotalExploration
        ' 
        lblTotalExploration.AutoSize = True
        lblTotalExploration.Location = New Point(181, 258)
        lblTotalExploration.Name = "lblTotalExploration"
        lblTotalExploration.Size = New Size(13, 15)
        lblTotalExploration.TabIndex = 210
        lblTotalExploration.Text = "0"
        ' 
        ' lblTotalEndurance
        ' 
        lblTotalEndurance.AutoSize = True
        lblTotalEndurance.Location = New Point(181, 231)
        lblTotalEndurance.Name = "lblTotalEndurance"
        lblTotalEndurance.Size = New Size(13, 15)
        lblTotalEndurance.TabIndex = 209
        lblTotalEndurance.Text = "0"
        ' 
        ' lblTotalDiscretion
        ' 
        lblTotalDiscretion.AutoSize = True
        lblTotalDiscretion.Location = New Point(181, 204)
        lblTotalDiscretion.Name = "lblTotalDiscretion"
        lblTotalDiscretion.Size = New Size(13, 15)
        lblTotalDiscretion.TabIndex = 208
        lblTotalDiscretion.Text = "0"
        ' 
        ' lblTotalDiplomatie
        ' 
        lblTotalDiplomatie.AutoSize = True
        lblTotalDiplomatie.Location = New Point(181, 178)
        lblTotalDiplomatie.Name = "lblTotalDiplomatie"
        lblTotalDiplomatie.Size = New Size(13, 15)
        lblTotalDiplomatie.TabIndex = 207
        lblTotalDiplomatie.Text = "0"
        ' 
        ' lblTotalConnDeLaRue
        ' 
        lblTotalConnDeLaRue.AutoSize = True
        lblTotalConnDeLaRue.Location = New Point(181, 150)
        lblTotalConnDeLaRue.Name = "lblTotalConnDeLaRue"
        lblTotalConnDeLaRue.Size = New Size(13, 15)
        lblTotalConnDeLaRue.TabIndex = 206
        lblTotalConnDeLaRue.Text = "0"
        ' 
        ' lblTotalBluff
        ' 
        lblTotalBluff.AutoSize = True
        lblTotalBluff.Location = New Point(181, 122)
        lblTotalBluff.Name = "lblTotalBluff"
        lblTotalBluff.Size = New Size(13, 15)
        lblTotalBluff.TabIndex = 205
        lblTotalBluff.Text = "0"
        ' 
        ' lblTotalAthletisme
        ' 
        lblTotalAthletisme.AutoSize = True
        lblTotalAthletisme.Location = New Point(181, 94)
        lblTotalAthletisme.Name = "lblTotalAthletisme"
        lblTotalAthletisme.Size = New Size(13, 15)
        lblTotalAthletisme.TabIndex = 204
        lblTotalAthletisme.Text = "0"
        ' 
        ' lblTotalAcrobaties
        ' 
        lblTotalAcrobaties.AutoSize = True
        lblTotalAcrobaties.Location = New Point(181, 38)
        lblTotalAcrobaties.Name = "lblTotalAcrobaties"
        lblTotalAcrobaties.Size = New Size(13, 15)
        lblTotalAcrobaties.TabIndex = 203
        lblTotalAcrobaties.Text = "0"
        ' 
        ' lblTotalArcanes
        ' 
        lblTotalArcanes.AutoSize = True
        lblTotalArcanes.Location = New Point(181, 65)
        lblTotalArcanes.Name = "lblTotalArcanes"
        lblTotalArcanes.Size = New Size(13, 15)
        lblTotalArcanes.TabIndex = 202
        lblTotalArcanes.Text = "0"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(158, 10)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(32, 15)
        lblTotal.TabIndex = 201
        lblTotal.Text = "Total"
        ' 
        ' lblPenArmureSoins
        ' 
        lblPenArmureSoins.AutoSize = True
        lblPenArmureSoins.Location = New Point(641, 459)
        lblPenArmureSoins.Name = "lblPenArmureSoins"
        lblPenArmureSoins.Size = New Size(13, 15)
        lblPenArmureSoins.TabIndex = 200
        lblPenArmureSoins.Text = "0"
        ' 
        ' lblDiversSoins
        ' 
        lblDiversSoins.AutoSize = True
        lblDiversSoins.Location = New Point(568, 459)
        lblDiversSoins.Name = "lblDiversSoins"
        lblDiversSoins.Size = New Size(13, 15)
        lblDiversSoins.TabIndex = 199
        lblDiversSoins.Text = "0"
        ' 
        ' lblModRacialSoins
        ' 
        lblModRacialSoins.AutoSize = True
        lblModRacialSoins.Location = New Point(496, 459)
        lblModRacialSoins.Name = "lblModRacialSoins"
        lblModRacialSoins.Size = New Size(13, 15)
        lblModRacialSoins.TabIndex = 198
        lblModRacialSoins.Text = "0"
        ' 
        ' lblModCaracSoins
        ' 
        lblModCaracSoins.AutoSize = True
        lblModCaracSoins.Location = New Point(342, 459)
        lblModCaracSoins.Name = "lblModCaracSoins"
        lblModCaracSoins.Size = New Size(13, 15)
        lblModCaracSoins.TabIndex = 196
        lblModCaracSoins.Text = "0"
        ' 
        ' lblDemiNiveauSoins
        ' 
        lblDemiNiveauSoins.AutoSize = True
        lblDemiNiveauSoins.Location = New Point(262, 459)
        lblDemiNiveauSoins.Name = "lblDemiNiveauSoins"
        lblDemiNiveauSoins.Size = New Size(13, 15)
        lblDemiNiveauSoins.TabIndex = 195
        lblDemiNiveauSoins.Text = "0"
        ' 
        ' lblPenArmureReligion
        ' 
        lblPenArmureReligion.AutoSize = True
        lblPenArmureReligion.Location = New Point(641, 431)
        lblPenArmureReligion.Name = "lblPenArmureReligion"
        lblPenArmureReligion.Size = New Size(13, 15)
        lblPenArmureReligion.TabIndex = 194
        lblPenArmureReligion.Text = "0"
        ' 
        ' lblDiversReligion
        ' 
        lblDiversReligion.AutoSize = True
        lblDiversReligion.Location = New Point(568, 431)
        lblDiversReligion.Name = "lblDiversReligion"
        lblDiversReligion.Size = New Size(13, 15)
        lblDiversReligion.TabIndex = 193
        lblDiversReligion.Text = "0"
        ' 
        ' lblModRacialReligion
        ' 
        lblModRacialReligion.AutoSize = True
        lblModRacialReligion.Location = New Point(496, 431)
        lblModRacialReligion.Name = "lblModRacialReligion"
        lblModRacialReligion.Size = New Size(13, 15)
        lblModRacialReligion.TabIndex = 192
        lblModRacialReligion.Text = "0"
        ' 
        ' lblModCaracReligion
        ' 
        lblModCaracReligion.AutoSize = True
        lblModCaracReligion.Location = New Point(342, 431)
        lblModCaracReligion.Name = "lblModCaracReligion"
        lblModCaracReligion.Size = New Size(13, 15)
        lblModCaracReligion.TabIndex = 190
        lblModCaracReligion.Text = "0"
        ' 
        ' lblDemiNiveauReligion
        ' 
        lblDemiNiveauReligion.AutoSize = True
        lblDemiNiveauReligion.Location = New Point(262, 431)
        lblDemiNiveauReligion.Name = "lblDemiNiveauReligion"
        lblDemiNiveauReligion.Size = New Size(13, 15)
        lblDemiNiveauReligion.TabIndex = 189
        lblDemiNiveauReligion.Text = "0"
        ' 
        ' lblPenArmurePerception
        ' 
        lblPenArmurePerception.AutoSize = True
        lblPenArmurePerception.Location = New Point(641, 409)
        lblPenArmurePerception.Name = "lblPenArmurePerception"
        lblPenArmurePerception.Size = New Size(13, 15)
        lblPenArmurePerception.TabIndex = 188
        lblPenArmurePerception.Text = "0"
        ' 
        ' lblDiversPerception
        ' 
        lblDiversPerception.AutoSize = True
        lblDiversPerception.Location = New Point(568, 409)
        lblDiversPerception.Name = "lblDiversPerception"
        lblDiversPerception.Size = New Size(13, 15)
        lblDiversPerception.TabIndex = 187
        lblDiversPerception.Text = "0"
        ' 
        ' lblModRacialPerception
        ' 
        lblModRacialPerception.AutoSize = True
        lblModRacialPerception.Location = New Point(496, 409)
        lblModRacialPerception.Name = "lblModRacialPerception"
        lblModRacialPerception.Size = New Size(13, 15)
        lblModRacialPerception.TabIndex = 186
        lblModRacialPerception.Text = "0"
        ' 
        ' lblModCaracPerception
        ' 
        lblModCaracPerception.AutoSize = True
        lblModCaracPerception.Location = New Point(342, 409)
        lblModCaracPerception.Name = "lblModCaracPerception"
        lblModCaracPerception.Size = New Size(13, 15)
        lblModCaracPerception.TabIndex = 184
        lblModCaracPerception.Text = "0"
        ' 
        ' lblDemiNiveauPerception
        ' 
        lblDemiNiveauPerception.AutoSize = True
        lblDemiNiveauPerception.Location = New Point(262, 409)
        lblDemiNiveauPerception.Name = "lblDemiNiveauPerception"
        lblDemiNiveauPerception.Size = New Size(13, 15)
        lblDemiNiveauPerception.TabIndex = 183
        lblDemiNiveauPerception.Text = "0"
        ' 
        ' lblPenArmureNature
        ' 
        lblPenArmureNature.AutoSize = True
        lblPenArmureNature.Location = New Point(641, 382)
        lblPenArmureNature.Name = "lblPenArmureNature"
        lblPenArmureNature.Size = New Size(13, 15)
        lblPenArmureNature.TabIndex = 182
        lblPenArmureNature.Text = "0"
        ' 
        ' lblDiversNature
        ' 
        lblDiversNature.AutoSize = True
        lblDiversNature.Location = New Point(568, 382)
        lblDiversNature.Name = "lblDiversNature"
        lblDiversNature.Size = New Size(13, 15)
        lblDiversNature.TabIndex = 181
        lblDiversNature.Text = "0"
        ' 
        ' lblModRacialNature
        ' 
        lblModRacialNature.AutoSize = True
        lblModRacialNature.Location = New Point(496, 382)
        lblModRacialNature.Name = "lblModRacialNature"
        lblModRacialNature.Size = New Size(13, 15)
        lblModRacialNature.TabIndex = 180
        lblModRacialNature.Text = "0"
        ' 
        ' lblModCaracNature
        ' 
        lblModCaracNature.AutoSize = True
        lblModCaracNature.Location = New Point(342, 382)
        lblModCaracNature.Name = "lblModCaracNature"
        lblModCaracNature.Size = New Size(13, 15)
        lblModCaracNature.TabIndex = 178
        lblModCaracNature.Text = "0"
        ' 
        ' lblDemiNiveauNature
        ' 
        lblDemiNiveauNature.AutoSize = True
        lblDemiNiveauNature.Location = New Point(262, 382)
        lblDemiNiveauNature.Name = "lblDemiNiveauNature"
        lblDemiNiveauNature.Size = New Size(13, 15)
        lblDemiNiveauNature.TabIndex = 177
        lblDemiNiveauNature.Text = "0"
        ' 
        ' lblPenArmureLarcin
        ' 
        lblPenArmureLarcin.AutoSize = True
        lblPenArmureLarcin.Location = New Point(641, 359)
        lblPenArmureLarcin.Name = "lblPenArmureLarcin"
        lblPenArmureLarcin.Size = New Size(13, 15)
        lblPenArmureLarcin.TabIndex = 176
        lblPenArmureLarcin.Text = "0"
        ' 
        ' lblDiversLarcin
        ' 
        lblDiversLarcin.AutoSize = True
        lblDiversLarcin.Location = New Point(568, 359)
        lblDiversLarcin.Name = "lblDiversLarcin"
        lblDiversLarcin.Size = New Size(13, 15)
        lblDiversLarcin.TabIndex = 175
        lblDiversLarcin.Text = "0"
        ' 
        ' lblModRacialLarcin
        ' 
        lblModRacialLarcin.AutoSize = True
        lblModRacialLarcin.Location = New Point(496, 359)
        lblModRacialLarcin.Name = "lblModRacialLarcin"
        lblModRacialLarcin.Size = New Size(13, 15)
        lblModRacialLarcin.TabIndex = 174
        lblModRacialLarcin.Text = "0"
        ' 
        ' lblModCaracLarcin
        ' 
        lblModCaracLarcin.AutoSize = True
        lblModCaracLarcin.Location = New Point(342, 359)
        lblModCaracLarcin.Name = "lblModCaracLarcin"
        lblModCaracLarcin.Size = New Size(13, 15)
        lblModCaracLarcin.TabIndex = 172
        lblModCaracLarcin.Text = "0"
        ' 
        ' lblDemiNiveauLarcin
        ' 
        lblDemiNiveauLarcin.AutoSize = True
        lblDemiNiveauLarcin.Location = New Point(262, 359)
        lblDemiNiveauLarcin.Name = "lblDemiNiveauLarcin"
        lblDemiNiveauLarcin.Size = New Size(13, 15)
        lblDemiNiveauLarcin.TabIndex = 171
        lblDemiNiveauLarcin.Text = "0"
        ' 
        ' lblPenArmureIntuition
        ' 
        lblPenArmureIntuition.AutoSize = True
        lblPenArmureIntuition.Location = New Point(641, 332)
        lblPenArmureIntuition.Name = "lblPenArmureIntuition"
        lblPenArmureIntuition.Size = New Size(13, 15)
        lblPenArmureIntuition.TabIndex = 170
        lblPenArmureIntuition.Text = "0"
        ' 
        ' lblDiversIntuition
        ' 
        lblDiversIntuition.AutoSize = True
        lblDiversIntuition.Location = New Point(568, 332)
        lblDiversIntuition.Name = "lblDiversIntuition"
        lblDiversIntuition.Size = New Size(13, 15)
        lblDiversIntuition.TabIndex = 169
        lblDiversIntuition.Text = "0"
        ' 
        ' lblModRacialIntuition
        ' 
        lblModRacialIntuition.AutoSize = True
        lblModRacialIntuition.Location = New Point(496, 332)
        lblModRacialIntuition.Name = "lblModRacialIntuition"
        lblModRacialIntuition.Size = New Size(13, 15)
        lblModRacialIntuition.TabIndex = 168
        lblModRacialIntuition.Text = "0"
        ' 
        ' lblModCaracIntuition
        ' 
        lblModCaracIntuition.AutoSize = True
        lblModCaracIntuition.Location = New Point(342, 332)
        lblModCaracIntuition.Name = "lblModCaracIntuition"
        lblModCaracIntuition.Size = New Size(13, 15)
        lblModCaracIntuition.TabIndex = 166
        lblModCaracIntuition.Text = "0"
        ' 
        ' lblDemiNiveauIntuition
        ' 
        lblDemiNiveauIntuition.AutoSize = True
        lblDemiNiveauIntuition.Location = New Point(262, 332)
        lblDemiNiveauIntuition.Name = "lblDemiNiveauIntuition"
        lblDemiNiveauIntuition.Size = New Size(13, 15)
        lblDemiNiveauIntuition.TabIndex = 165
        lblDemiNiveauIntuition.Text = "0"
        ' 
        ' lblPenArmureIntimidation
        ' 
        lblPenArmureIntimidation.AutoSize = True
        lblPenArmureIntimidation.Location = New Point(641, 307)
        lblPenArmureIntimidation.Name = "lblPenArmureIntimidation"
        lblPenArmureIntimidation.Size = New Size(13, 15)
        lblPenArmureIntimidation.TabIndex = 164
        lblPenArmureIntimidation.Text = "0"
        ' 
        ' lblDiversIntimidation
        ' 
        lblDiversIntimidation.AutoSize = True
        lblDiversIntimidation.Location = New Point(568, 307)
        lblDiversIntimidation.Name = "lblDiversIntimidation"
        lblDiversIntimidation.Size = New Size(13, 15)
        lblDiversIntimidation.TabIndex = 163
        lblDiversIntimidation.Text = "0"
        ' 
        ' lblModRacialIntimidation
        ' 
        lblModRacialIntimidation.AutoSize = True
        lblModRacialIntimidation.Location = New Point(496, 307)
        lblModRacialIntimidation.Name = "lblModRacialIntimidation"
        lblModRacialIntimidation.Size = New Size(13, 15)
        lblModRacialIntimidation.TabIndex = 162
        lblModRacialIntimidation.Text = "0"
        ' 
        ' lblModCaracIntimidation
        ' 
        lblModCaracIntimidation.AutoSize = True
        lblModCaracIntimidation.Location = New Point(342, 307)
        lblModCaracIntimidation.Name = "lblModCaracIntimidation"
        lblModCaracIntimidation.Size = New Size(13, 15)
        lblModCaracIntimidation.TabIndex = 160
        lblModCaracIntimidation.Text = "0"
        ' 
        ' lblDemiNiveauIntimidation
        ' 
        lblDemiNiveauIntimidation.AutoSize = True
        lblDemiNiveauIntimidation.Location = New Point(262, 307)
        lblDemiNiveauIntimidation.Name = "lblDemiNiveauIntimidation"
        lblDemiNiveauIntimidation.Size = New Size(13, 15)
        lblDemiNiveauIntimidation.TabIndex = 159
        lblDemiNiveauIntimidation.Text = "0"
        ' 
        ' lblPenArmureHistoire
        ' 
        lblPenArmureHistoire.AutoSize = True
        lblPenArmureHistoire.Location = New Point(641, 283)
        lblPenArmureHistoire.Name = "lblPenArmureHistoire"
        lblPenArmureHistoire.Size = New Size(13, 15)
        lblPenArmureHistoire.TabIndex = 158
        lblPenArmureHistoire.Text = "0"
        ' 
        ' lblDiversHistoire
        ' 
        lblDiversHistoire.AutoSize = True
        lblDiversHistoire.Location = New Point(568, 283)
        lblDiversHistoire.Name = "lblDiversHistoire"
        lblDiversHistoire.Size = New Size(13, 15)
        lblDiversHistoire.TabIndex = 157
        lblDiversHistoire.Text = "0"
        ' 
        ' lblModRacialHistoire
        ' 
        lblModRacialHistoire.AutoSize = True
        lblModRacialHistoire.Location = New Point(496, 283)
        lblModRacialHistoire.Name = "lblModRacialHistoire"
        lblModRacialHistoire.Size = New Size(13, 15)
        lblModRacialHistoire.TabIndex = 156
        lblModRacialHistoire.Text = "0"
        ' 
        ' lblModCaracHistoire
        ' 
        lblModCaracHistoire.AutoSize = True
        lblModCaracHistoire.Location = New Point(342, 283)
        lblModCaracHistoire.Name = "lblModCaracHistoire"
        lblModCaracHistoire.Size = New Size(13, 15)
        lblModCaracHistoire.TabIndex = 154
        lblModCaracHistoire.Text = "0"
        ' 
        ' lblDemiNiveauHistoire
        ' 
        lblDemiNiveauHistoire.AutoSize = True
        lblDemiNiveauHistoire.Location = New Point(262, 283)
        lblDemiNiveauHistoire.Name = "lblDemiNiveauHistoire"
        lblDemiNiveauHistoire.Size = New Size(13, 15)
        lblDemiNiveauHistoire.TabIndex = 153
        lblDemiNiveauHistoire.Text = "0"
        ' 
        ' lblPenArmureExploration
        ' 
        lblPenArmureExploration.AutoSize = True
        lblPenArmureExploration.Location = New Point(641, 258)
        lblPenArmureExploration.Name = "lblPenArmureExploration"
        lblPenArmureExploration.Size = New Size(13, 15)
        lblPenArmureExploration.TabIndex = 152
        lblPenArmureExploration.Text = "0"
        ' 
        ' lblDiversExploration
        ' 
        lblDiversExploration.AutoSize = True
        lblDiversExploration.Location = New Point(568, 258)
        lblDiversExploration.Name = "lblDiversExploration"
        lblDiversExploration.Size = New Size(13, 15)
        lblDiversExploration.TabIndex = 151
        lblDiversExploration.Text = "0"
        ' 
        ' lblModRacialExploration
        ' 
        lblModRacialExploration.AutoSize = True
        lblModRacialExploration.Location = New Point(496, 258)
        lblModRacialExploration.Name = "lblModRacialExploration"
        lblModRacialExploration.Size = New Size(13, 15)
        lblModRacialExploration.TabIndex = 150
        lblModRacialExploration.Text = "0"
        ' 
        ' lblModCaracExploration
        ' 
        lblModCaracExploration.AutoSize = True
        lblModCaracExploration.Location = New Point(342, 258)
        lblModCaracExploration.Name = "lblModCaracExploration"
        lblModCaracExploration.Size = New Size(13, 15)
        lblModCaracExploration.TabIndex = 148
        lblModCaracExploration.Text = "0"
        ' 
        ' lblDemiNiveauExploration
        ' 
        lblDemiNiveauExploration.AutoSize = True
        lblDemiNiveauExploration.Location = New Point(262, 258)
        lblDemiNiveauExploration.Name = "lblDemiNiveauExploration"
        lblDemiNiveauExploration.Size = New Size(13, 15)
        lblDemiNiveauExploration.TabIndex = 147
        lblDemiNiveauExploration.Text = "0"
        ' 
        ' lblPenArmureEndurance
        ' 
        lblPenArmureEndurance.AutoSize = True
        lblPenArmureEndurance.Location = New Point(641, 231)
        lblPenArmureEndurance.Name = "lblPenArmureEndurance"
        lblPenArmureEndurance.Size = New Size(13, 15)
        lblPenArmureEndurance.TabIndex = 146
        lblPenArmureEndurance.Text = "0"
        ' 
        ' lblDiversEndurance
        ' 
        lblDiversEndurance.AutoSize = True
        lblDiversEndurance.Location = New Point(568, 231)
        lblDiversEndurance.Name = "lblDiversEndurance"
        lblDiversEndurance.Size = New Size(13, 15)
        lblDiversEndurance.TabIndex = 145
        lblDiversEndurance.Text = "0"
        ' 
        ' lblModRacialEndurance
        ' 
        lblModRacialEndurance.AutoSize = True
        lblModRacialEndurance.Location = New Point(496, 231)
        lblModRacialEndurance.Name = "lblModRacialEndurance"
        lblModRacialEndurance.Size = New Size(13, 15)
        lblModRacialEndurance.TabIndex = 144
        lblModRacialEndurance.Text = "0"
        ' 
        ' lblModCaracEndurance
        ' 
        lblModCaracEndurance.AutoSize = True
        lblModCaracEndurance.Location = New Point(342, 231)
        lblModCaracEndurance.Name = "lblModCaracEndurance"
        lblModCaracEndurance.Size = New Size(13, 15)
        lblModCaracEndurance.TabIndex = 142
        lblModCaracEndurance.Text = "0"
        ' 
        ' lblDemiNiveauEndurance
        ' 
        lblDemiNiveauEndurance.AutoSize = True
        lblDemiNiveauEndurance.Location = New Point(262, 231)
        lblDemiNiveauEndurance.Name = "lblDemiNiveauEndurance"
        lblDemiNiveauEndurance.Size = New Size(13, 15)
        lblDemiNiveauEndurance.TabIndex = 141
        lblDemiNiveauEndurance.Text = "0"
        ' 
        ' lblPenArmureDiscretion
        ' 
        lblPenArmureDiscretion.AutoSize = True
        lblPenArmureDiscretion.Location = New Point(641, 204)
        lblPenArmureDiscretion.Name = "lblPenArmureDiscretion"
        lblPenArmureDiscretion.Size = New Size(13, 15)
        lblPenArmureDiscretion.TabIndex = 140
        lblPenArmureDiscretion.Text = "0"
        ' 
        ' lblDiversDiscretion
        ' 
        lblDiversDiscretion.AutoSize = True
        lblDiversDiscretion.Location = New Point(568, 204)
        lblDiversDiscretion.Name = "lblDiversDiscretion"
        lblDiversDiscretion.Size = New Size(13, 15)
        lblDiversDiscretion.TabIndex = 139
        lblDiversDiscretion.Text = "0"
        ' 
        ' lblModRacialDiscretion
        ' 
        lblModRacialDiscretion.AutoSize = True
        lblModRacialDiscretion.Location = New Point(496, 204)
        lblModRacialDiscretion.Name = "lblModRacialDiscretion"
        lblModRacialDiscretion.Size = New Size(13, 15)
        lblModRacialDiscretion.TabIndex = 138
        lblModRacialDiscretion.Text = "0"
        ' 
        ' lblModCaracDiscretion
        ' 
        lblModCaracDiscretion.AutoSize = True
        lblModCaracDiscretion.Location = New Point(342, 204)
        lblModCaracDiscretion.Name = "lblModCaracDiscretion"
        lblModCaracDiscretion.Size = New Size(13, 15)
        lblModCaracDiscretion.TabIndex = 136
        lblModCaracDiscretion.Text = "0"
        ' 
        ' lblDemiNiveauDiscretion
        ' 
        lblDemiNiveauDiscretion.AutoSize = True
        lblDemiNiveauDiscretion.Location = New Point(262, 204)
        lblDemiNiveauDiscretion.Name = "lblDemiNiveauDiscretion"
        lblDemiNiveauDiscretion.Size = New Size(13, 15)
        lblDemiNiveauDiscretion.TabIndex = 135
        lblDemiNiveauDiscretion.Text = "0"
        ' 
        ' lblPenArmureDiplomatie
        ' 
        lblPenArmureDiplomatie.AutoSize = True
        lblPenArmureDiplomatie.Location = New Point(641, 178)
        lblPenArmureDiplomatie.Name = "lblPenArmureDiplomatie"
        lblPenArmureDiplomatie.Size = New Size(13, 15)
        lblPenArmureDiplomatie.TabIndex = 134
        lblPenArmureDiplomatie.Text = "0"
        ' 
        ' lblDiversDiplomatie
        ' 
        lblDiversDiplomatie.AutoSize = True
        lblDiversDiplomatie.Location = New Point(568, 178)
        lblDiversDiplomatie.Name = "lblDiversDiplomatie"
        lblDiversDiplomatie.Size = New Size(13, 15)
        lblDiversDiplomatie.TabIndex = 133
        lblDiversDiplomatie.Text = "0"
        ' 
        ' lblModRacialDiplomatie
        ' 
        lblModRacialDiplomatie.AutoSize = True
        lblModRacialDiplomatie.Location = New Point(496, 178)
        lblModRacialDiplomatie.Name = "lblModRacialDiplomatie"
        lblModRacialDiplomatie.Size = New Size(13, 15)
        lblModRacialDiplomatie.TabIndex = 132
        lblModRacialDiplomatie.Text = "0"
        ' 
        ' lblPenArmureConnDeLaRue
        ' 
        lblPenArmureConnDeLaRue.AutoSize = True
        lblPenArmureConnDeLaRue.Location = New Point(641, 150)
        lblPenArmureConnDeLaRue.Name = "lblPenArmureConnDeLaRue"
        lblPenArmureConnDeLaRue.Size = New Size(13, 15)
        lblPenArmureConnDeLaRue.TabIndex = 131
        lblPenArmureConnDeLaRue.Text = "0"
        ' 
        ' lblDiversConnDeLaRue
        ' 
        lblDiversConnDeLaRue.AutoSize = True
        lblDiversConnDeLaRue.Location = New Point(568, 150)
        lblDiversConnDeLaRue.Name = "lblDiversConnDeLaRue"
        lblDiversConnDeLaRue.Size = New Size(13, 15)
        lblDiversConnDeLaRue.TabIndex = 130
        lblDiversConnDeLaRue.Text = "0"
        ' 
        ' lblModRacialConnDeLarue
        ' 
        lblModRacialConnDeLarue.AutoSize = True
        lblModRacialConnDeLarue.Location = New Point(496, 150)
        lblModRacialConnDeLarue.Name = "lblModRacialConnDeLarue"
        lblModRacialConnDeLarue.Size = New Size(13, 15)
        lblModRacialConnDeLarue.TabIndex = 129
        lblModRacialConnDeLarue.Text = "0"
        ' 
        ' lblPenArmureBluff
        ' 
        lblPenArmureBluff.AutoSize = True
        lblPenArmureBluff.Location = New Point(641, 122)
        lblPenArmureBluff.Name = "lblPenArmureBluff"
        lblPenArmureBluff.Size = New Size(13, 15)
        lblPenArmureBluff.TabIndex = 128
        lblPenArmureBluff.Text = "0"
        ' 
        ' lblDiversBluff
        ' 
        lblDiversBluff.AutoSize = True
        lblDiversBluff.Location = New Point(568, 122)
        lblDiversBluff.Name = "lblDiversBluff"
        lblDiversBluff.Size = New Size(13, 15)
        lblDiversBluff.TabIndex = 127
        lblDiversBluff.Text = "0"
        ' 
        ' lblModRacialBluff
        ' 
        lblModRacialBluff.AutoSize = True
        lblModRacialBluff.Location = New Point(496, 122)
        lblModRacialBluff.Name = "lblModRacialBluff"
        lblModRacialBluff.Size = New Size(13, 15)
        lblModRacialBluff.TabIndex = 126
        lblModRacialBluff.Text = "0"
        ' 
        ' lblPenArmureAthletisme
        ' 
        lblPenArmureAthletisme.AutoSize = True
        lblPenArmureAthletisme.Location = New Point(641, 94)
        lblPenArmureAthletisme.Name = "lblPenArmureAthletisme"
        lblPenArmureAthletisme.Size = New Size(13, 15)
        lblPenArmureAthletisme.TabIndex = 125
        lblPenArmureAthletisme.Text = "0"
        ' 
        ' lblDiversAthletisme
        ' 
        lblDiversAthletisme.AutoSize = True
        lblDiversAthletisme.Location = New Point(568, 94)
        lblDiversAthletisme.Name = "lblDiversAthletisme"
        lblDiversAthletisme.Size = New Size(13, 15)
        lblDiversAthletisme.TabIndex = 124
        lblDiversAthletisme.Text = "0"
        ' 
        ' lblModRacialAthletisme
        ' 
        lblModRacialAthletisme.AutoSize = True
        lblModRacialAthletisme.Location = New Point(496, 94)
        lblModRacialAthletisme.Name = "lblModRacialAthletisme"
        lblModRacialAthletisme.Size = New Size(13, 15)
        lblModRacialAthletisme.TabIndex = 123
        lblModRacialAthletisme.Text = "0"
        ' 
        ' lblPenArmureArcanes
        ' 
        lblPenArmureArcanes.AutoSize = True
        lblPenArmureArcanes.Location = New Point(641, 65)
        lblPenArmureArcanes.Name = "lblPenArmureArcanes"
        lblPenArmureArcanes.Size = New Size(13, 15)
        lblPenArmureArcanes.TabIndex = 122
        lblPenArmureArcanes.Text = "0"
        ' 
        ' lblDiversArcanes
        ' 
        lblDiversArcanes.AutoSize = True
        lblDiversArcanes.Location = New Point(568, 65)
        lblDiversArcanes.Name = "lblDiversArcanes"
        lblDiversArcanes.Size = New Size(13, 15)
        lblDiversArcanes.TabIndex = 121
        lblDiversArcanes.Text = "0"
        ' 
        ' lblModRacialArcanes
        ' 
        lblModRacialArcanes.AutoSize = True
        lblModRacialArcanes.Location = New Point(496, 65)
        lblModRacialArcanes.Name = "lblModRacialArcanes"
        lblModRacialArcanes.Size = New Size(13, 15)
        lblModRacialArcanes.TabIndex = 120
        lblModRacialArcanes.Text = "0"
        ' 
        ' lblPenArmureAcrobaties
        ' 
        lblPenArmureAcrobaties.AutoSize = True
        lblPenArmureAcrobaties.Location = New Point(641, 38)
        lblPenArmureAcrobaties.Name = "lblPenArmureAcrobaties"
        lblPenArmureAcrobaties.Size = New Size(13, 15)
        lblPenArmureAcrobaties.TabIndex = 119
        lblPenArmureAcrobaties.Text = "0"
        ' 
        ' lblDiversAcrobaties
        ' 
        lblDiversAcrobaties.AutoSize = True
        lblDiversAcrobaties.Location = New Point(568, 38)
        lblDiversAcrobaties.Name = "lblDiversAcrobaties"
        lblDiversAcrobaties.Size = New Size(13, 15)
        lblDiversAcrobaties.TabIndex = 118
        lblDiversAcrobaties.Text = "0"
        ' 
        ' lblModRacialAcrobaties
        ' 
        lblModRacialAcrobaties.AutoSize = True
        lblModRacialAcrobaties.Location = New Point(496, 38)
        lblModRacialAcrobaties.Name = "lblModRacialAcrobaties"
        lblModRacialAcrobaties.Size = New Size(13, 15)
        lblModRacialAcrobaties.TabIndex = 117
        lblModRacialAcrobaties.Text = "0"
        ' 
        ' lblSoins
        ' 
        lblSoins.AutoSize = True
        lblSoins.Location = New Point(15, 459)
        lblSoins.Name = "lblSoins"
        lblSoins.Size = New Size(35, 15)
        lblSoins.TabIndex = 116
        lblSoins.Text = "Soins"
        ' 
        ' lblReligion
        ' 
        lblReligion.AutoSize = True
        lblReligion.Location = New Point(15, 431)
        lblReligion.Name = "lblReligion"
        lblReligion.Size = New Size(50, 15)
        lblReligion.TabIndex = 115
        lblReligion.Text = "Religion"
        ' 
        ' lblPerception
        ' 
        lblPerception.AutoSize = True
        lblPerception.Location = New Point(15, 409)
        lblPerception.Name = "lblPerception"
        lblPerception.Size = New Size(64, 15)
        lblPerception.TabIndex = 114
        lblPerception.Text = "Perception"
        ' 
        ' lblNature
        ' 
        lblNature.AutoSize = True
        lblNature.Location = New Point(15, 382)
        lblNature.Name = "lblNature"
        lblNature.Size = New Size(43, 15)
        lblNature.TabIndex = 113
        lblNature.Text = "Nature"
        ' 
        ' lblLarcin
        ' 
        lblLarcin.AutoSize = True
        lblLarcin.Location = New Point(15, 359)
        lblLarcin.Name = "lblLarcin"
        lblLarcin.Size = New Size(39, 15)
        lblLarcin.TabIndex = 112
        lblLarcin.Text = "Larcin"
        ' 
        ' lblIntuition
        ' 
        lblIntuition.AutoSize = True
        lblIntuition.Location = New Point(15, 332)
        lblIntuition.Name = "lblIntuition"
        lblIntuition.Size = New Size(52, 15)
        lblIntuition.TabIndex = 111
        lblIntuition.Text = "Intuition"
        ' 
        ' lblIntimidation
        ' 
        lblIntimidation.AutoSize = True
        lblIntimidation.Location = New Point(15, 307)
        lblIntimidation.Name = "lblIntimidation"
        lblIntimidation.Size = New Size(72, 15)
        lblIntimidation.TabIndex = 110
        lblIntimidation.Text = "Intimidation"
        ' 
        ' lblHistoire
        ' 
        lblHistoire.AutoSize = True
        lblHistoire.Location = New Point(15, 283)
        lblHistoire.Name = "lblHistoire"
        lblHistoire.Size = New Size(48, 15)
        lblHistoire.TabIndex = 109
        lblHistoire.Text = "Histoire"
        ' 
        ' lblExploration
        ' 
        lblExploration.AutoSize = True
        lblExploration.Location = New Point(15, 258)
        lblExploration.Name = "lblExploration"
        lblExploration.Size = New Size(67, 15)
        lblExploration.TabIndex = 108
        lblExploration.Text = "Exploration"
        ' 
        ' lblEndurance
        ' 
        lblEndurance.AutoSize = True
        lblEndurance.Location = New Point(15, 231)
        lblEndurance.Name = "lblEndurance"
        lblEndurance.Size = New Size(63, 15)
        lblEndurance.TabIndex = 107
        lblEndurance.Text = "Endurance"
        ' 
        ' lblDiscretion
        ' 
        lblDiscretion.AutoSize = True
        lblDiscretion.Location = New Point(15, 204)
        lblDiscretion.Name = "lblDiscretion"
        lblDiscretion.Size = New Size(60, 15)
        lblDiscretion.TabIndex = 106
        lblDiscretion.Text = "Discrétion"
        ' 
        ' lblPenArmure
        ' 
        lblPenArmure.AutoSize = True
        lblPenArmure.Location = New Point(603, 10)
        lblPenArmure.Name = "lblPenArmure"
        lblPenArmure.Size = New Size(92, 15)
        lblPenArmure.TabIndex = 105
        lblPenArmure.Text = "Pénalité Armure"
        ' 
        ' lblDivers
        ' 
        lblDivers.AutoSize = True
        lblDivers.Location = New Point(553, 10)
        lblDivers.Name = "lblDivers"
        lblDivers.Size = New Size(39, 15)
        lblDivers.TabIndex = 104
        lblDivers.Text = "Divers"
        ' 
        ' lblModRacial
        ' 
        lblModRacial.AutoSize = True
        lblModRacial.Location = New Point(472, 10)
        lblModRacial.Name = "lblModRacial"
        lblModRacial.Size = New Size(66, 15)
        lblModRacial.TabIndex = 103
        lblModRacial.Text = "Mod Racial"
        ' 
        ' lblModCaracDiplomatie
        ' 
        lblModCaracDiplomatie.AutoSize = True
        lblModCaracDiplomatie.Location = New Point(342, 178)
        lblModCaracDiplomatie.Name = "lblModCaracDiplomatie"
        lblModCaracDiplomatie.Size = New Size(13, 15)
        lblModCaracDiplomatie.TabIndex = 96
        lblModCaracDiplomatie.Text = "0"
        ' 
        ' lblModCaracConnDeLaRue
        ' 
        lblModCaracConnDeLaRue.AutoSize = True
        lblModCaracConnDeLaRue.Location = New Point(342, 150)
        lblModCaracConnDeLaRue.Name = "lblModCaracConnDeLaRue"
        lblModCaracConnDeLaRue.Size = New Size(13, 15)
        lblModCaracConnDeLaRue.TabIndex = 95
        lblModCaracConnDeLaRue.Text = "0"
        ' 
        ' lblModCaracBluff
        ' 
        lblModCaracBluff.AutoSize = True
        lblModCaracBluff.Location = New Point(342, 122)
        lblModCaracBluff.Name = "lblModCaracBluff"
        lblModCaracBluff.Size = New Size(13, 15)
        lblModCaracBluff.TabIndex = 94
        lblModCaracBluff.Text = "0"
        ' 
        ' lblModCaracAthletisme
        ' 
        lblModCaracAthletisme.AutoSize = True
        lblModCaracAthletisme.Location = New Point(342, 94)
        lblModCaracAthletisme.Name = "lblModCaracAthletisme"
        lblModCaracAthletisme.Size = New Size(13, 15)
        lblModCaracAthletisme.TabIndex = 93
        lblModCaracAthletisme.Text = "0"
        ' 
        ' lblModCaracAcrobaties
        ' 
        lblModCaracAcrobaties.AutoSize = True
        lblModCaracAcrobaties.Location = New Point(342, 38)
        lblModCaracAcrobaties.Name = "lblModCaracAcrobaties"
        lblModCaracAcrobaties.Size = New Size(13, 15)
        lblModCaracAcrobaties.TabIndex = 92
        lblModCaracAcrobaties.Text = "0"
        ' 
        ' lblModCaracArcanes
        ' 
        lblModCaracArcanes.AutoSize = True
        lblModCaracArcanes.Location = New Point(342, 65)
        lblModCaracArcanes.Name = "lblModCaracArcanes"
        lblModCaracArcanes.Size = New Size(13, 15)
        lblModCaracArcanes.TabIndex = 91
        lblModCaracArcanes.Text = "0"
        ' 
        ' lblDemiNiveauDiplomatie
        ' 
        lblDemiNiveauDiplomatie.AutoSize = True
        lblDemiNiveauDiplomatie.Location = New Point(262, 178)
        lblDemiNiveauDiplomatie.Name = "lblDemiNiveauDiplomatie"
        lblDemiNiveauDiplomatie.Size = New Size(13, 15)
        lblDemiNiveauDiplomatie.TabIndex = 90
        lblDemiNiveauDiplomatie.Text = "0"
        ' 
        ' lblDemiNiveauConnDeLaRue
        ' 
        lblDemiNiveauConnDeLaRue.AutoSize = True
        lblDemiNiveauConnDeLaRue.Location = New Point(262, 150)
        lblDemiNiveauConnDeLaRue.Name = "lblDemiNiveauConnDeLaRue"
        lblDemiNiveauConnDeLaRue.Size = New Size(13, 15)
        lblDemiNiveauConnDeLaRue.TabIndex = 89
        lblDemiNiveauConnDeLaRue.Text = "0"
        ' 
        ' lblDemiNiveauBluff
        ' 
        lblDemiNiveauBluff.AutoSize = True
        lblDemiNiveauBluff.Location = New Point(262, 122)
        lblDemiNiveauBluff.Name = "lblDemiNiveauBluff"
        lblDemiNiveauBluff.Size = New Size(13, 15)
        lblDemiNiveauBluff.TabIndex = 88
        lblDemiNiveauBluff.Text = "0"
        ' 
        ' lblDemiNiveauAthletisme
        ' 
        lblDemiNiveauAthletisme.AutoSize = True
        lblDemiNiveauAthletisme.Location = New Point(262, 94)
        lblDemiNiveauAthletisme.Name = "lblDemiNiveauAthletisme"
        lblDemiNiveauAthletisme.Size = New Size(13, 15)
        lblDemiNiveauAthletisme.TabIndex = 87
        lblDemiNiveauAthletisme.Text = "0"
        ' 
        ' lblDemiNiveauAcrobaties
        ' 
        lblDemiNiveauAcrobaties.AutoSize = True
        lblDemiNiveauAcrobaties.Location = New Point(262, 38)
        lblDemiNiveauAcrobaties.Name = "lblDemiNiveauAcrobaties"
        lblDemiNiveauAcrobaties.Size = New Size(13, 15)
        lblDemiNiveauAcrobaties.TabIndex = 86
        lblDemiNiveauAcrobaties.Text = "0"
        ' 
        ' lblDemiNiveauArcanes
        ' 
        lblDemiNiveauArcanes.AutoSize = True
        lblDemiNiveauArcanes.Location = New Point(262, 65)
        lblDemiNiveauArcanes.Name = "lblDemiNiveauArcanes"
        lblDemiNiveauArcanes.Size = New Size(13, 15)
        lblDemiNiveauArcanes.TabIndex = 85
        lblDemiNiveauArcanes.Text = "0"
        ' 
        ' lblFormation
        ' 
        lblFormation.AutoSize = True
        lblFormation.Location = New Point(396, 10)
        lblFormation.Name = "lblFormation"
        lblFormation.Size = New Size(62, 15)
        lblFormation.TabIndex = 78
        lblFormation.Text = "Formation"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(316, 10)
        Label21.Name = "Label21"
        Label21.Size = New Size(65, 15)
        Label21.TabIndex = 77
        Label21.Text = "Mod Carac"
        ' 
        ' lblDemiNiveau
        ' 
        lblDemiNiveau.AutoSize = True
        lblDemiNiveau.Location = New Point(239, 10)
        lblDemiNiveau.Name = "lblDemiNiveau"
        lblDemiNiveau.Size = New Size(64, 15)
        lblDemiNiveau.TabIndex = 76
        lblDemiNiveau.Text = "1/2 Niveau"
        ' 
        ' lblDiplomatie
        ' 
        lblDiplomatie.AutoSize = True
        lblDiplomatie.Location = New Point(15, 178)
        lblDiplomatie.Name = "lblDiplomatie"
        lblDiplomatie.Size = New Size(65, 15)
        lblDiplomatie.TabIndex = 74
        lblDiplomatie.Text = "Diplomatie"
        ' 
        ' lblConnDeLaRue
        ' 
        lblConnDeLaRue.AutoSize = True
        lblConnDeLaRue.Location = New Point(15, 150)
        lblConnDeLaRue.Name = "lblConnDeLaRue"
        lblConnDeLaRue.Size = New Size(128, 15)
        lblConnDeLaRue.TabIndex = 73
        lblConnDeLaRue.Text = "Connaissance de la rue"
        ' 
        ' lblBluff
        ' 
        lblBluff.AutoSize = True
        lblBluff.Location = New Point(15, 122)
        lblBluff.Name = "lblBluff"
        lblBluff.Size = New Size(32, 15)
        lblBluff.TabIndex = 72
        lblBluff.Text = "Bluff"
        ' 
        ' lblAthletisme
        ' 
        lblAthletisme.AutoSize = True
        lblAthletisme.Location = New Point(15, 94)
        lblAthletisme.Name = "lblAthletisme"
        lblAthletisme.Size = New Size(64, 15)
        lblAthletisme.TabIndex = 71
        lblAthletisme.Text = "Athlétisme"
        ' 
        ' lblArcanes
        ' 
        lblArcanes.AutoSize = True
        lblArcanes.Location = New Point(15, 65)
        lblArcanes.Name = "lblArcanes"
        lblArcanes.Size = New Size(49, 15)
        lblArcanes.TabIndex = 70
        lblArcanes.Text = "Arcanes"
        ' 
        ' lblAcrobaties
        ' 
        lblAcrobaties.AutoSize = True
        lblAcrobaties.Location = New Point(15, 38)
        lblAcrobaties.Name = "lblAcrobaties"
        lblAcrobaties.Size = New Size(63, 15)
        lblAcrobaties.TabIndex = 69
        lblAcrobaties.Text = "Acrobaties"
        ' 
        ' tabCaracteristique
        ' 
        tabCaracteristique.Controls.Add(lblCharismeAffichage)
        tabCaracteristique.Controls.Add(lblSagesseAffichage)
        tabCaracteristique.Controls.Add(lblIntelligenceAffichage)
        tabCaracteristique.Controls.Add(lblDexteriteAffichage)
        tabCaracteristique.Controls.Add(lblForceAffichage)
        tabCaracteristique.Controls.Add(lblConstitutionAffichage)
        tabCaracteristique.Controls.Add(lblModClasseVolonte)
        tabCaracteristique.Controls.Add(lblModClasseVigueur)
        tabCaracteristique.Controls.Add(lblModClasseReflexes)
        tabCaracteristique.Controls.Add(lblModClasseCA)
        tabCaracteristique.Controls.Add(lblModClasseSauvegardes)
        tabCaracteristique.Controls.Add(lblTotalVolonte)
        tabCaracteristique.Controls.Add(lblTotalVigueur)
        tabCaracteristique.Controls.Add(lblTotalCA)
        tabCaracteristique.Controls.Add(lblTotalReflexes)
        tabCaracteristique.Controls.Add(lblTotalSauvegardes)
        tabCaracteristique.Controls.Add(lblPenArmureVolonte)
        tabCaracteristique.Controls.Add(lblDiversVolonte)
        tabCaracteristique.Controls.Add(lblModRacialVolonte)
        tabCaracteristique.Controls.Add(lblPenArmureVigueur)
        tabCaracteristique.Controls.Add(lblDiversVigueur)
        tabCaracteristique.Controls.Add(lblModRacialVigueur)
        tabCaracteristique.Controls.Add(lblPenArmureReflexes)
        tabCaracteristique.Controls.Add(lblDiversReflexes)
        tabCaracteristique.Controls.Add(lblModRacialReflexes)
        tabCaracteristique.Controls.Add(lblPenArmureCA)
        tabCaracteristique.Controls.Add(lblDiversCA)
        tabCaracteristique.Controls.Add(lblModRacialCA)
        tabCaracteristique.Controls.Add(lblPenArmureSauvegardes)
        tabCaracteristique.Controls.Add(lblDiversSauvegardes)
        tabCaracteristique.Controls.Add(lblModRacialSauvegardes)
        tabCaracteristique.Controls.Add(lblModCaracVolonte)
        tabCaracteristique.Controls.Add(lblModCaracVigueur)
        tabCaracteristique.Controls.Add(lblModCaracCA)
        tabCaracteristique.Controls.Add(lblModCaracReflexes)
        tabCaracteristique.Controls.Add(lblDemiNiveauVolonte)
        tabCaracteristique.Controls.Add(lblDemiNiveauVigueur)
        tabCaracteristique.Controls.Add(lblDemiNiveauCA)
        tabCaracteristique.Controls.Add(lblDemiNiveauReflexes)
        tabCaracteristique.Controls.Add(lblModCaracSauvegardes)
        tabCaracteristique.Controls.Add(lblDemiNiveauSauvegardes)
        tabCaracteristique.Controls.Add(lblVolonte)
        tabCaracteristique.Controls.Add(lblVigueur)
        tabCaracteristique.Controls.Add(lblReflexes)
        tabCaracteristique.Controls.Add(lblClasseArmure)
        tabCaracteristique.Controls.Add(lblModCalculCharisme)
        tabCaracteristique.Controls.Add(lblModCalculSagesse)
        tabCaracteristique.Controls.Add(lblModCalculIntelligence)
        tabCaracteristique.Controls.Add(lblModCalculDexterite)
        tabCaracteristique.Controls.Add(lblModCalculForce)
        tabCaracteristique.Controls.Add(lblModCalculConstitution)
        tabCaracteristique.Controls.Add(lblValCalculCharisme)
        tabCaracteristique.Controls.Add(lblValCalculSagesse)
        tabCaracteristique.Controls.Add(lblValCalculIntelligence)
        tabCaracteristique.Controls.Add(lblValCalculDexterite)
        tabCaracteristique.Controls.Add(lblValCalculForce)
        tabCaracteristique.Controls.Add(lblValCalculConstitution)
        tabCaracteristique.Controls.Add(lblModRaceCharisme)
        tabCaracteristique.Controls.Add(lblModRaceSagesse)
        tabCaracteristique.Controls.Add(lblModRaceIntelligence)
        tabCaracteristique.Controls.Add(lblModRaceDexterite)
        tabCaracteristique.Controls.Add(lblModRaceForce)
        tabCaracteristique.Controls.Add(lblModRaceConstitution)
        tabCaracteristique.Controls.Add(Label1)
        tabCaracteristique.Controls.Add(lblValeurCalcul)
        tabCaracteristique.Controls.Add(lblModRace)
        tabCaracteristique.Controls.Add(lblBase)
        tabCaracteristique.Controls.Add(lblCharisme)
        tabCaracteristique.Controls.Add(lblSagesse)
        tabCaracteristique.Controls.Add(lblIntelligence)
        tabCaracteristique.Controls.Add(lblDexterite)
        tabCaracteristique.Controls.Add(lblConstitution)
        tabCaracteristique.Controls.Add(lblForce)
        tabCaracteristique.Location = New Point(4, 24)
        tabCaracteristique.Name = "tabCaracteristique"
        tabCaracteristique.Padding = New Padding(3)
        tabCaracteristique.Size = New Size(798, 496)
        tabCaracteristique.TabIndex = 0
        tabCaracteristique.Text = "Caratéristiques"
        tabCaracteristique.UseVisualStyleBackColor = True
        ' 
        ' lblCharismeAffichage
        ' 
        lblCharismeAffichage.AutoSize = True
        lblCharismeAffichage.Location = New Point(131, 182)
        lblCharismeAffichage.Name = "lblCharismeAffichage"
        lblCharismeAffichage.Size = New Size(13, 15)
        lblCharismeAffichage.TabIndex = 307
        lblCharismeAffichage.Text = "0"
        ' 
        ' lblSagesseAffichage
        ' 
        lblSagesseAffichage.AutoSize = True
        lblSagesseAffichage.Location = New Point(131, 154)
        lblSagesseAffichage.Name = "lblSagesseAffichage"
        lblSagesseAffichage.Size = New Size(13, 15)
        lblSagesseAffichage.TabIndex = 306
        lblSagesseAffichage.Text = "0"
        ' 
        ' lblIntelligenceAffichage
        ' 
        lblIntelligenceAffichage.AutoSize = True
        lblIntelligenceAffichage.Location = New Point(131, 126)
        lblIntelligenceAffichage.Name = "lblIntelligenceAffichage"
        lblIntelligenceAffichage.Size = New Size(13, 15)
        lblIntelligenceAffichage.TabIndex = 305
        lblIntelligenceAffichage.Text = "0"
        ' 
        ' lblDexteriteAffichage
        ' 
        lblDexteriteAffichage.AutoSize = True
        lblDexteriteAffichage.Location = New Point(131, 98)
        lblDexteriteAffichage.Name = "lblDexteriteAffichage"
        lblDexteriteAffichage.Size = New Size(13, 15)
        lblDexteriteAffichage.TabIndex = 304
        lblDexteriteAffichage.Text = "0"
        ' 
        ' lblForceAffichage
        ' 
        lblForceAffichage.AutoSize = True
        lblForceAffichage.Location = New Point(131, 41)
        lblForceAffichage.Name = "lblForceAffichage"
        lblForceAffichage.Size = New Size(13, 15)
        lblForceAffichage.TabIndex = 303
        lblForceAffichage.Text = "0"
        ' 
        ' lblConstitutionAffichage
        ' 
        lblConstitutionAffichage.AutoSize = True
        lblConstitutionAffichage.Location = New Point(131, 69)
        lblConstitutionAffichage.Name = "lblConstitutionAffichage"
        lblConstitutionAffichage.Size = New Size(13, 15)
        lblConstitutionAffichage.TabIndex = 302
        lblConstitutionAffichage.Text = "0"
        ' 
        ' lblModClasseVolonte
        ' 
        lblModClasseVolonte.AutoSize = True
        lblModClasseVolonte.Location = New Point(414, 397)
        lblModClasseVolonte.Name = "lblModClasseVolonte"
        lblModClasseVolonte.Size = New Size(13, 15)
        lblModClasseVolonte.TabIndex = 301
        lblModClasseVolonte.Text = "0"
        ' 
        ' lblModClasseVigueur
        ' 
        lblModClasseVigueur.AutoSize = True
        lblModClasseVigueur.Location = New Point(414, 342)
        lblModClasseVigueur.Name = "lblModClasseVigueur"
        lblModClasseVigueur.Size = New Size(13, 15)
        lblModClasseVigueur.TabIndex = 300
        lblModClasseVigueur.Text = "0"
        ' 
        ' lblModClasseReflexes
        ' 
        lblModClasseReflexes.AutoSize = True
        lblModClasseReflexes.Location = New Point(414, 368)
        lblModClasseReflexes.Name = "lblModClasseReflexes"
        lblModClasseReflexes.Size = New Size(13, 15)
        lblModClasseReflexes.TabIndex = 299
        lblModClasseReflexes.Text = "0"
        ' 
        ' lblModClasseCA
        ' 
        lblModClasseCA.AutoSize = True
        lblModClasseCA.Location = New Point(414, 312)
        lblModClasseCA.Name = "lblModClasseCA"
        lblModClasseCA.Size = New Size(13, 15)
        lblModClasseCA.TabIndex = 298
        lblModClasseCA.Text = "0"
        ' 
        ' lblModClasseSauvegardes
        ' 
        lblModClasseSauvegardes.AutoSize = True
        lblModClasseSauvegardes.Location = New Point(390, 285)
        lblModClasseSauvegardes.Name = "lblModClasseSauvegardes"
        lblModClasseSauvegardes.Size = New Size(68, 15)
        lblModClasseSauvegardes.TabIndex = 297
        lblModClasseSauvegardes.Text = "Mod Classe"
        ' 
        ' lblTotalVolonte
        ' 
        lblTotalVolonte.AutoSize = True
        lblTotalVolonte.Location = New Point(178, 397)
        lblTotalVolonte.Name = "lblTotalVolonte"
        lblTotalVolonte.Size = New Size(13, 15)
        lblTotalVolonte.TabIndex = 296
        lblTotalVolonte.Text = "0"
        ' 
        ' lblTotalVigueur
        ' 
        lblTotalVigueur.AutoSize = True
        lblTotalVigueur.Location = New Point(178, 342)
        lblTotalVigueur.Name = "lblTotalVigueur"
        lblTotalVigueur.Size = New Size(13, 15)
        lblTotalVigueur.TabIndex = 295
        lblTotalVigueur.Text = "0"
        ' 
        ' lblTotalCA
        ' 
        lblTotalCA.AutoSize = True
        lblTotalCA.Location = New Point(178, 312)
        lblTotalCA.Name = "lblTotalCA"
        lblTotalCA.Size = New Size(13, 15)
        lblTotalCA.TabIndex = 294
        lblTotalCA.Text = "0"
        ' 
        ' lblTotalReflexes
        ' 
        lblTotalReflexes.AutoSize = True
        lblTotalReflexes.Location = New Point(178, 368)
        lblTotalReflexes.Name = "lblTotalReflexes"
        lblTotalReflexes.Size = New Size(13, 15)
        lblTotalReflexes.TabIndex = 293
        lblTotalReflexes.Text = "0"
        ' 
        ' lblTotalSauvegardes
        ' 
        lblTotalSauvegardes.AutoSize = True
        lblTotalSauvegardes.Location = New Point(155, 285)
        lblTotalSauvegardes.Name = "lblTotalSauvegardes"
        lblTotalSauvegardes.Size = New Size(32, 15)
        lblTotalSauvegardes.TabIndex = 292
        lblTotalSauvegardes.Text = "Total"
        ' 
        ' lblPenArmureVolonte
        ' 
        lblPenArmureVolonte.AutoSize = True
        lblPenArmureVolonte.Location = New Point(638, 397)
        lblPenArmureVolonte.Name = "lblPenArmureVolonte"
        lblPenArmureVolonte.Size = New Size(13, 15)
        lblPenArmureVolonte.TabIndex = 291
        lblPenArmureVolonte.Text = "0"
        ' 
        ' lblDiversVolonte
        ' 
        lblDiversVolonte.AutoSize = True
        lblDiversVolonte.Location = New Point(565, 397)
        lblDiversVolonte.Name = "lblDiversVolonte"
        lblDiversVolonte.Size = New Size(13, 15)
        lblDiversVolonte.TabIndex = 290
        lblDiversVolonte.Text = "0"
        ' 
        ' lblModRacialVolonte
        ' 
        lblModRacialVolonte.AutoSize = True
        lblModRacialVolonte.Location = New Point(493, 397)
        lblModRacialVolonte.Name = "lblModRacialVolonte"
        lblModRacialVolonte.Size = New Size(13, 15)
        lblModRacialVolonte.TabIndex = 289
        lblModRacialVolonte.Text = "0"
        ' 
        ' lblPenArmureVigueur
        ' 
        lblPenArmureVigueur.AutoSize = True
        lblPenArmureVigueur.Location = New Point(638, 342)
        lblPenArmureVigueur.Name = "lblPenArmureVigueur"
        lblPenArmureVigueur.Size = New Size(13, 15)
        lblPenArmureVigueur.TabIndex = 288
        lblPenArmureVigueur.Text = "0"
        ' 
        ' lblDiversVigueur
        ' 
        lblDiversVigueur.AutoSize = True
        lblDiversVigueur.Location = New Point(565, 342)
        lblDiversVigueur.Name = "lblDiversVigueur"
        lblDiversVigueur.Size = New Size(13, 15)
        lblDiversVigueur.TabIndex = 287
        lblDiversVigueur.Text = "0"
        ' 
        ' lblModRacialVigueur
        ' 
        lblModRacialVigueur.AutoSize = True
        lblModRacialVigueur.Location = New Point(493, 342)
        lblModRacialVigueur.Name = "lblModRacialVigueur"
        lblModRacialVigueur.Size = New Size(13, 15)
        lblModRacialVigueur.TabIndex = 286
        lblModRacialVigueur.Text = "0"
        ' 
        ' lblPenArmureReflexes
        ' 
        lblPenArmureReflexes.AutoSize = True
        lblPenArmureReflexes.Location = New Point(638, 368)
        lblPenArmureReflexes.Name = "lblPenArmureReflexes"
        lblPenArmureReflexes.Size = New Size(13, 15)
        lblPenArmureReflexes.TabIndex = 285
        lblPenArmureReflexes.Text = "0"
        ' 
        ' lblDiversReflexes
        ' 
        lblDiversReflexes.AutoSize = True
        lblDiversReflexes.Location = New Point(565, 368)
        lblDiversReflexes.Name = "lblDiversReflexes"
        lblDiversReflexes.Size = New Size(13, 15)
        lblDiversReflexes.TabIndex = 284
        lblDiversReflexes.Text = "0"
        ' 
        ' lblModRacialReflexes
        ' 
        lblModRacialReflexes.AutoSize = True
        lblModRacialReflexes.Location = New Point(493, 368)
        lblModRacialReflexes.Name = "lblModRacialReflexes"
        lblModRacialReflexes.Size = New Size(13, 15)
        lblModRacialReflexes.TabIndex = 283
        lblModRacialReflexes.Text = "0"
        ' 
        ' lblPenArmureCA
        ' 
        lblPenArmureCA.AutoSize = True
        lblPenArmureCA.Location = New Point(638, 312)
        lblPenArmureCA.Name = "lblPenArmureCA"
        lblPenArmureCA.Size = New Size(13, 15)
        lblPenArmureCA.TabIndex = 282
        lblPenArmureCA.Text = "0"
        ' 
        ' lblDiversCA
        ' 
        lblDiversCA.AutoSize = True
        lblDiversCA.Location = New Point(565, 312)
        lblDiversCA.Name = "lblDiversCA"
        lblDiversCA.Size = New Size(13, 15)
        lblDiversCA.TabIndex = 281
        lblDiversCA.Text = "0"
        ' 
        ' lblModRacialCA
        ' 
        lblModRacialCA.AutoSize = True
        lblModRacialCA.Location = New Point(493, 312)
        lblModRacialCA.Name = "lblModRacialCA"
        lblModRacialCA.Size = New Size(13, 15)
        lblModRacialCA.TabIndex = 280
        lblModRacialCA.Text = "0"
        ' 
        ' lblPenArmureSauvegardes
        ' 
        lblPenArmureSauvegardes.AutoSize = True
        lblPenArmureSauvegardes.Location = New Point(600, 285)
        lblPenArmureSauvegardes.Name = "lblPenArmureSauvegardes"
        lblPenArmureSauvegardes.Size = New Size(92, 15)
        lblPenArmureSauvegardes.TabIndex = 279
        lblPenArmureSauvegardes.Text = "Pénalité Armure"
        ' 
        ' lblDiversSauvegardes
        ' 
        lblDiversSauvegardes.AutoSize = True
        lblDiversSauvegardes.Location = New Point(550, 285)
        lblDiversSauvegardes.Name = "lblDiversSauvegardes"
        lblDiversSauvegardes.Size = New Size(39, 15)
        lblDiversSauvegardes.TabIndex = 278
        lblDiversSauvegardes.Text = "Divers"
        ' 
        ' lblModRacialSauvegardes
        ' 
        lblModRacialSauvegardes.AutoSize = True
        lblModRacialSauvegardes.Location = New Point(468, 285)
        lblModRacialSauvegardes.Name = "lblModRacialSauvegardes"
        lblModRacialSauvegardes.Size = New Size(66, 15)
        lblModRacialSauvegardes.TabIndex = 277
        lblModRacialSauvegardes.Text = "Mod Racial"
        ' 
        ' lblModCaracVolonte
        ' 
        lblModCaracVolonte.AutoSize = True
        lblModCaracVolonte.Location = New Point(339, 397)
        lblModCaracVolonte.Name = "lblModCaracVolonte"
        lblModCaracVolonte.Size = New Size(13, 15)
        lblModCaracVolonte.TabIndex = 276
        lblModCaracVolonte.Text = "0"
        ' 
        ' lblModCaracVigueur
        ' 
        lblModCaracVigueur.AutoSize = True
        lblModCaracVigueur.Location = New Point(339, 342)
        lblModCaracVigueur.Name = "lblModCaracVigueur"
        lblModCaracVigueur.Size = New Size(13, 15)
        lblModCaracVigueur.TabIndex = 275
        lblModCaracVigueur.Text = "0"
        ' 
        ' lblModCaracCA
        ' 
        lblModCaracCA.AutoSize = True
        lblModCaracCA.Location = New Point(339, 312)
        lblModCaracCA.Name = "lblModCaracCA"
        lblModCaracCA.Size = New Size(13, 15)
        lblModCaracCA.TabIndex = 274
        lblModCaracCA.Text = "0"
        ' 
        ' lblModCaracReflexes
        ' 
        lblModCaracReflexes.AutoSize = True
        lblModCaracReflexes.Location = New Point(339, 368)
        lblModCaracReflexes.Name = "lblModCaracReflexes"
        lblModCaracReflexes.Size = New Size(13, 15)
        lblModCaracReflexes.TabIndex = 273
        lblModCaracReflexes.Text = "0"
        ' 
        ' lblDemiNiveauVolonte
        ' 
        lblDemiNiveauVolonte.AutoSize = True
        lblDemiNiveauVolonte.Location = New Point(258, 397)
        lblDemiNiveauVolonte.Name = "lblDemiNiveauVolonte"
        lblDemiNiveauVolonte.Size = New Size(13, 15)
        lblDemiNiveauVolonte.TabIndex = 272
        lblDemiNiveauVolonte.Text = "0"
        ' 
        ' lblDemiNiveauVigueur
        ' 
        lblDemiNiveauVigueur.AutoSize = True
        lblDemiNiveauVigueur.Location = New Point(258, 342)
        lblDemiNiveauVigueur.Name = "lblDemiNiveauVigueur"
        lblDemiNiveauVigueur.Size = New Size(13, 15)
        lblDemiNiveauVigueur.TabIndex = 271
        lblDemiNiveauVigueur.Text = "0"
        ' 
        ' lblDemiNiveauCA
        ' 
        lblDemiNiveauCA.AutoSize = True
        lblDemiNiveauCA.Location = New Point(258, 312)
        lblDemiNiveauCA.Name = "lblDemiNiveauCA"
        lblDemiNiveauCA.Size = New Size(13, 15)
        lblDemiNiveauCA.TabIndex = 270
        lblDemiNiveauCA.Text = "0"
        ' 
        ' lblDemiNiveauReflexes
        ' 
        lblDemiNiveauReflexes.AutoSize = True
        lblDemiNiveauReflexes.Location = New Point(258, 368)
        lblDemiNiveauReflexes.Name = "lblDemiNiveauReflexes"
        lblDemiNiveauReflexes.Size = New Size(13, 15)
        lblDemiNiveauReflexes.TabIndex = 269
        lblDemiNiveauReflexes.Text = "0"
        ' 
        ' lblModCaracSauvegardes
        ' 
        lblModCaracSauvegardes.AutoSize = True
        lblModCaracSauvegardes.Location = New Point(313, 285)
        lblModCaracSauvegardes.Name = "lblModCaracSauvegardes"
        lblModCaracSauvegardes.Size = New Size(65, 15)
        lblModCaracSauvegardes.TabIndex = 268
        lblModCaracSauvegardes.Text = "Mod Carac"
        ' 
        ' lblDemiNiveauSauvegardes
        ' 
        lblDemiNiveauSauvegardes.AutoSize = True
        lblDemiNiveauSauvegardes.Location = New Point(236, 285)
        lblDemiNiveauSauvegardes.Name = "lblDemiNiveauSauvegardes"
        lblDemiNiveauSauvegardes.Size = New Size(64, 15)
        lblDemiNiveauSauvegardes.TabIndex = 267
        lblDemiNiveauSauvegardes.Text = "1/2 Niveau"
        ' 
        ' lblVolonte
        ' 
        lblVolonte.AutoSize = True
        lblVolonte.Location = New Point(12, 397)
        lblVolonte.Name = "lblVolonte"
        lblVolonte.Size = New Size(47, 15)
        lblVolonte.TabIndex = 266
        lblVolonte.Text = "Volonté"
        ' 
        ' lblVigueur
        ' 
        lblVigueur.AutoSize = True
        lblVigueur.Location = New Point(12, 342)
        lblVigueur.Name = "lblVigueur"
        lblVigueur.Size = New Size(48, 15)
        lblVigueur.TabIndex = 265
        lblVigueur.Text = "Vigueur"
        ' 
        ' lblReflexes
        ' 
        lblReflexes.AutoSize = True
        lblReflexes.Location = New Point(12, 368)
        lblReflexes.Name = "lblReflexes"
        lblReflexes.Size = New Size(50, 15)
        lblReflexes.TabIndex = 264
        lblReflexes.Text = "Réflexes"
        ' 
        ' lblClasseArmure
        ' 
        lblClasseArmure.AutoSize = True
        lblClasseArmure.Location = New Point(12, 312)
        lblClasseArmure.Name = "lblClasseArmure"
        lblClasseArmure.Size = New Size(91, 15)
        lblClasseArmure.TabIndex = 263
        lblClasseArmure.Text = "Classe d'armure"
        ' 
        ' lblModCalculCharisme
        ' 
        lblModCalculCharisme.AutoSize = True
        lblModCalculCharisme.Location = New Point(360, 182)
        lblModCalculCharisme.Name = "lblModCalculCharisme"
        lblModCalculCharisme.Size = New Size(13, 15)
        lblModCalculCharisme.TabIndex = 68
        lblModCalculCharisme.Text = "0"
        ' 
        ' lblModCalculSagesse
        ' 
        lblModCalculSagesse.AutoSize = True
        lblModCalculSagesse.Location = New Point(360, 154)
        lblModCalculSagesse.Name = "lblModCalculSagesse"
        lblModCalculSagesse.Size = New Size(13, 15)
        lblModCalculSagesse.TabIndex = 67
        lblModCalculSagesse.Text = "0"
        ' 
        ' lblModCalculIntelligence
        ' 
        lblModCalculIntelligence.AutoSize = True
        lblModCalculIntelligence.Location = New Point(360, 126)
        lblModCalculIntelligence.Name = "lblModCalculIntelligence"
        lblModCalculIntelligence.Size = New Size(13, 15)
        lblModCalculIntelligence.TabIndex = 66
        lblModCalculIntelligence.Text = "0"
        ' 
        ' lblModCalculDexterite
        ' 
        lblModCalculDexterite.AutoSize = True
        lblModCalculDexterite.Location = New Point(360, 98)
        lblModCalculDexterite.Name = "lblModCalculDexterite"
        lblModCalculDexterite.Size = New Size(13, 15)
        lblModCalculDexterite.TabIndex = 65
        lblModCalculDexterite.Text = "0"
        ' 
        ' lblModCalculForce
        ' 
        lblModCalculForce.AutoSize = True
        lblModCalculForce.Location = New Point(360, 41)
        lblModCalculForce.Name = "lblModCalculForce"
        lblModCalculForce.Size = New Size(13, 15)
        lblModCalculForce.TabIndex = 64
        lblModCalculForce.Text = "0"
        ' 
        ' lblModCalculConstitution
        ' 
        lblModCalculConstitution.AutoSize = True
        lblModCalculConstitution.Location = New Point(360, 69)
        lblModCalculConstitution.Name = "lblModCalculConstitution"
        lblModCalculConstitution.Size = New Size(13, 15)
        lblModCalculConstitution.TabIndex = 63
        lblModCalculConstitution.Text = "0"
        ' 
        ' lblValCalculCharisme
        ' 
        lblValCalculCharisme.AutoSize = True
        lblValCalculCharisme.Location = New Point(271, 182)
        lblValCalculCharisme.Name = "lblValCalculCharisme"
        lblValCalculCharisme.Size = New Size(13, 15)
        lblValCalculCharisme.TabIndex = 62
        lblValCalculCharisme.Text = "0"
        ' 
        ' lblValCalculSagesse
        ' 
        lblValCalculSagesse.AutoSize = True
        lblValCalculSagesse.Location = New Point(271, 154)
        lblValCalculSagesse.Name = "lblValCalculSagesse"
        lblValCalculSagesse.Size = New Size(13, 15)
        lblValCalculSagesse.TabIndex = 61
        lblValCalculSagesse.Text = "0"
        ' 
        ' lblValCalculIntelligence
        ' 
        lblValCalculIntelligence.AutoSize = True
        lblValCalculIntelligence.Location = New Point(271, 126)
        lblValCalculIntelligence.Name = "lblValCalculIntelligence"
        lblValCalculIntelligence.Size = New Size(13, 15)
        lblValCalculIntelligence.TabIndex = 60
        lblValCalculIntelligence.Text = "0"
        ' 
        ' lblValCalculDexterite
        ' 
        lblValCalculDexterite.AutoSize = True
        lblValCalculDexterite.Location = New Point(271, 98)
        lblValCalculDexterite.Name = "lblValCalculDexterite"
        lblValCalculDexterite.Size = New Size(13, 15)
        lblValCalculDexterite.TabIndex = 59
        lblValCalculDexterite.Text = "0"
        ' 
        ' lblValCalculForce
        ' 
        lblValCalculForce.AutoSize = True
        lblValCalculForce.Location = New Point(271, 41)
        lblValCalculForce.Name = "lblValCalculForce"
        lblValCalculForce.Size = New Size(13, 15)
        lblValCalculForce.TabIndex = 58
        lblValCalculForce.Text = "0"
        ' 
        ' lblValCalculConstitution
        ' 
        lblValCalculConstitution.AutoSize = True
        lblValCalculConstitution.Location = New Point(271, 69)
        lblValCalculConstitution.Name = "lblValCalculConstitution"
        lblValCalculConstitution.Size = New Size(13, 15)
        lblValCalculConstitution.TabIndex = 57
        lblValCalculConstitution.Text = "0"
        ' 
        ' lblModRaceCharisme
        ' 
        lblModRaceCharisme.AutoSize = True
        lblModRaceCharisme.Location = New Point(457, 182)
        lblModRaceCharisme.Name = "lblModRaceCharisme"
        lblModRaceCharisme.Size = New Size(13, 15)
        lblModRaceCharisme.TabIndex = 56
        lblModRaceCharisme.Text = "0"
        ' 
        ' lblModRaceSagesse
        ' 
        lblModRaceSagesse.AutoSize = True
        lblModRaceSagesse.Location = New Point(457, 154)
        lblModRaceSagesse.Name = "lblModRaceSagesse"
        lblModRaceSagesse.Size = New Size(13, 15)
        lblModRaceSagesse.TabIndex = 55
        lblModRaceSagesse.Text = "0"
        ' 
        ' lblModRaceIntelligence
        ' 
        lblModRaceIntelligence.AutoSize = True
        lblModRaceIntelligence.Location = New Point(457, 126)
        lblModRaceIntelligence.Name = "lblModRaceIntelligence"
        lblModRaceIntelligence.Size = New Size(13, 15)
        lblModRaceIntelligence.TabIndex = 54
        lblModRaceIntelligence.Text = "0"
        ' 
        ' lblModRaceDexterite
        ' 
        lblModRaceDexterite.AutoSize = True
        lblModRaceDexterite.Location = New Point(457, 98)
        lblModRaceDexterite.Name = "lblModRaceDexterite"
        lblModRaceDexterite.Size = New Size(13, 15)
        lblModRaceDexterite.TabIndex = 53
        lblModRaceDexterite.Text = "0"
        ' 
        ' lblModRaceForce
        ' 
        lblModRaceForce.AutoSize = True
        lblModRaceForce.Location = New Point(457, 41)
        lblModRaceForce.Name = "lblModRaceForce"
        lblModRaceForce.Size = New Size(13, 15)
        lblModRaceForce.TabIndex = 52
        lblModRaceForce.Text = "0"
        ' 
        ' lblModRaceConstitution
        ' 
        lblModRaceConstitution.AutoSize = True
        lblModRaceConstitution.Location = New Point(457, 69)
        lblModRaceConstitution.Name = "lblModRaceConstitution"
        lblModRaceConstitution.Size = New Size(13, 15)
        lblModRaceConstitution.TabIndex = 51
        lblModRaceConstitution.Text = "0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(332, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 15)
        Label1.TabIndex = 44
        Label1.Text = "Mod Calculé"
        ' 
        ' lblValeurCalcul
        ' 
        lblValeurCalcul.AutoSize = True
        lblValeurCalcul.Location = New Point(245, 14)
        lblValeurCalcul.Name = "lblValeurCalcul"
        lblValeurCalcul.Size = New Size(87, 15)
        lblValeurCalcul.TabIndex = 43
        lblValeurCalcul.Text = "Valeur Calculée"
        ' 
        ' lblModRace
        ' 
        lblModRace.AutoSize = True
        lblModRace.Location = New Point(434, 14)
        lblModRace.Name = "lblModRace"
        lblModRace.Size = New Size(60, 15)
        lblModRace.TabIndex = 42
        lblModRace.Text = "Mod Race"
        ' 
        ' lblBase
        ' 
        lblBase.AutoSize = True
        lblBase.Location = New Point(122, 14)
        lblBase.Name = "lblBase"
        lblBase.Size = New Size(31, 15)
        lblBase.TabIndex = 41
        lblBase.Text = "Base"
        ' 
        ' lblCharisme
        ' 
        lblCharisme.AutoSize = True
        lblCharisme.Location = New Point(5, 182)
        lblCharisme.Name = "lblCharisme"
        lblCharisme.Size = New Size(57, 15)
        lblCharisme.TabIndex = 40
        lblCharisme.Text = "Charisme"
        ' 
        ' lblSagesse
        ' 
        lblSagesse.AutoSize = True
        lblSagesse.Location = New Point(5, 154)
        lblSagesse.Name = "lblSagesse"
        lblSagesse.Size = New Size(48, 15)
        lblSagesse.TabIndex = 39
        lblSagesse.Text = "Sagesse"
        ' 
        ' lblIntelligence
        ' 
        lblIntelligence.AutoSize = True
        lblIntelligence.Location = New Point(5, 126)
        lblIntelligence.Name = "lblIntelligence"
        lblIntelligence.Size = New Size(68, 15)
        lblIntelligence.TabIndex = 38
        lblIntelligence.Text = "Intelligence"
        ' 
        ' lblDexterite
        ' 
        lblDexterite.AutoSize = True
        lblDexterite.Location = New Point(5, 98)
        lblDexterite.Name = "lblDexterite"
        lblDexterite.Size = New Size(57, 15)
        lblDexterite.TabIndex = 37
        lblDexterite.Text = "Dextéritié"
        ' 
        ' lblConstitution
        ' 
        lblConstitution.AutoSize = True
        lblConstitution.Location = New Point(5, 69)
        lblConstitution.Name = "lblConstitution"
        lblConstitution.Size = New Size(73, 15)
        lblConstitution.TabIndex = 36
        lblConstitution.Text = "Constitution"
        ' 
        ' lblForce
        ' 
        lblForce.AutoSize = True
        lblForce.Location = New Point(5, 41)
        lblForce.Name = "lblForce"
        lblForce.Size = New Size(36, 15)
        lblForce.TabIndex = 35
        lblForce.Text = "Force"
        ' 
        ' tabGlobal
        ' 
        tabGlobal.Controls.Add(tabCaracteristique)
        tabGlobal.Controls.Add(tabCompetences)
        tabGlobal.Location = New Point(13, 112)
        tabGlobal.Name = "tabGlobal"
        tabGlobal.SelectedIndex = 0
        tabGlobal.Size = New Size(806, 524)
        tabGlobal.TabIndex = 9
        ' 
        ' lblPointExperienceAffichage
        ' 
        lblPointExperienceAffichage.AutoSize = True
        lblPointExperienceAffichage.Location = New Point(604, 42)
        lblPointExperienceAffichage.Name = "lblPointExperienceAffichage"
        lblPointExperienceAffichage.Size = New Size(13, 15)
        lblPointExperienceAffichage.TabIndex = 21
        lblPointExperienceAffichage.Text = "0"
        ' 
        ' lblNomPersonnageAffichage
        ' 
        lblNomPersonnageAffichage.AutoSize = True
        lblNomPersonnageAffichage.Location = New Point(148, 42)
        lblNomPersonnageAffichage.Name = "lblNomPersonnageAffichage"
        lblNomPersonnageAffichage.Size = New Size(0, 15)
        lblNomPersonnageAffichage.TabIndex = 22
        ' 
        ' lblClassePersoAffichage
        ' 
        lblClassePersoAffichage.AutoSize = True
        lblClassePersoAffichage.Location = New Point(150, 70)
        lblClassePersoAffichage.Name = "lblClassePersoAffichage"
        lblClassePersoAffichage.Size = New Size(0, 15)
        lblClassePersoAffichage.TabIndex = 23
        ' 
        ' lblRacePersoAffichage
        ' 
        lblRacePersoAffichage.AutoSize = True
        lblRacePersoAffichage.Location = New Point(489, 70)
        lblRacePersoAffichage.Name = "lblRacePersoAffichage"
        lblRacePersoAffichage.Size = New Size(0, 15)
        lblRacePersoAffichage.TabIndex = 24
        ' 
        ' lblPerilAffichage
        ' 
        lblPerilAffichage.AutoSize = True
        lblPerilAffichage.Location = New Point(1005, 103)
        lblPerilAffichage.Name = "lblPerilAffichage"
        lblPerilAffichage.Size = New Size(13, 15)
        lblPerilAffichage.TabIndex = 25
        lblPerilAffichage.Text = "0"
        ' 
        ' lblPeril
        ' 
        lblPeril.AutoSize = True
        lblPeril.Location = New Point(882, 102)
        lblPeril.Name = "lblPeril"
        lblPeril.Size = New Size(30, 15)
        lblPeril.TabIndex = 26
        lblPeril.Text = "Péril"
        ' 
        ' formFeuillePerso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1214, 675)
        Controls.Add(lblPerilAffichage)
        Controls.Add(lblPeril)
        Controls.Add(lblRacePersoAffichage)
        Controls.Add(lblClassePersoAffichage)
        Controls.Add(lblNomPersonnageAffichage)
        Controls.Add(lblPointExperienceAffichage)
        Controls.Add(ddlStuff)
        Controls.Add(ddlListePerso)
        Controls.Add(lblPVValeur)
        Controls.Add(lblPV)
        Controls.Add(lblInitiativeValeur)
        Controls.Add(lblInitiative)
        Controls.Add(btnVoirPerso)
        Controls.Add(lblNiveauCalcul)
        Controls.Add(lblNiveau)
        Controls.Add(lblPointExperience)
        Controls.Add(tabGlobal)
        Controls.Add(lblRacePersonnage)
        Controls.Add(lblClassePersonnage)
        Controls.Add(lblNomPersonnage)
        FormBorderStyle = FormBorderStyle.None
        Name = "formFeuillePerso"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Création de personnage"
        tabCompetences.ResumeLayout(False)
        tabCompetences.PerformLayout()
        tabCaracteristique.ResumeLayout(False)
        tabCaracteristique.PerformLayout()
        tabGlobal.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblNomPersonnage As Label
    Friend WithEvents lblClassePersonnage As Label
    Friend WithEvents lblRacePersonnage As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents lblPointExperience As Label
    Friend WithEvents lblNiveau As Label
    Friend WithEvents lblNiveauCalcul As Label
    Friend WithEvents btnVoirPerso As Button
    Friend WithEvents lblInitiative As Label
    Friend WithEvents lblInitiativeValeur As Label
    Friend WithEvents lblPVValeur As Label
    Friend WithEvents lblPV As Label
    Friend WithEvents ddlListePerso As ComboBox
    Friend WithEvents ddlStuff As CheckedListBox
    Friend WithEvents tabCompetences As TabPage
    Friend WithEvents chkFormAcrobaties As CheckBox
    Friend WithEvents chkFormArcanes As CheckBox
    Friend WithEvents chkFormAthletisme As CheckBox
    Friend WithEvents chkFormBluff As CheckBox
    Friend WithEvents chkFormConnDeLaRue As CheckBox
    Friend WithEvents chkFormDiplomatie As CheckBox
    Friend WithEvents chkFormDiscretion As CheckBox
    Friend WithEvents chkFormEndurance As CheckBox
    Friend WithEvents chkFormExploration As CheckBox
    Friend WithEvents chkFormHistoire As CheckBox
    Friend WithEvents chkFormIntimidation As CheckBox
    Friend WithEvents chkFormIntuition As CheckBox
    Friend WithEvents chkFormLarcin As CheckBox
    Friend WithEvents chkFormNature As CheckBox
    Friend WithEvents chkFormPerception As CheckBox
    Friend WithEvents chkFormReligion As CheckBox
    Friend WithEvents chkFormSoins As CheckBox
    Friend WithEvents lblTotalSoins As Label
    Friend WithEvents lblTotalReligion As Label
    Friend WithEvents lblTotalPerception As Label
    Friend WithEvents lblTotalNature As Label
    Friend WithEvents lblTotalLarcin As Label
    Friend WithEvents lblTotalIntuition As Label
    Friend WithEvents lblTotalIntimidation As Label
    Friend WithEvents lblTotalHistoire As Label
    Friend WithEvents lblTotalExploration As Label
    Friend WithEvents lblTotalEndurance As Label
    Friend WithEvents lblTotalDiscretion As Label
    Friend WithEvents lblTotalDiplomatie As Label
    Friend WithEvents lblTotalConnDeLaRue As Label
    Friend WithEvents lblTotalBluff As Label
    Friend WithEvents lblTotalAthletisme As Label
    Friend WithEvents lblTotalAcrobaties As Label
    Friend WithEvents lblTotalArcanes As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPenArmureSoins As Label
    Friend WithEvents lblDiversSoins As Label
    Friend WithEvents lblModRacialSoins As Label
    Friend WithEvents lblModCaracSoins As Label
    Friend WithEvents lblDemiNiveauSoins As Label
    Friend WithEvents lblPenArmureReligion As Label
    Friend WithEvents lblDiversReligion As Label
    Friend WithEvents lblModRacialReligion As Label
    Friend WithEvents lblModCaracReligion As Label
    Friend WithEvents lblDemiNiveauReligion As Label
    Friend WithEvents lblPenArmurePerception As Label
    Friend WithEvents lblDiversPerception As Label
    Friend WithEvents lblModRacialPerception As Label
    Friend WithEvents lblModCaracPerception As Label
    Friend WithEvents lblDemiNiveauPerception As Label
    Friend WithEvents lblPenArmureNature As Label
    Friend WithEvents lblDiversNature As Label
    Friend WithEvents lblModRacialNature As Label
    Friend WithEvents lblModCaracNature As Label
    Friend WithEvents lblDemiNiveauNature As Label
    Friend WithEvents lblPenArmureLarcin As Label
    Friend WithEvents lblDiversLarcin As Label
    Friend WithEvents lblModRacialLarcin As Label
    Friend WithEvents lblModCaracLarcin As Label
    Friend WithEvents lblDemiNiveauLarcin As Label
    Friend WithEvents lblPenArmureIntuition As Label
    Friend WithEvents lblDiversIntuition As Label
    Friend WithEvents lblModRacialIntuition As Label
    Friend WithEvents lblModCaracIntuition As Label
    Friend WithEvents lblDemiNiveauIntuition As Label
    Friend WithEvents lblPenArmureIntimidation As Label
    Friend WithEvents lblDiversIntimidation As Label
    Friend WithEvents lblModRacialIntimidation As Label
    Friend WithEvents lblModCaracIntimidation As Label
    Friend WithEvents lblDemiNiveauIntimidation As Label
    Friend WithEvents lblPenArmureHistoire As Label
    Friend WithEvents lblDiversHistoire As Label
    Friend WithEvents lblModRacialHistoire As Label
    Friend WithEvents lblModCaracHistoire As Label
    Friend WithEvents lblDemiNiveauHistoire As Label
    Friend WithEvents lblPenArmureExploration As Label
    Friend WithEvents lblDiversExploration As Label
    Friend WithEvents lblModRacialExploration As Label
    Friend WithEvents lblModCaracExploration As Label
    Friend WithEvents lblDemiNiveauExploration As Label
    Friend WithEvents lblPenArmureEndurance As Label
    Friend WithEvents lblDiversEndurance As Label
    Friend WithEvents lblModRacialEndurance As Label
    Friend WithEvents lblModCaracEndurance As Label
    Friend WithEvents lblDemiNiveauEndurance As Label
    Friend WithEvents lblPenArmureDiscretion As Label
    Friend WithEvents lblDiversDiscretion As Label
    Friend WithEvents lblModRacialDiscretion As Label
    Friend WithEvents lblModCaracDiscretion As Label
    Friend WithEvents lblDemiNiveauDiscretion As Label
    Friend WithEvents lblPenArmureDiplomatie As Label
    Friend WithEvents lblDiversDiplomatie As Label
    Friend WithEvents lblModRacialDiplomatie As Label
    Friend WithEvents lblPenArmureConnDeLaRue As Label
    Friend WithEvents lblDiversConnDeLaRue As Label
    Friend WithEvents lblModRacialConnDeLarue As Label
    Friend WithEvents lblPenArmureBluff As Label
    Friend WithEvents lblDiversBluff As Label
    Friend WithEvents lblModRacialBluff As Label
    Friend WithEvents lblPenArmureAthletisme As Label
    Friend WithEvents lblDiversAthletisme As Label
    Friend WithEvents lblModRacialAthletisme As Label
    Friend WithEvents lblPenArmureArcanes As Label
    Friend WithEvents lblDiversArcanes As Label
    Friend WithEvents lblModRacialArcanes As Label
    Friend WithEvents lblPenArmureAcrobaties As Label
    Friend WithEvents lblDiversAcrobaties As Label
    Friend WithEvents lblModRacialAcrobaties As Label
    Friend WithEvents lblSoins As Label
    Friend WithEvents lblReligion As Label
    Friend WithEvents lblPerception As Label
    Friend WithEvents lblNature As Label
    Friend WithEvents lblLarcin As Label
    Friend WithEvents lblIntuition As Label
    Friend WithEvents lblIntimidation As Label
    Friend WithEvents lblHistoire As Label
    Friend WithEvents lblExploration As Label
    Friend WithEvents lblEndurance As Label
    Friend WithEvents lblDiscretion As Label
    Friend WithEvents lblPenArmure As Label
    Friend WithEvents lblDivers As Label
    Friend WithEvents lblModRacial As Label
    Friend WithEvents lblModCaracDiplomatie As Label
    Friend WithEvents lblModCaracConnDeLaRue As Label
    Friend WithEvents lblModCaracBluff As Label
    Friend WithEvents lblModCaracAthletisme As Label
    Friend WithEvents lblModCaracAcrobaties As Label
    Friend WithEvents lblModCaracArcanes As Label
    Friend WithEvents lblDemiNiveauDiplomatie As Label
    Friend WithEvents lblDemiNiveauConnDeLaRue As Label
    Friend WithEvents lblDemiNiveauBluff As Label
    Friend WithEvents lblDemiNiveauAthletisme As Label
    Friend WithEvents lblDemiNiveauAcrobaties As Label
    Friend WithEvents lblDemiNiveauArcanes As Label
    Friend WithEvents lblFormation As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblDemiNiveau As Label
    Friend WithEvents lblDiplomatie As Label
    Friend WithEvents lblConnDeLaRue As Label
    Friend WithEvents lblBluff As Label
    Friend WithEvents lblAthletisme As Label
    Friend WithEvents lblArcanes As Label
    Friend WithEvents lblAcrobaties As Label
    Friend WithEvents tabCaracteristique As TabPage
    Friend WithEvents lblModClasseVolonte As Label
    Friend WithEvents lblModClasseVigueur As Label
    Friend WithEvents lblModClasseReflexes As Label
    Friend WithEvents lblModClasseCA As Label
    Friend WithEvents lblModClasseSauvegardes As Label
    Friend WithEvents lblTotalVolonte As Label
    Friend WithEvents lblTotalVigueur As Label
    Friend WithEvents lblTotalCA As Label
    Friend WithEvents lblTotalReflexes As Label
    Friend WithEvents lblTotalSauvegardes As Label
    Friend WithEvents lblPenArmureVolonte As Label
    Friend WithEvents lblDiversVolonte As Label
    Friend WithEvents lblModRacialVolonte As Label
    Friend WithEvents lblPenArmureVigueur As Label
    Friend WithEvents lblDiversVigueur As Label
    Friend WithEvents lblModRacialVigueur As Label
    Friend WithEvents lblPenArmureReflexes As Label
    Friend WithEvents lblDiversReflexes As Label
    Friend WithEvents lblModRacialReflexes As Label
    Friend WithEvents lblPenArmureCA As Label
    Friend WithEvents lblDiversCA As Label
    Friend WithEvents lblModRacialCA As Label
    Friend WithEvents lblPenArmureSauvegardes As Label
    Friend WithEvents lblDiversSauvegardes As Label
    Friend WithEvents lblModRacialSauvegardes As Label
    Friend WithEvents lblModCaracVolonte As Label
    Friend WithEvents lblModCaracVigueur As Label
    Friend WithEvents lblModCaracCA As Label
    Friend WithEvents lblModCaracReflexes As Label
    Friend WithEvents lblDemiNiveauVolonte As Label
    Friend WithEvents lblDemiNiveauVigueur As Label
    Friend WithEvents lblDemiNiveauCA As Label
    Friend WithEvents lblDemiNiveauReflexes As Label
    Friend WithEvents lblModCaracSauvegardes As Label
    Friend WithEvents lblDemiNiveauSauvegardes As Label
    Friend WithEvents lblVolonte As Label
    Friend WithEvents lblVigueur As Label
    Friend WithEvents lblReflexes As Label
    Friend WithEvents lblClasseArmure As Label
    Friend WithEvents lblModCalculCharisme As Label
    Friend WithEvents lblModCalculSagesse As Label
    Friend WithEvents lblModCalculIntelligence As Label
    Friend WithEvents lblModCalculDexterite As Label
    Friend WithEvents lblModCalculForce As Label
    Friend WithEvents lblModCalculConstitution As Label
    Friend WithEvents lblValCalculCharisme As Label
    Friend WithEvents lblValCalculSagesse As Label
    Friend WithEvents lblValCalculIntelligence As Label
    Friend WithEvents lblValCalculDexterite As Label
    Friend WithEvents lblValCalculForce As Label
    Friend WithEvents lblValCalculConstitution As Label
    Friend WithEvents lblModRaceCharisme As Label
    Friend WithEvents lblModRaceSagesse As Label
    Friend WithEvents lblModRaceIntelligence As Label
    Friend WithEvents lblModRaceDexterite As Label
    Friend WithEvents lblModRaceForce As Label
    Friend WithEvents lblModRaceConstitution As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblValeurCalcul As Label
    Friend WithEvents lblModRace As Label
    Friend WithEvents lblBase As Label
    Friend WithEvents lblCharisme As Label
    Friend WithEvents lblSagesse As Label
    Friend WithEvents lblIntelligence As Label
    Friend WithEvents lblDexterite As Label
    Friend WithEvents lblConstitution As Label
    Friend WithEvents lblForce As Label
    Friend WithEvents tabGlobal As TabControl
    Friend WithEvents lblPointExperienceAffichage As Label
    Friend WithEvents lblNomPersonnageAffichage As Label
    Friend WithEvents lblClassePersoAffichage As Label
    Friend WithEvents lblRacePersoAffichage As Label
    Friend WithEvents lblPerilAffichage As Label
    Friend WithEvents lblPeril As Label
    Friend WithEvents lblCharismeAffichage As Label
    Friend WithEvents lblSagesseAffichage As Label
    Friend WithEvents lblIntelligenceAffichage As Label
    Friend WithEvents lblDexteriteAffichage As Label
    Friend WithEvents lblForceAffichage As Label
    Friend WithEvents lblConstitutionAffichage As Label
End Class
