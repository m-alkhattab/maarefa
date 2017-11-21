USE [MAAREF]
GO

/****** Object:  StoredProcedure [dbo].[spInsertObject]    Script Date: 11/21/2017 10:59:35 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertObject] 
@OBJECTNAMEAR VARCHAR(50),
@OBJECTCOMMAND VARCHAR(100),
@OBJECTTYPE SMALLINT,
@PARNTOBJECT BIGINT,
@SHOWTOOLBAR SMALLINT,
@MENUICON VARCHAR(100),
@TOOLBARICON VARCHAR(100),
@CREATEUSER BIGINT,
@CREATEPC VARCHAR(20),
@CREATETIMESTAMP DATETIME,
@TRANSSTATUS SMALLINT,
@RECORDSTATUS SMALLINT
AS
BEGIN
    -- Insert statements for procedure here
	insert into dbo.OBJECTS ([OBJECT_NAME_AR]
      ,[OBJECT_COMMAND]
      ,[OBJECT_TYPE]
      ,[PARNT_OBJECT]
      ,[SHOWTOOLBAR]
      ,[MENU_ICON]
      ,[TOOLBAR_ICON]
      ,[CREATE_USER]
      ,[CREATE_PC]
      ,[CREATE_TIMESTAMP]
      ,[TRANS_STATUS]
      ,[RECORD_STATUS])
	  values (@OBJECTNAMEAR ,
@OBJECTCOMMAND ,
@OBJECTTYPE ,
@PARNTOBJECT ,
@SHOWTOOLBAR ,
@MENUICON ,
@TOOLBARICON ,
@CREATEUSER ,
@CREATEPC ,
@CREATETIMESTAMP  ,
@TRANSSTATUS ,
@RECORDSTATUS )
END


GO

