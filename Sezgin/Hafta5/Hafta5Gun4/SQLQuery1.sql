USE Northwind
CREATE TABLE Kisi1(
ID int,
Ad varchar(20),
Soyad varchar(20)
)

INSERT INTO Kisi1 VALUES(1, 'Sabri', 'KUNT'), (2, 'Ahmet', 'TANRIVERDI'),
		(3, 'Ihsan', 'OLMEZ'), (4, 'Ali', 'RUZGAR'), (5, 'Mesut', 'ATESER')

CREATE TABLE Kisi2(
ID int,
Ad varchar(20),
Soyad varchar(20)
)

INSERT INTO Kisi2 VALUES(1, 'Sabri', 'KUNT'), (2, 'Ahmet', 'TANRIVERDI'), 
		(3,'Metin', 'TOSUN'), (4, 'Ali', 'AYDOGAN'), (5, 'Ali', 'KALFA')

SELECT * FROM Kisi1 UNION ALL SELECT * FROM Kisi2

--Eastern Region'�na kay�tl� olan t�m Employee listesini getir.
SELECT Employees.FirstName + ' ' + Employees.LastName as Name 
FROM Employees INNER JOIN (SELECT DISTINCT EmployeeTerritories.EmployeeID FROM EmployeeTerritories INNER JOIN 
									(SELECT Territories.TerritoryID FROM Territories 
										INNER JOIN Region ON Region.RegionID = Territories.RegionID WHERE Region.RegionDescription = 'Eastern') t 
											ON t.TerritoryID = EmployeeTerritories.TerritoryID) et
						  ON et.EmployeeID = Employees.EmployeeID

--�irket adlar�n� ve yapm�� olduklar� toplam �ipari�leri listele, toplam sipari�e g�re desc s�rala
SELECT DISTINCT Customers.CompanyName, a.TotalOrder FROM Customers 
INNER JOIN (SELECT Orders.CustomerID, COUNT(Orders.CustomerID) as TotalOrder FROM Orders GROUP BY Orders.CustomerID) a
ON Customers.CustomerID = a.CustomerID ORDER BY a.TotalOrder DESC

--Hangi �irket Hangi �r�n� ne kadar ald�
SELECT Customers.CompanyName, q2.OrderDate, q2.ProductName, q2.TotalOrder FROM Customers
INNER JOIN(SELECT Orders.CustomerID, Orders.OrderDate, q1.ProductName, q1.TotalOrder FROM Orders 
				INNER JOIN (SELECT ProductName, o.OrderID, o.TotalOrder FROM Products 
							INNER JOIN (SELECT [Order Details].OrderID, [Order Details].ProductID, SUM([Order Details].Quantity) as TotalOrder 
							FROM [Order Details] INNER JOIN Products ON Products.ProductID = [Order Details].ProductID GROUP BY [Order Details].ProductID, [Order Details].OrderID) as o
							ON o.ProductID = Products.ProductID) q1 
				ON q1.OrderID = Orders.OrderID) q2
ON q2.CustomerID = Customers.CustomerID 
ORDER BY q2.ProductName, q2.TotalOrder DESC

--En �ok sat��� yapan 3 Employee'nin primini 200 yap ve bast�r
SELECT TOP 3 Employees.FirstName + ' ' + Employees.LastName as Name, q2.EmployeeTotal, 200.00 as Prim FROM Employees
INNER JOIN (SELECT Orders.EmployeeID, SUM(q1.OrderTotalPrice) as EmployeeTotal FROM Orders 
			INNER JOIN (SELECT OrderID, SUM([Order Details].Quantity * [Order Details].UnitPrice) as OrderTotalPrice FROM [Order Details] GROUP BY [Order Details].OrderID) q1
			ON q1.OrderID = Orders.OrderID
			GROUP BY Orders.EmployeeID) q2
ON q2.EmployeeID = Employees.EmployeeID
ORDER BY q2.EmployeeTotal DESC

--Hangi b�lgede hangi �r�n category'e g�re en �ok sat�lm��t�r. En �ok sat�� yapan category
SELECT Territories.TerritoryDescription, q2.CategoryName, q2.ProductName, SUM(q1.Price) as Total FROM Territories
INNER JOIN EmployeeTerritories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID
INNER JOIN Employees ON EmployeeTerritories.EmployeeID = Employees.EmployeeID
INNER JOIN Orders ON Orders.EmployeeID = Employees.EmployeeID
INNER JOIN (SELECT [Order Details].Quantity * [Order Details].UnitPrice as Price, [Order Details].OrderID, [Order Details].ProductID FROM [Order Details]) q1 ON q1.OrderID = Orders.OrderID
INNER JOIN (SELECT Categories.CategoryName, Products.ProductName, Products.ProductID FROM Categories INNER JOIN Products ON Products.CategoryID = Categories.CategoryID) q2
	ON q2.ProductID = q1.ProductID
GROUP BY Territories.TerritoryDescription, q2.CategoryName, q2.ProductName
ORDER BY Territories.TerritoryDescription, Total DESC

SELECT Employees.EmployeeID, q2.TerritoryDescription FROM Employees
INNER JOIN (SELECT Territories.TerritoryDescription, EmployeeTerritories.EmployeeID FROM EmployeeTerritories 
			INNER JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID) q2
ON Employees.EmployeeID = q2.EmployeeID

SELECT Orders.OrderID FROM Orders
INNER JOIN (SELECT Employees.EmployeeID, q2.TerritoryDescription FROM Employees
			INNER JOIN (SELECT Territories.TerritoryDescription, EmployeeTerritories.EmployeeID FROM EmployeeTerritories 
					INNER JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID) q2
			ON Employees.EmployeeID = q2.EmployeeID) q3
ON q3.EmployeeID = Orders.EmployeeID

SELECT Territories.TerritoryDescription, q2.CategoryName, q2.ProductName, SUM(q1.Price) as Total FROM Territories
INNER JOIN EmployeeTerritories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID
INNER JOIN Employees ON EmployeeTerritories.EmployeeID = Employees.EmployeeID
INNER JOIN Orders ON Orders.EmployeeID = Employees.EmployeeID
INNER JOIN (SELECT [Order Details].Quantity * [Order Details].UnitPrice as Price, [Order Details].OrderID, [Order Details].ProductID FROM [Order Details]) q1 ON q1.OrderID = Orders.OrderID
INNER JOIN (SELECT Categories.CategoryName, Products.ProductName, Products.ProductID FROM Categories INNER JOIN Products ON Products.CategoryID = Categories.CategoryID) q2
	ON q2.ProductID = q1.ProductID
GROUP BY Territories.TerritoryDescription, q2.CategoryName, q2.ProductName
ORDER BY Territories.TerritoryDescription, Total DESC

SELECT Products.CategoryID FROM Products 
INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
GROUP BY Products.CategoryID

SELECT Categories.CategoryName, COUNT(Categories.CategoryName) as Total FROM Categories
INNER JOIN (SELECT Products.CategoryID, Products.ProductName FROM Products 
			INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID) q1
ON q1.CategoryID = Categories.CategoryID
GROUP BY Categories.CategoryName