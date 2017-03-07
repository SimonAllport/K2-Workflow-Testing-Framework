
GO
/****** Object:  StoredProcedure [dbo].[sp_TestProcessFinish]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_TestProcessFinish]

	@id int,
	@Finished bit,
	@FinishedDate datetime


as

	UPDATE TestDetails SET 
	
		[Finished] = @Finished,
		[FinishedDate] = @FinishedDate
		
	WHERE [id] = @id
GO
