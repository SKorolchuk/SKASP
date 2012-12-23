USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Themes]    Script Date: 12/23/2012 1:04:00 PM ******/
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
	[Subgroup] [nchar](64) NULL,
 CONSTRAINT [PK_Themes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Themes]  WITH CHECK ADD  CONSTRAINT [FK_Themes_Usr_lg_data] FOREIGN KEY([Creator])
REFERENCES [dbo].[Usr_lg_data] ([id])
GO

ALTER TABLE [dbo].[Themes] CHECK CONSTRAINT [FK_Themes_Usr_lg_data]
GO


