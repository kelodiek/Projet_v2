use dbProjetE2Test;
GO

ALTER TABLE Recherche.tblFiltre1
ADD CONSTRAINT PK_tblFiltre1_IdFiltre1	PRIMARY KEY(IdFiltre1)
PRINT '1- Création de la contrainte PK_tblFiltre1_IdFiltre1 reussie'
GO

ALTER TABLE Recherche.tblFiltre2
ADD CONSTRAINT PK_tblFiltre2_IdFiltre2	PRIMARY KEY(IdFiltre2)
PRINT '1- Création de la contrainte PK_tblFiltre2_IdFiltre2 reussie'
GO

ALTER TABLE Recherche.tblFiltre3
ADD CONSTRAINT PK_tblFiltre3_IdFiltre3	PRIMARY KEY(IdFiltre3)
PRINT '1- Création de la contrainte PK_tblFiltre3_IdFiltre3 reussie'


ALTER TABLE Recherche.tblFiltre2
ADD CONSTRAINT FK_tblFiltre1_tblFiltre2_IdFiltre1	FOREIGN KEY(IdFiltre1) REFERENCES Test.tblFiltre1(IdFiltre1)
PRINT '2- Création de la contrainte FK_tblFiltre1_tblFiltre2_IdFiltre1 reussie'
GO

ALTER TABLE Recherche.tblFiltre3
ADD CONSTRAINT FK_tblFiltre2_tblFiltre3_IdFiltre2	FOREIGN KEY(IdFiltre2) REFERENCES Test.tblFiltre2(IdFiltre2)
PRINT '2- Création de la contrainte FK_tblFiltre2_tblFiltre3_CodeProjet reussie'
GO

USE master;