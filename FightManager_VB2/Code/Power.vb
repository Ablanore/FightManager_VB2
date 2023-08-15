Imports System.Text.Json
Imports System.IO

Public Class Power
    Property NomPower As String
    'Property NbDesDegat As Short
    'Property NbFaceDesDegat As Short
    'Property BonusDegat As Short
    'Property PointVieBase As Short
    'Property CaracteristiquesStuff As CaracteristiqueDef()
    'Property CompetencesStuff As CompetenceDefRace()
    'Property SauvegardesStuff As SauvegardeDef()

    Sub New(IdPower As String)
        'Faire une remontée des caractéristiques du power avec le Json comme pour les races ou les classes
        Dim UnPower = From power In JsonSerializer.Deserialize(Of LesPowers)(File.ReadAllText(LaGrandeClasse.PowerDataAdresse)).Powers Where power.Idpower = IdPower

        NomPower = UnPower.First.NomPower
        'NbDesDegat = UnStuff.First.NbDesDegat
        'NbFaceDesDegat = UnStuff.First.NbFaceDesDegat
        'BonusDegat = UnStuff.First.BonusDegat
        'PointVieBase = UnStuff.First.PointVieBase
        'CaracteristiquesStuff = UnStuff.First.Caracteristiques
        'CompetencesStuff = UnStuff.First.Competences
        'SauvegardesStuff = UnStuff.First.Sauvegardes
    End Sub
End Class