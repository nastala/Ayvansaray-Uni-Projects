USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[listSuppliers]    Script Date: 29.01.2019 14:49:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[listSuppliers]
	-- Add the parameters for the stored procedure here
AS
BEGIN

SET NOCOUNT ON
		SELECT* FROM Suppliers;

END