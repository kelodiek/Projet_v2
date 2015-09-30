use dbProjetE2Prod;
GO

ALTER TABLE Jeux.tblSysExp
ADD CONSTRAINT PK_tblSysExp_IdSysExp	PRIMARY KEY(IdSysExp)
PRINT '1- Création de la contrainte PK_tblSysExp_IdSysExp reussie'
GO

ALTER TABLE Jeux.tblCategorie
ADD CONSTRAINT PK_tblCategorie_CodeCategorie	PRIMARY KEY(CodeCategorie)
PRINT '2- Création de la contrainte PK_tblCategorie_CodeCategorie reussie'
GO

ALTER TABLE Jeux.tblTheme
ADD CONSTRAINT PK_tblTheme_IdTheme	PRIMARY KEY(IdTheme)
PRINT '3- Création de la contrainte PK_tblTheme_IdTheme reussie'
GO
ALTER TABLE Jeux.tblTheme
ADD CONSTRAINT UN_tblTheme_NomTheme	UNIQUE(NomTheme)
PRINT '3- Création de la contrainte UN_tblTheme_NomTheme reussie'
GO

ALTER TABLE Jeux.tblClassification
ADD CONSTRAINT PK_tblClassification_CoteESRB	PRIMARY KEY(CoteESRB)
PRINT '4- Création de la contrainte PK_tblClassification_CoteESRB reussie'
GO

ALTER TABLE Jeux.tblMode
ADD CONSTRAINT PK_tblMode_IdMode	PRIMARY KEY(IdMode)
PRINT '5- Création de la contrainte PK_tblMode_IdMode reussie'
GO
ALTER TABLE Jeux.tblMode
ADD CONSTRAINT UN_tblMode_NomMode	UNIQUE(NomMode)
PRINT '5- Création de la contrainte UN_tblMode_NomMode reussie'
GO

ALTER TABLE Jeux.tblGenre
ADD CONSTRAINT PK_tblGenre_IdGenre	PRIMARY KEY(IdGenre)
PRINT '6- Création de la contrainte PK_tblGenre_IdGenre reussie'
GO
ALTER TABLE Jeux.tblGenre
ADD CONSTRAINT UN_tblGenre_NomGenre	UNIQUE(NomGenre)
PRINT '6- Création de la contrainte UN_tblGenre_NomGenre reussie'
GO

ALTER TABLE Jeux.tblPlateforme
ADD CONSTRAINT PK_tblPlateforme_IdPlateforme	PRIMARY KEY(IdPlateforme)
PRINT '7- Création de la contrainte PK_tblPlateforme_IdPlateforme reussie'
GO
ALTER TABLE Jeux.tblPlateforme
ADD CONSTRAINT FK_tblPlateforme_tblCategorie_CodeCategorie	FOREIGN KEY(CodeCategorie) REFERENCES Jeux.tblCategorie(CodeCategorie)
PRINT '7- Création de la contrainte FK_tblPlateforme_tblCategorie_CodeCategorie reussie'
GO

ALTER TABLE Jeux.tblJeu
ADD CONSTRAINT PK_tblJeu_IdJeu	PRIMARY KEY(IdJeu)
PRINT '8- Création de la contrainte PK_tblJeu_IdJeu reussie'
GO
ALTER TABLE Jeux.tblJeu
ADD CONSTRAINT FK_tblJeu_tblClassification_CoteESRB	FOREIGN KEY(CoteESRB) REFERENCES Jeux.tblClassification(CoteESRB)
PRINT '8- Création de la contrainte FK_tblJeu_tblClassification_CoteESRB reussie'
GO
ALTER TABLE Jeux.tblJeu
ADD CONSTRAINT FK_tblJeu_tblGenre_IdGenre	FOREIGN KEY(IdGenre) REFERENCES Jeux.tblGenre(IdGenre)
PRINT '8- Création de la contrainte FK_tblJeu_tblGenre_IdGenre reussie'
GO
ALTER TABLE Jeux.tblJeu
ADD CONSTRAINT FK_tblJeu_tblMode_IdMode	FOREIGN KEY(IdMode) REFERENCES Jeux.tblMode(IdMode)
PRINT '8- Création de la contrainte FK_tblJeu_tblMode_IdMode reussie'
GO

