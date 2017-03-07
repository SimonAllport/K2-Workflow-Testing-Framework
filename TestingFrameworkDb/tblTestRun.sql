GO

/****** Object:  Table [dbo].[TestRun]    Script Date: 07/03/2017 16:35:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestRun](
	[TestRunId] [int] IDENTITY(1,1) NOT NULL,
	[TestId] [int] NULL,
	[TestType] [nvarchar](100) NULL,
	[ExpectedResult] [nvarchar](100) NULL,
	[ActualResult] [nvarchar](100) NULL,
	[Pass] [bit] NULL,
	[TestDate] [datetime] NULL,
	[LeftParameter] [nvarchar](100) NULL,
	[MiddleParameter] [nvarchar](100) NULL,
	[RightParameter] [nvarchar](100) NULL,
	[Milliseconds] [int] NULL,
	[ParameterArray] [nvarchar](200) NULL,
	[Parameters] [int] NULL,
	[Sign] [nvarchar](50) NULL,
 CONSTRAINT [PK_TestRun] PRIMARY KEY CLUSTERED 
(
	[TestRunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO