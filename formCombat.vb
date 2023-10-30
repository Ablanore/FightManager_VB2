Imports System.Collections.ObjectModel
Imports System.Text.Json
Imports System.IO
Imports System.Security.Cryptography
Imports FightManager_VB2.Sauvegarde
Imports System.Reflection.Metadata.Ecma335

Public Class formCombat
    Public lPersonnage As New List(Of Personnage)
    Public ListInitiative As New List(Of KeyValuePair(Of String, Integer))()
    'Private LstMembre As New CheckedListBox
    Private Sub formCombat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim lstMembre As New MyCheckedListBox
        With lstMembre
            .Name = "chkListMember"
            .DataSource = ListInitiative
            .Location = New Point(0, 50)
            .Size = New Point(150, 688)
            .CheckOnClick = True
            .ScrollAlwaysVisible = False
            .BorderStyle = BorderStyle.FixedSingle
            .DrawMode = DrawMode.OwnerDrawVariable
        End With
        Me.Controls.Add(lstMembre)

        'Pose des titres
        RemplissageTitre()
        'Remplisage des éléments du FLP
        For Each entry As KeyValuePair(Of String, Integer) In ListInitiative
            RemplirFLPResultat(entry)
        Next
    End Sub
    Private Sub RemplirFLPResultat(entry As KeyValuePair(Of String, Integer))
        Dim PersoIndex As New PersonnageSearch(entry.Key)
        Dim lePerso As Personnage = lPersonnage.Find(AddressOf PersoIndex.StartsWith)

        'Label pour afficher le nom du personnage avec son initiative
        Dim lblNomperso As New Label
        With lblNomperso
            .Name = "lblNom_" & lePerso.Nom
            .Width = 200
            .Text = lePerso.Nom & " I : " & entry.Value
        End With
        'Label pour afficher les points de vie courant du personnage concerné
        Dim lblPVtitre As New Label
        With lblPVtitre
            .Name = "lblPVtitre_" & lePerso.Nom
            .Width = 50
            .Text = "PV : "
        End With
        'Label pour afficher les points de vie courant du personnage concerné
        Dim lblPV As New Label
        With lblPV
            .Name = "lblPV_" & lePerso.Nom
            .Width = 50
            .Text = lePerso.PV
            AddHandler .TextChanged, Sub(sender As Object, e As EventArgs)
                                         lblPV_TextChanged(sender, e, lePerso)
                                     End Sub
        End With
        'ddl pour lister les stuff 
        Dim ddlStuf As New ComboBox
        With ddlStuf
            .Name = "ddlStuff_" & lePerso.Nom
            .DataSource = lePerso.StuffPersonnage

        End With
        'ddl pour lister les pouvoirs ; prévoir le add handler
        Dim ddlPower As New ComboBox
        With ddlPower
            .Name = "ddlPower_" & lePerso.Nom
            .DataSource = lePerso.PowerPersonnage
            AddHandler ddlPower.SelectedIndexChanged, Sub(sender As Object, e As EventArgs)
                                                          ddlPower_SelectedIndexChanged(sender, e, lePerso)
                                                      End Sub
        End With
        'textbox pour ajouter les avantages de combat ou d'autres trucs qu'on a pas encore programmé
        Dim txtAvantage As New TextBox
        With txtAvantage
            .Name = "txtAvantage_" & lePerso.Nom
            .Width = 50
            .Text = "0"

        End With
        'textbox pour récupérer le résutlat du réel pour l'attaque
        Dim txtDeAtaque As New TextBox
        With txtDeAtaque
            .Name = "txtDeAtt_" & lePerso.Nom
            .Width = 50
            .Text = "0"
        End With
        'textbox pour récupérer le résutlat du réel pour les dégâts
        Dim txtDeDegat As New TextBox
        With txtDeDegat
            .Name = "txtDeDeg_" & lePerso.Nom
            .Width = 50
            .Text = "0"
        End With
        Dim flpUnPersonnage As New FlowLayoutPanel
        With flpUnPersonnage
            .FlowDirection = FlowDirection.LeftToRight
            .AutoSize = True
            .AutoSizeMode = AutoSizeMode.GrowOnly
            .Name = "flp_" & lePerso.Nom
            With .Controls
                .Add(lblNomperso)
                .Add(lblPVtitre)
                .Add(lblPV)
                .Add(ddlStuf)
                .Add(ddlPower)
                .Add(txtAvantage)
                .Add(txtDeAtaque)
                .Add(txtDeDegat)
            End With
        End With
        flpPersonnages.Controls.Add(flpUnPersonnage)
    End Sub
    Private Sub ddlPower_SelectedIndexChanged(sender As Object, e As EventArgs, lePerso As Personnage)
        Dim ddl As ComboBox = DirectCast(sender, ComboBox)
        Dim Attaquant As Personnage = lePerso
        'Détermination du jet d'attaque avec test pour savoir si c'est un jet réel ou Engine
        Dim ResultDe As Short = 0
        Dim txtDeAtt As TextBox = Me.Controls.Find("txtDeAtt_" & Attaquant.Nom, True).First
        If txtDeAtt.Text = 0 Then
            ResultDe = LaGrandeClasse.Jetdes(20, 1)
        Else
            ResultDe = txtDeAtt.Text
        End If
        'Récupération du pouvoir utilisé
        Dim PowerAttaquant As New Power(ddl.SelectedItem)
        'trouver l'arme dans le ddl du stuff du personnage si le pouvoir utilise une arme, sinon, stuffbase pour avoir une arme vide
        Dim ArmeAttaquant As New Stuff("StuffBase")
        If PowerAttaquant.NombreArme <> 0 Then
            Dim ddlS As ComboBox = Me.Controls.Find("ddlStuff_" & Attaquant.Nom, True).First
            ArmeAttaquant = New Stuff(ddlS.SelectedItem)
        End If

        'Détermination de la valeur d'attaque en prenant tous les paramètres possibles, les vides devant être gérés en amont par l'arme vide ou autre.
        Dim txtAvantage As TextBox = Me.Controls.Find("txtAvantage_" & Attaquant.Nom, True).First
        Dim ValeurAttaque As Short = Attaquant.DemiNiveau + Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquant.Attaque, "Modificateur") + ArmeAttaquant.Maniement + ResultDe + txtAvantage.Text
        'Test pour savoir s'il ya réussite ou échec critique et ensuite attribution des points de dégât.
        Dim DegatArme As Short = 0
        Dim DegatPouvoir As Short = 0
        Select Case ResultDe
            Case 1
                MessageBox.Show(Attaquant.Nom & " loupe son coup et se retrouve sur le cul.")
                'voir le truc à mettre pour indiquer "joueur suivant" et gérer les statuts, genre le cul par terre
            Case 20
                DegatArme = ArmeAttaquant.NbDesDegat * ArmeAttaquant.NbFaceDesDegat
                DegatPouvoir = PowerAttaquant.NbDesDegat * PowerAttaquant.NbFaceDesDegat
            Case Else
                Dim txtDeDegat As TextBox = Me.Controls.Find("txtDeDeg_" & Attaquant.Nom, True).First
                If txtDeDegat.Text <> 0 Then
                    DegatArme = 0
                    DegatPouvoir = txtDeDegat.Text
                Else
                    DegatArme = LaGrandeClasse.Jetdes(ArmeAttaquant.NbFaceDesDegat, ArmeAttaquant.NbDesDegat)
                    DegatPouvoir = LaGrandeClasse.Jetdes(PowerAttaquant.NbFaceDesDegat, PowerAttaquant.NbDesDegat)
                End If

        End Select
        Dim MontantDegat As Short = DegatPouvoir + DegatArme + ArmeAttaquant.BonusDegat + PowerAttaquant.MontantBonusDegat + Attaquant.TrouverValeur(Personnage.enumLeType.Caracteristique, PowerAttaquant.CaracBonusDegat, PowerAttaquant.TypeBonusDegat)

        'Rotation sur l'ensemble des cibles cochées dans la liste
        For Each DefenseurKVP As KeyValuePair(Of String, Integer) In zzz.CheckedItems
            'Définition du défenseur en le piochant dans la liste des personnages
            Dim DefenseurIndex As New PersonnageSearch(DefenseurKVP.Key)
            Dim Defenseur As Personnage = lPersonnage.Find(AddressOf DefenseurIndex.StartsWith)
            'Récupération de la défense, normalement, tous les éléments ont été traites par la sauvegarde au nevau du personnage.
            Dim ValeurDefense As Short = Defenseur.TrouverValeur(Personnage.enumLeType.Sauvegarde, PowerAttaquant.Defense, "Valeur")
            'Comparaison de l'attaque et de la défense
            If ValeurAttaque >= ValeurDefense And ResultDe <> 1 Then
                MessageBox.Show(Attaquant.Nom & " gagne contre " & Defenseur.Nom & " avec un jet de : " & ValeurAttaque & " contre : " & ValeurDefense & vbCrLf & Attaquant.Nom & " fait " & MontantDegat & " points de dégât à " & Defenseur.Nom & ".")
                Defenseur.PV = Defenseur.PV - MontantDegat
                Dim LabelPV As Label = Me.Controls.Find("lblPV_" & Defenseur.Nom, True).First
                LabelPV.Text = Defenseur.PV
            Else
                MessageBox.Show(Attaquant.Nom & " loupe son coup contre " & Defenseur.Nom & ".")
            End If
        Next
    End Sub
    Private Sub lblPV_TextChanged(sender As Object, e As EventArgs, lePerso As Personnage)
        Dim lbl As Label = DirectCast(sender, Label)
        If lbl.Text <= lePerso.Peril Then
            lbl.BackColor = Color.Orange
            If lbl.Text <= 0 Then
                lbl.BackColor = Color.Red
            End If
        End If
    End Sub
    Private Sub RemplissageTitre()
        Dim lblTitreNomPerso As New Label
        With lblTitreNomPerso
            .Name = "lblTitre_NomPerso"
            .Width = 200
            .Text = "Nom du personnage / mob"
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Dim lblTitrePVTitre As New Label
        With lblTitrePVTitre
            .Name = "lblTitre_PVTitre"
            .Width = 105
            .Text = "Les PV"
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Dim lblTitreStuff As New Label
        With lblTitreStuff
            .Name = "lblTitre_Stuff"
            .Width = 120
            .Text = "Choix du Stuff"
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Dim lblTitrePower As New Label
        With lblTitrePower
            .Name = "lblTitre_Power"
            .Width = 120
            .Text = "Choix du Power"
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Dim lblTitreAvantage As New Label
        With lblTitreAvantage
            .Name = "lblTitre_Avantage"
            .Width = 50
            .Height = 40
            .Text = "Bonus toucher"
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Dim lblTitreDeAttaque As New Label
        With lblTitreDeAttaque
            .Name = "lblTitre_DeAttaque"
            .Width = 50
            .Height = 40
            .Text = "De d'attaque"
            .BorderStyle = BorderStyle.FixedSingle

        End With
        Dim lblTitreDeDegat As New Label
        With lblTitreDeDegat
            .Name = "lblTitre_DeDegat"
            .Width = 50
            .Height = 40
            .Text = "Dé de dégât"
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Dim flpTitre As New FlowLayoutPanel
        With flpTitre
            .FlowDirection = FlowDirection.LeftToRight
            .AutoSize = True
            .AutoSizeMode = AutoSizeMode.GrowOnly
            .Name = "flp_titre"
            With .Controls
                .Add(lblTitreNomPerso)
                .Add(lblTitrePVTitre)
                .Add(lblTitreStuff)
                .Add(lblTitrePower)
                .Add(lblTitreAvantage)
                .Add(lblTitreDeAttaque)
                .Add(lblTitreDeDegat)
            End With
        End With
        flpPersonnages.Controls.Add(flpTitre)
    End Sub
End Class
Public NotInheritable Class MyCheckedListBox
    Inherits CheckedListBox
    Public Sub New()
        ItemHeight = 35
    End Sub
    Public Overrides Property ItemHeight As Integer
End Class
