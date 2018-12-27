--Soru 1
USE [Northwind]
SELECT * FROM [Categories]
WHERE [Categories].[CategoryID] = 2

--Soru 2
USE [Northwind]
SELECT [Employees].[FirstName], [Employees].[LastName]
FROM [Employees] WHERE [Employees].[City] = 'London'
ORDER BY [Employees].[FirstName]

--Soru 3
USE [Northwind]
SELECT * FROM [Products]
WHERE [Products].[UnitPrice] BETWEEN 50 AND 80

--Soru 4
USE [Northwind]
SELECT [Customers].[CompanyName], [Customers].[City], [Customers].[Address], [Customers].[Country]
FROM [Customers] WHERE [Customers].[CompanyName] LIKE 'a%'

--Soru 5
USE [Northwind]
SELECT [Customers].[CompanyName], [Customers].[Address], [Customers].[City], [Customers].[Country]
FROM [Customers] WHERE [Customers].[Fax] IS NULL

--Soru 6
USE [Northwind]
SELECT * FROM [Customers]
WHERE [Customers].[CompanyName] LIKE 'a%' AND [Customers].[Country] = 'Germany'

--Soru 7
USE [Northwind]
SELECT * FROM [Customers]
WHERE [Customers].[CompanyName] NOT LIKE '%a'

--Soru 8
USE [Northwind]
SELECT TOP 5 [Products].[UnitPrice]
FROM [Products] ORDER BY [Products].[UnitPrice] DESC

--Soru 9
USE [Northwind]
SELECT DISTINCT([Customers].[CompanyName])
FROM [Customers] WHERE [Customers].[CompanyName] LIKE '%restaurant%'

--Soru 10
USE [Northwind]
SELECT [Orders].[OrderID], [Orders].[OrderDate]
FROM [Orders] WHERE [Orders].[OrderDate] BETWEEN '1996-07-04' AND '1996-12-31'

--Soru 11
USE [Northwind]
SELECT * FROM [Categories]
WHERE [Categories].[Description] LIKE 's%' OR [Categories].[Description] LIKE 'd%'

--Soru 12
USE [Northwind]
SELECT DISTINCT([Customers].[Country]) FROM [Customers]

--Soru 13
USE [Northwind]
SELECT [Products].[ProductName], [Products].[UnitPrice], '%18' as Tax
FROM [Products]

--Soru 14
USE [Northwind]
SELECT [Products].[ProductName], [Products].[UnitPrice]
FROM [Products] WHERE [Products].[CategoryID] IN (5, 9, 10) 

--Soru 15
USE [Northwind]
SELECT * FROM [Customers]
WHERE [Customers].[Country] = 'Germany' OR [Customers].[Country] = 'Sweden' 
OR [Customers].[Country] = 'UK' OR [Customers].[Country] = 'USA'

--Soru 16
USE [Northwind]
SELECT * FROM [Categories]
WHERE [Categories].[Description] LIKE '%p%t%' OR [Categories].[Description] LIKE '%t%p%' 

--Soru 17
USE [Northwind]
SELECT [Employees].[FirstName], [Employees].[LastName]
FROM [Employees] WHERE [Employees].[FirstName] LIKE '__n%'

--Soru 18
USE[Northwind]
SELECT ([Employees].[FirstName] + ' ' + [Employees].[LastName]) as Çalýþan, [PlakaKodlari].[PlakaKodu] 
FROM PlakaKodlari INNER JOIN Employees ON PlakaKodlari.Sehir = Employees.City

--Soru 19
USE Northwind
SELECT [Order Details].UnitPrice, [Order Details].Quantity FROM Orders INNER JOIN [Order Details] ON [Order Details].OrderID = Orders.OrderID
ORDER BY [Order Details].UnitPrice DESC, [Order Details].Quantity 

--Soru 20
USE Northwind
SELECT Customers.ContactName, Orders.OrderDate
FROM Customers INNER JOIN Orders ON Orders.CustomerID = Customers.CustomerID
WHERE Orders.OrderDate > '1998-01-01'

--Soru 21
USE Northwind
SELECT * FROM Products INNER JOIN Categories ON Categories.CategoryID = Products.ProductID
WHERE Categories.CategoryName = 'Beverages' AND Products.UnitsInStock > 0

--Soru 22
USE Northwind
SELECT Employees.EmployeeID, Employees.LastName, Employees.Title
FROM Employees 
WHERE Employees.Title IN (SELECT Employees.Title FROM Employees GROUP BY Employees.Title
									HAVING COUNT(*) > 1)
ORDER BY EmployeeID

--Soru 23
