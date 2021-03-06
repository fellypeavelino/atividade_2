USE [form_melo]
GO
/****** Object:  Table [dbo].[cadastro]    Script Date: 04/06/2014 22:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cadastro](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](100) NOT NULL,
	[rua] [varchar](80) NOT NULL,
	[numero] [varchar](20) NOT NULL,
	[complemento] [varchar](60) NOT NULL,
	[bairro] [varchar](60) NOT NULL,
	[cidade] [varchar](60) NOT NULL,
	[uf] [char](2) NOT NULL,
	[pais] [varchar](40) NOT NULL,
	[data] [varchar](600) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[rg] [varchar](14) NOT NULL,
	[pai] [varchar](100) NULL,
	[mae] [varchar](100) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
