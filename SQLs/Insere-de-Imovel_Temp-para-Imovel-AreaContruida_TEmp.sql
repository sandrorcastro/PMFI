
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Imovel_AreaConstruidad_Temp]
           ([ImovelId]
           ,[AreaConstruida])
SELECT distinct [ImovelId]
  --    ,[Matricula]
   --   ,[Latitude]
  --    ,[Longitude]
  --    ,[Complemento]
  --    ,[AreaTerreno]
      --,case when SUM([AreaConstruida]) -- then 0 else SUM([AreaConstruida]) end
	  ,SUM([AreaConstruida]) 
    --  ,[AnoConstrucao]
    --  ,[Caracteristica]
  FROM [SMF_Processo].[dbo].[Imovel_Temp]
  
  group by ImovelId
