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
	,t.terrAreaTerreno
	
from TribEdificacoes e
	inner join TribEdificacoesContrib ec on ec.EdificacaoID = e.EdificacaoID and (ec.Responsavel='Sim' or ec.Proprietario='Sim')
	inner join Contribuintes c on c.conId = ec.ConID
	left join tribAlvDocumento d on d.nrInscricao = e.InscricaoImobiliaria
	inner join TribTerreno t on t.TerrenoId = e.TerrenoId
group by e.InscricaoImobiliaria, c.conNome,c.ConEMail, c.ConTelefoneCelular,d.idDocumento,d.dsTipoDocumento,e.EdifCaracteristica,e.EdifAreaCoberta,e.EdifAreaConstruida,t.terrAreaTerreno
order by 1