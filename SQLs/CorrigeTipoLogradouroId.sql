USE [SMF_Processo]
GO

UPDATE [dbo].[Logradouro]
   SET 
    
      [TipoLogradouroId] =( select TipoLogradouroId from TipoLogradouro TL where TL.Descricao= descricaoTipoLogradouro  )
      
 
