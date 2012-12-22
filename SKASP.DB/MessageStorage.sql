USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[MessageStorage]    Script Date: 12/23/2012 2:00:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MessageStorage](
	[ID] [int] NOT NULL,
	[Name] [nchar](64) NULL,
	[Data] [nchar](256) NULL,
	[MsgOwner] [nchar](24) NULL
) ON [PRIMARY]

GO


