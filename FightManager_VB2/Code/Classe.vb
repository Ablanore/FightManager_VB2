Imports System.Text.Json
Imports System.IO
Imports System.Linq

Public Class Classe
    Property IdClasse As String
    Property NomClasse As String
    Property PointVieBase As Int16
    Property PointVieNiveau As Int16
    Property Recuperation As Int16
    Property NombreCompetence As Int16
    Property Sauvegardes As SauvegardeDef()
    Property Competences As CompetenceDefClasse()


    Sub New(IdClasse As String)
        Dim UneClasse = From clas In JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse)).Classes Where clas.IdClasse = IdClasse
        NomClasse = UneClasse.First.NomClasse
        PointVieBase = UneClasse.First.PointVieBase
        PointVieNiveau = UneClasse.First.PointVieNiveau
        Recuperation = UneClasse.First.Recuperation
        NombreCompetence = UneClasse.First.NombreCompetence
        Sauvegardes = UneClasse.First.Sauvegardes
        Competences = UneClasse.First.Competences
    End Sub
End Class