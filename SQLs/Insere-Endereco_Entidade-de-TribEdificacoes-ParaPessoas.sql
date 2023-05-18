USE [SMF_Processo]
GO

INSERT INTO [dbo].[Endereco_Entidade_TEMP]
           ([EntidadeId]
           ,[EnderecoId]
           ,[Numero]
           ,[TipoEntidadeId]
           ,[CEP]
		   ,[edifCep]
           ,[Principal]
           ,[Ativo]
           ,[Correspondencia]
           ,[EconomiaId]
           ,[EconomiaImovelId]
           ,[ImovelId]
           ,[PessoaId])
SELECT  
      (select (SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)))) from Contribuintes C where c.ConId= tec.ConId) as PessoaId
      ,enderecoId
	  ,numero
	  ,case when C_i.ConTipoPessoa='FISCA' then 1 else 2 end as TipoPessoaId
	  ,tee.CEP
	  ,te.edifcep
	  ,case when tee.Correspondencia='Sim' then 1 else 0 end as Correspondencia
	  ,0 as Principal
	   ,1 as Ativo
	   ,(select right(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),3)  from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as EconomiaId
	  ,(select concat(left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3),right(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),3) ) from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as EconomiaImovelId
	  ,(select left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3) from TribEdificacoes te where te.EdificacaoID=tee.EdificacaoID) as ImovelId
	  ,c_i.conid
	  

  FROM [SMF_Processo].[dbo].[TribEdificacoesContrib] tec 
  inner join [SMF_Processo].[dbo].[TribEdificacoesEndereco] tee on tee.EdificacaoID = tec.EdificacaoID
  inner join [SMF_Processo].[dbo].[Contribuintes] C_i on C_i.ConId = tec.ConId 
  inner join [SMF_Processo].[dbo].[TribEdificacoes] te on te.EdificacaoID = tec.edificacaoId