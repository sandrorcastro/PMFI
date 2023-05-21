/****** Script do comando SelectTopNRows de SSMS  ******/
/*update I
	SET
	I.AnoContrucao = IT.Anoconstrucao
	from Imovel I
	In*/
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Imovel_AnoConstrucao_TEMP]
           ([ImovelId]
           ,[AnoConstrucao])


SELECT distinct [ImovelId],
   --   ,[Matricula]
    --  ,[Latitude]
    --  ,[Longitude]
     -- ,[Complemento]
    --  ,[AreaTerreno]
    --  ,[AreaConstruida]
      [AnoConstrucao]
      --,[Caracteristica]
  FROM [SMF_Processo].[dbo].[Imovel_Temp]
  group by imovelid,anoconstrucao