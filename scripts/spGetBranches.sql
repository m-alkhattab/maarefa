USE [MAAREF]
GO

/****** Object:  StoredProcedure [dbo].[spGetBranches]    Script Date: 13/11/2017 1:31:21 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[spGetBranches]
as
select *
from Branches
GO


