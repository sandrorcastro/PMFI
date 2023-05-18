USE [SMF_Processo]
GO

UPDATE C
   SET 
		c.ibge = ct.CidadeId
    FROM [SMF_Processo].[dbo].[CidadeTEMP] ct
     inner join Cidade c on c.ibgeProsiga =right(ct.CidadeId,len(c.ibgeProsiga)) 


	 //Corrigi codigo ibge da tabela cidade que possui o código completo