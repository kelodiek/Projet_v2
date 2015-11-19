USE dbProjetE2Test;
GO
CREATE SCHEMA Recherche;
GO
CREATE TABLE Recherche.tblFiltre1
(
IdFiltre1			INT					NOT NULL	IDENTITY(1,1),
NomFiltre1			VARCHAR(100)		NOT NULL,
DescFiltre1			VARCHAR(250)		NULL,
NomVue				VARCHAR(100)		NOT NULL
)
GO
PRINT 'Création de Recherche.tblFiltre1 complétée'
GO

CREATE TABLE Recherche.tblFiltre2
(
IdFiltre2			INT					NOT NULL	IDENTITY(1,1),
NomFiltre2			VARCHAR(100)		NOT NULL,
DescFiltre2			VARCHAR(250)		NULL,
NomVue				VARCHAR(100)		NOT NULL,
IdFiltre1			INT					NOT NULL
)
GO
PRINT 'Création de Recherche.tblFiltre2 complétée'
GO

CREATE TABLE Recherche.tblFiltre3
(
IdFiltre3			INT					NOT NULL	IDENTITY(1,1),
NomFiltre3			VARCHAR(100)		NOT NULL,
DescFiltre3			VARCHAR(250)		NULL,
NomVue				VARCHAR(100)		NOT NULL,
IdFiltre2			INT					NOT NULL
)
GO
PRINT 'Création de Recherche.tblFiltre3 complétée'
GO
USE master;