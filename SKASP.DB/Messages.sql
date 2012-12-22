USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 12/23/2012 2:00:14 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[ID] [int] NOT NULL,
	[Creator] [int] NOT NULL,
	[Topic] [int] NOT NULL,
	[Text] [nchar](512) NULL,
	[Created_on] [date] NOT NULL
) ON [PRIMARY]

GO


