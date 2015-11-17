USE dbProjetE2Test
GO
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('PDG','Directeur g�n�ral et pr�sident de la compagnie qui g�re les diff�rentes succursales. Il consulte les documents et sort les rapports.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Directeur de compte','Directeur en charge de g�rer une succursale en particulier ainsi que ses diff�rents chefs. C�est lui que va rencontrer les compagnies pour d�nicher des contrats. Il valide les cahiers de charge et ajoute les clients.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Chef de projet','Celui qui est en charge de mener un projet � bien. Il divise les t�ches entre de nombreuses �quipes de travail. Il fait �galement un suivi du progr�s des �quipes.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Chef d��quipe','Celui qui g�re une �quipe de testeurs, distribue les billets de travail. Il examine la t�che � accomplir et s�lectionne le personnel appropri�.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Agente de bureau','Personne en charge de saisir dans le syst�me les informations que lui fournissent le PDG, le directeur de compte, les diff�rents chefs ainsi que les mod�rateurs de focus groupe.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Mod�rateur du focus groupe','Mod�rateur qui r�cup�re les avis, les opinions et les r�actions des joueurs par rapport aux id�es et aux prototypes d�un projet de l''entreprise.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Testeur','Teste les jeux vid�o pour trouver des bugs et rempli des billets de travail contenant les r�sultats de ses tests.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Client','Il consulte les r�sultats des tests. C�est aussi lui qui contacte la compagnie de test pour tester un jeu.');
INSERT INTO Personnel.tblRole(NomRole,DescRole) VALUES('Administrateur','Il g�re les informations contenu dans  la base de donn�es.');
GO
USE master;