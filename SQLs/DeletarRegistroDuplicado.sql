-- DELETE T FROM (SELECT *, DupRank = ROW_NUMBER() OVER (PARTITION BY EntidadeId,EnderecoId,Numero,TipoEntidadeId ORDER BY (SELECT NULL)) FROM SMF_Processo.dbo.Endereco_Entidade_TEMP) AS T WHERE DupRank > 1 
--DELETE T FROM (SELECT *, DupRank = ROW_NUMBER() OVER (PARTITION BY ImovelId,EconomiaId ORDER BY (SELECT NULL)) FROM SMF_Processo.dbo.Economia_TEMP) AS T WHERE DupRank > 1 
--DELETE T FROM (SELECT *, DupRank = ROW_NUMBER() OVER (PARTITION BY ImovelId,EconomiaId,PessoaId ORDER BY (SELECT NULL)) FROM SMF_Processo.dbo.Economia_Entidade_TEMP) AS T WHERE DupRank > 1 