
GO
/****** Object:  StoredProcedure [dbo].[sp_TestProcessUpdateStatus]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_TestProcessUpdateStatus]

	@id int,
	@Status nvarchar(50)


as

	UPDATE TestDetails SET 
	
		[status] = @status
	WHERE [id] = @id
GO
