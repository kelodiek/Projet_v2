use dbProjetE2Test;
GO

ALTER TABLE Personnel.tblRole
ADD CONSTRAINT PK_tblRole_IdRole PRIMARY KEY(IdRole)
PRINT '2- Création de la contrainte PK_tblRole_IdRole reussie'
GO

ALTER TABLE Personnel.tblGroupe
ADD CONSTRAINT PK_tblGroupe_IdGroupe PRIMARY KEY(IdGroupe)
PRINT '3- Création de la contrainte PK_tblGroupe_IdGroupe reussie'
GO

ALTER TABLE Personnel.tblDroit
ADD CONSTRAINT PK_tblDroit_CodeDroit	PRIMARY KEY(CodeDroit)
PRINT '4- Création de la contrainte PK_tblDroit_CodeDroit reussie'
GO

ALTER TABLE Personnel.tblUtilisateur
ADD CONSTRAINT PK_tblUtilisateur_NomUtil	PRIMARY KEY(NomUtil)
PRINT '5- Création de la contrainte PK_tblUtilisateur_NomUtil reussie'
GO

ALTER TABLE Personnel.tblUtilisateur
ADD CONSTRAINT FK_tblUtilisateur_tblRole_IdRole	FOREIGN KEY(IdRole) REFERENCES Personnel.tblRole(IdRole)
PRINT '5- Création de la contrainte FK_tblUtilisateur_tblRole_IdRole reussie'
GO

ALTER TABLE Personnel.tblUtilisateur
ADD CONSTRAINT FK_tblUtilisateur__tblEmploye_IdEmp	FOREIGN KEY(IdEmp) REFERENCES Personnel.tblEmploye(IdEmp)
PRINT '5- Création de la contrainte FK_tblUtilisateur__tblEmploye_IdEmp reussie'
GO

ALTER TABLE Personnel.tblGroupeDroit
ADD CONSTRAINT PK_tblGroupeDroit_CodeDroit_IdGroupe	PRIMARY KEY(CodeDroit,IdGroupe)
PRINT '6- Création de la contrainte PK_tblGroupeDroit_CodeDroit_IdGroupe reussie'
GO

ALTER TABLE Personnel.tblGroupeDroit
ADD CONSTRAINT FK_tblGroupeDroit_tblDroit_CodeDroit	FOREIGN KEY(CodeDroit) REFERENCES Personnel.tblDroit(CodeDroit)
PRINT '6- Création de la contrainte FK_tblGroupeDroit_tblDroit_CodeDroit reussie'
GO

ALTER TABLE Personnel.tblGroupeDroit
ADD CONSTRAINT FK_tblGroupeDroit_tblGroupe_IdGroupe	FOREIGN KEY(IdGroupe) REFERENCES Personnel.tblGroupe(IdGroupe)
PRINT '6- Création de la contrainte FK_tblGroupeDroit_tblGroupe_IdGroupe reussie'
GO

ALTER TABLE Personnel.tblGroupeUtil
ADD CONSTRAINT PK_tblGroupeUtil_NomUtil_IdGroupe	PRIMARY KEY(NomUtil,IdGroupe)
PRINT '7- Création de la contrainte PK_tblGroupeUtil_NomUtil_IdGroupe reussie'
GO

ALTER TABLE Personnel.tblGroupeUtil
ADD CONSTRAINT FK_tblGroupeUtil_tblUtilisateur_NomUtil	FOREIGN KEY(NomUtil) REFERENCES Personnel.tblUtilisateur(NomUtil)
PRINT '7- Création de la contrainte FK_tblGroupeDroit_tblDroit_CodeDroit reussie'
GO

ALTER TABLE Personnel.tblGroupeUtil
ADD CONSTRAINT FK_tblGroupeUtil_tblGroupe_IdGroupe	FOREIGN KEY(IdGroupe) REFERENCES Personnel.tblGroupe(IdGroupe)
PRINT '7- Création de la contrainte FK_tblGroupeUtil_tblGroupe_IdGroupe reussie'
GO

ALTER TABLE Personnel.tblEquipe
ADD CONSTRAINT PK_tblEquipe_IdEquipe PRIMARY KEY(IdEquipe)
PRINT '8- Création de la contrainte PK_tblEquipe_IdEquipe reussie'
GO

