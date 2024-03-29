USE [Einventory]
GO
/****** Object:  Table [dbo].[stockin]    Script Date: 17/12/2022 06:27:31 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stockin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [varchar](50) NOT NULL,
	[inti_price] [numeric](9, 2) NOT NULL,
	[category] [varchar](20) NULL,
	[quntity] [int] NULL,
	[deposit] [varchar](20) NULL,
	[expire] [varchar](20) NULL,
	[last_update] [varchar](20) NULL,
	[admin_username] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stockout]    Script Date: 17/12/2022 06:27:31 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stockout](
	[id] [int] NULL,
	[product_name] [varchar](50) NOT NULL,
	[inti_price] [numeric](9, 2) NOT NULL,
	[category] [varchar](20) NULL,
	[quntity] [int] NULL,
	[deposit] [varchar](20) NULL,
	[expire] [varchar](20) NULL,
	[last_update] [varchar](20) NULL,
	[admin_username] [varchar](30) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 17/12/2022 06:27:31 م ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](30) NULL,
	[password] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
