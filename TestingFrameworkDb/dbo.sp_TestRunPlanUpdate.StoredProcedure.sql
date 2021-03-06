
GO
/****** Object:  StoredProcedure [dbo].[sp_TestRunPlanUpdate]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TestRunPlanUpdate]

@TestRunId int,
@TestId int,
	@TestType nvarchar(100),
	@ExpectedResult nvarchar(100),
	
	@LeftParameter nvarchar(100),
	@MiddleParameter nvarchar(100),
	@RightParameter nvarchar(100),
	@Milliseconds nvarchar(100),
	@parameters int,
	@sign nvarchar(50)
as




	UPDATE TestRun SET 
		[TestId] = @TestId,
		[TestType] = @TestType,
		[ExpectedResult] = @ExpectedResult,
		
		[LeftParameter] = @LeftParameter,
		[MiddleParameter] = @MiddleParameter,
		[RightParameter] = @RightParameter,
		Milliseconds = @Milliseconds,
		[Parameters] = @Parameters,
		[sign] = @sign
	WHERE [TestRunId] = @TestRunId

GO
