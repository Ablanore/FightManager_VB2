Imports System.Text.Json
Imports System.IO
Imports System.Linq
Public Class Race

	Sub New(IdRace As String)
		Dim UneRace = From rasse In JsonSerializer.Deserialize(Of LesRaces)(File.ReadAllText(LaGrandeClasse.RaceDataAdresse)).Races Where rasse.IdRace = IdRace
		'_NomClasse = UneClasse.First.NomClasse



	End Sub
End Class
