/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT top(100)
		I.ImovelId,
	/*	te.EdifMatricula,
		te.edifCentroGrauLat,
		te.edifCentroGrauLon,
		te.EdifComplemento,
		te.EdifAreaConstruida,*/
		sum(te.EdifAreaConstruida)/*,
		te.EdifAnoConstrucao,
		te.EdifCaracteristica*/
		
  FROM [SMF_Processo].[dbo].[Imovel] I 
  full outer join TribEdificacoes te on left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3)= I.ImovelId
  where I.ImovelId in (103374701,644701259 )
 group by I.ImovelId ,/*
		te.EdifMatricula,
		te.edifCentroGrauLat,
		te.edifCentroGrauLon,
		te.EdifComplemento,*/
		te.EdifAreaConstruida --,
		--te.EdifAnoConstrucao,
		--te.EdifCaracteristica
	--sum(te.EdifAreaConstruida)
	
  order by 1