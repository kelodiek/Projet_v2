use dbProjetE2Prod;
GO
IF EXISTS (SELECT * FROM sys.schemas WHERE name = 'Test')
BEGIN
	EXEC( 'DROP TABLE Test.tblTypeTest' );
		
	EXEC( 'DROP SCHEMA Test' );
END
GO
CREATE SCHEMA Test

GO
CREATE TABLE Test.tblTypeTest
(
CodeTypeTest			VARCHAR(5)			NOT NULL,
NomTypeTest				VARCHAR(50)			NOT NULL,
ObjectifTypeTest		VARCHAR(150)		NULL,
DescTypeTest			VARCHAR(250)		NULL,
CommentaireTest			VARCHAR(250)		NULL
)
GO
PRINT 'Cr�ation de Test.tblTypeTest compl�t�e'

/*-----------PAS TERMIN�--------------------*/

GO
use master;