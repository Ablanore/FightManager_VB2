Imports System.Text.Json
Imports System.IO
Imports FightManager_VB2.Sauvegarde

Public Class TestAlaCon
    Public ListInitiative As New List(Of KeyValuePair(Of String, Integer))()
    Public lPersonnage As New List(Of Personnage)
    ''Chargement de l'attaquant, par exemple Barash avec charge dévastatrice et son fléau
    'Private AttaquantData As RecordPerso = JsonSerializer.Deserialize(Of RecordPerso)(File.ReadAllText("D:\MesTrucsAMoi\Fignt Manager Documents\Personnages\Bharash_Franck.json"))
    'Private Attaquant As New Personnage(AttaquantData.NomPerso, AttaquantData.TypePerso, AttaquantData.ClassePerso, AttaquantData.RacePerso, AttaquantData.TabCarac, AttaquantData.LesStuff, AttaquantData.LesPower, AttaquantData.PointExperiencePerso)
    ''Chargement du défenseur, par exemple dracoprêtre 
    'Private DefenseurData As RecordPerso = JsonSerializer.Deserialize(Of RecordPerso)(File.ReadAllText("D:\MesTrucsAMoi\Fignt Manager Documents\ZoneScenario\2_Z1_l'embuscade kobold\Dracoprêtre.json"))
    'Private Defenseur As New Personnage(DefenseurData.NomPerso, DefenseurData.TypePerso, DefenseurData.ClassePerso, DefenseurData.RacePerso, DefenseurData.TabCarac, DefenseurData.LesStuff, DefenseurData.LesPower, DefenseurData.PointExperiencePerso)
    Private Sub TestAlaCon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With LstMembre
            .Name = "chkListMember"
            .DataSource = ListInitiative
        End With

        Dim toolTip1 As New ToolTip()
        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 1000
        toolTip1.ReshowDelay = 500
        ' Force the ToolTip text to be displayed whether or not the form is active.
        toolTip1.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        toolTip1.SetToolTip(Me.TextBox1, "My biloute")
        toolTip1.SetToolTip(Me.btnTest, "My biloute")

        ''trouver l'arme : faire une ddl et récupérer l'id de l'arme
        'Dim ArmeAttaquant As New Stuff("FleaudArmeLourd")
        ''trouver le pouvoir : faire une ddl et récupérer l'id du pouvoir
        'Dim PowerAttaquand As New Power("ChargeDevastatrice")
        ''Chargement des valeurs dans les labels 
        'lblNomCaracAttaquant.Text = Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquand.Attaque, "Modificateur")
        'lblCaracAttaquant.Text = PowerAttaquand.Attaque
        'lblDemiLvlAttaquant.Text = Attaquant.DemiNiveau
        'lblNomAttaquant.Text = Attaquant.Nom
        'lblManiementAttaquant.Text = ArmeAttaquant.Maniement
        'lblNomArmeAttaquant.Text = ArmeAttaquant.NomStuff
        'lblBonusAttaqueAttaquant.Text = Attaquant.DemiNiveau + Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquand.Attaque, "Modificateur") + ArmeAttaquant.Maniement + 0

        'lblNomCaracDefenseur.Text = Defenseur.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquand.Defense, "Modificateur")
        'lblCaracDefenseur.Text = PowerAttaquand.Defense
        'lblDemiLvlDefenseur.Text = Defenseur.DemiNiveau
        'lblNomDefenseur.Text = Defenseur.Nom
        'lblBonusDefense.Text = Defenseur.TrouverValeur(Personnage.enumLeType.Sauvegarde, PowerAttaquand.Defense, "Valeur")

    End Sub
    Enum EnumSauvegardes
        ClasseArmure
        Vigueur
        Reflexes
        Volonte
    End Enum

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        MessageBox.Show("Nb coche " & LstMembre.CheckedItems.Count)
        For Each DefenseurKVP As KeyValuePair(Of String, Integer) In LstMembre.CheckedItems

            Dim DefenseurIndex As New PersonnageSearch(DefenseurKVP.Key)
            Dim Defenseur As Personnage = lPersonnage.Find(AddressOf DefenseurIndex.StartsWith)
            MessageBox.Show("Biloute est : " & DefenseurKVP.Key & " pour le personnage : " & Defenseur.Nom)
        Next

        'Dim strResult As String = ""
        'For i = 0 To 20
        '    strResult &= "Shoot à : " & TourDeFight() & vbCrLf
        'Next
        'My.Computer.Clipboard.SetText(strResult)
        'MessageBox.Show(strResult)
    End Sub
    Function TourDeFight() As String
        Dim ResultDe As Short = LaGrandeClasse.Jetdes(20, 1)
        'Récupération du pouvoir utilisé
        Dim PowerAttaquant As New Power("ChargeDevastatrice")
        Dim ArmeAttaquant As New Stuff("FleaudArmeLourd")

        'Définition de l'attaquant en le piochant dans la liste des personnages
        Dim ListStuf As New List(Of String)
        ListStuf.Add("Dague")
        ListStuf.Add("FleaudArmeLourd")
        Dim ListPower As New List(Of String)
        ListPower.Add("ChargeDevastatrice")
        ListPower.Add("ChargePoussante")
        ListPower.Add("GuidingStrike")
        Dim Attaquant As New Personnage("biloute", "Joueur", "Barbare", "Drakeide", {18, 18, 14, 15, 10, 10}, ListStuf, ListPower, 2000)
        'Définition du défenseur en le piochant dans la liste des personnages
        Dim Defenseur As New Personnage("biloute", "Joueur", "Barbare", "Drakeide", {4, 4, 4, 4, 4, 4}, ListStuf, ListPower, 2000)
        'Détermination de la valeur d'attaque en prenant tous les paramètres possibles, les vides devant être gérés en amont par l'arme vide ou autre.
        Dim ValeurAttaque As Short = Attaquant.DemiNiveau + Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquant.Attaque, "Modificateur") + ArmeAttaquant.Maniement + ResultDe
        'Récupération de la défense, normalement, tous les éléments ont été traites par la sauvegarde au nevau du personnage.
        Dim ValeurDefense As Short = Defenseur.TrouverValeur(Personnage.enumLeType.Sauvegarde, PowerAttaquant.Defense, "Valeur")
        'Comparaison de l'attaque et de la défense
        Dim strMontantDegat As String = ""
        If ValeurAttaque >= ValeurDefense Then
            Dim DegatArme As Short = 0
            Dim DegatPouvoir As Short = 0
            If ResultDe = 20 Then
                DegatArme = ArmeAttaquant.NbDesDegat * ArmeAttaquant.NbFaceDesDegat
                DegatPouvoir = PowerAttaquant.NbDesDegat * PowerAttaquant.NbFaceDesDegat
            Else
                DegatArme = LaGrandeClasse.Jetdes(ArmeAttaquant.NbFaceDesDegat, ArmeAttaquant.NbDesDegat)
                DegatPouvoir = LaGrandeClasse.Jetdes(PowerAttaquant.NbFaceDesDegat, PowerAttaquant.NbDesDegat)
            End If

            Dim MontantDegat As Short = DegatPouvoir + DegatArme + ArmeAttaquant.BonusDegat + PowerAttaquant.MontantBonusDegat + Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquant.CaracBonusDegat, PowerAttaquant.TypeBonusDegat)
            strMontantDegat = "Dégat de l'arme : " & DegatArme.ToString() & " dégat du pouvoir : " & DegatPouvoir.ToString() & " Bonus de l'arme : " & ArmeAttaquant.BonusDegat.ToString() & " Bonus pouvoir : " & PowerAttaquant.MontantBonusDegat.ToString() & " modificateur de carac : " & Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquant.CaracBonusDegat, PowerAttaquant.TypeBonusDegat).ToString() & " pour un total de : " & MontantDegat.ToString()
        End If

        Return strMontantDegat
    End Function

End Class