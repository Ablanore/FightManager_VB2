Public Class LaGrandeClasse
	Shared configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
	Public Shared RaceDataAdresse As String = configurationAppSettings.GetValue("RaceDataAdresse", GetType(System.String))
	Public Shared ClasseDataAdresse As String = configurationAppSettings.GetValue("ClasseDataAdresse", GetType(System.String))
End Class


Public Class LesClasses
	Public Property Classes As ClasseDef()
End Class

Public Class ClasseDef

	Public Property IdClasse As String
	Public Property NomClasse As String
	Public Property PointVieBase As Int16
	Public Property PointVieNiveau As Int16
	Public Property Recuperation As Int16
	Public Property Sauvegardes As SauvegardeDef()
	Public Property NombreCompetence As Int16
	Public Property Competences As CompetenceDef()
End Class

Public Class LesRaces
	Public Property Races As RaceDef()
End Class
Public Class RaceDef
	Public Property IdRace As String
	Public Property NomRaces As String
	Public Property Vitesse As Int16
	Public Property TailleMini As Int16
	Public Property TailelMaxi As Int16
	Public Property PoidsMini As Int16
	Public Property PoidsMaxi As Int16
	Public Property Taille As String
	Public Property Vision As String
	Public Property Caracteristiques As CaracteristiqueDef()
	Public Property Competences As CompetenceDefRace()
	Public Property Sauvegardes As SauvegardeDef()
End Class

Public Class SauvegardeDef
	Public Property Nom As String
	Public Property Valeur As Int16
End Class

Public Class CompetenceDef
	Public Property Nom As String
	Public Property Obligatoire As Boolean
End Class
Public Class CompetenceDefRace
	Public Property Nom As String
	Public Property Valeur As Int16
End Class

Public Class CaracteristiqueDef
	Public Property Nom As String
	Public Property Valeur As Int16
End Class
