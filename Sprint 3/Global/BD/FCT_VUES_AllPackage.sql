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
SELECT CodeCategorie, DescCategorie, ComCategorie
FROM Jeux.tblCategorie

GO


CREATE VIEW [VClassification] AS
SELECT CoteESRB, NomESRB, DescESRB
FROM Jeux.tblClassification

GO

CREATE VIEW [VGenre] AS
SELECT IdGenre, NomGenre, ComGenre
FROM Jeux.tblGenre

GO

CREATE VIEW [VJeu] AS
SELECT IdJeu, NomJeu, DescJeu, Actif, InfoSupJeu, Tag, CoteESRB, IdGenre, IdMode
FROM Jeux.tblJeu

GO

CREATE VIEW [VJeuSemblable] AS
SELECT IdJeuBase, IdJeuSemblable
FROM Jeux.tblJeuSemblable

GO

CREATE VIEW [VMode] AS
SELECT IdMode, NomMode, DescMode
FROM Jeux.tblMode

GO

CREATE VIEW [VPlateforme] AS
SELECT IdPlateforme, CodePlateforme, NomPlateforme, DescPlateforme, InfoSupPlateforme, Tag, CodeCategorie
FROM Jeux.tblPlateforme

GO

CREATE VIEW [VPlateformeJeu] AS
SELECT IdPlateforme, IdJeu
FROM Jeux.tblPlateformeJeu

GO

CREATE VIEW [VPlateformeSysExp] AS
SELECT IdPlateforme, IdSysExp
FROM Jeux.tblPlateformeSysExp

GO

CREATE VIEW [VTheme] AS
SELECT IdTheme, NomTheme, ComTheme
FROM Jeux.tblTheme

GO

CREATE VIEW [VThemeJeu] AS
SELECT IdTheme, IdJeu
FROM Jeux.tblThemeJeu

GO

CREATE VIEW [VVersion] AS
SELECT CodeVersion, NomVersion, DescVersion, StadeDeveloppement, DateVersion, DateSortiePrevue, Tag, IdJeu
FROM Jeux.tblVersion

GO

CREATE VIEW [VDroit] AS
SELECT CodeDroit, DescDroit
FROM Personnel.tblDroit

GO

CREATE VIEW [VEmploye] AS
SELECT IdEmp, PrenomEmp, NomEmp, CourrielEmp, NoTelPrincipal, NoTelSecondaire, AdressePostale, DateEmbaucheEmp, CompetenceParticuliere, Statut, CommentaireEmp
FROM Personnel.tblEmploye

GO

CREATE VIEW [VEmployeTypeTest] AS
SELECT IdEmp, CodeTypeTest
FROM Personnel.tblEmployeTypeTest

GO

CREATE VIEW [VEquipe] AS
SELECT IdEquipe, NomEquipe, CommentaireEquipe, Statut, IdChefEquipe, CodeProjet
FROM Personnel.tblEquipe

GO

CREATE VIEW [VEquipeTypeTest] AS
SELECT IdEquipe, CodeTypeTest
FROM Personnel.tblEquipeTypeTest

GO

CREATE VIEW [VGroupe] AS
SELECT IdGroupe, NomGroupe
FROM Personnel.tblGroupe

GO

CREATE VIEW [VGroupeDroit] AS
SELECT CodeDroit, IdGroupe
FROM Personnel.tblGroupeDroit

GO

CREATE VIEW [VGroupeUtil] AS
SELECT NomUtil, IdGroupe
FROM Personnel.tblGroupeUtil

GO

CREATE VIEW [VRole] AS
SELECT IdRole, NomRole, DescRole
FROM Personnel.tblRole

GO

CREATE VIEW [VUtilisateur] AS
SELECT NomUtil, MotPasUtil, PremiereConex, MotPasExpire, DateModifMotPas, IdRole, IdEmp, Actif
FROM Personnel.tblUtilisateur

GO

CREATE VIEW [VCasTest] AS
SELECT CodeCas, TitreCas, ObjectifCas, DateCreation, DateEcheance, DescCas, StatutCas, InfoSupCas, DifficulteCas, PrioriteCas, IdAuteur, CodeProjet, CodTypeTest
FROM Test.tblCasTest

GO

CREATE VIEW [VProjet] AS
SELECT CodeProjet, TitreProjet, ObjectifProjet, DateCreation, DateEcheance, DescProjet, Autre, CodeVersion, IdChefProjet
FROM Test.tblProjet

GO

CREATE VIEW [VTypeTest] AS
SELECT CodeTypeTest, NomTypeTest, ObjectifTypeTest, DescTypeTest, CommentaireTest
FROM Test.tblTypeTest

GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeCat ON VCategorie (CodeCategorie)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdGenre ON VGenre (IdGenre)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCoteESRB ON VClassification (CoteESRB)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdJeu ON VJeu (IdJeu)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdJeuBase_IdJeuSemblable ON VJeuSemblable (IdJeuBase, IdJeuSemblable)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdMode ON VMode (IdMode)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdPlateforme ON VPlateforme (IdPlateforme)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdPlateforme_IdJeu ON VPlateformeJeu (IdPlateforme, IdJeu)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdPlateforme_IdSysExp ON VPlateformeSysExp (IdPlateforme, IdSysExp)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdTheme ON VTheme (IdTheme)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdTheme_IdJeu ON VThemeJeu (IdTheme, IdJeu)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeVersion ON VVersion (CodeVersion)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeVersion ON VDroit (CodeDroit)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeDroit ON VDroit (CodeDroit)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdEmp ON VEmploye (IdEmp)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdEmp_CodeTypeTest ON VEmployeTypeTest (IdEmp, CodeTypeTest)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdEquipe ON VEquipe (IdEquipe)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdEquipe_CodeTypeTest ON VEquipeTypeTest (IdEquipe, CodeTypeTest)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdGroupe ON VGroupe (IdGroupe)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdGroupe_CodeDroit ON VGroupeDroit (IdGroupe, CodeDroit)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdGroupe_NomUtil ON VGroupeUtil (IdGroupe, NomUtil)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VIdRole ON VRole (IdRole)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VNomUtil ON VUtilisateur (NomUtil)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeCas ON VCasTest (CodeCas)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeProjet ON VProjet (CodeProjet)
GO
CREATE UNIQUE CLUSTERED INDEX PK_VCodeTypeTest ON VTypeTest (CodeTypeTest)
GO
USE master;
