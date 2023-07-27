Public Class Caracteristique
    ''' <summary>
    ''' Enum pour déclarer les noms des caractéristiques (en espérant pouvoir itérer dessus)
    ''' </summary>
    Enum EnumCaracteristique
        Force
        Constitution
        Dexterite
        Intelligence
        Sagesse
        Charisme
    End Enum

    Public Property Nom As String
    Public Property Valeur As Int16
    Public Property Modificateur As Int16
    Public Sub New(nomParam As EnumCaracteristique, valeurParam As Int16, laRaceParam As String)
        'Détermination du nom de la caractéristique
        Dim names = [Enum].GetNames(GetType(EnumCaracteristique))
        Nom = names(nomParam)
        'Détermination de la valeur de la caractéristique
        'Il faut remonter le bonus racial
        Dim laRace As New Race(laRaceParam)
        Valeur = valeurParam + laRace.Caracteristiques(nomParam).Valeur
        'Détermination du modificateur avec le calcul basique à partir de la valeur modifiée par la race.
        Modificateur = Math.Floor((Valeur - 10) / 2)
    End Sub
End Class