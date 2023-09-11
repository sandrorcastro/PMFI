SELECT NULL as NumeroProcesso
	  ,[nmProprietario]
      ,[nrPropCPFCNPJ]
	--  , [nrPropCPFCNPJ] AS CPFCNPJNormatizado
      ,[nrInscricao]
	  ,CONCAT('Processo aberto pela DVFOR para a notificação do proprietário/responsável ', [nmProprietario], ' pelo imóvel de inscrição imobiliária nº ' ,[nrInscricao],
' , para apresentação de CVCO - Certificado de Conclusão de Obra, com fundamento na Lei Complementar nº 
03/1991 (Código de Obras).') as TextoNotificacaoCVCO
	  ,c.ConEMail
      ,[dsPropEndereco]
      ,[dsPropFone]
	  ,substring([nrInscricao],1,2) +'.'+substring([nrInscricao],3,1) +'.'+substring([nrInscricao],4,2) +'.'+substring([nrInscricao],6,2) +'.'+ substring([nrInscricao],8,4) +'-'+ substring([nrInscricao],12,3) as InscriNormarizado
	  ,[dsObraEndereco]
      ,[dsTipoDocumento]
	
     
  FROM [DBProsiga].[dbo].[tribAlvDocumento] tad
  inner join [DBProsiga].[dbo].[Contribuintes] c on UPPER(c.ConNome)=UPPER(tad.nmProprietario)
  where dsTipoDocumento='alvara'
  and nrInscricao in 
 
(
'10308110569001',
'10307140103001',
'10307140313001',
'10307140424001',
'10314110237001',
'10253041244001',
'10253041184001',
'10253041099001',
'10253040938001',
'10253050323001',
'10253050456001',
'06625270170001',
'10147600111001',
'10147620469001',
'10147620437001',
'10140710199001',
'10140740276001',
'10141750182001',
'10324430197001',
'10329491623001',
'10329490570001',
'10105400343001',
'10105400377001',
'10105370364001',
'10313150436001',
'10313160069001',
'10404090573001',
'10404100479001',
'10404110556001',
'10404110495001',
'10404110474001',
'10405060045001',
'10405060496001',
'10305120389001',
'10305120309001',
'10305090405001',
'10305100326001',
'10305100381001',
'10115490889001'
)
order by 2,4

  