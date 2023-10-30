Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Personnage : Implements IComparable
    Property Nom As String
    Property TypePerso As String
    Property Classe As Classe
    Property Race As Race
    Property NbCompeChoisie As Short
    Property PointsExperience As Int32
    Property CaracteristiquesPerso As Caracteristiques
    Property CompetencesPersonnage As Competences
    Property SauvegardesPersonnage As Sauvegardes
    Property Niveau As Short
    Property DemiNiveau As Short
    Property PV As Short
    Property Peril As Short
    Property RecuperationValeur As Short
    Property RecuparationParJour As Short
    Property Initiative As Short
    Property Vitesse As Short
    Property Vision As String
    Property VoieParangonique As String
    Property DestinneEpique As String
    Property StuffPersonnage As List(Of String)
    Property PowerPersonnage As List(Of String)

    Sub New(Nom As String, TypePersoParam As String, ClassePerso As String, RacePerso As String, CaracteristiqueParam() As Short, StuffParam As List(Of String), PowerParam As List(Of String), PointExperiencePerso As UInt32)
        Me.Nom = Nom
        Me.TypePerso = TypePersoParam
        Me.Classe = New Classe(ClassePerso)
        Me.Race = New Race(RacePerso)
        Me.PointsExperience = PointExperiencePerso
        Me.NbCompeChoisie = 0
        'Le stuff
        'Finalement le moyen est plus simple en envoyant le tableau de String du Stuff là où il faut réellement boucler dessus.
        'Donc le personnage ne conserve QUE la liste des identifiants de Stuff qu'il possède, le reste se fait par calcul.
        'En parler à Franck pour valider l'idée. FAIT, il approuve.
        'Faire une fonction à part pour gérer le code.
        'Positionné ici car des New plus bas vont s'en servir et donc la liste sera vide à ce moment là.
        Me.StuffPersonnage = StuffParam

        'Les caractéristiques
        Me.CaracteristiquesPerso = New Caracteristiques(CaracteristiqueParam, RacePerso, Me.StuffPersonnage)

        Me.Niveau = Calculniveau(Me.PointsExperience)
        Me.DemiNiveau = Math.Floor(Niveau / 2)
        'Spécial pour déterminer les PV : si le mob à un zéro dans le PV de base c'est que c'est un sbire, donc PV = 1
        If Me.Classe.PointVieBase = 0 And Me.TypePerso = "Mob" Then
            Me.PV = 1
        Else
            Me.PV = Me.Classe.PointVieBase + Me.CaracteristiquesPerso.Constitution.Valeur + ((Me.Niveau - 1) * Me.Classe.PointVieNiveau)
        End If

        Me.Peril = Math.Floor(Me.PV / 2)
        Me.RecuperationValeur = Math.Floor(Me.PV / 4)
        Me.RecuparationParJour = Me.Classe.Recuperation + Me.CaracteristiquesPerso.Constitution.Modificateur
        Me.Initiative = Me.DemiNiveau + Me.CaracteristiquesPerso.Dexterite.Modificateur + Me.Classe.Initiative
        Me.Vitesse = Me.Race.Vitesse
        Me.Vision = Me.Race.Vision
        Me.VoieParangonique = ""
        Me.DestinneEpique = ""

        'Les compétences
        Dim TabFormation As Boolean() = {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}
        Me.CompetencesPersonnage = New Competences(TabFormation, Me.DemiNiveau, RacePerso, Me.CaracteristiquesPerso, Me.StuffPersonnage)

        'Les sauvegardes
        Me.SauvegardesPersonnage = New Sauvegardes(Me.CaracteristiquesPerso, Me.DemiNiveau, ClassePerso, RacePerso, Me.StuffPersonnage)

        'Les pouvoirs
        'on va faire comme pour le stuff en fait, un tableau de string qui contient des ID et on fait une classe avec les définitions, tout pareil.
        Me.PowerPersonnage = PowerParam '{"PowerBase", "PowerTest"}
    End Sub
    Public Enum enumLeType
        Caracteristique
        Competence
        Sauvegarde
    End Enum
    Function TrouverValeur(paramleType As enumLeType, paramNomValeur As String, ParamMod As String) As Short
        Select Case paramleType
            Case enumLeType.Caracteristique
                Dim caracRetour As Caracteristique
                Select Case paramNomValeur
                    Case "Force"
                        caracRetour = Me.CaracteristiquesPerso.Force
                    Case "Constitution"
                        caracRetour = Me.CaracteristiquesPerso.Constitution
                    Case "Dexterite"
                        caracRetour = Me.CaracteristiquesPerso.Dexterite
                    Case "Intelligence"
                        caracRetour = Me.CaracteristiquesPerso.Intelligence
                    Case "Sagesse"
                        caracRetour = Me.CaracteristiquesPerso.Sagesse
                    Case "Charisme"
                        caracRetour = Me.CaracteristiquesPerso.Charisme
                    Case Else
                        Return 0
                End Select
                If ParamMod = "Modificateur" Then
                    Return caracRetour.Modificateur
                Else
                    Return caracRetour.Valeur
                End If
            Case enumLeType.Competence
                Return 0
            Case enumLeType.Sauvegarde
                Dim sauveRetour As Sauvegarde
                Select Case paramNomValeur
                    Case "ClasseArmure"
                        sauveRetour = Me.SauvegardesPersonnage.ClasseArmure
                    Case "Vigueur"
                        sauveRetour = Me.SauvegardesPersonnage.Vigueur
                    Case "Reflexes"
                        sauveRetour = Me.SauvegardesPersonnage.Reflexes
                    Case "Volonte"
                        sauveRetour = Me.SauvegardesPersonnage.Volonté
                    Case Else
                        Return 0
                End Select
                Return sauveRetour.Valeur
            Case Else
                Return 0
        End Select
    End Function
    Private Function Calculniveau(nbpx As Int32)
        Dim TabNiveau = New Int32(,) {
              {0, 999, 1},
              {1000, 2249, 2},
              {2250, 3749, 3},
              {3750, 5499, 4},
              {5500, 7499, 5},
              {7500, 9999, 6},
              {10000, 12999, 7},
              {13000, 16499, 8},
              {16500, 20499, 9},
              {20500, 25999, 10},
              {26000, 31999, 11},
              {32000, 38999, 12},
              {39000, 46999, 13},
              {47000, 56999, 14},
              {57000, 68999, 15},
              {69000, 82999, 16},
              {83000, 98999, 17},
              {99000, 118999, 18},
              {119000, 142999, 19},
              {143000, 174999, 20},
              {175000, 209999, 21},
              {210000, 254999, 22},
              {255000, 309999, 23},
              {310000, 374999, 24},
              {375000, 449999, 25},
              {450000, 549999, 26},
              {550000, 674999, 27},
              {675000, 824999, 28},
              {825000, 999999, 29},
              {1000000, 1000000000, 30}
              }
        Dim ValeurRetour As Short = 0
        For index = 0 To TabNiveau.GetUpperBound(0)
            If nbpx >= TabNiveau(index, 0) And nbpx <= TabNiveau(index, 1) Then
                ValeurRetour = TabNiveau(index, 2)
            End If
        Next
        Return ValeurRetour
    End Function
    Public Function CompareTo(o As Object) As Integer _
             Implements IComparable.CompareTo
        Dim e As Personnage = TryCast(o, Personnage)
        If e Is Nothing Then
            Throw New ArgumentException("o is not an Personnage object.")
        End If

        Return Nom.CompareTo(e.Nom)
    End Function
End Class
Public Class PersonnageSearch
    Dim _s As String

    Public Sub New(s As String)
        _s = s
    End Sub

    Public Function StartsWith(e As Personnage) As Boolean
        Return e.Nom.StartsWith(_s, StringComparison.InvariantCultureIgnoreCase)
    End Function
End Class