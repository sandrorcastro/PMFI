use DBProsiga
select --distinct
	--d.nrInscricao
	e.InscricaoImobiliaria
	, c.conNome
	,c.ConEMail
	,c.ConTelefoneCelular
	,d.idDocumento
	,d.dsTipoDocumento
	,e.EdifCaracteristica
	,e.EdifAreaCoberta
	,e.EdifAreaConstruida
	
from TribEdificacoes e
	inner join TribEdificacoesContrib ec on ec.EdificacaoID = e.EdificacaoID and (ec.Responsavel='Sim' or ec.Proprietario='Sim')
	inner join Contribuintes c on c.conId = ec.ConID
	left join tribAlvDocumento d on d.nrInscricao = e.InscricaoImobiliaria
group by e.InscricaoImobiliaria, c.conNome,c.ConEMail, c.ConTelefoneCelular,d.idDocumento,d.dsTipoDocumento,e.EdifCaracteristica,e.EdifAreaCoberta,e.EdifAreaConstruida
order by 1