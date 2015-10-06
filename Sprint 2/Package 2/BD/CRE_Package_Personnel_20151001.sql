use dbProjetE2Prod;
GO
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Personnel')
BEGIN
	EXEC( 'DROP TABLE Personnel.tblGroupeUtil' );	
	
	EXEC( 'DROP TABLE Personnel.tblGroupeDroit' );	
	EXEC( 'DROP TABLE Personnel.tblUtilisateur' );
		
	EXEC( 'DROP TABLE Personnel.tblDroit' );
	EXEC( 'DROP TABLE Personnel.tblGroupe' );	
	EXEC( 'DROP TABLE Personnel.tblRole' );	
	EXEC( 'DROP TABLE Personnel.tblEmploye' );
		
	EXEC( 'DROP SCHEMA Personnel' );
END
GO
CREATE SCHEMA Personnel

GO
CREATE TABLE Personnel.tblEmploye
(
IdEmp					INT			NOT NULL	IDENTITY(1,1),
PrenomEmp				VARCHAR(25)	NOT NULL,
NomEmp					VARCHAR(25)	NOT NULL,
CourrielEmp				VARCHAR(45)	NOT NULL,
NoTelPrincipal			VARCHAR(20)	NOT NULL,
NoTelSecondaire			VARCHAR(20)	NULL,
AdressePostale			VARCHAR(90)	NOT NULL,
DateEmbaucheEmp			DATE		NOT NULL,
CompetenceParticuliere  VARCHAR(400)NULL,
Actif					BIT			NULL,
CommentaireEmp			VARCHAR(250)NULL
)
GO
PRINT 'Création de Personnel.tblEmploye complétée'

GO
CREATE TABLE Personnel.tblRole
(
IdRole		INT				NOT NULL	IDENTITY(1,1),
NomRole		VARCHAR(30)		NOT NULL,
DescRole	VARCHAR(100)	NULL
)
GO
PRINT 'Création de Personnel.tblRole complétée'

GO
CREATE TABLE Personnel.tblGroupe
(
IdGroupe		INT			NOT NULL	IDENTITY(1,1),
NomGroupe		VARCHAR(30)	NOT NULL
)
GO
PRINT 'Création de Personnel.tblGroupe complétée'

GO
CREATE TABLE Personnel.tblDroit
(
CodeDroit		VARCHAR(15)	NOT NULL,
DescDroit		VARCHAR(40)	NOT NULL
)
GO
PRINT 'Création de Personnel.tblDroit complétée'

/*-----------------------------------------------------------------*/



GO
CREATE TABLE Personnel.tblUtilisateur
(
NomUtil			VARCHAR(30)		NOT NULL,
MotPasUtil		VARCHAR(50)		NOT NULL,
PremiereConex	BIT				NOT NULL,
MotPasExpire	BIT				NOT NULL,
DateModifMotPas	DATE			NULL,
IdRole			INT				NOT NULL,
IdEmp			INT				NOT NULL
)
GO
PRINT 'Création de Personnel.tblUtilisateur complétée'



GO
CREATE TABLE Personnel.tblGroupeDroit
(
CodeDroit			VARCHAR(15)	NOT NULL,
IdGroupe			INT			NOT NULL,
)
GO
PRINT 'Création de Personnel.tblGroupeDroit complétée'

/*------------------------------------------------------------------*/

GO
CREATE TABLE Personnel.tblGroupeUtil
(
NomUtil			VARCHAR(30)	NOT NULL,
IdGroupe		INT			NOT NULL
)
GO
PRINT 'Création de Personnel.tblGroupeUtil complétée'

/*-----------PAS TERMINÉ--------------------*/

GO
use master;