Public Class LaGrandeClasse
	Shared configurationAppSettings As System.Configuration.AppSettingsReader = New System.Configuration.AppSettingsReader
	Public Shared RaceDataAdresse As String = configurationAppSettings.GetValue("RaceDataAdresse", GetType(System.String))
	Public Shared ClasseDataAdresse As String = configurationAppSettings.GetValue("ClasseDataAdresse", GetType(System.String))
	Public Shared StuffDataAdresse As String = configurationAppSettings.GetValue("StuffDataAdresse", GetType(System.String))
	Public Shared PowerDataAdresse As String = configurationAppSettings.GetValue("powerDataAdresse", GetType(System.String))
	Public Shared DossierDesPerso As String = configurationAppSettings.GetValue("DossierDesPersos", GetType(System.String))
	Public Shared DossierDesZones As String = configurationAppSettings.GetValue("DossierDesZones", GetType(System.String))
	Public Shared Function Jetdes(nbFace As Short, nbDe As Short) As Short
		Randomize()
		Dim ResultDe As Short = 0
		For i = 1 To nbDe
			ResultDe += CInt(Int((nbFace * Rnd()) + 1))
		Next
		Return ResultDe
	End Function
End Class

Public Class RecordPerso
	Public Property NomPerso As String
	Public Property TypePerso As String
	Public Property ClassePerso As String
	Public Property RacePerso As String
	Public Property TabCarac As Short()
	Public Property LesStuff As List(Of String)
	Public Property LesPower As List(Of String)
	Public Property PointExperiencePerso As UInt32
End Class
Public Class LesClasses
	Public Property Classes As ClasseDef()
End Class
Public Class ClasseDef

	Public Property IdClasse As String
	Public Property NomClasse As String
	Public Property PointVieBase As Short
	Public Property PointVieNiveau As Short
	Public Property Recuperation As Short
	Public Property Initiative As Short
	Public Property Sauvegardes As SauvegardeDef()
	Public Property NombreCompetence As Short
	Public Property Competences As CompetenceDefClasse()
End Class
Public Class LesRaces
	Public Property Races As RaceDef()
End Class
Public Class RaceDef
	Public Property IdRace As String
	Public Property NomRace As String
	Public Property Vitesse As Short
	Public Property TailleMini As Short
	Public Property TailelMaxi As Short
	Public Property PoidsMini As Short
	Public Property PoidsMaxi As Short
	Public Property Taille As String
	Public Property Vision As String
	Public Property Caracteristiques As CaracteristiqueDef()
	Public Property Competences As CompetenceDefRace()
	Public Property Sauvegardes As SauvegardeDef()
End Class
Public Class SauvegardeDef
	Public Property Nom As String
	Public Property Valeur As Short
End Class
Public Class CompetenceDefClasse
	Public Property Nom As String
	Public Property Obligatoire As Boolean
End Class
Public Class CompetenceDefRace
	Public Property Nom As String
	Public Property Valeur As Short
End Class
Public Class CaracteristiqueDef
	Public Property Nom As String
	Public Property Valeur As Short
End Class
Public Class LesStuffs
	Public Property Stuffs As StuffDef()
End Class
Public Class StuffDef
	Public Property IdStuff As String
	Public Property NomStuff As String
	Public Property Maniement As Short
	Public Property NbDesDegat As Short
	Public Property NbFaceDesDegat As Short
	Public Property BonusDegat As Short
	Public Property PointVieBase As Short
	Public Property Caracteristiques As CaracteristiqueDef()
	Public Property Competences As CompetenceDefRace()
	Public Property Sauvegardes As SauvegardeDef()
	Sub New(IdStuff As String, NomStuff As String)
		Me.IdStuff = IdStuff
		Me.NomStuff = NomStuff
	End Sub
End Class
Public Class LesPowers
	Public Property Powers As PowerDef()
End Class
Public Class PowerDef
	Public Property IdPower As String
	Public Property NomPower As String
	Public Property Classe As String
	Public Property TypePower As String
	Public Property LvlPower As Short
	Public Property FrqPower As String
	Public Property Attaque As String
	Public Property Defense As String
	Public Property BonusAttaque As Short
	Public Property NbDesDegat As Short
	Public Property NbFaceDesDegat As Short
	Public Property TypeBonusDegat As String
	Public Property CaracBonusDegat As String
	Public Property MontantBonusDegat As Short
	Public Property NombreArme As Short
	Public Property Commentaire As String
End Class