use dbProjetE2Test;
GO

ALTER TABLE Test.tblProjet
ADD CONSTRAINT PK_tblProjet_CodeProjet	PRIMARY KEY(CodeProjet)
PRINT '1- Création de la contrainte PK_tblProjet_CodeProjet reussie'
GO

GO
ALTER TABLE Test.tblProjet
ADD CONSTRAINT FK_tblProjet_tblVersion_CodeVersion	FOREIGN KEY(CodeVersion) REFERENCES Jeux.tblVersion(CodeVersion)
PRINT '1- Création de la contrainte FK_tblProjet_tblVersion_CodeVersion reussie'
GO

GO
ALTER TABLE Test.tblProjet
ADD CONSTRAINT FK_tblProjet_tblVersion_IdChefProjet	FOREIGN KEY(IdChefProjet) REFERENCES Personnel.tblEmploye(IdEmp)
PRINT '1- Création de la contrainte FK_tblProjet_tblVersion_IdChefProjet reussie'
GO

GO
ALTER TABLE Test.tblCasTest
ADD CONSTRAINT PK_tblCasTest_CodeCas	PRIMARY KEY(CodeCas)
PRINT '2- Création de la contrainte PK_tblCasTest_CodeCas reussie'
GO

GO
ALTER TABLE Test.tblCasTest
ADD CONSTRAINT FK_tblCasTest_tblProjet_CodeProjet	FOREIGN KEY(CodeProjet) REFERENCES Test.tblProjet(CodeProjet)
PRINT '2- Création de la contrainte FK_tblCasTest_tblProjet_CodeProjet reussie'
GO

GO
ALTER TABLE Test.tblCasTest
ADD CONSTRAINT FK_tblCasTest_tblTypeTest_CodeTypeTest	FOREIGN KEY(CodeTypeTest) REFERENCES Test.tblTypeTest(CodeTypeTest)
PRINT '2- Création de la contrainte FK_tblCasTest_tblTypeTest_CodeTypeTest reussie'
GO

use master;