USE [Northwind]
GO
/****** Object:  Trigger [dbo].[DeleteProducts]    Script Date: 23.01.2019 10:00:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create TRIGGER  [dbo].[DeleteProducts]
ON  [dbo].[Products]
INSTEAD OF DELETE 
AS
BEGIN 
UPDATE Products SET Discontinued=1 WHERE ProductID in (SELECT ProductID From Deleted)

 END
