USE [Nawab]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/4/2021 9:27:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[f_name] [nvarchar](100) NULL,
	[m_name] [nvarchar](100) NULL,
	[l_name] [nvarchar](100) NULL,
	[address] [nvarchar](100) NULL,
	[birthDay] [nvarchar](100) NULL,
	[score] [nvarchar](100) NULL,
	[dep_id] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDay], [score], [dep_id]) VALUES (2, N'Le', N'Minh', N'Trang', N'Ho Chi Minh', N'1-2-2000', N'9', NULL)
INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDay], [score], [dep_id]) VALUES (5, N'Ho', N'Chi', N'Nguyen', N'Binh Dinh', N'15-05-2000', N'10', NULL)
INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDay], [score], [dep_id]) VALUES (6, N'le', N'thi', N'ha', N'hai phong', N'10-12-2000', N'3', NULL)
INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDay], [score], [dep_id]) VALUES (7, N'Nguye', N'Huong', N'Giang ', N'Sai Gon', N'29-2-2000', N'6', NULL)
INSERT [dbo].[Student] ([Id], [f_name], [m_name], [l_name], [address], [birthDay], [score], [dep_id]) VALUES (8, N'nguyen', N'manh ', N'hoai', N'Binh Dinh', N'10-4-2000', N'5', NULL)
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
