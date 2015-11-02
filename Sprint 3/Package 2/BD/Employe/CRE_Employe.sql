use dbProjetE2Test;
GO
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Personnel')
BEGIN
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
PRINT 'Création de Personnel.tblEmploye complétée'
