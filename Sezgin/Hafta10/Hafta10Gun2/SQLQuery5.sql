USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[listProducts]    Script Date: 29.01.2019 13:24:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[listProducts]
	-- Add the parameters for the stored procedure here
AS
BEGIN

SET NOCOUNT ON
		SELECT* FROM Products;

END