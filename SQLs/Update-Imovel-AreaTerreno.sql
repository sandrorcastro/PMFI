USE [SMF_Processo]
GO
UPDATE I
   SET 
      I.[AreaTerreno] = tt.terrAreaTerreno
	  FROM [SMF_Processo].[dbo].[Imovel] I 
  inner join TribEdificacoes te on left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3)= I.ImovelId
  inner join TribTerreno tt on tt.terrenoId=te.TerrenoID


