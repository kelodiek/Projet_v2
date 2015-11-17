use dbProjetE2Test;
GO
CREATE VIEW [AllChefEquipe] AS
SELECT e.IdEmp,e.PrenomEmp, e.NomEmp, e.Statut
        FROM Personnel.tblEmploye AS e
		INNER JOIN Personnel.tblUtilisateur as u
		ON e.IdEmp = u.IdEmp
		INNER JOIN Personnel.tblRole AS r
              ON r.IdRole = u.IdRole
WHERE r.NomRole='Chef d’équipe'

GO

CREATE VIEW [AllEmployeRole] AS
SELECT e.IdEmp, e.PrenomEmp, e.NomEmp, e.CourrielEmp, e.NoTelPrincipal, e.NoTelSecondaire, e.AdressePostale,
    e.DateEmbaucheEmp, e.CompetenceParticuliere, e.Statut, e.CommentaireEmp, r.IdRole, r.NomRole, r.DescRole
        FROM Personnel.tblEmploye AS e
  INNER JOIN Personnel.tblUtilisateur as u
  ON e.IdEmp = u.IdEmp
  INNER JOIN Personnel.tblRole AS r
              ON r.IdRole = u.IdRole
GO

CREATE FUNCTION GetEmployeByRole(@role AS INT)
RETURNS @EmployeByRole TABLE
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
	CommentaireEmp			VARCHAR(250)NULL,
	IdRole					INT			NOT NULL,
	NomRole					VARCHAR(30)	NOT NULL,
	DescRole				VARCHAR(250)NULL
   )
AS
BEGIN
   INSERT @EmployeByRole
        SELECT e.IdEmp, e.PrenomEmp, e.NomEmp, e.CourrielEmp, e.NoTelPrincipal, e.NoTelSecondaire, e.AdressePostale,
				e.DateEmbaucheEmp, e.CompetenceParticuliere, e.Statut, e.CommentaireEmp, r.IdRole, r.NomRole, r.DescRole
        FROM Personnel.tblEmploye AS e
		INNER JOIN Personnel.tblUtilisateur as u
		ON e.IdEmp = u.IdEmp
		INNER JOIN Personnel.tblRole AS r
              ON r.IdRole = u.IdRole
        WHERE r.IdRole > @role
   RETURN
END

GO
use master;