ALTER TABLE Jeux.tblPlateformeSysExp
ADD CONSTRAINT PK_tblPlateformeSysExp_IdPlateforme_IdSysExp	PRIMARY KEY(IdPlateforme, IdSysExp)
PRINT '9- Création de la contrainte PK_tblPlateformeSysExp_IdPlateforme_IdSysExp reussie'
GO
ALTER TABLE Jeux.tblPlateformeSysExp
ADD CONSTRAINT FK_tblPlateformeSysExp_tblPlateforme_IdPlateforme	FOREIGN KEY(IdPlateforme) REFERENCES Jeux.tblPlateforme(IdPlateforme)
PRINT '9- Création de la contrainte FK_tblPlateformeSysExp_tblPlateforme_IdPlateforme reussie'
GO
ALTER TABLE Jeux.tblPlateformeSysExp
ADD CONSTRAINT FK_tblPlateformeSysExp_tblSysExp_IdSysExp	FOREIGN KEY(IdSysExp) REFERENCES Jeux.tblSysExp(IdSysExp)
PRINT '9- Création de la contrainte FK_tblPlateformeSysExp_tblSysExp_IdSysExp reussie'
GO

ALTER TABLE Jeux.tblThemeJeu
ADD CONSTRAINT PK_tblThemeJeu_IdTheme_IdJeu	PRIMARY KEY(IdTheme, IdJeu)
PRINT '10- Création de la contrainte PK_tblThemeJeu_IdTheme_IdJeu reussie'
GO
ALTER TABLE Jeux.tblThemeJeu
ADD CONSTRAINT FK_tblThemeJeu_tblTheme_IdTheme	FOREIGN KEY(IdTheme) REFERENCES Jeux.tblTheme(IdTheme)
PRINT '10- Création de la contrainte FK_tblThemeJeu_tblTheme_IdTheme reussie'
GO
ALTER TABLE Jeux.tblThemeJeu
ADD CONSTRAINT FK_tblThemeJeu_tblJeu_IdJeu	FOREIGN KEY(IdJeu) REFERENCES Jeux.tblJeu(IdJeu)
PRINT '10- Création de la contrainte FK_tblThemeJeu_tblJeu_IdJeu reussie'
GO

ALTER TABLE Jeux.tblVersion
ADD CONSTRAINT PK_tblVersion_CodeVersion	PRIMARY KEY(CodeVersion)
PRINT '11- Création de la contrainte PK_tblVersion_CodeVersion reussie'
GO
ALTER TABLE Jeux.tblVersion
ADD CONSTRAINT FK_tblVersion_tblJeu_IdJeu	FOREIGN KEY(IdJeu) REFERENCES Jeux.tblJeu(IdJeu)
PRINT '11- Création de la contrainte FK_tblVersion_tblJeu_IdJeu reussie'
GO

ALTER TABLE Jeux.tblJeuSemblable
ADD CONSTRAINT PK_tblJeuSemblable_IdJeuBase_IdJeuSemblable	PRIMARY KEY(IdJeuBase, IdJeuSemblable)
PRINT '12- Création de la contrainte PK_tblJeuSemblable_IdJeuBase_IdJeuSemblable reussie'
GO
ALTER TABLE Jeux.tblJeuSemblable
ADD CONSTRAINT FK_tblJeuSemblable_tblJeu_IdJeuBase	FOREIGN KEY(IdJeuBase) REFERENCES Jeux.tblJeu(IdJeu)
PRINT '12- Création de la contrainte FK_tblJeuSemblable_tblJeu_IdJeuBase reussie'
GO
ALTER TABLE Jeux.tblJeuSemblable
ADD CONSTRAINT FK_tblJeuSemblable_tblJeu_IdJeuSemblable	FOREIGN KEY(IdJeuSemblable) REFERENCES Jeux.tblJeu(IdJeu)
PRINT '12- Création de la contrainte FK_tblJeuSemblable_tblJeu_IdJeuSemblable reussie'
GO

ALTER TABLE Jeux.tblPlateformeJeu
ADD CONSTRAINT PK_tblPlateformeJeu_IdPlateforme_IdJeu	PRIMARY KEY(IdPlateforme, IdJeu)
PRINT '12- Création de la contrainte PK_tblPlateformeJeu_IdPlateforme_IdJeu reussie'
GO
ALTER TABLE Jeux.tblPlateformeJeu
ADD CONSTRAINT FK_tblPlateformeJeu_tblPlateforme_IdPlateforme	FOREIGN KEY(IdPlateforme) REFERENCES Jeux.tblPlateforme(IdPlateforme)
PRINT '12- Création de la contrainte FK_tblPlateformeJeu_tblPlateforme_IdPlateforme reussie'
GO
ALTER TABLE Jeux.tblPlateformeJeu
ADD CONSTRAINT FK_tblPlateformeJeu_tblJeu_IdJeu	FOREIGN KEY(IdJeu) REFERENCES Jeux.tblJeu(IdJeu)
PRINT '12- Création de la contrainte FK_tblPlateformeJeu_tblJeu_IdJeu reussie'
GO

use master;