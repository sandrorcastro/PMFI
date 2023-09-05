Este script insere linhas na tabela logradouro acertando o IdTipoLogradouro importados de DBProsiga para uma tabela local LogradouroTEMP
USE [PMFI]
GO

INSERT INTO PMFI.dbo.[Logradouro]
           ([IdLogradouro]
           ,[IdTipoLogradouro]
           ,[LogradTipo]
           ,[nome])
SELECT  [LogradID]
      ,(select idtipo from logradourotipo LT where L.LogradTipo= LT.dstipologradouro) as IdTipoLogradouro
	  ,(select dstipologradouro from logradourotipo LT where L.LogradTipo= LT.dstipologradouro) as DSTipoLogradouro
      ,[LogradNome]
  FROM [PMFI].[dbo].[Logradourotemp] L
