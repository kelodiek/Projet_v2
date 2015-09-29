USE dbProjetE2Prod
GO
INSERT INTO Jeux.tblMode(NomMode,DescMode) VALUES('Solo','Les jeux solo se joue avec qu''un seul joueur, ne nécessite aucune connexion internet, sauf si spécifier');
INSERT INTO Jeux.tblMode(NomMode,DescMode) VALUES('Multi local','Les jeux multi local ce joue a plusieur joueur sur la même plateforme de jeu, aucune connexion internet nécessaire, sauf si spécifier');
INSERT INTO Jeux.tblMode(NomMode,DescMode) VALUES('Multi en ligne','les jeux en ligne nécessitant une connexion internet à haut débit');
INSERT INTO Jeux.tblMode(NomMode,DescMode) VALUES('MMO','Les jeux massivement multijoueur en ligne nécessite une connexion internet haute débit et constante');
GO
USE master;