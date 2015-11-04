USE dbProjetE2Test;
GO

--IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Test')
--BEGIN
--	EXEC( 'DROP TABLE Test.tblCasTest' );
--	EXEC( 'DROP TABLE Test.tblProjet' );
		
--END

GO
CREATE TABLE Test.tblProjet
(
CodeProjet			VARCHAR(10)			NOT NULL,
TitreProjet			VARCHAR(50)			NULL,
ObjectifProjet		VARCHAR(500)		NULL,
DateCreation		DATE				NULL,
DateEcheance		DATE				NULL,
DescProjet			VARCHAR(500)		NULL,
Autre				VARCHAR(500)		NULL,
CodeVersion			VARCHAR(10)			NULL,
IdChefProjet		INT					NULL
)
GO
PRINT 'Création de Test.tblProjet complétée'

GO
CREATE TABLE Test.tblCasTest
(
CodeCas				VARCHAR(10)			NOT NULL,
TitreCas			VARCHAR(35)			NULL,
ObjectifCas			VARCHAR(500)		NULL,
DateCreation		DATE				NULL,
DateEcheance		DATE				NULL,
DescCas				VARCHAR(500)		NULL,
StatutCas			VARCHAR(50)			NULL,
InfoSupCas			VARCHAR(200)		NULL,
DifficulteCas		CHAR(10)			NULL,
PrioriteCas			CHAR(10)			NULL,
IdAuteur			INT					NULL,	
CodeProjet			VARCHAR(10)			NOT NULL,
CodeTypeTest		VARCHAR(5)			NOT NULL
)
GO
PRINT 'Création de Test.tblCasTest complétée'

GO
use master;