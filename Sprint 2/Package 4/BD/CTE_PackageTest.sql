use dbProjetE2Prod;
GO
ALTER TABLE Test.tblTypeTest
ADD CONSTRAINT PK_tblTypeTest_CodeTypeTest	PRIMARY KEY(CodeTypeTest)
PRINT '1- Création de la contrainte PK_tblTypeTest_CodeTypeTest reussie'
GO

use master;