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
  
  --where tec.Proprietario='Não' and Responsavel='Não' and CoResponsavel='Não'
  /*,TipoResponsabilidadeId = case
		when (Proprietario='Não' and Responsavel='Não' and CoResponsavel='Sim')  then 3
		when (Proprietario='Não' and Responsavel='Não' and CoResponsavel='Não')  then 1
		when (Proprietario='Não' and Responsavel='Sim' and CoResponsavel='Sim')  then 1
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='Não')  then 2
		when (Proprietario='Sim' and Responsavel='Não' and CoResponsavel='Sim')  then 2
		when (Proprietario='Sim' and Responsavel='Não' and CoResponsavel='Não')  then 2
		when (Proprietario='Não' and Responsavel='Sim' and CoResponsavel='Sim')  then 1
		when (Proprietario='Não' and Responsavel='Sim' and CoResponsavel='Não')  then 2
		when (Proprietario='Não' and Responsavel='Não' and CoResponsavel='Sim')  then 1
	    when (Proprietario='Sim' and Responsavel='Não' and CoResponsavel='Não')  then 1
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='Sim')  then 1
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='Não')  then 1
		when (Proprietario='Não' and Responsavel='Não' and CoResponsavel='Sim')  then 1
	    when (Proprietario='Não' and Responsavel='Não' and CoResponsavel='Não')  then 1
		when (Proprietario='Não' and Responsavel='Sim' and CoResponsavel='Sim')  then 2
		when (Proprietario='Sim' and Responsavel='Sim' and CoResponsavel='Não')  then 2
		when (Proprietario='Sim' and Responsavel='Não' and CoResponsavel='Sim')  then 1
		when (Proprietario='Sim' and Responsavel='Não' and CoResponsavel='Não')  then 1
		end*/