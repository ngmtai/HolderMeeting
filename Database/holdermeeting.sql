USE [HolderMeeting]
GO
/****** Object:  Table [dbo].[Vote]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vote](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](400) NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [date] NULL,
	[CreateUser] [nvarchar](100) NULL,
	[UpdateDate] [date] NULL,
	[UpdateUser] [nvarchar](100) NULL,
 CONSTRAINT [PK_Vote] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HolderInvite]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HolderInvite](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
	[TotalShare] [decimal](18, 0) NULL,
 CONSTRAINT [PK_HolderInvite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[Id] [int] NOT NULL,
	[DisplayName] [nvarchar](300) NULL,
	[TotalShare] [decimal](18, 0) NULL,
	[About] [nvarchar](500) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnswerType]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AnswerType](
	[Id] [int] NOT NULL,
	[DisplayName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_AnswerType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Holder]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Holder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [varchar](50) NULL,
	[Name] [nvarchar](200) NULL,
	[TotalShare] [decimal](18, 0) NULL,
	[AuthorizerName] [nvarchar](200) NULL,
	[IsActive] [bit] NULL,
	[CompanyId] [int] NULL,
	[CreateDate] [date] NULL,
	[CreateUser] [nvarchar](100) NULL,
	[UpdateDate] [date] NULL,
	[UpdateUser] [nvarchar](100) NULL,
 CONSTRAINT [PK_Holder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](500) NULL,
	[TypeId] [int] NULL,
	[VoteId] [int] NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [date] NULL,
	[CreateUser] [nvarchar](100) NULL,
	[UpdateDate] [date] NULL,
	[UpdateUser] [nvarchar](100) NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holder_Vote]    Script Date: 12/06/2014 16:22:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holder_Vote](
	[HolderId] [int] NOT NULL,
	[VoteId] [int] NOT NULL,
	[AnswerId] [int] NOT NULL,
	[AnswerName] [nvarchar](500) NULL,
	[TotalShare] [decimal](18, 0) NULL,
	[IsActive] [bit] NULL,
	[CreateDate] [date] NULL,
	[CreateUser] [nvarchar](100) NULL,
	[UpdateDate] [date] NULL,
	[UpdateUser] [nvarchar](100) NULL,
 CONSTRAINT [PK_Holder_Vote] PRIMARY KEY CLUSTERED 
(
	[HolderId] ASC,
	[VoteId] ASC,
	[AnswerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Answer_AnswerType]    Script Date: 12/06/2014 16:22:22 ******/
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_AnswerType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[AnswerType] ([Id])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_AnswerType]
GO
/****** Object:  ForeignKey [FK_Answer_Vote]    Script Date: 12/06/2014 16:22:22 ******/
ALTER TABLE [dbo].[Answer]  WITH CHECK ADD  CONSTRAINT [FK_Answer_Vote] FOREIGN KEY([VoteId])
REFERENCES [dbo].[Vote] ([Id])
GO
ALTER TABLE [dbo].[Answer] CHECK CONSTRAINT [FK_Answer_Vote]
GO
/****** Object:  ForeignKey [FK_Holder_Company]    Script Date: 12/06/2014 16:22:22 ******/
ALTER TABLE [dbo].[Holder]  WITH CHECK ADD  CONSTRAINT [FK_Holder_Company] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([Id])
GO
ALTER TABLE [dbo].[Holder] CHECK CONSTRAINT [FK_Holder_Company]
GO
/****** Object:  ForeignKey [FK_Holder_Vote_Answer]    Script Date: 12/06/2014 16:22:22 ******/
ALTER TABLE [dbo].[Holder_Vote]  WITH CHECK ADD  CONSTRAINT [FK_Holder_Vote_Answer] FOREIGN KEY([AnswerId])
REFERENCES [dbo].[Answer] ([Id])
GO
ALTER TABLE [dbo].[Holder_Vote] CHECK CONSTRAINT [FK_Holder_Vote_Answer]
GO
/****** Object:  ForeignKey [FK_Holder_Vote_Holder]    Script Date: 12/06/2014 16:22:22 ******/
ALTER TABLE [dbo].[Holder_Vote]  WITH CHECK ADD  CONSTRAINT [FK_Holder_Vote_Holder] FOREIGN KEY([HolderId])
REFERENCES [dbo].[Holder] ([Id])
GO
ALTER TABLE [dbo].[Holder_Vote] CHECK CONSTRAINT [FK_Holder_Vote_Holder]
GO
/****** Object:  ForeignKey [FK_Holder_Vote_Vote]    Script Date: 12/06/2014 16:22:22 ******/
ALTER TABLE [dbo].[Holder_Vote]  WITH CHECK ADD  CONSTRAINT [FK_Holder_Vote_Vote] FOREIGN KEY([VoteId])
REFERENCES [dbo].[Vote] ([Id])
GO
ALTER TABLE [dbo].[Holder_Vote] CHECK CONSTRAINT [FK_Holder_Vote_Vote]
GO
