USE [Northwind]
GO

/****** Object:  Table [dbo].[ProductsX]    Script Date: 15.01.2019 13:53:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[ProductsX]

CREATE TABLE [dbo].[ProductsX](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[SupplierID] [int] NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [nvarchar](20) NULL,
	[UnitPrice] [money] NULL CONSTRAINT [DF_ProductsX_UnitPrice]  DEFAULT ((0)),
	[UnitsInStock] [smallint] NULL CONSTRAINT [DF_ProductsX_UnitsInStock]  DEFAULT ((0)),
	[UnitsOnOrder] [smallint] NULL CONSTRAINT [DF_ProductsX_UnitsOnOrder]  DEFAULT ((0)),
	[ReorderLevel] [smallint] NULL CONSTRAINT [DF_ProductsX_ReorderLevel]  DEFAULT ((0)),
	[Discontinued] [bit] NOT NULL CONSTRAINT [DF_ProductsX_Discontinued]  DEFAULT ((0)),
 CONSTRAINT [PK_ProductsX] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[ProductsX]  WITH NOCHECK ADD  CONSTRAINT [FK_ProductsX_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO

ALTER TABLE [dbo].[ProductsX] CHECK CONSTRAINT [FK_ProductsX_Categories]
GO

ALTER TABLE [dbo].[ProductsX]  WITH NOCHECK ADD  CONSTRAINT [FK_ProductsX_Suppliers] FOREIGN KEY([SupplierID])
REFERENCES [dbo].[Suppliers] ([SupplierID])
GO

ALTER TABLE [dbo].[ProductsX] CHECK CONSTRAINT [FK_ProductsX_Suppliers]
GO

ALTER TABLE [dbo].[ProductsX]  WITH NOCHECK ADD  CONSTRAINT [CK_ProductsX_UnitPrice] CHECK  (([UnitPrice]>=(0)))
GO

ALTER TABLE [dbo].[ProductsX] CHECK CONSTRAINT [CK_ProductsX_UnitPrice]
GO

ALTER TABLE [dbo].[ProductsX]  WITH NOCHECK ADD  CONSTRAINT [CK_ReorderLevel_X] CHECK  (([ReorderLevel]>=(0)))
GO

ALTER TABLE [dbo].[ProductsX] CHECK CONSTRAINT [CK_ReorderLevel_X]
GO

ALTER TABLE [dbo].[ProductsX]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsInStock_X] CHECK  (([UnitsInStock]>=(0)))
GO

ALTER TABLE [dbo].[ProductsX] CHECK CONSTRAINT [CK_UnitsInStock_X]
GO

ALTER TABLE [dbo].[ProductsX]  WITH NOCHECK ADD  CONSTRAINT [CK_UnitsOnOrder_X] CHECK  (([UnitsOnOrder]>=(0)))
GO

ALTER TABLE [dbo].[ProductsX] CHECK CONSTRAINT [CK_UnitsOnOrder_X]
GO


