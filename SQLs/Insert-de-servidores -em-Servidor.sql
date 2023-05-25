/****** Script do comando SelectTopNRows de SSMS  ******/
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Servidor]
           ([ServidorId]
           ,[Nome]
           ,[Matricula]
           ,[Ativo]
           ,[Cargo]
           ,[Funcao]
           ,[UnidadeId])
SELECT [ServID]
      ,[ServNome]
      ,[ServMatricula]
      ,case when ServSituacaoFunc='Ativo' then 1 else 0 end
      ,[ServCargo]
      ,[ServFuncao]
      ,[ServDivisaoID]
  FROM [DBProSIGA_IPTU].[dbo].[Servidores]