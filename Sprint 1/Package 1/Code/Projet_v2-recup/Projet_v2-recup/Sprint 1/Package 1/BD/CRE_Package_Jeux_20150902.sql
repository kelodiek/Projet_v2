use dbProjetE2Prod;
GO
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Jeux')
BEGIN
	EXEC( 'DROP TABLE Jeux.tblPlateformeJeu' );
	EXEC( 'DROP TABLE Jeux.tblJeuSemblable' );	
	EXEC( 'DROP TABLE Jeux.tblVersion' );	
	EXEC( 'DROP TABLE Jeux.tblThemeJeu' );	
	EXEC( 'DROP TABLE Jeux.tblPlateformeSysExp' );	
	EXEC( 'DROP TABLE Jeux.tblJeu' );	
	EXEC( 'DROP TABLE Jeux.tblPlateforme' );	
	EXEC( 'DROP TABLE Jeux.tblGenre' );	
	EXEC( 'DROP TABLE Jeux.tblMode' );	
	EXEC( 'DROP TABLE Jeux.tblClassification' );	
	EXEC( 'DROP TABLE Jeux.tblTheme' );	
	EXEC( 'DROP TABLE Jeux.tblCategorie' );	
	EXEC( 'DROP TABLE Jeux.tblSysExp' );
		
	EXEC( 'DROP SCHEMA Jeux' );
END
GO
CREATE SCHEMA Jeux

GO
CREATE TABLE Jeux.tblSysExp
(
IdSysExp		INT			NOT NULL	IDENTITY(1,1),
CodeSysExp		VARCHAR(10)	NOT NULL,
NomSysExp		VARCHAR(25)	NOT NULL,
EditionSysExp	VARCHAR(40)	NOT NULL,
VersionSysExp	VARCHAR(40)	NULL,
InfoSupSysExp	TEXT		NULL,
Tag				TEXT		NULL
)
GO
PRINT 'Cr�ation de Jeux.tblSysExp compl�t�e'

GO
CREATE TABLE Jeux.tblCategorie
(
CodeCategorie	VARCHAR(7)		NOT NULL,
DescCategorie	VARCHAR(40)		NOT NULL,
ComCategorie	VARCHAR(150)	NULL
)
GO
PRINT 'Cr�ation de Jeux.tblCategorie compl�t�e'

GO
CREATE TABLE Jeux.tblTheme
(
IdTheme			INT			NOT NULL	IDENTITY(1,1),
NomTheme		VARCHAR(40)	NOT NULL,
ComTheme		VARCHAR(250)NULL
)
GO
PRINT 'Cr�ation de Jeux.tblTheme compl�t�e'

GO
CREATE TABLE Jeux.tblClassification
(
CoteESRB		VARCHAR(3)	NOT NULL,
NomESRB			VARCHAR(30)	NOT NULL,
DescESRB		VARCHAR(40)	NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblClassification compl�t�e'

GO
CREATE TABLE Jeux.tblMode
(
IdMode			INT			NOT NULL	IDENTITY(1,1),
NomMode			VARCHAR(20)	NOT NULL,
DescMode		VARCHAR(250)NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblMode compl�t�e'

GO
CREATE TABLE Jeux.tblGenre
(
IdGenre			INT			NOT NULL	IDENTITY(1,1),
NomGenre		VARCHAR(35)	NOT NULL,
ComGenre		VARCHAR(250)NULL
)
GO
PRINT 'Cr�ation de Jeux.tblGenre compl�t�e'

/*------------------------------------------------------------------------------*/

GO
CREATE TABLE Jeux.tblPlateforme
(
IdPlateforme		INT			NOT NULL	IDENTITY(1,1),
CodePlateforme		VARCHAR(10)	NOT NULL,
NomPlateforme		VARCHAR(40)	NOT NULL,
CPU					VARCHAR(40) NULL,
CarteMere			VARCHAR(60)	NULL,
RAM					VARCHAR(60)	NULL,
Stockage			VARCHAR(60)	NULL,
DescPlateforme		VARCHAR(250)NOT NULL,
InfoSupPlateforme	TEXT		NULL,
Tag					TEXT		NULL,
CodeCategorie		VARCHAR(7)	NULL
)
GO
PRINT 'Cr�ation de Jeux.tblPlateforme compl�t�e'

GO
CREATE TABLE Jeux.tblJeu
(
IdJeu			INT				NOT NULL	IDENTITY(1,1),
NomJeu			VARCHAR(50)		NOT NULL,
DescJeu			VARCHAR(100)	NOT NULL,
Actif			BIT				NOT NULL,
InfoSupJeu		TEXT			NULL,
Tag				TEXT			NULL,
CoteESRB		VARCHAR(3)		NULL,
IdGenre			INT				NULL,
IdMode			INT				NULL
)
GO
PRINT 'Cr�ation de Jeux.tblJeu compl�t�e'

/*------------------------------------------------------------------------------*/

GO
CREATE TABLE Jeux.tblPlateformeSysExp
(
IdPlateforme	INT			NOT NULL,
IdSysExp		INT			NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblPlateformeSysExp compl�t�e'

GO
CREATE TABLE Jeux.tblThemeJeu
(
IdTheme			INT			NOT NULL,
IdJeu			INT			NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblThemeJeu compl�t�e'

GO
CREATE TABLE Jeux.tblVersion
(
CodeVersion			VARCHAR(10)	NOT NULL,
NomVersion			VARCHAR(50)	NOT NULL,
DescVersion			VARCHAR(250)NULL,
StadeDeveloppement	VARCHAR(30)	NOT NULL,
DateVersion			DATE		NOT NULL,
DateSortiePrevue	DATE		NULL,
Tag					TEXT		NULL,
IdJeu				INT			NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblVersion compl�t�e'

GO
CREATE TABLE Jeux.tblJeuSemblable
(
IdJeuBase		INT			NOT NULL,
IdJeuSemblable	INT			NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblJeuSemblable compl�t�e'

GO
CREATE TABLE Jeux.tblPlateformeJeu
(
IdPlateforme	INT			NOT NULL,
IdJeu			INT			NOT NULL
)
GO
PRINT 'Cr�ation de Jeux.tblPlateformeJeu compl�t�e'


GO
use master;