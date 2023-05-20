/****** Script do comando SelectTopNRows de SSMS  ******/
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Economia_Entidade_temp]
           ([ImovelId]
           ,[EconomiaId]
           ,[PessoaId]
           ,Proprietario
           ,Responsavel
           ,CoResponsavel
           ,Locatario
           ,Correspondente)
SELECT  
      left(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),Len(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))))-3) as ImovelId
	,right(SUBSTRING(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria), PATINDEX('%[^0]%',SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria)), LEN(SMF_Processo.dbo.fncRecupera_Numeros(te.InscricaoImobiliaria))),3)   as EconomiaId
	,tec.ConID
	,case when tec.Proprietario='Sim' then 1 else 0 end  
    ,case when Responsavel='Sim' then 1 else 0 end
    ,case when CoResponsavel='Sim' then 1 else 0 end
    ,case when Locatario='Sim' then 1 else 0 end
    ,case when Correspondencia='Sim' then 1 else 0 end
  FROM [SMF_Processo].[dbo].[TribEdificacoesContrib] tec
  inner join TribEdificacoes te on te.EdificacaoID = tec.EdificacaoID     
  
  --where tec.Proprietario='N�o' and Responsavel='N�o' and CoResponsavel='N�o'
  /*,TipoResponsabilidadeId = case
		when (Proprietario='N�o' and Responsavel='N�o' and CoResponsavel='Sim')  then 3
		when (Proprietario='N�o' and Responsavel='N�o' and CoResponsavel='N�o')  then 1
		when (Proprietario='N�o' and Responsavel='Sim' and CoResponsavel='Sim')  then 1
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='N�o')  then 2
		when (Proprietario='Sim' and Responsavel='N�o' and CoResponsavel='Sim')  then 2
		when (Proprietario='Sim' and Responsavel='N�o' and CoResponsavel='N�o')  then 2
		when (Proprietario='N�o' and Responsavel='Sim' and CoResponsavel='Sim')  then 1
		when (Proprietario='N�o' and Responsavel='Sim' and CoResponsavel='N�o')  then 2
		when (Proprietario='N�o' and Responsavel='N�o' and CoResponsavel='Sim')  then 1
	    when (Proprietario='Sim' and Responsavel='N�o' and CoResponsavel='N�o')  then 1
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='Sim')  then 1
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='N�o')  then 1
		when (Proprietario='N�o' and Responsavel='N�o' and CoResponsavel='Sim')  then 1
	    when (Proprietario='N�o' and Responsavel='N�o' and CoResponsavel='N�o')  then 1
		when (Proprietario='N�o' and Responsavel='Sim' and CoResponsavel='Sim')  then 2
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='N�o')  then 2
		when (Proprietario='Sim' and Responsavel='N�o' and CoResponsavel='Sim')  then 1
		when (Proprietario='Sim' and Responsavel='N�o' and CoResponsavel='N�o')  then 1
		end*/