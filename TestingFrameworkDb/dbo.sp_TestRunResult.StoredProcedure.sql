
GO
/****** Object:  StoredProcedure [dbo].[sp_TestRunResult]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TestRunResult]

@TestRunId int,
@Result nvarchar(100),
@ExpectedResult nvarchar(100),
@Pass Bit

as




update TestRun set ActualResult = @Result,Pass = @Pass,TestDate = GetDate()
where TestRunId = @TestRunId
GO
