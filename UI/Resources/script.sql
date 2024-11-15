USE [master]
GO
DROP DATABASE [DB_SIFRE]
CREATE DATABASE [DB_SIFRE]
USE [DB_SIFRE]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 28/10/2024 03:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nchar](100) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Labels]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Labels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Languages]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Languages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[isDefault] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](max) NOT NULL,
	[Type] [int] NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedBy] [uniqueidentifier] NULL,
	[UpdatedAt] [datetime] NULL,
	[Module] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NOT NULL,
	[Type] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductLogs]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductLogs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Points] [bigint] NOT NULL,
	[Category] [nvarchar](100) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[IsBlocked] [bit] NOT NULL,
	[EndDate] [datetime] NULL,
	[ProductId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[Points] [bigint] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[ProductName] [varchar](100) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[CheckDigitHorizontal] [varchar](max) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleComponent]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleComponent](
	[ParentPermissionId] [int] NULL,
	[ChildPermissionId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Points] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[TransactionDate] [date] NOT NULL,
	[CheckDigitHorizontal] [varchar](max) NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Translations]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Translations](
	[LanguageId] [int] NOT NULL,
	[LabelId] [int] NOT NULL,
	[Translation] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Translations] PRIMARY KEY CLUSTERED 
(
	[LanguageId] ASC,
	[LabelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 28/10/2024 03:28:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [uniqueidentifier] NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Username] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[FirstName] [nvarchar](255) NOT NULL,
	[LastName] [nvarchar](255) NOT NULL,
	[IsBlocked] [bit] NOT NULL,
	[LanguageId] [int] NULL,
	[RoleId] [int] NULL,
	[Points] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[PointTransfers](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [SenderUserId] [int] NOT NULL,
    [ReceiverUserId] [int] NOT NULL,
    [PointsTransferred] [int] NOT NULL,
    [TransferDate] [datetime] NOT NULL DEFAULT GETDATE(),
PRIMARY KEY CLUSTERED 
(
    [Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
CONSTRAINT [FK_PointTransfers_Sender] FOREIGN KEY ([SenderUserId]) REFERENCES [dbo].[Users]([Id]),
CONSTRAINT [FK_PointTransfers_Receiver] FOREIGN KEY ([ReceiverUserId]) REFERENCES [dbo].[Users]([Id])
) ON [PRIMARY]
GO
/****** Object:  Index [IX_Languages_isDefault]    Script Date: 28/10/2024 03:28:11 ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Languages_isDefault] ON [dbo].[Languages]
(
	[isDefault] ASC
)
WHERE ([isDefault]=(1))
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Languages] ADD  DEFAULT ((0)) FOR [isDefault]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (newid()) FOR [Id]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Points]  DEFAULT ((0)) FOR [Points]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD FOREIGN KEY([UpdatedBy])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[RoleComponent]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_RoleComponent_Child] FOREIGN KEY([ChildPermissionId])
REFERENCES [dbo].[Permissions] ([Id])
GO
ALTER TABLE [dbo].[RoleComponent] CHECK CONSTRAINT [FK_Permissions_RoleComponent_Child]
GO
ALTER TABLE [dbo].[RoleComponent]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_RoleComponent_Parent] FOREIGN KEY([ParentPermissionId])
REFERENCES [dbo].[Permissions] ([Id])
GO
ALTER TABLE [dbo].[RoleComponent] CHECK CONSTRAINT [FK_Permissions_RoleComponent_Parent]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Products]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_Users]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Labels] FOREIGN KEY([LabelId])
REFERENCES [dbo].[Labels] ([Id])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Labels]
GO
ALTER TABLE [dbo].[Translations]  WITH CHECK ADD  CONSTRAINT [FK_Translations_Languages] FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
ALTER TABLE [dbo].[Translations] CHECK CONSTRAINT [FK_Translations_Languages]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([LanguageId])
REFERENCES [dbo].[Languages] ([Id])
GO
SET IDENTITY_INSERT [dbo].[Languages] ON 
GO
INSERT [dbo].[Languages] ([Id], [Name], [isDefault]) VALUES (1, N'English', 0)
GO
INSERT [dbo].[Languages] ([Id], [Name], [isDefault]) VALUES (2, N'Spanish', 1)
GO
SET IDENTITY_INSERT [dbo].[Languages] OFF
GO
INSERT [dbo].[Users] ([Id], [Email], [Username], [Password], [FirstName], [LastName], [IsBlocked], [LanguageId], [RoleId], [Points]) VALUES (N'08095958-3051-46e0-8869-6e8619a20643', N'gestor@admin.com', N'Gestor', N'9BA3A747D2E934A8964C121DFD29905096D84CA4C99F0E479EA5CA13BE5D86BE', N'Gestor', N'Comercial', 0, 1, 28, 85000)
GO
INSERT [dbo].[Users] ([Id], [Email], [Username], [Password], [FirstName], [LastName], [IsBlocked], [LanguageId], [RoleId], [Points]) VALUES (N'3a205255-2224-47cf-9207-74426cbb7f54', N'lautaro.bazaes@gmail.com', N'Lautaro', N'9BA3A747D2E934A8964C121DFD29905096D84CA4C99F0E479EA5CA13BE5D86BE', N'Lautaro', N'Bazaes', 0, 1, 27, 9000)
GO
INSERT [dbo].[Users] ([Id], [Email], [Username], [Password], [FirstName], [LastName], [IsBlocked], [LanguageId], [RoleId], [Points]) VALUES (N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', N'admin@admin.com', N'Admin', N'9BA3A747D2E934A8964C121DFD29905096D84CA4C99F0E479EA5CA13BE5D86BE', N'Admin', N'Admin', 0, 2, 26, 938099)
GO
SET IDENTITY_INSERT [dbo].[Labels] ON 
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1004, N'MANAGE_LANG')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1005, N'PRODUCTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1006, N'NO_ROWS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1007, N'MENU_START')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1008, N'MENU_LOGIN')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1009, N'MENU_CHANGE_PASSWORD')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1010, N'MENU_LOGOUT')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1011, N'MENU_POINTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1012, N'MENU_CHECK_POINTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1013, N'MENU_VIEW_PRODUCTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1014, N'MENU_ADMIN')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1015, N'MANAGE_EMPLOYEES')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1016, N'MANAGE_ROLES')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1017, N'MANAGE_LANGUAGE')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1018, N'MANAGE_PRODUCTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1019, N'MANAGE_OBJECTIVES')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1020, N'MENU_REPORTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1021, N'MENU_HELP')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1022, N'POINTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1023, N'MENU_EXCHANGE_POINTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1024, N'EXCHANGE')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1025, N'CATEGORY')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1026, N'POINTS_EXCHANGE')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1027, N'POINTS_HISTORY')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1028, N'AVAILABLE_PRODUCTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1029, N'MANAGE_PRODUCT_TITLE')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1030, N'NAME')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1031, N'DESCRIPTION')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1032, N'ADD')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1033, N'DISABLE')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1034, N'DISABLED_PRODUCT')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1035, N'ADDED_PRODUCT')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1036, N'SUCCESS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1037, N'ALL_REQUIRED')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1038, N'VALID_POINTS')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1039, N'ACCEPT')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1040, N'CANCEL')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1041, N'CONFIRM_LOGOUT')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1042, N'DELETE_ROLE_ERROR')
GO
INSERT [dbo].[Labels] ([Id], [Name]) VALUES (1043, N'ROLE_ALREADY_EXISTS')
GO
SET IDENTITY_INSERT [dbo].[Labels] OFF
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1004, N'Lang management')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1005, N'Products')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1006, N'No rows selected')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1007, N'Start')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1008, N'Login')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1009, N'Change Password')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1010, N'Logout')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1011, N'Points')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1012, N'Check Points')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1013, N'View Products')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1014, N'Administration')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1015, N'Manage Employees')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1016, N'Manage Roles')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1017, N'Manage Language')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1018, N'Manage Products')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1019, N'Manage Objectives')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1020, N'Reports')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1021, N'Help')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1022, N'Points:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1023, N'Exchange points')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1024, N'Exchange')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1025, N'Category:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1026, N'Points Exchange:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1027, N'Points History:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1028, N'Available Products:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1029, N'Manage Products:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1030, N'Name:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1031, N'Description:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1032, N'Add')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1033, N'Disable')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1034, N'The product was disabled successfully.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1035, N'The product was added successfully.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1036, N'Success')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1037, N'All fields are required.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1038, N'The points field must be a valid number.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1039, N'Accept')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1040, N'Cancel')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1041, N'Are you sure you want to log out?')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1042, N'Cannot delete a role if it has assigned users.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (1, 1043, N'The role already exists.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1004, N'Gestión de idiomas')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1005, N'Productos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1006, N'No hay registros seleccionados.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1007, N'Inicio')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1008, N'Iniciar sesión')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1009, N'Cambiar clave')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1010, N'Cerrar sesión')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1011, N'Puntos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1012, N'Consultar puntos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1013, N'Ver productos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1014, N'Administración')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1015, N'Gestionar empleados')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1016, N'Gestionar perfiles')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1017, N'Gestionar idioma')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1018, N'Gestionar productos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1019, N'Gestionar objetivos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1020, N'Reportería')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1021, N'Ayuda')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1022, N'Puntos:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1023, N'Canjear puntos')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1024, N'Canjear')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1025, N'Categoría:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1026, N'Canjear puntos:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1027, N'Historial de puntos:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1028, N'Productos disponibles:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1029, N'Gestión de productos:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1030, N'Nombre:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1031, N'Descripción:')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1032, N'Agregar')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1033, N'Deshabilitar')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1034, N'Se deshabilitó el producto correctamente.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1035, N'Se dio de alta el producto')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1036, N'Éxito')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1037, N'Todos los campos son obligatorios.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1038, N'El campo de puntos debe ser un número válido.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1039, N'Aceptar')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1040, N'Cancelar')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1041, N'¿Está seguro que desea salir?')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1042, N'No se puede eliminar un perfil si tiene usuarios asignados.')
GO
INSERT [dbo].[Translations] ([LanguageId], [LabelId], [Translation]) VALUES (2, 1043, N'Ya existe el rol.')
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1, N'Se creó el idioma Puaner', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-06-24T20:27:39.697' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (2, N'Se creó el idioma Prueba', 2, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-06-24T20:28:55.953' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (3, N'Se borró el idioma Puaner', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-06-24T20:30:04.483' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (4, N'Se borró el idioma Prueba', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-06-24T20:30:06.767' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (5, N'Se borró la etiqueta COD_CAMBIAR_IDIOMA', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-06-24T21:40:13.407' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (6, N'Se creó la etiqueta COD_LABEL', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-06-24T21:48:47.830' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1002, N'Se creó la etiqueta MANAGE_LANG', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-06T20:59:02.300' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1003, N'Se creó la etiqueta MANAGE_LANG', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-06T20:59:03.187' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1004, N'Se borró la etiqueta COD_LABEL', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-06T20:59:31.927' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1005, N'Se borró la etiqueta MANAGE_LANG', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-06T21:00:22.563' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1006, N'Se borró la etiqueta MANAGE_LANG', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-06T21:00:29.210' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1007, N'Se creó la etiqueta MANAGE_LANG', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-06T21:00:35.027' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1008, N'Se creó el idioma Prueba', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-07T00:01:59.697' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1009, N'Se borró el idioma Prueba', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-07T00:02:04.933' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1010, N'Se creó el idioma Prueba', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-07T00:05:33.930' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1011, N'Se borró el idioma Prueba', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-07T00:05:36.523' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1012, N'Se creó la etiqueta MANAGE_LANG', 0, N'3a205255-2224-47cf-9207-74426cbb7f54', CAST(N'2024-07-07T00:21:30.733' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1013, N'Se creó la etiqueta PRODUCTS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:16:01.243' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1014, N'Se creó la etiqueta PRODUCTS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:19:30.940' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1015, N'Se creó la etiqueta PRODUCTS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:19:40.930' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1016, N'Se borró la traducción Prueba', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:23:54.510' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1017, N'Se creó la etiqueta MANAGE_LANG', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:27:16.663' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1018, N'Se borró la traducción Testing', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:27:56.517' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1019, N'Se creó la etiqueta MANAGE_LANG', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-08T02:28:26.577' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1020, N'Se creó la etiqueta NO_ROWS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T06:39:05.993' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1021, N'Se creó la etiqueta NO_ROWS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T06:40:38.587' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1022, N'Se creó la etiqueta NO_ROWS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T06:40:54.513' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1023, N'Se borró la traducción No hay registros seleccionados.', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T06:41:06.573' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1024, N'Se creó la etiqueta NO_ROWS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T06:41:26.303' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1025, N'Se borró la traducción Products', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T22:26:05.583' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1026, N'Se creó la etiqueta PRODUCTS', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-07-15T22:26:14.737' AS DateTime), NULL, NULL, NULL)
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1027, N'Se creó el idioma Spanish2', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T04:25:51.137' AS DateTime), NULL, NULL, N'FrmManageLanguage')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1028, N'Se borró el idioma Spanish2', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T04:26:02.747' AS DateTime), NULL, NULL, N'FrmManageLanguage')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1029, N'Data inconsistency detected in table: Transactions | 93a205255-2224-47cf-9207-74426cbb7f54100015/8/2024 00:00:00|Transactions', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T16:58:59.010' AS DateTime), NULL, NULL, N'FrmLogin')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1030, N'Se agregó el producto: Prueba Bitacora', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T17:18:01.227' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1031, N'Se agregó el producto: Bitacora 2', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T17:18:52.493' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1032, N'Se deshabilitó el producto: Bitacora 2', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T17:19:56.487' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1033, N'Se agregó el producto: Prueba gestor', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:04:43.200' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1034, N'Se agregó el producto: Prueba gestor', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:15:38.217' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1035, N'Se agregó el producto: Prueba gestor', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:16:02.527' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1036, N'Se deshabilitó el producto: Prueba gestor', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:18:03.147' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1037, N'Se deshabilitó el producto: Prueba DV 2', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:19:51.790' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1038, N'Se agregó el producto: Prueba nueva', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:28:46.410' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1039, N'Se deshabilitó el producto: Prueba nueva', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:28:58.790' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1040, N'Se agregó el producto: Prueba 12', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:32:32.693' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1041, N'Se deshabilitó el producto: Prueba 12', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:32:38.917' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1042, N'Se deshabilitó el producto: Prueba gestor', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:33:07.763' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1043, N'Data inconsistency detected in table: Products | 1221000030/9/2024 18:28:45Prueba nuevaGestor 4|Products', 3, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:33:38.233' AS DateTime), NULL, NULL, N'FrmLogin')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1044, N'Se recalculó la tabla Products, vuelva a iniciar sesión', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:33:40.967' AS DateTime), NULL, NULL, N'FrmInconsistencyManagement')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1045, N'Se deshabilitó el producto: Bitacora 2', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:36:44.933' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1046, N'Se deshabilitó el producto: Prueba 12', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:37:43.643' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
INSERT [dbo].[Logs] ([Id], [Message], [Type], [CreatedBy], [CreatedAt], [UpdatedBy], [UpdatedAt], [Module]) VALUES (1047, N'Se deshabilitó el producto: Teatro 25%', 0, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', CAST(N'2024-09-30T18:38:23.290' AS DateTime), NULL, NULL, N'FrmAddProducts')
GO
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 
GO
INSERT [dbo].[Categories] ([Id], [Description]) VALUES (1, N'Moda                                                                                                ')
GO
INSERT [dbo].[Categories] ([Id], [Description]) VALUES (2, N'Entretenimiento                                                                                     ')
GO
INSERT [dbo].[Categories] ([Id], [Description]) VALUES (3, N'Giftcard                                                                                            ')
GO
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (1, 2, 15000, CAST(N'2024-07-08T01:51:49.737' AS DateTime), NULL, N'Cine 2x1', N'Entradas al 2x1 en Hoyts', N'8ab861a8ca61c1cb1a4eb84c03249c2791669ffe1a8282932f4d655f97d8aa5c')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (2, 3, 900, CAST(N'2024-07-08T01:56:27.327' AS DateTime), NULL, N'70 mil pesos en Havanna', N'Giftcard de 70 mil pesos en havanna', N'04291c6922e3791633e75e908bab005f4f30768a08ffb2195c7d28ea5d70a7b0')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (3, 2, 1000, CAST(N'2024-07-15T07:47:49.600' AS DateTime), CAST(N'2024-09-30T18:38:20.273' AS DateTime), N'Teatro 25%', N'Teatro al 25% de descuento los días jueves', N'24ec4b98980d723b31a62ae8c08cb61c4ef0af22d39d798cdb0b4ac7fc60f640')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (4, 3, 1000, CAST(N'2024-08-05T02:08:38.150' AS DateTime), NULL, N'Giftcard Asado vegano', N'Asado hecho de carne notco', N'ed01defaf8c89f28d4d3e48262244368d7dfcd6f6b336424c26642fa7f6a5a00')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (5, 2, 1050, CAST(N'2024-09-30T15:25:44.467' AS DateTime), CAST(N'2024-09-30T15:29:22.563' AS DateTime), N'Prueba DV', N'Prueba Digito Verificador', N'71ca3b325b5b0fb177527f20a7d77958a3da1987f0d74a53b47d4fd71a60ce12')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (6, 3, 50000, CAST(N'2024-09-30T15:27:03.580' AS DateTime), CAST(N'2024-09-30T18:19:48.433' AS DateTime), N'Prueba DV 2', N'Digito Verificador', N'74b87de2538fa71e8a9718033187ebc60653694d6613bf6aa37eb3776918726a')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (7, 2, 100, CAST(N'2024-09-30T17:17:59.360' AS DateTime), CAST(N'2024-09-30T17:18:03.230' AS DateTime), N'Prueba Bitacora', N'Bitacora', N'dfc7c905a42ab7d4c1c783bc098b3f62e5ff52199e599d29c6db505a219e909e')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (8, 2, 111, CAST(N'2024-09-30T17:18:50.183' AS DateTime), CAST(N'2024-09-30T18:36:40.830' AS DateTime), N'Bitacora 2', N'Bitacora 2', N'2b5d33fa344ab073e5bd37c8e546b67c6568726467b6ec89e0236e67e23d1ceb')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (9, 2, 1666, CAST(N'2024-09-30T18:04:42.077' AS DateTime), CAST(N'2024-09-30T18:33:04.580' AS DateTime), N'Prueba gestor', N'gestor', N'7f43c9be3a0a187fe2195b05e515e93100ab7006ea72c409f173628b198ea51a')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (10, 2, 1509, CAST(N'2024-09-30T18:15:36.793' AS DateTime), CAST(N'2024-09-30T18:16:14.543' AS DateTime), N'Prueba gestor', N'gestor2', N'6a3efee323ab8c8bb8741d751792059a7c75b0c16ca0b2f79a28e36ef9bdc31c')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (11, 2, 19000, CAST(N'2024-09-30T18:16:01.500' AS DateTime), CAST(N'2024-09-30T18:17:59.170' AS DateTime), N'Prueba gestor', N'Prueba 3', N'ab0a12c6372c4b9f33da991cd0c1b6fa85afe19115f93d8f8951d1c73a2b3ad8')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (12, 2, 10000, CAST(N'2024-09-30T18:28:45.403' AS DateTime), NULL, N'Prueba nueva', N'Gestor 4', N'f5c62f8aff2145746e8d9bf1eeb068041a135782991043325c244f4ffabe6814')
GO
INSERT [dbo].[Products] ([Id], [CategoryId], [Points], [StartDate], [EndDate], [ProductName], [Description], [CheckDigitHorizontal]) VALUES (13, 3, 1444, CAST(N'2024-09-30T18:32:31.493' AS DateTime), NULL, N'Prueba 12', N'Prueba 12', N'26e23c032cc863ae1530e5a28bbfe4f0c08c5743e1769f3f77fdc7bfa9ec7bec')
GO
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Transactions] ON 
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (1, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 1500, 1, CAST(N'2024-07-08' AS Date), N'446f801e8858406dd5c05dc9684f029dcfc1ff318ea68fcaa0bf8187d573fa96')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (2, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 15000, 1, CAST(N'2024-07-15' AS Date), N'23070d30d2adeaa50946817819d8f380c4901d9e67537c6a8301f044771d61ce')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (3, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 15000, 1, CAST(N'2024-07-15' AS Date), N'5679fe63aee723e262f93f09998ea546cb2ee4c9f32f887af1a4f6e29491a1b1')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (4, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 900, 2, CAST(N'2024-07-15' AS Date), N'c2583d0c4f69c235fbd709b0e28c20c1e72922f05630e799b03edb326f4f6290')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (5, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 15000, 1, CAST(N'2024-07-15' AS Date), N'3d5bcb0aed469a00d3efcbb637e4e7fe563b8243624a78c85c4db455d67babdd')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (6, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 15000, 1, CAST(N'2024-07-15' AS Date), N'9822c1bef0c9b4aa2acd9f9e07b3c60c1232b659543d924964daeccc5c57f527')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (7, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 15000, 1, CAST(N'2024-07-15' AS Date), N'355ac9cae57f7b96286661a9e35eec3f644a7aa321abb88849fc042e423efdb9')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (8, N'08095958-3051-46e0-8869-6e8619a20643', 15000, 1, CAST(N'2024-07-15' AS Date), N'9f85472e0504001e2d86d28563406b5d24754f3f4831bd06d9d9bcd0795f0b4a')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (9, N'3a205255-2224-47cf-9207-74426cbb7f54', 1000, 1, CAST(N'2024-08-05' AS Date), N'f2a7b25b574d4632c7420bdbd7d569c08da64f95ce19f75080bc2d9c2c3ce724')
GO
INSERT [dbo].[Transactions] ([Id], [UserId], [Points], [ProductId], [TransactionDate], [CheckDigitHorizontal]) VALUES (10, N'2eb2ce71-c0db-43f3-a6fb-d23dabd608df', 1000, 4, CAST(N'2024-09-30' AS Date), N'f863dec9f864b635ce7665799cd6f9b3978495e8413f65bf59931c8446e6cd79')
GO
SET IDENTITY_INSERT [dbo].[Transactions] OFF
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (15, N'Cambiar clave', N'CAMBIAR_CLAVE')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (16, N'Consultar puntos', N'CONSULTAR_PUNTOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (17, N'Canjear puntos', N'CANJEAR_PUNTOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (18, N'Ver productos', N'VER_PRODUCTOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (19, N'Gestionar idioma', N'GESTIONAR_IDIOMA')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (20, N'Gestionar perfil', N'GESTIONAR_PERFIL')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (21, N'Gestionar productos', N'GESTIONAR_PRODUCTOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (22, N'Gestionar empleados', N'GESTIONAR_EMPLEADOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (23, N'Gestionar objetivos', N'GESTIONAR_OBJETIVOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (24, N'Ver reporteria', N'VER_REPORTERIA')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (25, N'Ver ayuda', N'VER_AYUDA')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (26, N'Administrador', NULL)
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (27, N'Colaborador', NULL)
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (28, N'Gestor comercial', NULL)
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (29, N'Cambiar idioma', N'CAMBIAR_IDIOMA')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (32, N'Testing 2', NULL)
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (33, N'Prueba', N'CAMBIAR_CLAVE')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (34, N'Gestionar backup', N'GESTIONAR_BACKUP')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (35, N'Bitacora eventos', N'BITACORA_EVENTOS')
GO
INSERT [dbo].[Permissions] ([Id], [Name], [Type]) VALUES (36, N'Bitacora productos', N'BITACORA_PRODUCTOS')
GO
SET IDENTITY_INSERT [dbo].[Permissions] OFF
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (27, 15)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (27, 16)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (27, 17)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (27, 18)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (27, 25)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 27)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 28)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 19)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 20)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 22)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 15)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 16)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 18)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 17)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 21)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 23)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 25)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 24)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 29)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 27)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 34)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 35)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (26, 36)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 36)
GO
INSERT [dbo].[RoleComponent] ([ParentPermissionId], [ChildPermissionId]) VALUES (28, 35)
GO
SET IDENTITY_INSERT [dbo].[ProductLogs] ON 
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (1, N'Prueba nueva', N'Gestor 4', 10000, N'Entretenimiento                                                                                     ', CAST(N'2024-09-30T18:28:50.550' AS DateTime), 0, NULL, 12)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (2, N'Prueba nueva', N'Gestor 4', 10000, N'Entretenimiento                                                                                     ', CAST(N'2024-09-30T18:28:45.000' AS DateTime), 1, NULL, 12)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (3, N'Prueba 12', N'Prueba 12', 1444, N'Entretenimiento                                                                                     ', CAST(N'2024-09-30T18:32:33.820' AS DateTime), 0, NULL, 13)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (4, N'Prueba 12', N'Prueba 12', 1444, N'Giftcard                                                                                            ', CAST(N'2024-09-30T18:32:31.000' AS DateTime), 1, NULL, 13)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (5, N'Prueba gestor', N'gestor', 1666, N'Entretenimiento                                                                                     ', CAST(N'2024-09-30T18:04:42.000' AS DateTime), 1, NULL, 9)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (6, N'Bitacora 2', N'Bitacora 2', 111, N'Entretenimiento                                                                                     ', CAST(N'2024-09-30T17:18:50.000' AS DateTime), 1, NULL, 8)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (7, N'Prueba 12', N'Prueba 12', 1444, N'Giftcard                                                                                            ', CAST(N'2024-09-30T18:32:31.000' AS DateTime), 1, NULL, 13)
GO
INSERT [dbo].[ProductLogs] ([Id], [ProductName], [Description], [Points], [Category], [StartDate], [IsBlocked], [EndDate], [ProductId]) VALUES (8, N'Teatro 25%', N'Teatro al 25% de descuento los días jueves', 1000, N'Entretenimiento                                                                                     ', CAST(N'2024-07-15T07:47:49.000' AS DateTime), 1, NULL, 3)
GO
SET IDENTITY_INSERT [dbo].[ProductLogs] OFF
GO

USE [master]
GO
ALTER DATABASE [DB_SIFRE] SET  READ_WRITE 
GO