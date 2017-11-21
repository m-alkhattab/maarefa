USE [MAAREF]
GO

/****** Object:  StoredProcedure [dbo].[spGetObjects]    Script Date: 11/21/2017 10:59:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spGetObjects] 
	
AS
BEGIN
    -- Insert statements for procedure here
	SELECT [OBJECT_ID]
      ,[OBJECT_NAME_AR]
      ,[OBJECT_NAME_EN]
      ,[OBJECT_COMMAND]
      ,[OBJECT_TYPE]
      ,[PARNT_OBJECT]
      ,[SHOWTOOLBAR]
      ,[MENU_ICON]
      ,[TOOLBAR_ICON]
  FROM [MAAREF].[dbo].[OBJECTS]  
END

GO

