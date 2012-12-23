USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[News]    Script Date: 12/23/2012 1:04:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[News](
	[ID] [int] NOT NULL,
	[Name] [nchar](50) NULL,
	[NewsContent] [nchar](256) NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


