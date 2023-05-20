/****** Script do comando SelectTopNRows de SSMS  ******/
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Economia]
           ([ImovelId]
           ,[EconomiaId]
           ,[Complemento]
           ,[AreaConstruida]
           ,[AnoConstrucao]
           ,[Numeracao]
           ,[Caracteristica]
           ,[Matricula]
           ,[TemProcessos]
           ,[TerrenoIdTemp])
SELECT [ImovelId]
      ,[EconomiaId]
      ,[Complemento]
      ,[AreaConstruida]
      ,[AnoConstrucao]
      ,[Numeracao]
      ,[Caracteristica]
      ,[Matricula]
      ,0
      ,[TerrenoIdTemp]
  FROM [SMF_Processo].[dbo].[Economia_temp]