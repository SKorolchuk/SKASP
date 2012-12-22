USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Usr_lg_data]    Script Date: 12/23/2012 2:01:00 AM ******/
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
	[created_on] [date] NOT NULL
) ON [PRIMARY]

GO


