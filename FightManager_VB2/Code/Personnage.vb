Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class Personnage
    Property Nom As String
    Property Classe As Classe
    Property Race As Race
    Property NbCompeChoisie As UInt16
    Property PointsExperience As UInt32
    Property CaracteristiquesPerso As Caracteristiques
    Property CompetencesPersonnage As Competences
    Property SauvegardesPersonnage As Sauvegardes
    Property Niveau As UInt16
    Property DemiNiveau As UInt16
    Property PV As UInt16
    Property Peril As UInt16
    Property RecuperationValeur As UInt16
    Property RecuparationParJour As UInt16
    Property Initiative As UInt16
    Property Vitesse As UInt16
    Property Vision As String
    Property VoieParangonique As String
    Property DestinneEpique As String
    Property StuffPersonnage As String()
    Property PowerPersonnage As String()

    Sub New(Nom As String, ClassePerso As String, RacePerso As String, CaracteristiqueParam() As Short, PointExperiencePerso As UInt32)
        Me.Nom = Nom
        Me.Classe = New Classe(ClassePerso)
        Me.Race = New Race(RacePerso)
        Me.PointsExperience = PointExperiencePerso
        Me.NbCompeChoisie = 0
        'Le stuff
        'Finalement lme moyen est plus simple en envoyant le tableau de String du Stuf là où il faut réellemnt boulcer dessus.
        'Donc le personnage ne conserve QUE la liste des identifiants de stuf qu'il possède, le reste se fait pas calcul.
        'En parler à Franck pour valider l'idée.
        Me.StuffPersonnage = {"StuffBase", "StuffTest"}

        'Les caractéristiques
        Me.CaracteristiquesPerso = New Caracteristiques(CaracteristiqueParam, RacePerso, Me.StuffPersonnage)

        Me.Niveau = Calculniveau(Me.PointsExperience)
        Me.DemiNiveau = Math.Floor(Niveau / 2)
        Me.PV = Me.Classe.PointVieBase + Me.CaracteristiquesPerso.Constitution.Valeur + (Me.Niveau * Me.Classe.PointVieNiveau)
        Me.Peril = Math.Floor(Me.PV / 2)
        Me.RecuperationValeur = Math.Floor(Me.PV / 4)
        Me.RecuparationParJour = Me.Classe.Recuperation + Me.CaracteristiquesPerso.Constitution.Modificateur
        Me.Initiative = Me.DemiNiveau + Me.CaracteristiquesPerso.Dexterite.Modificateur
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
        'on va faire comme pour le stuff en fait., un tableau de string qui contient de ID et on fait une classe avec les définitions, tout pareil.
        Me.PowerPersonnage = {"PowerBase", "PowerTest"}
    End Sub

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
        Dim ValeurRetour As Int16 = 0
        For index = 0 To TabNiveau.GetUpperBound(0)
            If nbpx >= TabNiveau(index, 0) And nbpx <= TabNiveau(index, 1) Then
                ValeurRetour = TabNiveau(index, 2)
            End If
        Next
        Return ValeurRetour
    End Function
End Class