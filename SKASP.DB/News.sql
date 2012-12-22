USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[News]    Script Date: 12/23/2012 2:00:37 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[News](
	[ID] [int] NOT NULL,
	[Name] [nchar](50) NULL,
	[NewsContent] [nchar](256) NULL,
	[Date] [date] NULL
) ON [PRIMARY]

GO


