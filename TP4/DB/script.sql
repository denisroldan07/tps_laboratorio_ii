USE [Vuelos]
GO
/****** Object:  Table [dbo].[tickets]    Script Date: 6/20/2022 8:30:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tickets](
	[dni] [bigint] NOT NULL,
	[nombre] [varchar](255) NOT NULL,
	[apellido] [varchar](255) NOT NULL,
	[asiento] [int] NOT NULL,
	[destino] [varchar](255) NOT NULL,
	[avion] [int] NOT NULL,
	[fecha] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tickets] ADD  DEFAULT (NULL) FOR [fecha]
GO