ALTER TABLE Personnel.tblEquipe
ADD CONSTRAINT FK_tblEquipe_tblEmploye_IdChefEquipe	FOREIGN KEY(IdChefEquipe) REFERENCES Personnel.tblEmploye(IdEmp)
PRINT '8- Création de la contrainte FK_tblEquipe_tblEmploye_IdChefEquipe reussie'
GO

ALTER TABLE Personnel.tblEquipe
ADD CONSTRAINT FK_tblEquipe_tblProjet_CodeProjet	FOREIGN KEY(CodeProjet) REFERENCES Test.tblProjet(CodeProjet)
PRINT '8- Création de la contrainte FK_tblEquipe_tblProjet_CodeProjet reussie'
GO

ALTER TABLE Personnel.tblEquipeTesteur
ADD CONSTRAINT PK_tblEquipeTesteur_IdEmp_IdEquipe	PRIMARY KEY(IdEmp,IdEquipe)
PRINT '9- Création de la contrainte PK_tblEquipeTesteur_IdEmp_IdEquipe reussie'
GO

ALTER TABLE Personnel.tblEquipeTesteur
ADD CONSTRAINT FK_tblEquipeTesteur_tblEmploye_IdEmp	FOREIGN KEY(IdEmp) REFERENCES Personnel.tblEmploye(IdEmp)
PRINT '9- Création de la contrainte FK_tblEquipeTesteur_tblEmploye_IdEmp reussie'
GO

ALTER TABLE Personnel.tblEquipeTesteur
ADD CONSTRAINT FK_tblEquipeTesteur_tblEquipe_IdEquipe	FOREIGN KEY(IdEquipe) REFERENCES Personnel.tblEquipe(IdEquipe)
PRINT '9- Création de la contrainte FK_tblEquipeTesteur_tblEquipe_IdEquipe reussie'
GO

ALTER TABLE Personnel.tblEmployeTypeTest
ADD CONSTRAINT PK_tblEmployeTypeTest_IdEmp_CodeTypeTest	PRIMARY KEY(IdEmp,CodeTypeTest)
PRINT '10- Création de la contrainte PK_tblEmployeTypeTest_IdEmp_CodeTypeTest reussie'
GO

ALTER TABLE Personnel.tblEmployeTypeTest
ADD CONSTRAINT FK_tblEmployeTypeTest_tblEmploye_IdEmp	FOREIGN KEY(IdEmp) REFERENCES Personnel.tblEmploye(IdEmp)
PRINT '10- Création de la contrainte FK_tblEmployeTypeTest_tblEmploye_IdEmp reussie'
GO

ALTER TABLE Personnel.tblEmployeTypeTest
ADD CONSTRAINT FK_tblEmployeTypeTest_tblTypeTest_CodeTypeTest	FOREIGN KEY(CodeTypeTest) REFERENCES Test.tblTypeTest(CodeTypeTest)
PRINT '10- Création de la contrainte FK_tblEmployeTypeTest_tblTypeTest_CodeTypeTest reussie'
GO

ALTER TABLE Personnel.tblEquipeTypeTest
ADD CONSTRAINT PK_tblEquipeTypeTest_IdEquipe_CodeTypeTest	PRIMARY KEY(IdEquipe,CodeTypeTest)
PRINT '11- Création de la contrainte PK_tblEquipeTypeTest_IdEquipe_CodeTypeTest reussie'
GO

ALTER TABLE Personnel.tblEquipeTypeTest
ADD CONSTRAINT FK_tblEquipeTypeTest_tblEquipe_IdEquipe	FOREIGN KEY(IdEquipe) REFERENCES Personnel.tblEquipe(IdEquipe)
PRINT '11- Création de la contrainte FK_tblEquipeTypeTest_tblEquipe_IdEquipe reussie'
GO

ALTER TABLE Personnel.tblEquipeTypeTest
ADD CONSTRAINT FK_tblEquipeTypeTest_tblTypeTest_CodeTypeTest	FOREIGN KEY(CodeTypeTest) REFERENCES Test.tblTypeTest(CodeTypeTest)
PRINT '11- Création de la contrainte FK_tblEquipeTypeTest_tblTypeTest_CodeTypeTest reussie'
GO
use master;