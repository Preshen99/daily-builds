USE [Cafe]
GO

/****** Object:  Table [dbo].[menu_items]    Script Date: 2026/10/20 17:29:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[menu_items](
	[id] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[price] [decimal](18, 2) NOT NULL,
	[stock] [int] NOT NULL,
	[added_on] [date] NOT NULL,
	[supplier] [nvarchar](50) NULL,
 CONSTRAINT [PK_menu_items] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


