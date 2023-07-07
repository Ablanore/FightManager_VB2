Public Class Personnage
    Private _nom As String
    Private _classe As Classe
    Private _race As Race
    Private _pointsExperience As UInt32
    Private _nbCompeChoisie As UInt16
    Private _caracteristiquesBase(6) As Caracteristique
    Private _competencesPersonnage() As Competence
    Private _sauvegardesPersonnage() As Sauvegarde

    Sub New(Nom As String, Classe As Classe, Race As Race, Caracteristique() As Caracteristique, PointExperience As UInt32)
        Me._nom = Nom
        Me._classe = Classe
        Me._race = Race
        Me._pointsExperience = PointExperience
        Me._nbCompeChoisie = 0
        'Me._caracteristiquesBase(6) = Caracteristique
        'Me._competencesPersonnage() = Competence

    End Sub

End Class