
GO
/****** Object:  StoredProcedure [dbo].[sp_TestRunPlanResults]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_TestRunPlanResults]
@TestRunId int,
	@ActualResult nvarchar(100),
	@Pass bit,
	@TestDate datetime
	
as



UPDATE TestRun SET 
		
		[ActualResult] = @ActualResult,
		[Pass] = @Pass,
		[TestDate] = @TestDate
		
	WHERE [TestRunId] = @TestRunId

GO
