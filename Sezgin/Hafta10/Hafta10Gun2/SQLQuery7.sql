USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[insertCategory]    Script Date: 29.01.2019 14:23:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[insertCategory]
	-- Add the parameters for the stored procedure here
	@catname nvarchar(15),
	@catDesc ntext
AS
BEGIN

--SET NOCOUNT ON
		INSERT INTO Categories (CategoryName,Description) VALUES (@catname,@catDesc)

END