
GO
/****** Object:  StoredProcedure [dbo].[sp_TestPlanActualParameters]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[sp_TestPlanActualParameters]
@TestRunId int,
@Parameters nvarchar(200)

as

update testrun set ParameterArray = @Parameters
where TestRunId = @TestRunId
GO
