/*
USE [SMF_Processo]
GO

INSERT INTO [dbo].[Imovel_AnoConstrucao_TEMP]
           ([ImovelId]
           ,[AnoConstrucao])

		   */
update I
SET
	I.complemento = it.complemento
	,I.caracteristica=it.caracteristica
from Imovel I
inner join Imovel_Temp it on it.imovelid=i.imovelid

/*



SELECT distinct [ImovelId]
	,  [Complemento]
     ,[Caracteristica]
  FROM [SMF_Processo].[dbo].[Imovel_Temp]
  group by imovelid,complemento,caracteristica*/