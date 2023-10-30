Imports System.Text.Json
Imports System.IO
Imports FightManager_VB2.Personnage

Public Class Stuff
    Property NomStuff As String
    Property Maniement As Short
    Property NbDesDegat As Short
    Property NbFaceDesDegat As Short
    Property BonusDegat As Short
    Property PointVieBase As Short
    Property CaracteristiquesStuff As CaracteristiqueDef()
    Property CompetencesStuff As CompetenceDefRace()
    Property SauvegardesStuff As SauvegardeDef()

    Sub New(IdStuff As String)
        'Faire une remontée des caractéristiques du stuff avec le Json comme pour les races ou les classes
        Dim UnStuff = From stuf In JsonSerializer.Deserialize(Of LesStuffs)(File.ReadAllText(LaGrandeClasse.StuffDataAdresse)).Stuffs Where stuf.IdStuff = IdStuff

        NomStuff = UnStuff.First.NomStuff
        Maniement = UnStuff.First.Maniement
        NbDesDegat = UnStuff.First.NbDesDegat
        NbFaceDesDegat = UnStuff.First.NbFaceDesDegat
        BonusDegat = UnStuff.First.BonusDegat
        PointVieBase = UnStuff.First.PointVieBase
        CaracteristiquesStuff = UnStuff.First.Caracteristiques
        CompetencesStuff = UnStuff.First.Competences
        SauvegardesStuff = UnStuff.First.Sauvegardes
    End Sub
End Class