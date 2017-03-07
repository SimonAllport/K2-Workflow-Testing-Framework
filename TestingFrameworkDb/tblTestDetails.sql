GO

/****** Object:  Table [dbo].[TestDetails]    Script Date: 07/03/2017 16:32:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestDetails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TestName] [nvarchar](50) NULL,
	[WorkflowName] [nvarchar](500) NULL,
	[ProcessTypeId] [uniqueidentifier] NULL,
	[ProcessInstanceId] [int] NULL,
	[Folio] [nvarchar](50) NULL,
	[Originator] [nvarchar](100) NULL,
	[Started] [bit] NULL,
	[StartedDate] [datetime] NULL,
	[Finished] [bit] NULL,
	[FinishedDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[ViewFlow] [nvarchar](500) NULL,
	[Route] [nvarchar](500) NULL,
 CONSTRAINT [PK_TestDetails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO