USE dbProjetE2Prod;
GO
INSERT INTO Personnel.tblDroit(CodeDroit,DescDroit) values('RP01','Droit lecture sur tout le contenu de jeu');
INSERT INTO Personnel.tblDroit(CodeDroit,DescDroit) values('WP01','Droit écriture sur tout le contenu de jeu');
INSERT INTO Personnel.tblDroit(CodeDroit,DescDroit) values('RP02','Droit lecture sur tout le contenu employé');
INSERT INTO Personnel.tblDroit(CodeDroit,DescDroit) values('WP02','Droit écriture sur tout le contenu employé');
INSERT INTO Personnel.tblDroit(CodeDroit,DescDroit) values('RP03','Droit lecture sur tout le contenu test');
INSERT INTO Personnel.tblDroit(CodeDroit,DescDroit) values('WP03','Droit écriture sur tout le contenu de test');
GO
USE master;