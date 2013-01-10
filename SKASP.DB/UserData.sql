USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[UserData]    Script Date: 1/10/2013 12:58:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserData](
	[UserId] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[SubName] [nvarchar](max) NULL,
	[BirthDate] [date] NULL,
	[Interests] [nvarchar](max) NULL,
	[BirthCity] [nvarchar](max) NULL,
	[AvatarId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO


