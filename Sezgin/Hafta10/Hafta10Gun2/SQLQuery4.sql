USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[listCategories]    Script Date: 29.01.2019 10:55:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[listCategories]
	-- Add the parameters for the stored procedure here
AS
BEGIN

SET NOCOUNT ON
		SELECT* FROM Categories;

END