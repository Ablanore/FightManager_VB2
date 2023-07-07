Public Class Caracteristique
    ''' <summary>
    ''' Enum pour déclarer les noms des caractéristiques (en espérant pouvoir itérer dessus
    ''' </summary>
    Enum EnumCaracteristique
        Force = 1
        Constitution = 2
        Dexterite = 3
        Intelligence = 4
        Sagesse = 5
        Charisme = 6
    End Enum

    Property nom As EnumCaracteristique
    Property valeur As Int16
    Private _modificateur As Int16
    Property modificateur As Int16
        Get
            Return _modificateur
        End Get
        Set(value As Int16)

        End Set
    End Property

    Public Sub New(nom As EnumCaracteristique, valeur As Int16)
        nom = nom
        valeur = valeur
        _modificateur = Math.Floor((valeur - 10) / 2)
    End Sub
End Class