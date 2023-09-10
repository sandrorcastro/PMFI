SELECT NULL as NumeroProcesso
	  ,[nmProprietario]
      ,[nrPropCPFCNPJ]
	--  , [nrPropCPFCNPJ] AS CPFCNPJNormatizado
	  ,c.ConEMail
      ,[dsPropEndereco]
      ,[dsPropFone]
      ,[nrInscricao]
	  ,substring([nrInscricao],1,2) +'.'+substring([nrInscricao],3,1) +'.'+substring([nrInscricao],4,2) +'.'+substring([nrInscricao],6,2) +'.'+ substring([nrInscricao],8,4) +'-'+ substring([nrInscricao],12,3)
	  ,[dsObraEndereco]
      ,[dsTipoDocumento]
	  ,CONCAT('Processo aberto pela DVFOR para a notificação do proprietário/responsável pelo imóvel de inscrição imobiliária nº ' ,[nrInscricao],
' , para apresentação de CVCO - Certificado de Conclusão de Obra, com fundamento na Lei Complementar nº 
03/1991 (Código de Obras).') as TextoNotificacaoCVCO
     
  FROM [DBProsiga].[dbo].[tribAlvDocumento] tad
  inner join [DBProsiga].[dbo].[Contribuintes] c on UPPER(c.ConNome)=UPPER(tad.nmProprietario)
  where dsTipoDocumento='alvara'
  and nrInscricao in 
  (
  '06650291261001',
  '06531420589001',
  '10202250231001',
  '06521011686001',
  '06631150168001',
  '10331520461001',
  '10147600256001',
  '10228130126001')
