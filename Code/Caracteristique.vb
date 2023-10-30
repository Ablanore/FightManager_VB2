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
    Public Property Valeur As Short
    Public Property Modificateur As Short
    Public Property ModificateurRacial As Short
    Public Sub New(nomParam As EnumCaracteristique, valeurParam As Short, laRaceParam As String, leStuff As List(Of String))
        'Détermination du nom de la caractéristique
        Dim names = [Enum].GetNames(GetType(EnumCaracteristique))
        Nom = names(nomParam)
        'Détermination de la valeur de la caractéristique
        'Il faut remonter le bonus racial
        Dim laRace As New Race(laRaceParam)
        'Itération des stuf du personnage reçu sous forme de tableau de string, comme sa Property de base StuffPersonnage
        Dim laCaracteristique As Short = 0
        For Each stuf In leStuff
            Dim leStuf As New Stuff(stuf)
            laCaracteristique += leStuf.CaracteristiquesStuff(nomParam).Valeur
        Next
        Valeur = valeurParam + laRace.Caracteristiques(nomParam).Valeur + laCaracteristique
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

    Public Sub New(ValeursParam() As Short, laRaceParam As String, leStuff As List(Of String))

        Force = New Caracteristique(Caracteristique.EnumCaracteristique.Force, ValeursParam(0), laRaceParam, leStuff)
        Constitution = New Caracteristique(Caracteristique.EnumCaracteristique.Constitution, ValeursParam(1), laRaceParam, leStuff)
        Dexterite = New Caracteristique(Caracteristique.EnumCaracteristique.Dexterite, ValeursParam(2), laRaceParam, leStuff)
        Intelligence = New Caracteristique(Caracteristique.EnumCaracteristique.Intelligence, ValeursParam(3), laRaceParam, leStuff)
        Sagesse = New Caracteristique(Caracteristique.EnumCaracteristique.Sagesse, ValeursParam(4), laRaceParam, leStuff)
        Charisme = New Caracteristique(Caracteristique.EnumCaracteristique.Charisme, ValeursParam(5), laRaceParam, leStuff)

    End Sub
End Class