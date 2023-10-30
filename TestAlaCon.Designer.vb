<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestAlaCon
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnTest = New Button()
        lblDeminiveau = New Label()
        lblNomArme = New Label()
        lblManiementTitre = New Label()
        lblSagesse = New Label()
        lblCharisme = New Label()
        lblNomCombattant = New Label()
        lblDemiLvlTitre = New Label()
        lblValCalculConstitution = New Label()
        lblValCalculForce = New Label()
        lblValCalculDexterite = New Label()
        lblValCalculIntelligence = New Label()
        lblValCalculSagesse = New Label()
        lblValCalculCharisme = New Label()
        lblModCalculConstitution = New Label()
        lblModCalculForce = New Label()
        lblModCalculDexterite = New Label()
        lblModCalculIntelligence = New Label()
        lblModCalculSagesse = New Label()
        lblModCalculCharisme = New Label()
        lblModCaracTitre = New Label()
        lblReflexes = New Label()
        lblVigueur = New Label()
        lblVolonte = New Label()
        lblCaracConcerne = New Label()
        lblTotalReflexes = New Label()
        lblTotalCA = New Label()
        lblTotalVigueur = New Label()
        lblTotalVolonte = New Label()
        lblNomCaracAttaquant = New Label()
        lblCaracAttaquant = New Label()
        lblDemiLvlAttaquant = New Label()
        lblNomAttaquant = New Label()
        lblManiementAttaquant = New Label()
        lblNomArmeAttaquant = New Label()
        lblNomCaracDefenseur = New Label()
        lblCaracDefenseur = New Label()
        lblDemiLvlDefenseur = New Label()
        lblNomDefenseur = New Label()
        lblBonusAttaqueTitre = New Label()
        lblBonusAttaqueAttaquant = New Label()
        lblBonusDefense = New Label()
        LstMembre = New CheckedListBox()
        TextBox1 = New TextBox()
        ToolStrip1 = New ToolStrip()
        ToolStripTextBox1 = New ToolStripTextBox()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(703, 404)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(75, 23)
        btnTest.TabIndex = 3
        btnTest.Text = "go test"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' lblDeminiveau
        ' 
        lblDeminiveau.AutoSize = True
        lblDeminiveau.Location = New Point(535, 175)
        lblDeminiveau.Name = "lblDeminiveau"
        lblDeminiveau.Size = New Size(13, 15)
        lblDeminiveau.TabIndex = 303
        lblDeminiveau.Text = "0"
        ' 
        ' lblNomArme
        ' 
        lblNomArme.AutoSize = True
        lblNomArme.Location = New Point(307, 9)
        lblNomArme.Name = "lblNomArme"
        lblNomArme.Size = New Size(66, 15)
        lblNomArme.TabIndex = 304
        lblNomArme.Text = "Nom Arme"
        ' 
        ' lblManiementTitre
        ' 
        lblManiementTitre.AutoSize = True
        lblManiementTitre.Location = New Point(379, 9)
        lblManiementTitre.Name = "lblManiementTitre"
        lblManiementTitre.Size = New Size(68, 15)
        lblManiementTitre.TabIndex = 305
        lblManiementTitre.Text = "Maniement"
        ' 
        ' lblSagesse
        ' 
        lblSagesse.AutoSize = True
        lblSagesse.Location = New Point(558, 203)
        lblSagesse.Name = "lblSagesse"
        lblSagesse.Size = New Size(48, 15)
        lblSagesse.TabIndex = 306
        lblSagesse.Text = "Sagesse"
        ' 
        ' lblCharisme
        ' 
        lblCharisme.AutoSize = True
        lblCharisme.Location = New Point(558, 231)
        lblCharisme.Name = "lblCharisme"
        lblCharisme.Size = New Size(57, 15)
        lblCharisme.TabIndex = 307
        lblCharisme.Text = "Charisme"
        ' 
        ' lblNomCombattant
        ' 
        lblNomCombattant.AutoSize = True
        lblNomCombattant.Location = New Point(12, 9)
        lblNomCombattant.Name = "lblNomCombattant"
        lblNomCombattant.Size = New Size(111, 15)
        lblNomCombattant.TabIndex = 310
        lblNomCombattant.Text = "Noms Combattants"
        ' 
        ' lblDemiLvlTitre
        ' 
        lblDemiLvlTitre.AutoSize = True
        lblDemiLvlTitre.Location = New Point(124, 9)
        lblDemiLvlTitre.Name = "lblDemiLvlTitre"
        lblDemiLvlTitre.Size = New Size(39, 15)
        lblDemiLvlTitre.TabIndex = 311
        lblDemiLvlTitre.Text = "1/2 lvl"
        ' 
        ' lblValCalculConstitution
        ' 
        lblValCalculConstitution.AutoSize = True
        lblValCalculConstitution.Location = New Point(391, 259)
        lblValCalculConstitution.Name = "lblValCalculConstitution"
        lblValCalculConstitution.Size = New Size(13, 15)
        lblValCalculConstitution.TabIndex = 324
        lblValCalculConstitution.Text = "0"
        ' 
        ' lblValCalculForce
        ' 
        lblValCalculForce.AutoSize = True
        lblValCalculForce.Location = New Point(391, 231)
        lblValCalculForce.Name = "lblValCalculForce"
        lblValCalculForce.Size = New Size(13, 15)
        lblValCalculForce.TabIndex = 325
        lblValCalculForce.Text = "0"
        ' 
        ' lblValCalculDexterite
        ' 
        lblValCalculDexterite.AutoSize = True
        lblValCalculDexterite.Location = New Point(391, 288)
        lblValCalculDexterite.Name = "lblValCalculDexterite"
        lblValCalculDexterite.Size = New Size(13, 15)
        lblValCalculDexterite.TabIndex = 326
        lblValCalculDexterite.Text = "0"
        ' 
        ' lblValCalculIntelligence
        ' 
        lblValCalculIntelligence.AutoSize = True
        lblValCalculIntelligence.Location = New Point(391, 316)
        lblValCalculIntelligence.Name = "lblValCalculIntelligence"
        lblValCalculIntelligence.Size = New Size(13, 15)
        lblValCalculIntelligence.TabIndex = 327
        lblValCalculIntelligence.Text = "0"
        ' 
        ' lblValCalculSagesse
        ' 
        lblValCalculSagesse.AutoSize = True
        lblValCalculSagesse.Location = New Point(391, 344)
        lblValCalculSagesse.Name = "lblValCalculSagesse"
        lblValCalculSagesse.Size = New Size(13, 15)
        lblValCalculSagesse.TabIndex = 328
        lblValCalculSagesse.Text = "0"
        ' 
        ' lblValCalculCharisme
        ' 
        lblValCalculCharisme.AutoSize = True
        lblValCalculCharisme.Location = New Point(391, 372)
        lblValCalculCharisme.Name = "lblValCalculCharisme"
        lblValCalculCharisme.Size = New Size(13, 15)
        lblValCalculCharisme.TabIndex = 329
        lblValCalculCharisme.Text = "0"
        ' 
        ' lblModCalculConstitution
        ' 
        lblModCalculConstitution.AutoSize = True
        lblModCalculConstitution.Location = New Point(480, 259)
        lblModCalculConstitution.Name = "lblModCalculConstitution"
        lblModCalculConstitution.Size = New Size(13, 15)
        lblModCalculConstitution.TabIndex = 330
        lblModCalculConstitution.Text = "0"
        ' 
        ' lblModCalculForce
        ' 
        lblModCalculForce.AutoSize = True
        lblModCalculForce.Location = New Point(480, 231)
        lblModCalculForce.Name = "lblModCalculForce"
        lblModCalculForce.Size = New Size(13, 15)
        lblModCalculForce.TabIndex = 331
        lblModCalculForce.Text = "0"
        ' 
        ' lblModCalculDexterite
        ' 
        lblModCalculDexterite.AutoSize = True
        lblModCalculDexterite.Location = New Point(480, 288)
        lblModCalculDexterite.Name = "lblModCalculDexterite"
        lblModCalculDexterite.Size = New Size(13, 15)
        lblModCalculDexterite.TabIndex = 332
        lblModCalculDexterite.Text = "0"
        ' 
        ' lblModCalculIntelligence
        ' 
        lblModCalculIntelligence.AutoSize = True
        lblModCalculIntelligence.Location = New Point(480, 316)
        lblModCalculIntelligence.Name = "lblModCalculIntelligence"
        lblModCalculIntelligence.Size = New Size(13, 15)
        lblModCalculIntelligence.TabIndex = 333
        lblModCalculIntelligence.Text = "0"
        ' 
        ' lblModCalculSagesse
        ' 
        lblModCalculSagesse.AutoSize = True
        lblModCalculSagesse.Location = New Point(480, 344)
        lblModCalculSagesse.Name = "lblModCalculSagesse"
        lblModCalculSagesse.Size = New Size(13, 15)
        lblModCalculSagesse.TabIndex = 334
        lblModCalculSagesse.Text = "0"
        ' 
        ' lblModCalculCharisme
        ' 
        lblModCalculCharisme.AutoSize = True
        lblModCalculCharisme.Location = New Point(480, 372)
        lblModCalculCharisme.Name = "lblModCalculCharisme"
        lblModCalculCharisme.Size = New Size(13, 15)
        lblModCalculCharisme.TabIndex = 335
        lblModCalculCharisme.Text = "0"
        ' 
        ' lblModCaracTitre
        ' 
        lblModCaracTitre.AutoSize = True
        lblModCaracTitre.Location = New Point(238, 9)
        lblModCaracTitre.Name = "lblModCaracTitre"
        lblModCaracTitre.Size = New Size(63, 15)
        lblModCaracTitre.TabIndex = 336
        lblModCaracTitre.Text = "mod carac"
        ' 
        ' lblReflexes
        ' 
        lblReflexes.AutoSize = True
        lblReflexes.Location = New Point(558, 287)
        lblReflexes.Name = "lblReflexes"
        lblReflexes.Size = New Size(50, 15)
        lblReflexes.TabIndex = 337
        lblReflexes.Text = "Réflexes"
        ' 
        ' lblVigueur
        ' 
        lblVigueur.AutoSize = True
        lblVigueur.Location = New Point(558, 261)
        lblVigueur.Name = "lblVigueur"
        lblVigueur.Size = New Size(48, 15)
        lblVigueur.TabIndex = 338
        lblVigueur.Text = "Vigueur"
        ' 
        ' lblVolonte
        ' 
        lblVolonte.AutoSize = True
        lblVolonte.Location = New Point(558, 316)
        lblVolonte.Name = "lblVolonte"
        lblVolonte.Size = New Size(47, 15)
        lblVolonte.TabIndex = 339
        lblVolonte.Text = "Volonté"
        ' 
        ' lblCaracConcerne
        ' 
        lblCaracConcerne.AutoSize = True
        lblCaracConcerne.Location = New Point(169, 9)
        lblCaracConcerne.Name = "lblCaracConcerne"
        lblCaracConcerne.Size = New Size(63, 15)
        lblCaracConcerne.TabIndex = 365
        lblCaracConcerne.Text = "nom carac"
        ' 
        ' lblTotalReflexes
        ' 
        lblTotalReflexes.AutoSize = True
        lblTotalReflexes.Location = New Point(724, 287)
        lblTotalReflexes.Name = "lblTotalReflexes"
        lblTotalReflexes.Size = New Size(13, 15)
        lblTotalReflexes.TabIndex = 366
        lblTotalReflexes.Text = "0"
        ' 
        ' lblTotalCA
        ' 
        lblTotalCA.AutoSize = True
        lblTotalCA.Location = New Point(724, 231)
        lblTotalCA.Name = "lblTotalCA"
        lblTotalCA.Size = New Size(13, 15)
        lblTotalCA.TabIndex = 367
        lblTotalCA.Text = "0"
        ' 
        ' lblTotalVigueur
        ' 
        lblTotalVigueur.AutoSize = True
        lblTotalVigueur.Location = New Point(724, 261)
        lblTotalVigueur.Name = "lblTotalVigueur"
        lblTotalVigueur.Size = New Size(13, 15)
        lblTotalVigueur.TabIndex = 368
        lblTotalVigueur.Text = "0"
        ' 
        ' lblTotalVolonte
        ' 
        lblTotalVolonte.AutoSize = True
        lblTotalVolonte.Location = New Point(724, 316)
        lblTotalVolonte.Name = "lblTotalVolonte"
        lblTotalVolonte.Size = New Size(13, 15)
        lblTotalVolonte.TabIndex = 369
        lblTotalVolonte.Text = "0"
        ' 
        ' lblNomCaracAttaquant
        ' 
        lblNomCaracAttaquant.AutoSize = True
        lblNomCaracAttaquant.Location = New Point(169, 50)
        lblNomCaracAttaquant.Name = "lblNomCaracAttaquant"
        lblNomCaracAttaquant.Size = New Size(63, 15)
        lblNomCaracAttaquant.TabIndex = 375
        lblNomCaracAttaquant.Text = "nom carac"
        ' 
        ' lblCaracAttaquant
        ' 
        lblCaracAttaquant.AutoSize = True
        lblCaracAttaquant.Location = New Point(238, 50)
        lblCaracAttaquant.Name = "lblCaracAttaquant"
        lblCaracAttaquant.Size = New Size(63, 15)
        lblCaracAttaquant.TabIndex = 374
        lblCaracAttaquant.Text = "mod carac"
        ' 
        ' lblDemiLvlAttaquant
        ' 
        lblDemiLvlAttaquant.AutoSize = True
        lblDemiLvlAttaquant.Location = New Point(124, 50)
        lblDemiLvlAttaquant.Name = "lblDemiLvlAttaquant"
        lblDemiLvlAttaquant.Size = New Size(39, 15)
        lblDemiLvlAttaquant.TabIndex = 373
        lblDemiLvlAttaquant.Text = "1/2 lvl"
        ' 
        ' lblNomAttaquant
        ' 
        lblNomAttaquant.AutoSize = True
        lblNomAttaquant.Location = New Point(12, 50)
        lblNomAttaquant.Name = "lblNomAttaquant"
        lblNomAttaquant.Size = New Size(111, 15)
        lblNomAttaquant.TabIndex = 372
        lblNomAttaquant.Text = "Noms Combattants"
        ' 
        ' lblManiementAttaquant
        ' 
        lblManiementAttaquant.AutoSize = True
        lblManiementAttaquant.Location = New Point(379, 50)
        lblManiementAttaquant.Name = "lblManiementAttaquant"
        lblManiementAttaquant.Size = New Size(68, 15)
        lblManiementAttaquant.TabIndex = 371
        lblManiementAttaquant.Text = "Maniement"
        ' 
        ' lblNomArmeAttaquant
        ' 
        lblNomArmeAttaquant.AutoSize = True
        lblNomArmeAttaquant.Location = New Point(307, 50)
        lblNomArmeAttaquant.Name = "lblNomArmeAttaquant"
        lblNomArmeAttaquant.Size = New Size(66, 15)
        lblNomArmeAttaquant.TabIndex = 370
        lblNomArmeAttaquant.Text = "Nom Arme"
        ' 
        ' lblNomCaracDefenseur
        ' 
        lblNomCaracDefenseur.AutoSize = True
        lblNomCaracDefenseur.Location = New Point(169, 90)
        lblNomCaracDefenseur.Name = "lblNomCaracDefenseur"
        lblNomCaracDefenseur.Size = New Size(63, 15)
        lblNomCaracDefenseur.TabIndex = 375
        lblNomCaracDefenseur.Text = "nom carac"
        ' 
        ' lblCaracDefenseur
        ' 
        lblCaracDefenseur.AutoSize = True
        lblCaracDefenseur.Location = New Point(238, 90)
        lblCaracDefenseur.Name = "lblCaracDefenseur"
        lblCaracDefenseur.Size = New Size(63, 15)
        lblCaracDefenseur.TabIndex = 374
        lblCaracDefenseur.Text = "mod carac"
        ' 
        ' lblDemiLvlDefenseur
        ' 
        lblDemiLvlDefenseur.AutoSize = True
        lblDemiLvlDefenseur.Location = New Point(124, 90)
        lblDemiLvlDefenseur.Name = "lblDemiLvlDefenseur"
        lblDemiLvlDefenseur.Size = New Size(39, 15)
        lblDemiLvlDefenseur.TabIndex = 373
        lblDemiLvlDefenseur.Text = "1/2 lvl"
        ' 
        ' lblNomDefenseur
        ' 
        lblNomDefenseur.AutoSize = True
        lblNomDefenseur.Location = New Point(12, 90)
        lblNomDefenseur.Name = "lblNomDefenseur"
        lblNomDefenseur.Size = New Size(111, 15)
        lblNomDefenseur.TabIndex = 372
        lblNomDefenseur.Text = "Noms Combattants"
        ' 
        ' lblBonusAttaqueTitre
        ' 
        lblBonusAttaqueTitre.AutoSize = True
        lblBonusAttaqueTitre.Location = New Point(468, 9)
        lblBonusAttaqueTitre.Name = "lblBonusAttaqueTitre"
        lblBonusAttaqueTitre.Size = New Size(85, 15)
        lblBonusAttaqueTitre.TabIndex = 371
        lblBonusAttaqueTitre.Text = "Bonus Attaque"
        ' 
        ' lblBonusAttaqueAttaquant
        ' 
        lblBonusAttaqueAttaquant.AutoSize = True
        lblBonusAttaqueAttaquant.Location = New Point(468, 50)
        lblBonusAttaqueAttaquant.Name = "lblBonusAttaqueAttaquant"
        lblBonusAttaqueAttaquant.Size = New Size(85, 15)
        lblBonusAttaqueAttaquant.TabIndex = 371
        lblBonusAttaqueAttaquant.Text = "Bonus Attaque"
        ' 
        ' lblBonusDefense
        ' 
        lblBonusDefense.AutoSize = True
        lblBonusDefense.Location = New Point(468, 90)
        lblBonusDefense.Name = "lblBonusDefense"
        lblBonusDefense.Size = New Size(85, 15)
        lblBonusDefense.TabIndex = 376
        lblBonusDefense.Text = "Bonus Defense"
        ' 
        ' LstMembre
        ' 
        LstMembre.FormattingEnabled = True
        LstMembre.Location = New Point(12, 132)
        LstMembre.Name = "LstMembre"
        LstMembre.Size = New Size(250, 274)
        LstMembre.TabIndex = 377
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(681, 67)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 378
        TextBox1.Tag = "Zouzou aussi"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripTextBox1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 379
        ToolStrip1.Text = "My biloute et truc"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 25)
        ' 
        ' TestAlaCon
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(TextBox1)
        Controls.Add(LstMembre)
        Controls.Add(lblBonusDefense)
        Controls.Add(lblNomCaracDefenseur)
        Controls.Add(lblCaracDefenseur)
        Controls.Add(lblDemiLvlDefenseur)
        Controls.Add(lblNomDefenseur)
        Controls.Add(lblNomCaracAttaquant)
        Controls.Add(lblCaracAttaquant)
        Controls.Add(lblDemiLvlAttaquant)
        Controls.Add(lblNomAttaquant)
        Controls.Add(lblManiementAttaquant)
        Controls.Add(lblNomArmeAttaquant)
        Controls.Add(lblTotalVolonte)
        Controls.Add(lblTotalVigueur)
        Controls.Add(lblTotalCA)
        Controls.Add(lblTotalReflexes)
        Controls.Add(lblCaracConcerne)
        Controls.Add(lblVolonte)
        Controls.Add(lblVigueur)
        Controls.Add(lblReflexes)
        Controls.Add(lblModCaracTitre)
        Controls.Add(lblModCalculCharisme)
        Controls.Add(lblModCalculSagesse)
        Controls.Add(lblModCalculIntelligence)
        Controls.Add(lblModCalculDexterite)
        Controls.Add(lblModCalculForce)
        Controls.Add(lblModCalculConstitution)
        Controls.Add(lblValCalculCharisme)
        Controls.Add(lblValCalculSagesse)
        Controls.Add(lblValCalculIntelligence)
        Controls.Add(lblValCalculDexterite)
        Controls.Add(lblValCalculForce)
        Controls.Add(lblValCalculConstitution)
        Controls.Add(lblDemiLvlTitre)
        Controls.Add(lblNomCombattant)
        Controls.Add(lblCharisme)
        Controls.Add(lblSagesse)
        Controls.Add(lblManiementTitre)
        Controls.Add(lblNomArme)
        Controls.Add(lblDeminiveau)
        Controls.Add(lblBonusAttaqueTitre)
        Controls.Add(lblBonusAttaqueAttaquant)
        Controls.Add(btnTest)
        Name = "TestAlaCon"
        Text = "TestAlaCon"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnTest As Button
    Friend WithEvents lblDeminiveau As Label
    Friend WithEvents lblNomArme As Label
    Friend WithEvents lblManiementTitre As Label
    Friend WithEvents lblSagesse As Label
    Friend WithEvents lblCharisme As Label
    Friend WithEvents lblNomCombattant As Label
    Friend WithEvents lblDemiLvlTitre As Label
    Friend WithEvents lblValCalculConstitution As Label
    Friend WithEvents lblValCalculForce As Label
    Friend WithEvents lblValCalculDexterite As Label
    Friend WithEvents lblValCalculIntelligence As Label
    Friend WithEvents lblValCalculSagesse As Label
    Friend WithEvents lblValCalculCharisme As Label
    Friend WithEvents lblModCalculConstitution As Label
    Friend WithEvents lblModCalculForce As Label
    Friend WithEvents lblModCalculDexterite As Label
    Friend WithEvents lblModCalculIntelligence As Label
    Friend WithEvents lblModCalculSagesse As Label
    Friend WithEvents lblModCalculCharisme As Label
    Friend WithEvents lblModCaracTitre As Label
    Friend WithEvents lblReflexes As Label
    Friend WithEvents lblVigueur As Label
    Friend WithEvents lblVolonte As Label
    Friend WithEvents lblCaracConcerne As Label
    Friend WithEvents lblTotalReflexes As Label
    Friend WithEvents lblTotalCA As Label
    Friend WithEvents lblTotalVigueur As Label
    Friend WithEvents lblTotalVolonte As Label
    Friend WithEvents lblNomCaracAttaquant As Label
    Friend WithEvents lblCaracAttaquant As Label
    Friend WithEvents lblDemiLvlAttaquant As Label
    Friend WithEvents lblNomAttaquant As Label
    Friend WithEvents lblManiementAttaquant As Label
    Friend WithEvents lblNomArmeAttaquant As Label
    Friend WithEvents lblNomCaracDefenseur As Label
    Friend WithEvents lblCaracDefenseur As Label
    Friend WithEvents lblDemiLvlDefenseur As Label
    Friend WithEvents lblNomDefenseur As Label
    Friend WithEvents lblBonusAttaqueTitre As Label
    Friend WithEvents lblBonusAttaqueAttaquant As Label
    Friend WithEvents lblBonusDefense As Label
    Friend WithEvents LstMembre As CheckedListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
End Class
