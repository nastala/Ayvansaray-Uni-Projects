-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Alter PROCEDURE [dbo].[DeleteProduct]
 	-- Add the parameters for the stored procedure here
 @ProductID  int
AS
DECLARE @trimli nvarchar(50) = ltrim(rtrim(@ProductID))
BEGIN
 Delete from Products where ProductID=@ProductID
end 
go
