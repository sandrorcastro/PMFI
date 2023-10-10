/****** Script do comando SelectTopNRows de SSMS  ******/
SELECT 
		'' as NumeroProcesso
		,CONCAT('Processo aberto pela DVFOR para a notificação do proprietário/responsável ', c.ConNome, ' pelo imóvel de inscrição imobiliária nº ' ,e.InscricaoImobiliaria,' , para construção da calçada padrão, com fundamento na Lei Complementar nº 3.144/2005 (Padronização de Calçadas no Município).') as TextoNotificacaoProcesso
		--,CONCAT('Informo que a notificação foi entregue oprietário/responsável ', c.ConNome, ' pelo imóvel de inscrição imobiliária nº ' ,e.InscricaoImobiliaria,' , para construção da calçada padrão, com fundamento na Lei Complementar nº 3.144/2005 (Padronização de Calçadas no Município).') as TextoNotificacaoDespacho

		,c.ConNome as Responsavel
		,c.ConCNPJCPF 
		,Concat('CEP:',c.COnCEP,':',' ',c.ConTipoLograd,' ',c.ConEndereco,' ',c.ConNumero,',',' ', (select BaiNome from [DBProSIGA].[dbo].[Bairro] b where  b.BairroId=c.ConBairroId )) as Endereco
		,Concat((select CidNome from cidade where cidadeid=c.ConCidadeId),' ', c.ConTelefoneCelular,' ',c.ConTelefoneComercial,' ',c.ConTelefoneResidencial,' ',c.ConTelefones) as Cidade_Telefone
	   ,substring([InscricaoImobiliaria],1,2) +'.'+substring([InscricaoImobiliaria],3,1) +'.'+substring([InscricaoImobiliaria],4,2) +'.'+substring([InscricaoImobiliaria],6,2) +'.'+ substring([InscricaoImobiliaria],8,4) +'-'+ substring([InscricaoImobiliaria],12,3) as InscriNormarizado
       ,[InscricaoImobiliaria]
      , Concat('CEP:',ee.CEP,':',' ',l.logradTipo,' ',l.LogradNome,' ',ee.Numero,',',' ', (select descricao from Loteamentos lot where lot.IDLoteamento=ee.IDLoteamento)) as EnderecoImovel	    
	 ,'' As Referencia
FROM [DBProSIGA].[dbo].[TribEdificacoes] e
	inner join [DBProSIGA].[dbo].[TribEdificacoesContrib]  ec on ec.EdificacaoId = e.EdificacaoId
	inner join [DBProSIGA].[dbo].[Contribuintes] c on c.ConId = ec.ConId
	inner join [DBProSIGA].[dbo].[TribEdificacoesEndereco] ee on ee.EdificacaoID = e.EdificacaoId 
	inner join [DBProSIGA].[dbo].[Logradouro] l on l.LogradID = ee.LogradId 
where  
	ec.Responsavel='Sim'
	AND E.inscricaoimobiliaria in 
	(
		'10139090168001',
		'10139090184001',
		'10138200516001',
		'10138190456001',
		'10139090136001',
		'10138180280001',
		'10139070180001',
		'10139070164001',
		'10139080178001',
		'10139090368001',
		'10138070160001',
		'10138070140001',
		'10139090352001',
		'10139090384001',
		'10139140106001',
		'10139140093001',
		'10139150274001',
		'10139150298001',
		'10139150310001',
		'10139150346001',
		'10139150358001',
		'10139150427001',
		'10139150443001',
		'10139150474001',
		'10139100152001',
		'10139100168001',
		'10139100225001',
		'10139100295001',
		'10139110407001',
		'10139100336001'
	)