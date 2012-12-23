USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Usr_lg_data]    Script Date: 12/23/2012 1:03:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usr_lg_data](
	[id] [int] NOT NULL,
	[Name] [nchar](15) NULL,
	[SubName] [nchar](15) NULL,
	[loginstr] [nchar](8) NOT NULL,
	[passwd] [nchar](10) NOT NULL,
	[created_on] [date] NOT NULL,
 CONSTRAINT [PK_Usr_lg_data] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


