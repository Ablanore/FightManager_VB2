Public Class LaGrandeClasse
	Shared configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
	Public Shared RaceDataAdresse As String = configurationAppSettings.GetValue("RaceDataAdresse", GetType(System.String))
	Public Shared ClasseDataAdresse As String = configurationAppSettings.GetValue("ClasseDataAdresse", GetType(System.String))
	Public Shared StuffDataAdresse As String = configurationAppSettings.GetValue("StuffDataAdresse", GetType(System.String))
	Public Shared PowerDataAdresse As String = configurationAppSettings.GetValue("powerDataAdresse", GetType(System.String))
	Public Shared DossierDesPerso As String = configurationAppSettings.GetValue("DossierDesPersos", GetType(System.String))
	Public Shared Function Jetdes(nbFace As Short) As Short
		Randomize()
		Return CInt(Int((nbFace * Rnd()) + 1))
	End Function
End Class

Public Class RecordPerso
	Public Property NomPerso As String
	Public Property ClassePerso As String
	Public Property RacePerso As String
	Public Property TabCarac As Short()
	Public Property LesStuff As String()
	Public Property LesPower As String()
	Public Property PointExperiencePerso As UInt32
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
	Public Property Competences As CompetenceDefClasse()
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
Public Class CompetenceDefClasse
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
Public Class LesStuffs
	Public Property Stuffs As StuffDef()
End Class
Public Class StuffDef
	Public Property IdStuff As String
	Public Property NomStuff As String
	Public Property NbDesDegat As Short
	Public Property NbFaceDesDegat As Short
	Public Property BonusDegat As Short
	Public Property PointVieBase As Short
	Public Property Caracteristiques As CaracteristiqueDef()
	Public Property Competences As CompetenceDefRace()
	Public Property Sauvegardes As SauvegardeDef()
End Class
Public Class LesPowers
	Public Property Powers As PowerDef()
End Class
Public Class PowerDef
	Public Property Idpower As String
	Public Property NomPower As String
	'Public Property NbDesDegat As Short
	'Public Property NbFaceDesDegat As Short
	'Public Property BonusDegat As Short
	'Public Property PointVieBase As Short
	'Public Property Caracteristiques As CaracteristiqueDef()
	'Public Property Competences As CompetenceDefRace()
	'Public Property Sauvegardes As SauvegardeDef()
End Class