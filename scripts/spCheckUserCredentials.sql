USE [MAAREF]
GO

/****** Object:  StoredProcedure [dbo].[spCheckUserCredentials]    Script Date: 13/11/2017 1:30:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spCheckUserCredentials]
@UserName nvarchar(100),
@Password nvarchar(100),
@BranchID int
As
select *
from USERS
where USER_NAME=@UserName
and PASSWORD=@Password
and BranchID=@BranchID
GO


