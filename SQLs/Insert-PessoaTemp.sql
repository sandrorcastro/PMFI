/****** Script do comando SelectTopNRows de SSMS  ******/
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Pessoa_TEMP]
           ([PessoaId]
           ,[Nome]
           ,[TipoPessoaId]
           ,[DataCadastro]
           ,[Ativo]
           ,[conId])
SELECT 
		SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)))
		,[ConNome]
		,case when C.ConTipoPessoa='FISICA' then 1 else 2 end as TipoPessoaId
		,[ConDtUltAlt]
		,(select(1)) as Ativo
		,[ConId]
      
  FROM [SMF_Processo].[dbo].[Contribuintes] C
  --group by ConNome
  group by SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)))
			,ConNome
			,[ConTipoPessoa]
			,[ConId]
			,[ConDtUltAlt]