
GO
/****** Object:  StoredProcedure [dbo].[sp_AddTestRoute]    Script Date: 07/03/2017 16:40:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddTestRoute]
@Route nvarchar(500),
@Id int

as

update TestDetails set [Route] = @Route
where id = @Id


GO
