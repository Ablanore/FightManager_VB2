Imports System.Text.Json
Imports System.IO

Public Class formInitiative
    Private tabPerso(-1) As Personnage
    Private Sub formInitiative_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each perso In My.Computer.FileSystem.GetFiles(LaGrandeClasse.DossierDesPerso)
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

    Private Sub btnLancerInititiative_Click(sender As Object, e As EventArgs) Handles btnLancerInititiative.Click
        Dim ListInitiative As SortedList = New SortedList()

        For Each p In tabPerso
            Dim lbl As Label = Me.Controls.Find("lblInitPerso" & p.Nom, True)(0)
            Dim txt As TextBox = Me.Controls.Find("txtInit" & p.Nom, True)(0)
            If txt.Text = "" Then
                lbl.Text = p.Initiative + LaGrandeClasse.Jetdes(20)
            Else
                lbl.Text = p.Initiative + txt.Text
            End If
            ListInitiative.Add(CInt(lbl.Text), p)
        Next
        Me.Controls.Clear()
        Dim floTruc As New FlowLayoutPanel
        floTruc.FlowDirection = FlowDirection.BottomUp
        floTruc.AutoSize = True
        floTruc.AutoSizeMode = AutoSizeMode.GrowOnly
        For Each i In ListInitiative.Values
            Dim lbl As New Label
            Dim perso As Personnage = i
            lbl.Text = perso.Nom & " : "
            floTruc.Controls.Add(lbl)
        Next
        Me.Controls.Add(floTruc)
    End Sub
End Class