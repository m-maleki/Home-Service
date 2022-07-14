USE [HomeServiceDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
	[Score] [int] NOT NULL,
	[ExpertId] [uniqueidentifier] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[ProfileImgUrl] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[ApplicationUserId] [uniqueidentifier] NOT NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
	[Birthday] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExpertHomeService]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExpertHomeService](
	[ExpertsId] [uniqueidentifier] NOT NULL,
	[HomeServicesId] [int] NOT NULL,
 CONSTRAINT [PK_ExpertHomeService] PRIMARY KEY CLUSTERED 
(
	[ExpertsId] ASC,
	[HomeServicesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Experts]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Experts](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Biography] [nvarchar](max) NULL,
	[ProfileImgUrl] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[MobileNumber] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
	[Score] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[ApplicationUserId] [uniqueidentifier] NOT NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
	[Birthday] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Experts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomeServiceCategories]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomeServiceCategories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[IsDeleted] [bit] NOT NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_HomeServiceCategories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HomeServices]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HomeServices](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ImgUrl] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[HomeServiceCategoryId] [int] NULL,
 CONSTRAINT [PK_HomeServices] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Alt] [nvarchar](max) NULL,
	[Url] [nvarchar](max) NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[HomeServiceId] [int] NOT NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suggestions]    Script Date: 7/14/2022 11:56:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suggestions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[ExpertId] [uniqueidentifier] NOT NULL,
	[SuggestedPrice] [float] NOT NULL,
	[RegisterDate] [datetime2](7) NOT NULL,
	[DurationOfWork] [datetime2](7) NOT NULL,
	[IsAccept] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Suggestions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220714184537_init', N'6.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220714191514_init2', N'6.0.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220714192114_56465', N'6.0.6')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'880b502d-a703-ed11-ab1c-3c7c3f514021', N'maleki.jm@gmail.com', N'MALEKI.JM@GMAIL.COM', N'maleki.jm@gmail.com', N'MALEKI.JM@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEFxhFyUPbYNxPiQ6aMTLwZjtRUUOa27+lka7aZTzMj1t0N2llQxnYeJYm/fTrOFuNA==', N'IKCLLLIK5SJGYC4JLNUTIX6JYPVRA6VG', N'62f100f3-9e08-4c1b-bff9-720427982a4f', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f89604c6-a703-ed11-ab1c-3c7c3f514021', N'maleki@gmail.com', N'MALEKI@GMAIL.COM', N'maleki@gmail.com', N'MALEKI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEObb1W5ida8NtQmV5ujaHnx8HqCyRQc/F6M3NmYcSI+9DIvrcumH/d0Ou586X1ap2Q==', N'2T3XGZ43FTSQAQCMLFBS7LZNHXHXJRME', N'a96cd882-24fc-46ad-8b14-67649c4167c3', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[Customers] ([Id], [FirstName], [LastName], [PhoneNumber], [MobileNumber], [ProfileImgUrl], [Address], [IsDeleted], [ApplicationUserId], [RegisterDate], [Birthday]) VALUES (N'5e892728-48d8-4318-9a92-08da65cbaac0', N'مسعود', N'ملکی', NULL, NULL, NULL, NULL, 0, N'f89604c6-a703-ed11-ab1c-3c7c3f514021', CAST(N'2022-07-14T23:34:22.9757056' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[ExpertHomeService] ([ExpertsId], [HomeServicesId]) VALUES (N'a023af57-3be6-47f6-a021-08da65cb120a', 4)
INSERT [dbo].[ExpertHomeService] ([ExpertsId], [HomeServicesId]) VALUES (N'a023af57-3be6-47f6-a021-08da65cb120a', 6)
GO
INSERT [dbo].[Experts] ([Id], [FirstName], [LastName], [Biography], [ProfileImgUrl], [PhoneNumber], [MobileNumber], [Address], [Score], [IsDeleted], [ApplicationUserId], [RegisterDate], [Birthday]) VALUES (N'a023af57-3be6-47f6-a021-08da65cb120a', N'علیرضا', N'رحیمی', NULL, NULL, NULL, N'0912222222', N'تهران', 0, 0, N'880b502d-a703-ed11-ab1c-3c7c3f514021', CAST(N'2022-07-14T23:30:06.7188527' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[HomeServiceCategories] ON 

INSERT [dbo].[HomeServiceCategories] ([Id], [Name], [IsDeleted], [RegisterDate]) VALUES (1, N'بنایی', 0, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[HomeServiceCategories] ([Id], [Name], [IsDeleted], [RegisterDate]) VALUES (2, N'دکوراسیون', 0, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[HomeServiceCategories] ([Id], [Name], [IsDeleted], [RegisterDate]) VALUES (3, N'نمای ساختمان', 0, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[HomeServiceCategories] OFF
GO
SET IDENTITY_INSERT [dbo].[HomeServices] ON 

INSERT [dbo].[HomeServices] ([Id], [Name], [Description], [ImgUrl], [Price], [RegisterDate], [IsDeleted], [HomeServiceCategoryId]) VALUES (4, N'کاشی و سرامیک', NULL, NULL, 0, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2), 0, 1)
INSERT [dbo].[HomeServices] ([Id], [Name], [Description], [ImgUrl], [Price], [RegisterDate], [IsDeleted], [HomeServiceCategoryId]) VALUES (6, N'مبلمان', NULL, NULL, 0, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2), 0, 2)
SET IDENTITY_INSERT [dbo].[HomeServices] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CustomerId], [HomeServiceId], [RegisterDate], [Status], [IsDeleted]) VALUES (4, N'5e892728-48d8-4318-9a92-08da65cbaac0', 4, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2), 2, 0)
INSERT [dbo].[Orders] ([Id], [CustomerId], [HomeServiceId], [RegisterDate], [Status], [IsDeleted]) VALUES (5, N'5e892728-48d8-4318-9a92-08da65cbaac0', 6, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2), 6, 0)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Suggestions] ON 

