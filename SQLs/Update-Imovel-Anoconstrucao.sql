/****** Script do comando SelectTopNRows de SSMS  ******/
update I
set i.anoconstrucao=ia.anoconstrucao
from Imovel i
inner join Imovel_AnoConstrucao_TEMP ia on ia.imovelid=i.imovelid


/*
SELECT [ImovelId]
      ,[AnoConstrucao]
  FROM [SMF_Processo].[dbo].[Imovel_AnoConstrucao_TEMP]*/