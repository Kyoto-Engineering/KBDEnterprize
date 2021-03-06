USE [PhonebookDB]
GO
/****** Object:  Table [dbo].[PersonInfo]    Script Date: 12/10/2016 10:09:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonInfo](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[PersonName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Specialization] [varchar](50) NULL,
	[Profession] [varchar](50) NULL,
	[EducationalLevel] [varchar](50) NULL,
	[HighestDegree] [varchar](50) NULL,
	[AgeGroup] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_PersonInfo] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonInformationn]    Script Date: 12/10/2016 10:09:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonInformationn](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[PersonName] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Mobile] [varchar](50) NULL,
	[Specialization] [varchar](50) NULL,
	[Profession] [varchar](50) NULL,
	[EducationalLevel] [varchar](50) NULL,
	[HighestDegree] [varchar](50) NULL,
	[AgeGroup] [varchar](50) NULL,
	[Company] [varchar](50) NULL,
	[Category] [varchar](50) NULL,
 CONSTRAINT [PK_PersonInformationn] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 12/10/2016 10:09:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[CategoryId] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPerson]    Script Date: 12/10/2016 10:09:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPerson](
	[PersonId] [int] NOT NULL,
	[PersonName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblPerson] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblPersonCategory]    Script Date: 12/10/2016 10:09:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPersonCategory](
	[PersonID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
 CONSTRAINT [PK_tblPersonCategory] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC,
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[PersonInfo] ON 

INSERT [dbo].[PersonInfo] ([PersonID], [PersonName], [Email], [Mobile], [Specialization], [Profession], [EducationalLevel], [HighestDegree], [AgeGroup], [Company], [CategoryID]) VALUES (1, N'jiii', N'j@gmail.com', N'01851664635', N'Hardware Ebgineer', N'Accountants', N'Some college, no degree', N'BSc In Mechanical Engineering', N'31-35', N'k', NULL)
INSERT [dbo].[PersonInfo] ([PersonID], [PersonName], [Email], [Mobile], [Specialization], [Profession], [EducationalLevel], [HighestDegree], [AgeGroup], [Company], [CategoryID]) VALUES (2, N'aa', N'a@gmail.com', N'12364646744', N'Software Engineer', N'Architects', N'High school diploma or equivalent', N'BSc in EEE', N'21-25', N'ss', NULL)
SET IDENTITY_INSERT [dbo].[PersonInfo] OFF
SET IDENTITY_INSERT [dbo].[PersonInformationn] ON 

INSERT [dbo].[PersonInformationn] ([PersonID], [PersonName], [Email], [Mobile], [Specialization], [Profession], [EducationalLevel], [HighestDegree], [AgeGroup], [Company], [Category]) VALUES (1, N'd', N'd@gmail.com', N'01746543541', N'Sub Assistant Engineer', N'Engineers', N'Postsecondary non-degree award', N'BSc in EEE', N'26-30', N'a', N'Tall')
SET IDENTITY_INSERT [dbo].[PersonInformationn] OFF
INSERT [dbo].[tblCategory] ([CategoryId], [CategoryName]) VALUES (1, N'jony')
INSERT [dbo].[tblCategory] ([CategoryId], [CategoryName]) VALUES (2, N'redoy')
INSERT [dbo].[tblCategory] ([CategoryId], [CategoryName]) VALUES (3, N'ayon')
INSERT [dbo].[tblCategory] ([CategoryId], [CategoryName]) VALUES (4, N'kalam')
INSERT [dbo].[tblCategory] ([CategoryId], [CategoryName]) VALUES (5, N'bidhan')
ALTER TABLE [dbo].[PersonInfo]  WITH CHECK ADD  CONSTRAINT [FK_PersonInfo_tblCategory] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[tblCategory] ([CategoryId])
GO
ALTER TABLE [dbo].[PersonInfo] CHECK CONSTRAINT [FK_PersonInfo_tblCategory]
GO
