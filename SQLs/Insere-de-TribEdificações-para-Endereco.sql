/****** Script do comando SelectTopNRows de SSMS  ******/
USE [SMF_Processo]
GO
INSERT INTO [dbo].[Endereco]
           ([EnderecoId]
           ,[CidadeId]
           ,[LogradouroId]
           ,[Complemento]
           ,[Ativo]
           ,[CEP])
SELECT  [EnderecoID]
       ,[CidadeID]
       ,[LogradID]
       ,[Complemento]
	   ,1 as Ativo
	  ,[CEP]

  FROM [SMF_Processo].[dbo].[TribEdificacoesEndereco]
  
