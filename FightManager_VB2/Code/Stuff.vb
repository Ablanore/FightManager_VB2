Public Class Stuff
    Property NomStuff As String
    Property NbDesDegat As Short
    Property NbFaceDesDegat As Short
    Property BonusDegat As Short
    Property PointVieBase As Short
    Property CaracteristiquesPerso As Caracteristiques
    Property CompetencesPersonnage As Competences
    Property SauvegardesPersonnage As Sauvegardes

    Sub New(IdStuff As String)
        'Faire une remontée des caractéristiques du stuff avec le Json comme pour les races ou les classes
    End Sub
End Class