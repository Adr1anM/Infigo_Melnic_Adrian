USE [CMSPlus]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Comments]    Script Date: 8/30/2024 ******/

CREATE TABLE [dbo].[Comments](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [FullName] [varchar](200) NOT NULL,
    [Content] [nvarchar](400) NOT NULL,
    [TopicId] [int] NOT NULL,
    [CreatedOnUtc] [datetime] NULL,
    [UpdatedOnUtc] [datetime] NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [CreatedOnUtc]
ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [UpdatedOnUtc]

ALTER TABLE [dbo].[Comments] 
ADD CONSTRAINT [FK_Comments_Topics] 
FOREIGN KEY ([TopicId]) 
REFERENCES [dbo].[Topics]([Id])
ON DELETE CASCADE

GO