/****** Script do comando SelectTopNRows de SSMS  ******/

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
           ,[PessoaId])


SELECT [EntidadeId]
      ,[EnderecoId]
      ,[Numero]
      ,[TipoEntidadeId]
      ,[edifCep]
      ,[Principal]
      ,[Ativo]
      ,[Correspondencia]
      ,[EconomiaId]
      ,[EconomiaImovelId]
      ,[ImovelId]
      ,[PessoaId]
  FROM [SMF_Processo].[dbo].[Endereco_Entidade_TEMP]