Imports System.Windows
Public Class Competence
    ''' <summary>
    ''' Enum pour déclarer les noms des compétences (en espérant pouvoir itérer dessus)
    ''' </summary>
    Enum EnumCompetence
        Acrobaties
        Arcanes
        Athletisme
        Bluff
        ConnDeLaRue
        Diplomatie
        Discretion
        Endurance
        Exploration
        Histoire
        Intuition
        Intimidation
        Larcin
        Nature
        Perception
        Religion
        Soins
    End Enum
    Public Property Nom As String
    Public Property Valeur As Short
    Public Property ModRacial As Short
    Public Property ModCarac As Short
    Public Property PenArmure As Short
    Public Property Divers As Short
    Public Property Formation As Short

    Public Sub New(nomParam As EnumCompetence, FormationParam As Boolean, DemiNiveauParam As Short, laRaceParam As String, CaracParam As Short)
        'Détermination du nom de la compétence
        Dim names = [Enum].GetNames(GetType(EnumCompetence))
        Me.Nom = names(nomParam)
        'Détermination de la valeur de la compétence
        'Rappel de la formule : 1/2 niveau + mod carac + formation + Mod racial + divers - pénalité armure
        Dim laRace As New Race(laRaceParam)
        Dim ValueFormation As Short = 0
        If FormationParam Then
            ValueFormation = 5
        Else
            ValueFormation = 0
        End If
        Valeur = DemiNiveauParam + ValueFormation + laRace.Competences(nomParam).Valeur + CaracParam
        Me.ModRacial = laRace.Competences(nomParam).Valeur
        Me.ModCarac = CaracParam
        Me.PenArmure = 0
        Me.Divers = 0
        Me.Formation = ValueFormation


        'Dim CompetenceCaracteristique = {{"Acrobaties", "2"}, {"Arcanes", " 3"}, {"Athletisme", " 0"}, {"Bluff", " 5"}, {"ConnDeLaRue", " 5"}, {"Diplomatie", " 5"}, {"Discretion", " 2"}, {"Endurance", " 1"}, {"Exploration", " 4"}, {"Histoire", " 3"}, {"Intimidation", " 5"}, {"Intuition", " 4"}, {"Larcin", " 2"}, {"Nature", " 4"}, {"Perception", " 4"}, {"Religion", " 3"}, {"Soins", " 4"}}
        'Dim laCarac As Short
        'For i As Integer = 0 To CompetenceCaracteristique.GetLength(0) - 1
        '    If CompetenceCaracteristique(i, 0) = nomParam.ToString() Then
        '        laCarac = CompetenceCaracteristique(i, 1)
        '        Exit For
        '    End If
        'Next
    End Sub
End Class

Public Class Competences
    Public Property Acrobaties As Competence
    Public Property Arcanes As Competence
    Public Property Athletisme As Competence
    Public Property Bluff As Competence
    Public Property ConnDeLaRue As Competence
    Public Property Diplomatie As Competence
    Public Property Discretion As Competence
    Public Property Endurance As Competence
    Public Property Exploration As Competence
    Public Property Histoire As Competence
    Public Property Intuition As Competence
    Public Property Intimidation As Competence
    Public Property Larcin As Competence
    Public Property Nature As Competence
    Public Property Perception As Competence
    Public Property Religion As Competence
    Public Property Soins As Competence

    Public Sub New(FormationParam As Boolean(), DemiNiveauParam As Short, laRaceParam As String, CaracParam As Caracteristiques)
        Acrobaties = New Competence(Competence.EnumCompetence.Acrobaties, FormationParam(0), DemiNiveauParam, laRaceParam, CaracParam.Dexterite.Modificateur)
        Arcanes = New Competence(Competence.EnumCompetence.Arcanes, FormationParam(1), DemiNiveauParam, laRaceParam, CaracParam.Intelligence.Modificateur)
        Athletisme = New Competence(Competence.EnumCompetence.Athletisme, FormationParam(2), DemiNiveauParam, laRaceParam, CaracParam.Force.Modificateur)
        Bluff = New Competence(Competence.EnumCompetence.Bluff, FormationParam(3), DemiNiveauParam, laRaceParam, CaracParam.Charisme.Modificateur)
        ConnDeLaRue = New Competence(Competence.EnumCompetence.ConnDeLaRue, FormationParam(4), DemiNiveauParam, laRaceParam, CaracParam.Charisme.Modificateur)
        Diplomatie = New Competence(Competence.EnumCompetence.Diplomatie, FormationParam(5), DemiNiveauParam, laRaceParam, CaracParam.Charisme.Modificateur)
        Discretion = New Competence(Competence.EnumCompetence.Discretion, FormationParam(6), DemiNiveauParam, laRaceParam, CaracParam.Dexterite.Modificateur)
        Endurance = New Competence(Competence.EnumCompetence.Endurance, FormationParam(7), DemiNiveauParam, laRaceParam, CaracParam.Constitution.Modificateur)
        Exploration = New Competence(Competence.EnumCompetence.Exploration, FormationParam(8), DemiNiveauParam, laRaceParam, CaracParam.Sagesse.Modificateur)
        Histoire = New Competence(Competence.EnumCompetence.Histoire, FormationParam(9), DemiNiveauParam, laRaceParam, CaracParam.Intelligence.Modificateur)
        Intimidation = New Competence(Competence.EnumCompetence.Intimidation, FormationParam(10), DemiNiveauParam, laRaceParam, CaracParam.Charisme.Modificateur)
        Intuition = New Competence(Competence.EnumCompetence.Intuition, FormationParam(11), DemiNiveauParam, laRaceParam, CaracParam.Sagesse.Modificateur)
        Larcin = New Competence(Competence.EnumCompetence.Larcin, FormationParam(12), DemiNiveauParam, laRaceParam, CaracParam.Dexterite.Modificateur)
        Nature = New Competence(Competence.EnumCompetence.Nature, FormationParam(13), DemiNiveauParam, laRaceParam, CaracParam.Sagesse.Modificateur)
        Perception = New Competence(Competence.EnumCompetence.Perception, FormationParam(14), DemiNiveauParam, laRaceParam, CaracParam.Sagesse.Modificateur)
        Religion = New Competence(Competence.EnumCompetence.Religion, FormationParam(15), DemiNiveauParam, laRaceParam, CaracParam.Intelligence.Modificateur)
        Soins = New Competence(Competence.EnumCompetence.Soins, FormationParam(16), DemiNiveauParam, laRaceParam, CaracParam.Sagesse.Modificateur)
    End Sub
End Class