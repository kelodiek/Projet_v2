USE dbProjetE2Test;
GO

ALTER TABLE Personnel.tblEmploye
ADD CONSTRAINT PK_tblEmploye_IdEmp PRIMARY KEY(IdEmp)
PRINT '1- Création de la contrainte PK_tblEmploye_IdEmp reussie'
GO
USE master;