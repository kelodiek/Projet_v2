use dbProjetE2Test;
GO


IF OBJECT_ID('Jeux.trigInstblJeuTagtblJeu', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblJeuTagtblJeu;
END

IF OBJECT_ID('Jeux.trigInstblPlateformeTagtblPlateforme', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblPlateformeTagtblPlateforme;
END

IF OBJECT_ID('Jeux.trigInstblThemeJeuTagtblJeu', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblThemeJeuTagtblJeu;
END

IF OBJECT_ID('Jeux.trigInstblPlateformeJeuTagtblJeu', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblPlateformeJeuTagtblJeu;
END

IF OBJECT_ID('Jeux.trigInstblPlateformeSysExpTagtblPlateforme', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblPlateformeSysExpTagtblPlateforme;
END

IF OBJECT_ID('Jeux.trigInstblVersionTagtblVersion', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblVersionTagtblVersion;
END

IF OBJECT_ID('Jeux.trigInstblSysExpTagtblSysExp', 'TR') IS NOT NULL
BEGIN
    DROP TRIGGER Jeux.trigInstblSysExpTagtblSysExp;
END



GO
CREATE TRIGGER Jeux.trigInstblJeuTagtblJeu	ON Jeux.tblJeu
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdJeu AS INT,
 @IdJeuText AS VARCHAR(250),
 @NomJeu AS  VARCHAR(50),
 @DescJeu AS VARCHAR(250), 
 @CoteESRB AS VARCHAR(3),
 @IdGenre AS INT,
 @IdMode AS INT, 
 @NomGenre AS VARCHAR(35), 
 @NomMode AS VARCHAR(20),
 @InfoSupJeu AS NVARCHAR(4000)
 
SELECT @IdJeu = IdJeu, @NomJeu = NomJeu, @DescJeu = DescJeu, @CoteESRB = CoteESRB, @IdGenre = IdGenre, @IdMode = IdMode
FROM inserted

SET @IdJeuText = CONVERT(VARCHAR(250), @IdJeu)

SELECT @InfoSupJeu = CAST(InfoSupJeu AS NVARCHAR(4000))
FROM Jeux.tblJeu
WHERE IdJeu = @IdJeu

SELECT @NomGenre = NomGenre
FROM Jeux.tblGenre
WHERE IdGenre = @IdGenre

SELECT @NomMode = NomMode
FROM Jeux.tblMode
WHERE IdMode = @IdMode

UPDATE Jeux.tblJeu
SET Tag = @IdJeuText + ' ' +@NomJeu + ' ' + @DescJeu + ' ' + COALESCE(@CoteESRB,'') + ' ' + COALESCE(@NomGenre,'') + ' ' + COALESCE(@NomMode,'') + ' ' + COALESCE(@InfoSupJeu,'')
WHERE IdJeu = @IdJeu

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblJeuTagtblJeu réussie'
    
    
GO
CREATE TRIGGER Jeux.trigInstblPlateformeTagtblPlateforme	ON Jeux.tblPlateforme
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdPlateforme AS INT,
 @IdPlateformeText AS VARCHAR(250),
 @CodePlateforme AS  VARCHAR(10),
 @NomPlateforme AS VARCHAR(40),
 @CPU AS VARCHAR(40),
 @CarteMere AS VARCHAR(60),
 @RAM AS VARCHAR(60),
 @Stockage AS VARCHAR(60),
 @DescPlateforme AS VARCHAR(250),
 @CodeCategorie AS VARCHAR(7),
 @DescCategorie AS VARCHAR(40),
 @InfoSup AS NVARCHAR(4000)

 
SELECT @IdPlateforme = IdPlateforme, @CodePlateforme = CodePlateforme, @NomPlateforme = NomPlateforme,@CPU = CPU, 
@CarteMere = CarteMere, @RAM = RAM, @Stockage = Stockage, @DescPlateforme = DescPlateforme, @CodeCategorie = CodeCategorie
FROM inserted

SET @IdPlateformeText = CONVERT(VARCHAR(250), @IdPlateforme)

SELECT @InfoSup = CAST(InfoSupPlateforme AS NVARCHAR(4000))
FROM Jeux.tblPlateforme
WHERE IdPlateforme = @IdPlateforme

SELECT @DescCategorie = DescCategorie
FROM Jeux.tblCategorie
WHERE CodeCategorie = @CodeCategorie


UPDATE Jeux.tblPlateforme
SET Tag = @IdPlateformeText + ' ' +@CodePlateforme + ' ' + @NomPlateforme + ' ' + COALESCE(@CPU,'') + ' ' +
 COALESCE(@CarteMere,'') + ' ' + COALESCE(@RAM,'')+ ' ' + COALESCE(@Stockage,'') + ' ' + @DescPlateforme + ' ' + COALESCE(@CodeCategorie,'') + ' ' + COALESCE(@DescCategorie,'') + ' ' +
 COALESCE(@InfoSup,'')
WHERE IdPlateforme = @IdPlateforme

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblPlateformeTagtblPlateforme réussie'    
GO


CREATE TRIGGER Jeux.trigInstblThemeJeuTagtblJeu	ON Jeux.tblThemeJeu
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdTheme AS INT,
 @IdJeu AS INT,
 @NomTheme AS  VARCHAR(40),
 @Tag AS NVARCHAR(4000)

 
SELECT @IdJeu = IdJeu, @IdTheme = IdTheme
FROM inserted

SELECT @NomTheme = NomTheme
FROM Jeux.tblTheme
WHERE IdTheme = @IdTheme

SELECT @Tag = CAST(Tag AS NVARCHAR(4000))
FROM Jeux.tblJeu
WHERE IdJeu = @IdJeu

UPDATE Jeux.tblJeu
SET Tag = (COALESCE(@Tag,'Tag null') + ' ' + @NomTheme)
WHERE IdJeu = @IdJeu

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblThemeJeuTagtblJeu réussie'

GO
CREATE TRIGGER Jeux.trigInstblPlateformeJeuTagtblJeu	ON Jeux.tblPlateformeJeu
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdPlateforme AS INT,
 @IdJeu AS INT,
 @CodePlateforme AS  VARCHAR(10),
 @NomPlateforme AS VARCHAR(40),
 @DescPlateforme AS	VARCHAR(250),
 @Tag AS NVARCHAR(4000)

 
SELECT @IdJeu = IdJeu, @IdPlateforme = IdPlateforme
FROM inserted

SELECT @CodePlateforme = CodePlateforme, @NomPlateforme = NomPlateforme, @DescPlateforme = DescPlateforme
FROM Jeux.tblPlateforme
WHERE IdPlateforme = @IdPlateforme

SELECT @Tag = CAST(Tag AS NVARCHAR(4000))
FROM Jeux.tblJeu
WHERE IdJeu = @IdJeu

UPDATE Jeux.tblJeu
SET Tag = (COALESCE(@Tag,'Tag null') + ' ' + @CodePlateforme + ' ' + @NomPlateforme + ' ' + @DescPlateforme)
WHERE IdJeu = @IdJeu

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblPlateformeJeuTagtblJeus réussie'

GO
CREATE TRIGGER Jeux.trigInstblPlateformeSysExpTagtblPlateforme	ON Jeux.tblPlateformeSysExp
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdPlateforme AS INT,
 @IdSysExp AS INT,
 @CodeSysExp AS  VARCHAR(10),
 @NomSysExp AS VARCHAR(25),
 @EditionSysExp AS	VARCHAR(40),
 @VersionSysExp AS VARCHAR(40),
 @Tag AS NVARCHAR(4000)

 
SELECT @IdSysExp = IdSysExp, @IdPlateforme = IdPlateforme
FROM inserted

SELECT @CodeSysExp = CodeSysExp, @NomSysExp = NomSysExp, @EditionSysExp = EditionSysExp, @VersionSysExp = VersionSysExp
FROM Jeux.tblSysExp
WHERE IdSysExp = @IdSysExp

SELECT @Tag = CAST(Tag AS NVARCHAR(4000))
FROM Jeux.tblPlateforme
WHERE IdPlateforme = @IdPlateforme

UPDATE Jeux.tblPlateforme
SET Tag = (COALESCE(@Tag,'Tag null') + ' ' + @CodeSysExp + ' ' + @NomSysExp + ' ' + @EditionSysExp + ' ' + COALESCE(@VersionSysExp,''))
WHERE IdPlateforme = @IdPlateforme

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblPlateformeSysExpTagtblPlateforme réussie'

GO
CREATE TRIGGER Jeux.trigInstblVersionTagtblVersion	ON Jeux.tblVersion
AFTER INSERT
AS
BEGIN
DECLARE 
 @CodeVersion AS VARCHAR(10),
 @NomVersion AS VARCHAR(50),
 @DescVersion AS VARCHAR(250),
 @StadeDeveloppement AS VARCHAR(30),
 @DateVersion AS DATE,
 @DateSortiePrevue AS DATE,
 @IdJeu AS INT,
 @NomJeu AS VARCHAR(50),
 @DescJeu AS VARCHAR(350)
 
SELECT @IdJeu = IdJeu, @CodeVersion = CodeVersion, @NomVersion = NomVersion, @DescVersion = DescVersion, @StadeDeveloppement = StadeDeveloppement,
 @DateVersion = DateVersion, @DateSortiePrevue = DateSortiePrevue
FROM inserted

SELECT @NomJeu = NomJeu, @DescJeu = DescJeu
FROM Jeux.tblJeu
WHERE IdJeu = @IdJeu

UPDATE Jeux.tblVersion
SET Tag = (@CodeVersion + ' ' + @NomVersion + ' ' + COALESCE(@DescVersion,'') + ' ' + @StadeDeveloppement + ' ' + CAST(@DateVersion AS VARCHAR(20)) 
+ ' ' + COALESCE(CAST(@DateSortiePrevue AS VARCHAR(20)),'') + ' ' + @NomJeu + ' ' + @DescJeu)
WHERE CodeVersion = @CodeVersion

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblVersionTagtblVersion réussie'

GO
CREATE TRIGGER Jeux.trigInstblSysExpTagtblSysExp	ON Jeux.tblSysExp
AFTER INSERT
AS
BEGIN
DECLARE 
 @IdSysExp AS INT,
 @IdSysExpText AS VARCHAR(250),
 @CodeSysExp AS VARCHAR(10),
 @NomSysExp AS VARCHAR(25),
 @EditionSysExp AS VARCHAR(40),
 @VersionSysExp AS VARCHAR(40)
 
SELECT @IdSysExp = IdSysExp, @CodeSysExp = CodeSysExp, @NomSysExp = NomSysExp, @EditionSysExp = EditionSysExp,
 @VersionSysExp = VersionSysExp
FROM inserted

SET @IdSysExpText = CONVERT(VARCHAR(250), @IdSysExp)

UPDATE Jeux.tblSysExp
SET Tag = (@IdSysExpText + ' ' + @CodeSysExp + ' ' + @NomSysExp + ' ' + @EditionSysExp + ' ' + COALESCE(@VersionSysExp,''))
WHERE IdSysExp = @IdSysExp

END;
GO   
PRINT 'Création du Trigger Jeux.trigInstblSysExpTagtblSysExp réussie'




USE master;