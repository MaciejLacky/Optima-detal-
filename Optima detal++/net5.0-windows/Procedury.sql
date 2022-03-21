IF NOT EXISTS 
(
	SELECT schema_name 
    FROM information_schema.schemata 
    WHERE schema_name = 'ELTES' 
)
BEGIN
    EXEC sp_executesql N'CREATE SCHEMA ELTES';
END

--MAPPING wysyłki i atrybutów
CREATE TABLE [ELTES].[OptimaDetalMapping](
[Map_Id] [int] IDENTITY(1,1) NOT NULL,
[Map_OptId] [int] NOT NULL,
[Map_OptValue] varchar(100) NOT NULL,
[Map_ItemId] [int] NOT NULL,
[Map_ItemValue] varchar(100) NOT NULL,
[Map_AddItemId] [int] NOT NULL,
[Map_AddItemValue] varchar(100) NOT NULL,
[Map_Typ] [int] NOT NULL)
GO

CREATE TABLE [ELTES].[OptDetalSpecialPrice](
[Sp_Id] [int] primary Key IDENTITY(1,1) NOT NULL,
[Sp_TwrOptId] [int] NOT NULL,
[Sp_TwrCode] varchar(100) NOT NULL,
[Sp_TwcPriceNumber] [int] NOT NULL,
[Sp_OldPrice] DECIMAL(10,2) NOT NULL,
[Sp_SpecialPrice] DECIMAL(10,2) NOT NULL,
[Sp_DateFrom] DATETIME NOT NULL,
[Sp_DateTo] DATETIME NOT NULL
)
GO



--StringSplitter

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND OBJECT_ID = OBJECT_ID('[ELTES].[DetalGetMapping]'))
DROP PROCEDURE [ELTES].[DetalGetMapping]  

GO

CREATE PROCEDURE [ELTES].[DetalGetMapping] @type int
AS
SELECT Map_Id,Map_OptId,Map_OptValue,Map_ItemId,Map_ItemValue,Map_AddItemId, Map_AddItemValue
FROM ELTES.OptimaDetalMapping
WHERE Map_Typ=@type
GO





