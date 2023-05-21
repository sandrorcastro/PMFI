/****** Script do comando SelectTopNRows de SSMS  ******/

USE [SMF_Processo]
GO

INSERT INTO [dbo].[Imovel_Temp]
           ([ImovelId]
		   ,Matricula
		   ,Latitude
		   ,Longitude
		   ,complemento
		   ,AreaTerreno
		   ,[AreaConstruida]
		   ,AnoConstrucao
		   ,caracteristica)

SELECT  
		I.ImovelId,
		I.Matricula,
		te.edifCentroGrauLat,
		te.edifCentroGrauLon,
		te.EdifComplemento,
		tt.TerrAreaTerreno,
		te.EdifAreaConstruida,
		te.EdifAnoConstrucao,
		te.EdifCaracteristica
		
FROM [SMF_Processo].[dbo].[Imovel] I 
  inner join TribEdificacoes te on left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3)= I.ImovelId
  inner join TribTerreno tt on tt.terrenoId=te.TerrenoID
--group by I.ImovelId , te.EdifAreaConstruida 
order by 1