INSERT [dbo].[Suggestions] ([Id], [OrderId], [ExpertId], [SuggestedPrice], [RegisterDate], [DurationOfWork], [IsAccept], [IsDeleted]) VALUES (1, 4, N'a023af57-3be6-47f6-a021-08da65cb120a', 2500000, CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2), CAST(N'2022-02-02T00:00:00.0000000' AS DateTime2), 1, 0)
SET IDENTITY_INSERT [dbo].[Suggestions] OFF
GO
ALTER TABLE [dbo].[AspNetRoles] ADD  DEFAULT (newsequentialid()) FOR [Id]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (newsequentialid()) FOR [Id]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Experts_ExpertId] FOREIGN KEY([ExpertId])
REFERENCES [dbo].[Experts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Experts_ExpertId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[ExpertHomeService]  WITH CHECK ADD  CONSTRAINT [FK_ExpertHomeService_Experts_ExpertsId] FOREIGN KEY([ExpertsId])
REFERENCES [dbo].[Experts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExpertHomeService] CHECK CONSTRAINT [FK_ExpertHomeService_Experts_ExpertsId]
GO
ALTER TABLE [dbo].[ExpertHomeService]  WITH CHECK ADD  CONSTRAINT [FK_ExpertHomeService_HomeServices_HomeServicesId] FOREIGN KEY([HomeServicesId])
REFERENCES [dbo].[HomeServices] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ExpertHomeService] CHECK CONSTRAINT [FK_ExpertHomeService_HomeServices_HomeServicesId]
GO
ALTER TABLE [dbo].[Experts]  WITH CHECK ADD  CONSTRAINT [FK_Experts_AspNetUsers_ApplicationUserId] FOREIGN KEY([ApplicationUserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Experts] CHECK CONSTRAINT [FK_Experts_AspNetUsers_ApplicationUserId]
GO
ALTER TABLE [dbo].[HomeServices]  WITH CHECK ADD  CONSTRAINT [FK_HomeServices_HomeServiceCategories_HomeServiceCategoryId] FOREIGN KEY([HomeServiceCategoryId])
REFERENCES [dbo].[HomeServiceCategories] ([Id])
GO
ALTER TABLE [dbo].[HomeServices] CHECK CONSTRAINT [FK_HomeServices_HomeServiceCategories_HomeServiceCategoryId]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Orders_OrderId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_HomeServices_HomeServiceId] FOREIGN KEY([HomeServiceId])
REFERENCES [dbo].[HomeServices] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_HomeServices_HomeServiceId]
GO
ALTER TABLE [dbo].[Suggestions]  WITH CHECK ADD  CONSTRAINT [FK_Suggestions_Experts_ExpertId] FOREIGN KEY([ExpertId])
REFERENCES [dbo].[Experts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Suggestions] CHECK CONSTRAINT [FK_Suggestions_Experts_ExpertId]
GO
ALTER TABLE [dbo].[Suggestions]  WITH CHECK ADD  CONSTRAINT [FK_Suggestions_Orders_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO
ALTER TABLE [dbo].[Suggestions] CHECK CONSTRAINT [FK_Suggestions_Orders_OrderId]
GO
