Imports System.Text.Json
Imports System.IO
Imports System.Linq

Public Class Classe
    ''' <summary>
    ''' Enum pour déclarer les noms des classes (en espérant pouvoir itérer dessus)
    ''' </summary>
    Enum EnumClasse
        Magicien
        Barde
        Barbare
        Sorcier

    End Enum

    Property IdClasse As String
    Property NomClasse As String
    Property PointVieBase As Short
    Property PointVieNiveau As Short
    Property Recuperation As Short
    Property Initiative As Short
    Property NombreCompetence As Short
    Property Sauvegardes As SauvegardeDef()
    Property Competences As CompetenceDefClasse()


    Sub New(IdClasse As String)
        Dim UneClasse = From clas In JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse)).Classes Where clas.IdClasse = IdClasse
        IdClasse = UneClasse.First.IdClasse
        NomClasse = UneClasse.First.NomClasse
        PointVieBase = UneClasse.First.PointVieBase
        PointVieNiveau = UneClasse.First.PointVieNiveau
        Recuperation = UneClasse.First.Recuperation
        Initiative = UneClasse.First.Initiative
        NombreCompetence = UneClasse.First.NombreCompetence
        Sauvegardes = UneClasse.First.Sauvegardes
        Competences = UneClasse.First.Competences
    End Sub
End Class