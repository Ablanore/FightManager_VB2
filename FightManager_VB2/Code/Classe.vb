Imports System.Text.Json
Imports System.IO
Imports System.Linq

Public Class Classe
    Private _NomClasse As String
    Private _PointVieBase As Int16

    Sub New(IdClasse As String)

        'Dim UneClasse = From clas In JsonSerializer.Deserialize(Of LesClasses)(File.ReadAllText(LaGrandeClasse.ClasseDataAdresse)).
        'Classes Where clas.IdClasse = IdClasse
        '_NomClasse = UneClasse.First.NomClasse



    End Sub



    '    Public Interface iCompeChoix
    'nom: enumCompetences
    'obligatoire: Boolean

    '    Public Interface iListeClasse
    'nom:        String
    'valeur:     String


    'Private _nom : String = ""
    'Private _idClasse : String = ""
    'Private _pointVieBase :         number = 0
    'Private _pointVieNiveau :        number = 0
    'Private _recuperation :        number = 0
    'Private _nombreCompetence :        number = 0
    '//private _competencesClasse: Competence[]
    'Private _competencesClasse :        iCompeChoix[]
    'Private _sauvegardesClasse :        Sauvegarde[]

    'Public Sub New(Idclasse String)
    '    Const classeData = classeData.find((Classe) >= Classe.IdClasse === Idclasse)

    '    If (classeData) Then {
    '        this._nom = classeData.NomClasse! == undefined ? classeData.NomClasse : ""
    '        this._idClasse = Idclasse
    '    this._pointVieBase = classeData.PointVieBase! == undefined ? classeData.PointVieBase : 0
    '        this._pointVieNiveau = classeData.PointVieNiveau! == undefined ? classeData.PointVieNiveau : 0
    '        this._recuperation = classeData.Recuperation! == undefined ? classeData.Recuperation : 0
    '        this._nombreCompetence = classeData.NombreCompetence! == undefined ? classeData.NombreCompetence : 0
    '        //this._competencesClasse = classeData.Competences !== undefined ? classeData.Competences.map(
    '        //    c => New Competence(c.Nom, 0, c.Obligatoire)) : []
    '        this._competencesClasse = classeData.Competences! == undefined ? classeData.Competences.map((data: iCompeChoix) => {
    '            Return {
    '              nom: Data.nom,
    '              obligatoire: Data.obligatoire,
    '            }
    '          }) : []
    '        this._sauvegardesClasse = classeData.Sauvegardes! == undefined ? classeData.Sauvegardes.map(
    '            c => New Sauvegarde(c.nom, c.Valeur)) : []
    '    } else {
    '        Throw New Error(`La race avec l'ID "${Idclasse}" n'existe pas.`);
    '    }
    'End Sub

    'Public Get nom(): String { return this._nom; }
    '//pas de setter volontairement car le nom de la classe est vérouillé dans la source de données
    'Public Get idClasse(): String { return this._idClasse; }
    '//pas de setter volontairement car l'id de la classe est vérouillé dans la source de données
    'Public Get pointVieBase(): number { return this._pointVieBase; }
    '//pas de setter volontairement car le nombre de point de vie de base de la classe est vérouillé dans la source de données
    'Public Get pointVieNiveau(): number { return this._pointVieNiveau; }
    '//pas de setter volontairement car le nombre de point de vie par niveau est vérouillé dans la source de données
    'Public Get recuperation(): number { return this._recuperation; }
    '//pas de setter volontairement car le nombre de récupération de la classe est vérouillé dans la source de données
    'Public Get nombreCompetence(): number { return this._nombreCompetence; }
    '//pas de setter volontairement car le nombre de compétence de la classe est vérouillé dans la source de données
    '//public get competencesClasse(): Competence[] { return this._competencesClasse; }
    'Public Get competencesClasse(): iCompeChoix[] { return this._competencesClasse; }
    '//pas de setter volontairement car la liste des compétences de la classe est vérouillée dans la source de données
    'Public Get sauvegardesClasse(): Sauvegarde[] { return this._sauvegardesClasse; }
    '//pas de setter volontairement car la liste des compétences de la classe est vérouillée dans la source de données

End Class