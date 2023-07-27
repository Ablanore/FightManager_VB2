Imports System.Text.Json
Imports System.IO
Imports System.Linq
Public Class Race
	Property IdRace As String
	Property NomRace As String
	Property Vitesse As Short
	Property TailleMini As Short
	Property TailleMaxi As Short
	Property PoidsMini As Short
	Property PoidsMaxi As Short
	Property Taille As String
	Property Vision As String
	Property Caracteristiques As CaracteristiqueDef()
	Property Competences As CompetenceDefRace()
	Property Sauvegardes As SauvegardeDef()

	Sub New(IdRace As String)
		Dim UneRace = From rasse In JsonSerializer.Deserialize(Of LesRaces)(File.ReadAllText(LaGrandeClasse.RaceDataAdresse)).Races Where rasse.IdRace = IdRace
		NomRace = UneRace.First.NomRaces
		Vitesse = UneRace.First.Vitesse
		TailleMini = UneRace.First.TailleMini
		TailleMaxi = UneRace.First.TailelMaxi
		PoidsMini = UneRace.First.PoidsMini
		PoidsMaxi = UneRace.First.PoidsMaxi
		Taille = UneRace.First.Taille
		Vision = UneRace.First.Vision

		Caracteristiques = UneRace.First.Caracteristiques
		Competences = UneRace.First.Competences
		Sauvegardes = UneRace.First.Sauvegardes

	End Sub
End Class
Public Class CaracteristiqueRace
	Public Property Nom As String
	Public Property Bonus As Int16
End Class
