Public Class Sauvegarde
	''' <summary>
	''' Enum pour déclarer les noms des sauvegardes (en espérant pouvoir itérer dessus)
	''' </summary>
	Enum EnumSauvegarde
		ClasseArmure
		Reflexes
		Vigueur
		Volonté
	End Enum
	Public Property Nom As String
	Public Property Valeur As Short
	Public Property ModRacial As Short
	Public Property ModCarac As Short
	Public Sub New(nomParam As EnumSauvegarde, DemiLevelParam As Short, CaracParam As Short, laClasseParam As String)
		Dim names = [Enum].GetNames(GetType(EnumSauvegarde))
		Nom = names(nomParam)
		Dim laClasse As New Classe(laClasseParam)
		Valeur = 10 + DemiLevelParam + CaracParam + laClasse.Sauvegardes(nomParam).Valeur
		'formule : 10 + demiLVL + modCarac + modClasse + Talent + 
		'ATTENTION : il faut rajouter les talents
		Me.ModCarac = CaracParam
		Me.ModRacial = laClasse.Sauvegardes(nomParam).Valeur
	End Sub
End Class

Public Class Sauvegardes
	Public Property ClasseArmure As Sauvegarde
	Public Property Reflexes As Sauvegarde
	Public Property Vigueur As Sauvegarde
	Public Property Volonté As Sauvegarde
	Public Sub New(CaracteristiqueParam As Caracteristiques, DemiLevelParam As Short, laClasseParam As String)
		'CA : Dex ou Int + le stuff (à voir s'il ne serait pas plus simple de rajouter le stuff directement dans le Personnage)
		'Refelxes : Dex ou Int
		'Vigueur : For ou Con
		'Volonté : Sag ou Cha
		ClasseArmure = New Sauvegarde(Sauvegarde.EnumSauvegarde.ClasseArmure, DemiLevelParam, CompareCarac(CaracteristiqueParam.Dexterite, CaracteristiqueParam.Intelligence), laClasseParam)
		Reflexes = New Sauvegarde(Sauvegarde.EnumSauvegarde.ClasseArmure, DemiLevelParam, CompareCarac(CaracteristiqueParam.Dexterite, CaracteristiqueParam.Intelligence), laClasseParam)
		Vigueur = New Sauvegarde(Sauvegarde.EnumSauvegarde.ClasseArmure, DemiLevelParam, CompareCarac(CaracteristiqueParam.Force, CaracteristiqueParam.Constitution), laClasseParam)
		Volonté = New Sauvegarde(Sauvegarde.EnumSauvegarde.ClasseArmure, DemiLevelParam, CompareCarac(CaracteristiqueParam.Sagesse, CaracteristiqueParam.Charisme), laClasseParam)
	End Sub
	Private Function CompareCarac(Carac1 As Caracteristique, Carac2 As Caracteristique)
		If Carac1.Valeur < Carac2.Valeur Then
			Return Carac2.Modificateur
		Else
			Return Carac1.Modificateur
		End If
	End Function
End Class