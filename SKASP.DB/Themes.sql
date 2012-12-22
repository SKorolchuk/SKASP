USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Themes]    Script Date: 12/23/2012 2:00:54 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Themes](
	[ID] [int] NOT NULL,
	[Name] [nchar](256) NULL,
	[Description] [nchar](256) NULL,
	[Creator] [int] NOT NULL,
	[Created_on] [date] NOT NULL,
	[Subgroup] [nchar](64) NULL
) ON [PRIMARY]

GO


