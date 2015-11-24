CREATE VIEW [VJeuRecherche] AS
SELECT j.NomJeu, j.DescJeu, j.CoteESRB, g.NomGenre , m.NomMode
        FROM Jeux.tblJeu AS j
		INNER JOIN Jeux.tblGenre as g
		ON j.IdGenre = g.IdGenre
		INNER JOIN Jeux.tblMode AS m
              ON j.IdMode = m.IdMode

GO

CREATE VIEW [VPlateformeRecherche] AS
SELECT CodePlateforme, NomPlateforme ,CodeCategorie ,DescPlateforme 
        FROM Jeux.tblPlateforme

GO

CREATE VIEW [VEmployeRecherche] AS
SELECT IdEmp, PrenomEmp, NomEmp,CourrielEmp, NoTelPrincipal, NoTelSecondaire, AdressePostale, DateEmbaucheEmp
        FROM Personnel.tblEmploye

GO

CREATE VIEW [VVersionRecherche] AS
SELECT CodeVersion, NomVersion, DescVersion, StadeDeveloppement, DateVersion, DateSortiePrevue
        FROM Jeux.tblVersion

GO

CREATE VIEW [VEquipeRecherche] AS
SELECT  e.CodeProjet, e.IdEquipe, e.NomEquipe, c.PrenomEmp c.NomEmp, t.NomTypeTest,
        FROM Personnel.tblEquipe AS e
		INNER JOIN Personnel.tblEquipeTypeTest as b
		ON b.IdEquipe = e.IdEquipe
		INNER JOIN Personnel.tblTypeTest AS t
              ON b.CodeTypeTest = t.CodeTypeTest
		INNER JOIN Personnel.tblEmploye AS c
              ON c.IdChefEquipe = e.IdEmp

GO

CREATE VIEW [VTypeTestRecherche] AS
SELECT CodeTypeTest, NomTypeTest, ObjectifTypeTest, DescTypeTest, CommentaireTest
        FROM Test.tblTypeTest
GO

CREATE VIEW [VProjetRecherche] AS
SELECT p.CodeProjet, p.TitreProjet, p.ObjectifProjet, p.DateCreation, p.DateEcheance, v.NomVersion
        FROM Test.tblProjet AS p
		INNER JOIN Jeux.tblVersion as v
		ON v.CodeVersion = p.CodeVersion
GO