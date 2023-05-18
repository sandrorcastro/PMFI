USE [SMF_Processo]
GO
INSERT INTO [dbo].[Endereco_Entidade]
           ([EntidadeId]
           ,[EnderecoId]
           ,[Numero]
           ,[TipoEntidadeId]
           ,[CEP]
           ,[Principal]
           ,[Ativo]
           ,[Correspondencia]
           ,[EconomiaId]
           ,[EconomiaImovelId]
           ,[ImovelId]
 )
SELECT 
	  (select concat(left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3),right(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),3) ) from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as EntidadeId
	  ,[EnderecoID]
      ,[Numero]
	  ,2 As TipoEntidadeId
      ,[CEP]
      ,0 as Principal
	  ,1 as Ativo
      ,case when tee.correspondencia ='Sim' then 1 else 0 end as Correspondencia
	  ,(select right(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),3)  from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as EconomiaId
	  ,(select concat(left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3),right(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),3) ) from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as EconomiaImovelId
	  ,(select left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3) from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as ImovelId
  FROM [SMF_Processo].[dbo].[TribEdificacoesEndereco] tee