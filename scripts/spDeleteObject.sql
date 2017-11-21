USE [MAAREF]
GO

/****** Object:  StoredProcedure [dbo].[spDeleteObject]    Script Date: 11/21/2017 10:58:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spDeleteObject] 
@OBJECTID bigint

AS
BEGIN
    -- Insert statements for procedure here
	delete from  dbo.OBJECTS 
	where [OBJECT_ID] = @OBJECTID
	   
END




GO

