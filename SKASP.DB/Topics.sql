USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Topics]    Script Date: 12/23/2012 2:00:57 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Topics](
	[ID] [int] NOT NULL,
	[Name] [nchar](256) NULL,
	[Description] [nchar](256) NULL,
	[Creator] [int] NOT NULL,
	[Created_on] [date] NOT NULL,
	[Theme] [int] NOT NULL
) ON [PRIMARY]

GO


