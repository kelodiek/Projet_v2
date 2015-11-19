CREATE TABLE Test.tblFiltre1
(
IdFiltre1			INT					NOT NULL	IDENTITY(1,1),
NomFiltre1			VARCHAR(100)		NOT NULL,
DescFiltre1			VARCHAR(250)		NULL,
NomVue				VARCHAR(100)		NOT NULL
)
GO
PRINT 'Création de Test.tblFiltre1 complétée'
GO

CREATE TABLE Test.tblFiltre2
(
IdFiltre2			INT					NOT NULL	IDENTITY(1,1),
NomFiltre2			VARCHAR(100)		NOT NULL,
DescFiltre2			VARCHAR(250)		NULL,
NomVue				VARCHAR(100)		NOT NULL,
IdFiltre1			INT					NOT NULL
)
GO
PRINT 'Création de Test.tblFiltre2 complétée'
GO

CREATE TABLE Test.tblFiltre3
(
IdFiltre3			INT					NOT NULL	IDENTITY(1,1),
NomFiltre3			VARCHAR(100)		NOT NULL,
DescFiltre3			VARCHAR(250)		NULL,
NomVue				VARCHAR(100)		NOT NULL,
IdFiltre2			INT					NOT NULL
)
GO
PRINT 'Création de Test.tblFiltre3 complétée'
GO