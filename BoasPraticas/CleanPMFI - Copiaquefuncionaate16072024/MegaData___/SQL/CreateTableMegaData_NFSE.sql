USE [NFSEDB]
GO

/****** Object:  Table [dbo].[MegaData_NFSE]    Script Date: 19/10/2023 10:04:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MegaData_NFSE](
	[IDMegaData_NFSE] [bigint] NOT NULL,
	[DataGeracao] [datetime] NOT NULL,
	[DataInicioPeriodo] [datetime] NOT NULL,
	[DataFinalPeriodo] [datetime] NOT NULL,
	[DataEnvio] [datetime] NULL,
	[NomeArquivo] [nchar](150) NULL,
	[CaminhoArquivo] [nchar](250) NULL,
	[TipoArquivo] [nchar](25) NULL,
 CONSTRAINT [PK_MegaData_NFSE] PRIMARY KEY CLUSTERED 
(
	[IDMegaData_NFSE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
