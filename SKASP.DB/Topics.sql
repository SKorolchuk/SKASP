USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Topics]    Script Date: 12/23/2012 1:03:31 PM ******/
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
	[Theme] [int] NOT NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Themes] FOREIGN KEY([Theme])
REFERENCES [dbo].[Themes] ([ID])
GO

ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Themes]
GO

ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Usr_lg_data] FOREIGN KEY([Creator])
REFERENCES [dbo].[Usr_lg_data] ([id])
GO

ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Usr_lg_data]
GO


