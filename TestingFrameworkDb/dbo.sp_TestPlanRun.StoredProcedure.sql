
GO
/****** Object:  StoredProcedure [dbo].[sp_TestPlanRun]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_TestPlanRun]

@TestId int

as

select 

		[TestId], 
	[TestType], 
	[ExpectedResult], 
	Pass,
	ActualResult,
	[LeftParameter], 
	[MiddleParameter], 
	[RightParameter],
	[Milliseconds],
	[Parameters],
	[Sign]
		from TestRun 
		where testid = @testid


GO
