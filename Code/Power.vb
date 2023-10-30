Imports System.Text.Json
Imports System.IO
Imports System.Windows.Forms.VisualStyles

Public Class Power
    Property NomPower As String
    Property Classe As String
    Property TypePower As String
    Property LvlPower As Short
    Property FrqPower As String
    Property Attaque As String
    Property Defense As String
    Property BonusAttaque As Short
    Property NbDesDegat As Short
    Property NbFaceDesDegat As Short
    Property TypeBonusDegat As String
    Property CaracBonusDegat As String
    Property MontantBonusDegat As Short
    Property NombreArme As Short
    Property Commentaire As String
    'Property PointVieBase As Short
    'Property CaracteristiquesStuff As CaracteristiqueDef()
    'Property CompetencesStuff As CompetenceDefRace()
    'Property SauvegardesStuff As SauvegardeDef()

    Sub New(IdPower As String)
        'Faire une remontée des caractéristiques du power avec le Json comme pour les races ou les classes
        Dim UnPower = From power In JsonSerializer.Deserialize(Of LesPowers)(File.ReadAllText(LaGrandeClasse.PowerDataAdresse)).Powers Where power.Idpower = IdPower

        NomPower = UnPower.First.NomPower
        Classe = UnPower.First.Classe
        TypePower = UnPower.First.TypePower
        LvlPower = UnPower.First.LvlPower
        FrqPower = UnPower.First.FrqPower
        Attaque = UnPower.First.Attaque
        Defense = UnPower.First.Defense
        BonusAttaque = UnPower.First.BonusAttaque
        NbDesDegat = UnPower.First.NbDesDegat
        NbFaceDesDegat = UnPower.First.NbFaceDesDegat
        TypeBonusDegat = UnPower.First.TypeBonusDegat
        CaracBonusDegat = UnPower.First.CaracBonusDegat
        MontantBonusDegat = UnPower.First.MontantBonusDegat
        NombreArme = UnPower.First.NombreArme
        Commentaire = UnPower.First.Commentaire
        'PointVieBase = UnStuff.First.PointVieBase
        'CaracteristiquesStuff = UnStuff.First.Caracteristiques
        'CompetencesStuff = UnStuff.First.Competences
        'SauvegardesStuff = UnStuff.First.Sauvegardes
    End Sub
End Class