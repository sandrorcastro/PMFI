USE [SMF_Processo]
GO
UPDATE I
   SET 
      I.[AreaConstruida] = t.areaconstruida
	
FROM [SMF_Processo].[dbo].[Imovel] I 
  inner join Imovel_AreaConstruidad_temp t on t.imovelid=I.imovelid


  

