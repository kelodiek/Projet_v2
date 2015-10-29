use dbProjetE2Test;
GO
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Personnel')
BEGIN
	EXEC( 'DROP TABLE Personnel.tblEquipeTypeTest' );
	EXEC( 'DROP TABLE Personnel.tblEmployeTypeTest' );
	EXEC( 'DROP TABLE Personnel.tblEquipeTesteur' );
	
	EXEC( 'DROP TABLE Personnel.tblEquipe' );
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
IdEmp					INT			NOT NULL,
PrenomEmp				VARCHAR(25)	NOT NULL,
NomEmp					VARCHAR(25)	NOT NULL,
CourrielEmp				VARCHAR(45)	NOT NULL,
NoTelPrincipal			VARCHAR(20)	NOT NULL,
NoTelSecondaire			VARCHAR(20)	NULL,
AdressePostale			VARCHAR(90)	NOT NULL,
DateEmbaucheEmp			DATE		NOT NULL,
CompetenceParticuliere  VARCHAR(400)NULL,
Statut					CHAR		NULL,
CommentaireEmp			VARCHAR(250)NULL
)
GO
PRINT 'Cr�ation de Personnel.tblEmploye compl�t�e'

GO
CREATE TABLE Personnel.tblRole
(
IdRole		INT				NOT NULL	IDENTITY(1,1),
NomRole		VARCHAR(30)		NOT NULL,
DescRole	VARCHAR(250)	NULL
)
GO
PRINT 'Cr�ation de Personnel.tblRole compl�t�e'

GO
CREATE TABLE Personnel.tblGroupe
(
IdGroupe		INT			NOT NULL	IDENTITY(1,1),
NomGroupe		VARCHAR(30)	NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblGroupe compl�t�e'

GO
CREATE TABLE Personnel.tblDroit
(
CodeDroit		VARCHAR(15)	NOT NULL,
DescDroit		VARCHAR(60)	NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblDroit compl�t�e'

/*-----------------------------------------------------------------*/



GO
CREATE TABLE Personnel.tblUtilisateur
(
NomUtil			VARCHAR(30)		NOT NULL,
MotPasUtil		VARCHAR(50)		NOT NULL,
PremiereConex	CHAR			NOT NULL,
MotPasExpire	CHAR			NOT NULL,
DateModifMotPas	DATE			NULL,
IdRole			INT				NOT NULL,
IdEmp			INT				NOT NULL,
Actif			CHAR			NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblUtilisateur compl�t�e'



GO
CREATE TABLE Personnel.tblGroupeDroit
(
CodeDroit			VARCHAR(15)	NOT NULL,
IdGroupe			INT			NOT NULL,
)
GO
PRINT 'Cr�ation de Personnel.tblGroupeDroit compl�t�e'

/*------------------------------------------------------------------*/

GO
CREATE TABLE Personnel.tblGroupeUtil
(
NomUtil			VARCHAR(30)	NOT NULL,
IdGroupe		INT			NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblGroupeUtil compl�t�e'

GO
CREATE TABLE Personnel.tblEquipe
(
IdEquipe			INT			NOT NULL	IDENTITY(1,1),
NomEquipe			VARCHAR(20)	NOT NULL,
CommentaireEquipe	VARCHAR(250)NULL,
Statut				CHAR		NOT NULL,
IdChefEquipe		INT			NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblEquipe compl�t�e'

GO
CREATE TABLE Personnel.tblEquipeTesteur
(
IdEmp				INT			NOT NULL,
IdEquipe			INT			NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblEquipeTesteur compl�t�e'

GO
CREATE TABLE Personnel.tblEmployeTypeTest
(
IdEmp				INT			NOT NULL,
CodeTypeTest		VARCHAR(5)	NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblEmployeTypeTest compl�t�e'

GO
CREATE TABLE Personnel.tblEquipeTypeTest
(
IdEquipe			INT			NOT NULL,
CodeTypeTest		VARCHAR(5)	NOT NULL
)
GO
PRINT 'Cr�ation de Personnel.tblEquipeTypeTest compl�t�e'

GO
use master;