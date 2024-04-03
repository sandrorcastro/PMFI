use NFSEDB

SELECT -- top(10)
	case when NFSE_TBL_EMPRESA.DTABERTURA is not Null then cast(year(NFSE_TBL_EMPRESA.DTABERTURA) as varchar) else '' end  AS AnoAberturaEmpresa, --remove resultados como  null trazendo campo em branco
	case when NFSE_TBL_EMPRESA.DTABERTURA is not null then cast(Month(NFSE_TBL_EMPRESA.DTABERTURA) as varchar) else '' end AS MesAberturaEmpresa, --remove resultados como  null trazendo campo em branco
	'7563' as CodigoTom,
	dbo.formata(NFSE_TBL_CONTRIBUINTE.STCPFCNPJ,'00000000000000') AS CNPJ_Contribuinte, 
	CASE WHEN NFSE_TBL_EMPRESA.STSITUACAO = 'A' THEN 3 ELSE 2 END AS Situacao,
	Replace(Replace(Replace(Replace(Replace(NFSE_TBL_CONTRIBUINTE.STNOME,';',''),'"',''),'-',''),'(',''),')','') AS RazaoSocial, --remove caracteres especiais como ";",""",")"...
	'19000101' as Inicio, --Data de Inicio da Autoriza��o sem as barras
	'' as Fim,
	--CASE WHEN IDREGIME = 5 THEN 1 ELSE 0 END as ContribuinteEstimado,
	CASE WHEN (IDREGIME = 2 or IDREGIME=8 ) THEN 1 ELSE 0 END as ContribuinteEstimado,
	replace(dbo.RetornaCNAEsEmpresa(IDEMPRESA),' |','|') AS CNAES, -- remove os espa�os em branco entre os pipes

--CASE WHEN IDREGIME = 5 THEN ISNULL((select TOP 1 ISNULL(VLESTIMADO,0) AS VLESTIMADO from NFSE_TBL_EMPRESA_REGIME_HISTORICO H WHERE H.IDEMPRESA = NFSE_TBL_EMPRESA.IDEMPRESA ORDER BY DTENTRADA DESC),0) ELSE 0 END AS VLRESTIMADO,
CASE WHEN (IDREGIME = 2 or IDREGIME=8 ) THEN ISNULL((select TOP 1 ISNULL(VLESTIMADO,0) AS VLESTIMADO from NFSE_TBL_EMPRESA_REGIME_HISTORICO H WHERE H.IDEMPRESA = NFSE_TBL_EMPRESA.IDEMPRESA ORDER BY DTENTRADA DESC),0) ELSE 0 END AS VLRESTIMADO,
dbo.fnFormataYYYYMMDD(GETDATE()) AS DTEXPORTACAO,


REPLACE(NFSE_TBL_CONTRIBUINTE.STENDERECO_LOGR + ',' + ISNULL(NFSE_TBL_CONTRIBUINTE.STENDERECO_NUMERO,'') + ',' +'Bairro:' + ISNULL(NFSE_TBL_CONTRIBUINTE.STENDERECO_BAIRRO,'') + ISNULL(CIDADE.STNOME,' - FOZ DO IGUACU/PR') +
	'- CEP: ' + NFSE_TBL_CONTRIBUINTE.STCEP + ' '
 ,';',' ') AS ENDERECO, 

	CASE WHEN dbo.fnVerificaEmail(NFSE_TBL_CONTRIBUINTE.STEMAIL) =  'V�lido' THEN NFSE_TBL_CONTRIBUINTE.STEMAIL ELSE '' END AS EmailContribuinte

FROM NFSE_TBL_EMPRESA 
	INNER JOIN NFSE_TBL_CONTRIBUINTE ON NFSE_TBL_EMPRESA.IDCONTRIBUINTE = NFSE_TBL_CONTRIBUINTE.IDCONTRIBUINTE
	LEFT JOIN NFSE_TBL_CIDADE CIDADE ON NFSE_TBL_CONTRIBUINTE.IDCIDADE = CIDADE.IDCIDADE
WHERE NFSE_TBL_CONTRIBUINTE.STTIPO = 'J' and DTABERTURA is not null 
GO
