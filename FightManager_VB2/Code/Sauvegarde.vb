Public Class Sauvegarde
	''' <summary>
	''' Enum pour déclarer les noms des sauvegardes (en espérant pouvoir itérer dessus)
	''' </summary>
	Enum EnumSauvegarde
		ClasseArmure
		Réflexes
		Vigueur
		Volonté
	End Enum
	Public Property Nom As String
	Public Property Valeur As Int16
	Public Sub New(nomParam As EnumSauvegarde, valeurParam As Int16)
		Dim names = [Enum].GetNames(GetType(EnumSauvegarde))
		Nom = names(nomParam)
		Valeur = valeurParam
	End Sub
End Class