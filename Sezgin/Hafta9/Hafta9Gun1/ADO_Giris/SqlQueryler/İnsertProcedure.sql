-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
USE [Northwind]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================


CREATE PROCEDURE [dbo].[AddProduct] 
	-- Add the parameters for the stored procedure here
   @ProductName  nvarchar(50),
   @UnitPrice money,
   @UnitsInStock smallint

AS
DECLARE @trimli nvarchar(50) = ltrim(rtrim(@ProductName))
BEGIN
if(exists (select * from Products Where ProductName=@trimli))
print 'Bu Üründen Zaten Eklidir'
else
 insert into Products(ProductName,UnitPrice,UnitsInStock) VALUES(@ProductName, @UnitPrice, @UnitsInStock)
end 
go

