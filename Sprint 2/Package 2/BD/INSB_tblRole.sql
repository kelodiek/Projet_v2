USE dbProjetE2Prod
GO
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('PDG','Directeur général et président de la compagnie qui gère les différentes succursales. Il consulte les documents et sort les rapports.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Modérateur du focus groupe','Directeur en charge de gérer une succursale en particulier ainsi que ses différents chefs. C’est lui que va rencontrer les compagnies pour dénicher des contrats. Il valide les cahiers de charge et ajoute les clients.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Chef de projet','Celui qui est en charge de mener un projet à bien. Il divise les tâches entre de nombreuses équipes de travail. Il fait également un suivi du progrès des équipes.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Chef d’équipe','Celui qui gère une équipe de testeurs, distribue les billets de travail. Il examine la tâche à accomplir et sélectionne le personnel approprié.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Agente de bureau','Personne en charge de saisir dans le système les informations que lui fournissent le PDG, le directeur de compte, les différents chefs ainsi que les modérateurs de focus groupe.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Modérateur du focus groupe','Modérateur qui récupère les avis, les opinions et les réactions des joueurs par rapport aux idées et aux prototypes d’un projet de l''entreprise.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Testeur','Teste les jeux vidéo pour trouver des bugs et rempli des billets de travail contenant les résultats de ses tests.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Client','Il consulte les résultats des tests. C’est aussi lui qui contacte la compagnie de test pour tester un jeu.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Administrateur','Il gère les informations contenu dans  la base de données.');