USE [StoryDB]
GO
IF  EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__KeyWord__Enabled__4D2A7347]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
Begin
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__KeyWord__Enabled__4D2A7347]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KeyWord] DROP CONSTRAINT [DF__KeyWord__Enabled__4D2A7347]
END


End
GO
/****** Object:  ForeignKey [fk_CategoryTag_Category]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_CategoryTag_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[CategoryTag]'))
ALTER TABLE [dbo].[CategoryTag] DROP CONSTRAINT [fk_CategoryTag_Category]
GO
/****** Object:  ForeignKey [fk_CategoryTag_Tag]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_CategoryTag_Tag]') AND parent_object_id = OBJECT_ID(N'[dbo].[CategoryTag]'))
ALTER TABLE [dbo].[CategoryTag] DROP CONSTRAINT [fk_CategoryTag_Tag]
GO
/****** Object:  ForeignKey [fk_Content_ContentType]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_Content_ContentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Content]'))
ALTER TABLE [dbo].[Content] DROP CONSTRAINT [fk_Content_ContentType]
GO
/****** Object:  ForeignKey [fk_Content_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_Content_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[Content]'))
ALTER TABLE [dbo].[Content] DROP CONSTRAINT [fk_Content_Story]
GO
/****** Object:  ForeignKey [fk_KeyWord_KeyWordGroup]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_KeyWord_KeyWordGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
ALTER TABLE [dbo].[KeyWord] DROP CONSTRAINT [fk_KeyWord_KeyWordGroup]
GO
/****** Object:  ForeignKey [fk_KeyWord_Style]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_KeyWord_Style]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
ALTER TABLE [dbo].[KeyWord] DROP CONSTRAINT [fk_KeyWord_Style]
GO
/****** Object:  ForeignKey [fk_StoryCategory_Category]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryCategory_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryCategory]'))
ALTER TABLE [dbo].[StoryCategory] DROP CONSTRAINT [fk_StoryCategory_Category]
GO
/****** Object:  ForeignKey [fk_StoryCategory_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryCategory_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryCategory]'))
ALTER TABLE [dbo].[StoryCategory] DROP CONSTRAINT [fk_StoryCategory_Story]
GO
/****** Object:  ForeignKey [fk_StoryKeyWord_KeyWord]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryKeyWord_KeyWord]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]'))
ALTER TABLE [dbo].[StoryKeyWord] DROP CONSTRAINT [fk_StoryKeyWord_KeyWord]
GO
/****** Object:  ForeignKey [fk_StoryKeyWord_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryKeyWord_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]'))
ALTER TABLE [dbo].[StoryKeyWord] DROP CONSTRAINT [fk_StoryKeyWord_Story]
GO
/****** Object:  ForeignKey [fk_StoryTag_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryTag_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryTag]'))
ALTER TABLE [dbo].[StoryTag] DROP CONSTRAINT [fk_StoryTag_Story]
GO
/****** Object:  ForeignKey [fk_StoryTag_Tag]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryTag_Tag]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryTag]'))
ALTER TABLE [dbo].[StoryTag] DROP CONSTRAINT [fk_StoryTag_Tag]
GO
/****** Object:  Table [dbo].[StoryKeyWord]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]') AND type in (N'U'))
DROP TABLE [dbo].[StoryKeyWord]
GO
/****** Object:  Table [dbo].[StoryTag]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoryTag]') AND type in (N'U'))
DROP TABLE [dbo].[StoryTag]
GO
/****** Object:  Table [dbo].[CategoryTag]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CategoryTag]') AND type in (N'U'))
DROP TABLE [dbo].[CategoryTag]
GO
/****** Object:  Table [dbo].[Content]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Content]') AND type in (N'U'))
DROP TABLE [dbo].[Content]
GO
/****** Object:  Table [dbo].[KeyWord]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyWord]') AND type in (N'U'))
DROP TABLE [dbo].[KeyWord]
GO
/****** Object:  Table [dbo].[StoryCategory]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoryCategory]') AND type in (N'U'))
DROP TABLE [dbo].[StoryCategory]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
DROP TABLE [dbo].[Category]
GO
/****** Object:  Table [dbo].[KeyWordGroup]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyWordGroup]') AND type in (N'U'))
DROP TABLE [dbo].[KeyWordGroup]
GO
/****** Object:  Table [dbo].[Story]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Story]') AND type in (N'U'))
DROP TABLE [dbo].[Story]
GO
/****** Object:  Table [dbo].[ContentType]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContentType]') AND type in (N'U'))
DROP TABLE [dbo].[ContentType]
GO
/****** Object:  Table [dbo].[Style]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Style]') AND type in (N'U'))
DROP TABLE [dbo].[Style]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 12/17/2012 19:59:29 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tag]') AND type in (N'U'))
DROP TABLE [dbo].[Tag]
GO
/****** Object:  Table [dbo].[Tag]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tag](
	[TagCode] [nvarchar](50) NOT NULL,
	[TagDescription] [nvarchar](1000) NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [pk_Tag] PRIMARY KEY CLUSTERED 
(
	[TagCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Style]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Style]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Style](
	[StyleId] [int] IDENTITY(1,1) NOT NULL,
	[StyleName] [nvarchar](50) NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[Bold] [bit] NOT NULL,
	[Italic] [bit] NOT NULL,
	[UnderLine] [bit] NOT NULL,
	[ForeColor] [nvarchar](20) NULL,
	[BackColor] [nvarchar](20) NULL,
	[OtherSetting] [xml] NOT NULL,
 CONSTRAINT [pkStyle] PRIMARY KEY CLUSTERED 
(
	[StyleId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ContentType]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContentType]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ContentType](
	[ContentTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ContentTypeCode] [nvarchar](50) NOT NULL,
	[ContentTypeMemeType] [nvarchar](50) NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Description] [varchar](1000) NULL,
 CONSTRAINT [pk_ContentType] PRIMARY KEY CLUSTERED 
(
	[ContentTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Story]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Story]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Story](
	[StoryId] [int] IDENTITY(1,1) NOT NULL,
	[StoryName] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](1000) NULL,
	[Tag] [nvarchar](1000) NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [pk_Story] PRIMARY KEY CLUSTERED 
(
	[StoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[KeyWordGroup]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyWordGroup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KeyWordGroup](
	[KeyWordGroupId] [int] IDENTITY(1,1) NOT NULL,
	[KeyWordGroupName] [nvarchar](50) NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[InsertDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
 CONSTRAINT [pkKeyWordGroup] PRIMARY KEY CLUSTERED 
(
	[KeyWordGroupId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Category]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[ParentCategoryId] [int] NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[UpdateBy] [nvarchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[Description] [nvarchar](1000) NULL,
 CONSTRAINT [pk_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [uk_ParentCategory] UNIQUE NONCLUSTERED 
(
	[ParentCategoryId] ASC,
	[CategoryName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[StoryCategory]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoryCategory]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StoryCategory](
	[StoryId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [pk_StoryCategory] PRIMARY KEY CLUSTERED 
(
	[StoryId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[KeyWord]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[KeyWord]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[KeyWord](
	[KeyWordId] [int] IDENTITY(1,1) NOT NULL,
	[KeyWordGroupId] [int] NOT NULL,
	[KeyWordValue] [nvarchar](200) NOT NULL,
	[KeyWordType] [nvarchar](50) NOT NULL,
	[Enabled] [bit] NOT NULL,
	[CreatetBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	[UpdateBy] [varchar](50) NOT NULL,
	[UpdateTime] [datetime] NOT NULL,
	[StyleId] [int] NOT NULL,
 CONSTRAINT [pkKeyWord] PRIMARY KEY CLUSTERED 
(
	[KeyWordId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Content]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Content]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Content](
	[StoryId] [int] NOT NULL,
	[ContentTypeId] [int] NOT NULL,
	[ContentData] [varbinary](max) NOT NULL,
 CONSTRAINT [pk_Content] PRIMARY KEY CLUSTERED 
(
	[StoryId] ASC,
	[ContentTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CategoryTag]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CategoryTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CategoryTag](
	[CategoryId] [int] NOT NULL,
	[TagCode] [nvarchar](50) NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [pk_CategoryTag] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC,
	[TagCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[StoryTag]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoryTag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StoryTag](
	[TagCode] [nvarchar](50) NOT NULL,
	[StoryId] [int] NOT NULL,
	[CreateBy] [nvarchar](50) NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [pk_StoryTag] PRIMARY KEY CLUSTERED 
(
	[StoryId] ASC,
	[TagCode] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[StoryKeyWord]    Script Date: 12/17/2012 19:59:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StoryKeyWord](
	[KeyWordId] [int] NOT NULL,
	[StoryId] [int] NOT NULL,
	[StoryKeyWordName] [nvarchar](50) NOT NULL,
	[UpdateBy] [varchar](50) NOT NULL,
	[UpdateDate] [datetime] NOT NULL,
	[Count] [int] NOT NULL,
	[Position] [int] NOT NULL,
 CONSTRAINT [pkStoryKeyWord] PRIMARY KEY CLUSTERED 
(
	[KeyWordId] ASC,
	[StoryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__KeyWord__Enabled__4D2A7347]    Script Date: 12/17/2012 19:59:29 ******/
