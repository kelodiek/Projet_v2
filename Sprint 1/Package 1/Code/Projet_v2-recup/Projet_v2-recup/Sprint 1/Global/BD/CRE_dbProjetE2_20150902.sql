use master;
GO
DECLARE @dbName varchar(20) 
SET @dbName = 'dbProjetE2Prod';

DECLARE @dbCreate NVARCHAR(MAX)
DECLARE @TemplateCreate NVARCHAR(MAX)
DECLARE @dbDrop NVARCHAR(MAX)
DECLARE @TemplateDrop NVARCHAR(MAX)

SET @TemplateCreate = N'CREATE DATABASE [{dbName}]'
SET @dbCreate = REPLACE(@TemplateCreate, '{dbName}', @dbName)
SET @TemplateDrop = N'DROP DATABASE [{dbName}]'
SET @dbDrop = REPLACE(@TemplateDrop, '{dbName}', @dbName)

if exists (select * from sysdatabases where name=@dbName)
  BEGIN
  PRINT @dbDrop
  EXECUTE (@dbDrop)
  END
  
PRINT @dbCreate
EXECUTE (@dbCreate)
GO

