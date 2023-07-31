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
    Public Property ModificateurRacial As Int16
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
        ModificateurRacial = laRace.Caracteristiques(nomParam).Valeur
    End Sub
End Class

Public Class Caracteristiques
    Public Property Force As Caracteristique
    Public Property Constitution As Caracteristique
    Public Property Dexterite As Caracteristique
    Public Property Intelligence As Caracteristique
    Public Property Sagesse As Caracteristique
    Public Property Charisme As Caracteristique

    Public Sub New(ValeursParam() As Int16, laRaceParam As String)

        Force = New Caracteristique(Caracteristique.EnumCaracteristique.Force, ValeursParam(0), laRaceParam)
        Constitution = New Caracteristique(Caracteristique.EnumCaracteristique.Constitution, ValeursParam(1), laRaceParam)
        Dexterite = New Caracteristique(Caracteristique.EnumCaracteristique.Dexterite, ValeursParam(2), laRaceParam)
        Intelligence = New Caracteristique(Caracteristique.EnumCaracteristique.Intelligence, ValeursParam(3), laRaceParam)
        Sagesse = New Caracteristique(Caracteristique.EnumCaracteristique.Sagesse, ValeursParam(4), laRaceParam)
        Charisme = New Caracteristique(Caracteristique.EnumCaracteristique.Charisme, ValeursParam(5), laRaceParam)

    End Sub
End Class