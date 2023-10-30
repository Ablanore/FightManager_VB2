Imports System.Text.Json
Imports System.IO
Imports System.Globalization
Imports System.Collections.ObjectModel

Public Class formInitiative
    Private PowerData As LesPowers = JsonSerializer.Deserialize(Of LesPowers)(File.ReadAllText(LaGrandeClasse.PowerDataAdresse))
    Private StuffData As LesStuffs = JsonSerializer.Deserialize(Of LesStuffs)(File.ReadAllText(LaGrandeClasse.StuffDataAdresse))
    Public lPersonnage As New List(Of Personnage)
    Public ListInitiative As New List(Of KeyValuePair(Of String, Integer))()
    Private StateInitiative As Boolean = True
    Private leForm As New formCombat()
    Private leTest As New TestAlaCon()
    Private Sub formInitiative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ListeDossier As New List(Of String)
        For Each s In My.Computer.FileSystem.GetDirectories(LaGrandeClasse.DossierDesZones)
            Dim WhereSlash As Short = 0
            While WhereSlash <> -1
                WhereSlash = s.IndexOf("\")
                s = s.Substring(WhereSlash + 1, s.Length - WhereSlash - 1)
            End While
            If s.Substring(0, 3) <> "zzz" Then
                ListeDossier.Add(s)
            End If
        Next
        ddlPersonnage.DataSource = ListeDossier
        ddlPersonnage.DisplayMember = "NomDossier"
        flpResultat.Hide()
    End Sub
    Private Sub btnLancerInititiative_Click(sender As Object, e As EventArgs) Handles btnLancerInititiative.Click
        If Not StateInitiative Then
            Exit Sub
        End If

        CalculInitiative(ListInitiative)
        ListInitiative = ListInitiative.OrderByDescending(Function(item) item.Value).ToList()
        flpResultat.Controls.Clear()
        flpResultat.Show()
        flpPersonnage.Controls.Clear()
        flpPersonnage.Hide()
        For Each entry As KeyValuePair(Of String, Integer) In ListInitiative
            RemplirFLPResultat(entry)
        Next
        StateInitiative = False
        'Ouverture du formCombat pour gérer le combat à venir à la suite du calcul de l'intiative
        With leForm
            .Name = "formCombatInit"
            .TopLevel = False
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .Dock = DockStyle.None
            .ListInitiative = ListInitiative
            .lPersonnage = lPersonnage
        End With
        ' Ajoutez le formulaire au contrôle Panel (ou autre contrôle de votre choix) du formulaire BaseLogiciel
        BaseLogiciel.Controls.Add(leForm)
        ' Affichez le formulaire 
        leForm.Show()
        ''Ouverture du testàla con pour faire des tests
        'With leTest
        '    .Name = "formCombatInit"
        '    .TopLevel = False
        '    .FormBorderStyle = FormBorderStyle.FixedDialog
        '    .Dock = DockStyle.Fill
        '    '.SetDesktopLocation(200, 450)
        '    .ListInitiative = ListInitiative
        '    .lPersonnage = lPersonnage
        'End With
        '' Ajoutez le formulaire au contrôle Panel (ou autre contrôle de votre choix) du formulaire BaseLogiciel
        'BaseLogiciel.Controls.Add(leTest)
        '' Affichez le formulaire 
        'leTest.Show()
    End Sub
    Private Sub CalculInitiative(ByRef ListInitiative As List(Of KeyValuePair(Of String, Integer)))
        For Each p In lPersonnage
            Dim txt As TextBox = Me.Controls.Find("txtInit" & p.Nom, True)(0)
            If txt.Text = "" Then
                ListInitiative.Add(New KeyValuePair(Of String, Integer)(p.Nom, CInt(p.Initiative + LaGrandeClasse.Jetdes(20, 1))))
            Else
                ListInitiative.Add(New KeyValuePair(Of String, Integer)(p.Nom, CInt(p.Initiative + txt.Text)))
            End If
        Next
    End Sub
    Private Sub RemplirFLPResultat(entry As KeyValuePair(Of String, Integer))
        Dim PersoIndex As New PersonnageSearch(entry.Key)
        Dim lePerso As Personnage = lPersonnage.Find(AddressOf PersoIndex.StartsWith)
        Dim lblNomperso As New Label
        With lblNomperso
            .Name = "lblNom_" & lePerso.Nom
            .Width = 250
            .Text = lePerso.Nom & " I : " & entry.Value & " D : " & lePerso.CaracteristiquesPerso.Dexterite.Valeur
        End With
        Dim flpPersonnage As New FlowLayoutPanel
        With flpPersonnage
            .FlowDirection = FlowDirection.LeftToRight
            .AutoSize = True
            .AutoSizeMode = AutoSizeMode.GrowOnly
            .Name = "flp_" & lePerso.Nom
            .Controls.Add(lblNomperso)
        End With
        flpResultat.Controls.Add(flpPersonnage)
    End Sub
    Private Sub ChargerPerso()
        For Each lePerso In lPersonnage
            Dim floLigne As New FlowLayoutPanel
            With floLigne
                .Name = "flo" & lePerso.Nom
                .FlowDirection = FlowDirection.LeftToRight
                .AutoSize = True
                .AutoSizeMode = AutoSizeMode.GrowOnly
            End With

            Dim lblNomPerso As New Label
            With lblNomPerso
                .Text = lePerso.Nom
                .Name = "lblNomPerso" & lePerso.Nom
                .Width = 150
            End With

            Dim txtScorDes As New TextBox
            With txtScorDes
                .Name = "txtInit" & lePerso.Nom
                .Width = 50
            End With

            With floLigne
                .Controls.Add(lblNomPerso)
                .Controls.Add(txtScorDes)
            End With
            flpPersonnage.Controls.Add(floLigne)
        Next
    End Sub
    Private Sub ddlPersonnage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlPersonnage.SelectedIndexChanged
        StateInitiative = True
        flpResultat.Controls.Clear()
        flpPersonnage.Controls.Clear()
        flpPersonnage.Show()
        flpResultat.Hide()
        lPersonnage.Clear()
        ListInitiative.Clear()
        leForm.Close()
        leForm = New formCombat()
        For Each perso In My.Computer.FileSystem.GetFiles(LaGrandeClasse.DossierDesPerso)
            ChargerTableauPerso(perso)
        Next
        For Each perso In My.Computer.FileSystem.GetFiles(LaGrandeClasse.DossierDesZones & "\" & ddlPersonnage.SelectedItem)
            ChargerTableauPerso(perso)
        Next
        ChargerPerso()
    End Sub
    Private Sub ChargerTableauPerso(perso As String)
        Dim unPerso As RecordPerso = JsonSerializer.Deserialize(Of RecordPerso)(File.ReadAllText(perso))
        Dim lePerso As New Personnage(unPerso.NomPerso, unPerso.TypePerso, unPerso.ClassePerso, unPerso.RacePerso, unPerso.TabCarac, unPerso.LesStuff, unPerso.LesPower, unPerso.PointExperiencePerso)
        lPersonnage.Add(lePerso)
    End Sub
End Class