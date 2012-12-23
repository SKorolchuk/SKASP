USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[MessageStorage]    Script Date: 12/23/2012 1:05:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MessageStorage](
	[ID] [int] NOT NULL,
	[Name] [nchar](64) NULL,
	[Data] [nchar](256) NULL,
	[MsgOwner] [nchar](24) NULL,
 CONSTRAINT [PK_MessageStorage] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


