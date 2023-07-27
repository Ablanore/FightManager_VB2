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
    Public Property Valeur As Int16
    Public Sub New(nomParam As EnumCompetence, FormationParam As Short, DemiNiveauParam As Short, laRaceParam As String, CaracParam As Caracteristique())

        Dim CompetenceCaracteristique = {{"Acrobaties", "2"}, {"Arcanes", " 3"}, {"Athletisme", " 0"}, {"Bluff", " 5"}, {"ConnDeLaRue", " 5"}, {"Diplomatie", " 5"}, {"Discretion", " 2"}, {"Endurance", " 1"}, {"Exploration", " 4"}, {"Histoire", " 3"}, {"Intimidation", " 5"}, {"Intuition", " 4"}, {"Larcin", " 2"}, {"Nature", " 4"}, {"Perception", " 4"}, {"Religion", " 3"}, {"Soins", " 4"}}

        'Détermination du nom de la compétence
        Dim names = [Enum].GetNames(GetType(EnumCompetence))
        Nom = names(nomParam)
        'Détermination de la valeur de la compétence
        'Rappel de la formule : 1/2 niveau + mod carac + formation + Mod racial + divers - pénalité armure
        Dim laRace As New Race(laRaceParam)
        Dim laCarac As Short
        For i As Integer = 0 To CompetenceCaracteristique.GetLength(0) - 1
            If CompetenceCaracteristique(i, 0) = nomParam.ToString() Then
                laCarac = CompetenceCaracteristique(i, 1)
                Exit For
            End If
        Next
        Valeur = DemiNiveauParam + FormationParam + laRace.Competences(nomParam).Valeur + CaracParam(laCarac).Modificateur

    End Sub
End Class