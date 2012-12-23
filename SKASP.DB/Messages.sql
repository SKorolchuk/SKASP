USE [dotnetpractise]
GO

/****** Object:  Table [dbo].[Messages]    Script Date: 12/23/2012 1:05:27 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Messages](
	[ID] [int] NOT NULL,
	[Creator] [int] NOT NULL,
	[Topic] [int] NOT NULL,
	[Text] [nchar](512) NULL,
	[Created_on] [date] NOT NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Topics] FOREIGN KEY([Topic])
REFERENCES [dbo].[Topics] ([ID])
GO

ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Topics]
GO

ALTER TABLE [dbo].[Messages]  WITH CHECK ADD  CONSTRAINT [FK_Messages_Usr_lg_data] FOREIGN KEY([Creator])
REFERENCES [dbo].[Usr_lg_data] ([id])
GO

ALTER TABLE [dbo].[Messages] CHECK CONSTRAINT [FK_Messages_Usr_lg_data]
GO


