This is database 


USE [Employee-Mangement]
GO

/****** Object:  Table [dbo].[Employee]    Script Date: 14-01-2025 12:56:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[EmployeeID] [int] NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Department] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
	[Phone] [varchar](50) NOT NULL,
	[JoiningDate] [datetime] NOT NULL
) ON [PRIMARY]
GO