IF Not EXISTS (SELECT * FROM sys.default_constraints WHERE object_id = OBJECT_ID(N'[dbo].[DF__KeyWord__Enabled__4D2A7347]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
Begin
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__KeyWord__Enabled__4D2A7347]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[KeyWord] ADD  DEFAULT ((1)) FOR [Enabled]
END


End
GO
/****** Object:  ForeignKey [fk_CategoryTag_Category]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_CategoryTag_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[CategoryTag]'))
ALTER TABLE [dbo].[CategoryTag]  WITH CHECK ADD  CONSTRAINT [fk_CategoryTag_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_CategoryTag_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[CategoryTag]'))
ALTER TABLE [dbo].[CategoryTag] CHECK CONSTRAINT [fk_CategoryTag_Category]
GO
/****** Object:  ForeignKey [fk_CategoryTag_Tag]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_CategoryTag_Tag]') AND parent_object_id = OBJECT_ID(N'[dbo].[CategoryTag]'))
ALTER TABLE [dbo].[CategoryTag]  WITH CHECK ADD  CONSTRAINT [fk_CategoryTag_Tag] FOREIGN KEY([TagCode])
REFERENCES [dbo].[Tag] ([TagCode])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_CategoryTag_Tag]') AND parent_object_id = OBJECT_ID(N'[dbo].[CategoryTag]'))
ALTER TABLE [dbo].[CategoryTag] CHECK CONSTRAINT [fk_CategoryTag_Tag]
GO
/****** Object:  ForeignKey [fk_Content_ContentType]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_Content_ContentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Content]'))
ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [fk_Content_ContentType] FOREIGN KEY([ContentTypeId])
REFERENCES [dbo].[ContentType] ([ContentTypeId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_Content_ContentType]') AND parent_object_id = OBJECT_ID(N'[dbo].[Content]'))
ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [fk_Content_ContentType]
GO
/****** Object:  ForeignKey [fk_Content_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_Content_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[Content]'))
ALTER TABLE [dbo].[Content]  WITH CHECK ADD  CONSTRAINT [fk_Content_Story] FOREIGN KEY([StoryId])
REFERENCES [dbo].[Story] ([StoryId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_Content_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[Content]'))
ALTER TABLE [dbo].[Content] CHECK CONSTRAINT [fk_Content_Story]
GO
/****** Object:  ForeignKey [fk_KeyWord_KeyWordGroup]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_KeyWord_KeyWordGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
ALTER TABLE [dbo].[KeyWord]  WITH CHECK ADD  CONSTRAINT [fk_KeyWord_KeyWordGroup] FOREIGN KEY([KeyWordGroupId])
REFERENCES [dbo].[KeyWordGroup] ([KeyWordGroupId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_KeyWord_KeyWordGroup]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
ALTER TABLE [dbo].[KeyWord] CHECK CONSTRAINT [fk_KeyWord_KeyWordGroup]
GO
/****** Object:  ForeignKey [fk_KeyWord_Style]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_KeyWord_Style]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
ALTER TABLE [dbo].[KeyWord]  WITH CHECK ADD  CONSTRAINT [fk_KeyWord_Style] FOREIGN KEY([StyleId])
REFERENCES [dbo].[Style] ([StyleId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_KeyWord_Style]') AND parent_object_id = OBJECT_ID(N'[dbo].[KeyWord]'))
ALTER TABLE [dbo].[KeyWord] CHECK CONSTRAINT [fk_KeyWord_Style]
GO
/****** Object:  ForeignKey [fk_StoryCategory_Category]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryCategory_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryCategory]'))
ALTER TABLE [dbo].[StoryCategory]  WITH CHECK ADD  CONSTRAINT [fk_StoryCategory_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryCategory_Category]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryCategory]'))
ALTER TABLE [dbo].[StoryCategory] CHECK CONSTRAINT [fk_StoryCategory_Category]
GO
/****** Object:  ForeignKey [fk_StoryCategory_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryCategory_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryCategory]'))
ALTER TABLE [dbo].[StoryCategory]  WITH CHECK ADD  CONSTRAINT [fk_StoryCategory_Story] FOREIGN KEY([StoryId])
REFERENCES [dbo].[Story] ([StoryId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryCategory_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryCategory]'))
ALTER TABLE [dbo].[StoryCategory] CHECK CONSTRAINT [fk_StoryCategory_Story]
GO
/****** Object:  ForeignKey [fk_StoryKeyWord_KeyWord]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryKeyWord_KeyWord]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]'))
ALTER TABLE [dbo].[StoryKeyWord]  WITH CHECK ADD  CONSTRAINT [fk_StoryKeyWord_KeyWord] FOREIGN KEY([KeyWordId])
REFERENCES [dbo].[KeyWord] ([KeyWordId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryKeyWord_KeyWord]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]'))
ALTER TABLE [dbo].[StoryKeyWord] CHECK CONSTRAINT [fk_StoryKeyWord_KeyWord]
GO
/****** Object:  ForeignKey [fk_StoryKeyWord_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryKeyWord_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]'))
ALTER TABLE [dbo].[StoryKeyWord]  WITH CHECK ADD  CONSTRAINT [fk_StoryKeyWord_Story] FOREIGN KEY([StoryId])
REFERENCES [dbo].[Story] ([StoryId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryKeyWord_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryKeyWord]'))
ALTER TABLE [dbo].[StoryKeyWord] CHECK CONSTRAINT [fk_StoryKeyWord_Story]
GO
/****** Object:  ForeignKey [fk_StoryTag_Story]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryTag_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryTag]'))
ALTER TABLE [dbo].[StoryTag]  WITH CHECK ADD  CONSTRAINT [fk_StoryTag_Story] FOREIGN KEY([StoryId])
REFERENCES [dbo].[Story] ([StoryId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryTag_Story]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryTag]'))
ALTER TABLE [dbo].[StoryTag] CHECK CONSTRAINT [fk_StoryTag_Story]
GO
/****** Object:  ForeignKey [fk_StoryTag_Tag]    Script Date: 12/17/2012 19:59:29 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryTag_Tag]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryTag]'))
ALTER TABLE [dbo].[StoryTag]  WITH CHECK ADD  CONSTRAINT [fk_StoryTag_Tag] FOREIGN KEY([TagCode])
REFERENCES [dbo].[Tag] ([TagCode])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_StoryTag_Tag]') AND parent_object_id = OBJECT_ID(N'[dbo].[StoryTag]'))
ALTER TABLE [dbo].[StoryTag] CHECK CONSTRAINT [fk_StoryTag_Tag]
GO
