USE [SMF_Processo]
GO

INSERT INTO [dbo].[PessoaJuridica]
           ([PessoaId]
           ,[RazaoSocial]
           ,[NomeFantasia]
           ,[InscricaoEstadual])
SELECT 
		[ConId]
		,c.ConNome
		,c.ConNomeFantasia
		,c.ConInscrEstadual

		--,C.ConIDNacionalidade
		--,(select PaisId from [SMF_Processo].dbo.Pais p where p.Nome like c.ConNacCorrigida)
		--,ConDtNasc
		--,C.ConSexo
		
		--,[ConDtUltAlt]
		--,(select(1)) as Ativo
		--,SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(C.ConCNPJCPF)))
      
  FROM [SMF_Processo].[dbo].[Contribuintes] C
  --inner join [SMF_Processo].[dbo].[Pais] P on p.Nome = C.Con
 where C.ConTipoPessoa='JURIDICA'