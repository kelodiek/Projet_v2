use dbProjetE2Test;
GO
CREATE VIEW [AllChefProjet] AS
SELECT e.IdEmp,e.PrenomEmp, e.NomEmp, e.Statut
        FROM Personnel.tblEmploye AS e
		INNER JOIN Personnel.tblUtilisateur as u
		ON e.IdEmp = u.IdEmp
		INNER JOIN Personnel.tblRole AS r
              ON r.IdRole = u.IdRole
WHERE r.NomRole='Chef de projet'

GO

CREATE VIEW [AllTesteur] AS
SELECT e.IdEmp,e.PrenomEmp, e.NomEmp, e.Statut
        FROM Personnel.tblEmploye AS e
		INNER JOIN Personnel.tblUtilisateur as u
		ON e.IdEmp = u.IdEmp
		INNER JOIN Personnel.tblRole AS r
              ON r.IdRole = u.IdRole
WHERE r.NomRole='Testeur'

GO

CREATE VIEW [VCategorie] AS
SELECT *
FROM Jeux.tblCategorie

GO

CREATE VIEW [VClassification] AS
SELECT *
FROM Jeux.tblClassification

GO

CREATE VIEW [VGenre] AS
SELECT *
FROM Jeux.tblGenre

GO

CREATE VIEW [VJeu] AS
SELECT *
FROM Jeux.tblJeu
GO

CREATE VIEW [VJeuSemblable] AS
SELECT *
FROM Jeux.tblJeuSemblable
GO
CREATE VIEW [VMode] AS
SELECT *
FROM Jeux.tblMode
GO
CREATE VIEW [VPlateforme] AS
SELECT *
FROM Jeux.tblPlateforme
GO
CREATE VIEW [VPlateformeJeu] AS
SELECT *
FROM Jeux.tblPlateformeJeu
GO
CREATE VIEW [VPlateformeSysExp] AS
SELECT *
FROM Jeux.tblPlateformeSysExp
GO
CREATE VIEW [VTheme] AS
SELECT *
FROM Jeux.tblTheme
GO
CREATE VIEW [VThemeJeu] AS
SELECT *
FROM Jeux.tblThemeJeu
GO
CREATE VIEW [VVersion] AS
SELECT *
FROM Jeux.tblVersion
GO
CREATE VIEW [VDroit] AS
SELECT *
FROM Personnel.tblDroit
GO
CREATE VIEW [VEmploye] AS
SELECT *
FROM Personnel.tblEmploye
GO
CREATE VIEW [VEmployeTypeTest] AS
SELECT *
FROM Personnel.tblEmployeTypeTest
GO
CREATE VIEW [VEquipe] AS
SELECT *
FROM Personnel.tblEquipe
GO
CREATE VIEW [VEquipeTypeTest] AS
SELECT *
FROM Personnel.tblEquipeTypeTest
GO
CREATE VIEW [VGroupe] AS
SELECT *
FROM Personnel.tblGroupe
GO
CREATE VIEW [VGroupeDroit] AS
SELECT *
FROM Personnel.tblGroupeDroit
GO
CREATE VIEW [VGroupeUtil] AS
SELECT *
FROM Personnel.tblGroupeUtil
GO
CREATE VIEW [VRole] AS
SELECT *
FROM Personnel.tblRole
GO
CREATE VIEW [VUtilisateur] AS
SELECT *
FROM Personnel.tblUtilisateur
GO
CREATE VIEW [VCasTest] AS
SELECT *
FROM Test.tblCasTest
GO
CREATE VIEW [VProjet] AS
SELECT *
FROM Test.tblProjet
GO
CREATE VIEW [VTypeTest] AS
SELECT *
FROM Test.tblTypeTest
GO
/*
CREATE VIEW [VResultatTest] AS
SELECT *
FROM Test.tblResultatTest
GO */
USE master;
