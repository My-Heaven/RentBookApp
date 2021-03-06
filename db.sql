USE [RentBooksApp]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 3/22/2021 9:05:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[fullname] [nvarchar](50) NULL,
	[roleId] [bit] NULL,
 CONSTRAINT [PK__tblAccou__F3DBC573A4EF5F70] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblAccount] ([username], [password], [fullname], [roleId]) VALUES (N'user', N'1', N'Employee', 1)
GO
