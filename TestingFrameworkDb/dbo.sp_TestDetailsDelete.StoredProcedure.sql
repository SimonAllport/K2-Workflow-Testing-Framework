
GO
/****** Object:  StoredProcedure [dbo].[sp_TestDetailsDelete]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_TestDetailsDelete]
	@id int
AS
SET NOCOUNT ON

DELETE FROM TestDetails
WHERE [id] = @id

SET NOCOUNT OFF


GO
