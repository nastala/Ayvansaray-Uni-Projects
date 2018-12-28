CREATE TABLE booksales (
  country VARCHAR(35), 
  genre varchar(20) NOT NULL CHECK (genre IN('fiction', 'non-fiction')), 
  year DATE, 
  sales INT
)

INSERT INTO booksales VALUES
  ('Senegal','fiction','2014',12234), ('Senegal','fiction','2015',15647),
  ('Senegal','non-fiction','2014',64980), ('Senegal','non-fiction','2015',78901),
  ('Paraguay','fiction','2014',87970), ('Paraguay','fiction','2015',76940),
  ('Paraguay','non-fiction','2014',8760), ('Paraguay','non-fiction','2015',9030)

SELECT booksales.year, SUM(booksales.sales) as total FROM booksales GROUP BY booksales.year WITH ROLLUP

SELECT country, year, genre, SUM(sales) FROM booksales GROUP BY country, year, genre WITH ROLLUP

SELECT s.CompanyName, Products.ProductName, SUM(Products.UnitsInStock) as 'Units-In-Stock' FROM Products 
INNER JOIN (SELECT Suppliers.CompanyName, Suppliers.SupplierID FROM Suppliers WHERE Suppliers.Country = 'Germany') s
ON s.SupplierID = Products.SupplierID
GROUP BY s.CompanyName, Products.ProductName
ORDER BY 'Units-In-Stock' DESC

SELECT Customers.CustomerID, SUM(od.OrderTotal) as CustomerTotal FROM Orders
INNER JOIN (SELECT [Order Details].OrderID, Sum([Order Details].Quantity * [Order Details].UnitPrice) as OrderTotal FROM [Order Details]
				GROUP BY [Order Details].OrderID) od
ON od.OrderID = Orders.OrderID
INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
WHERE  Orders.OrderDate BETWEEN '1997' AND '1998'
GROUP BY Customers.CustomerID
HAVING SUM(od.OrderTotal) > 40000
ORDER BY CustomerTotal DESC

SELECT O.ShipCountry AS 'Ulke', O.ShipCity AS 'Sehir', COUNT(OO.Quantity) AS 'Siparis Kalem Sayisi', COUNT(O.OrderID) as 'Siparis Gecme Sayisi'
FROM Orders O INNER JOIN [Order Details] OO ON O.OrderID = OO.OrderID
GROUP BY O.ShipCountry, O.ShipCity
WITH ROLLUP

--Soru: Kaç kere sipariþ verildi, kaç tane sipariþ kalemi var?
--WAY-1
SELECT O.ShipCountry AS 'Ulke', O.ShipCity AS 'Sehir', COUNT(OO.Quantity) AS 'Siparis Kalem Sayisi', OOO.OrderCount as 'Siparis Gecme Sayisi'
FROM Orders O 
INNER JOIN (SELECT Orders.ShipCountry, Orders.ShipCity, COUNT(Orders.OrderID) as OrderCount FROM Orders 
					GROUP BY Orders.ShipCity, Orders.ShipCountry) OOO ON OOO.ShipCountry = O.ShipCountry AND OOO.ShipCity = O.ShipCity
INNER JOIN [Order Details] OO ON O.OrderID = OO.OrderID
GROUP BY O.ShipCountry, O.ShipCity, OOO.OrderCount
--WAY-2
SELECT O.ShipCountry AS 'Ulke', O.ShipCity AS 'Sehir', COUNT(OO.Quantity) AS 'Siparis Kalem Sayisi', 
	(
		SELECT COUNT(Orders.OrderID) FROM Orders 
					WHERE Orders.ShipCity = O.ShipCity AND Orders.ShipCountry = O.ShipCountry
					GROUP BY Orders.ShipCity, Orders.ShipCountry
	) as 'Siparis Gecme Sayisi'
FROM Orders O 
INNER JOIN [Order Details] OO ON O.OrderID = OO.OrderID
GROUP BY O.ShipCountry, O.ShipCity
ORDER BY O.ShipCountry, O.ShipCity

CREATE PROCEDURE procOrderListWithMaxUnitPrice
AS
SELECT O.OrderID, C.CompanyName, CONVERT(VARCHAR, O.OrderDate, 103) AS OrderDate,
	(
		SELECT MAX(OO.UnitPrice) FROM [Order Details] OO WHERE O.OrderID = OO.OrderID
	) AS MaxUnitPrice
FROM Orders O INNER JOIN CUstomers C ON O.CustomerID = C.CustomerID

EXEC procOrderListWithMaxUnitPrice

CREATE PROCEDURE procOrderListWithMaxUnitPrice2
AS
SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate, MAX([Order Details].UnitPrice)
FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
GROUP BY Orders.OrderID, Customers.CompanyName, Orders.OrderDate
ORDER BY Orders.OrderID, Customers.CompanyName

EXEC procOrderListWithMaxUnitPrice2

SELECT Products.ProductName, ShipCountry, COUNT(*) as OrderCount FROM Products
INNER JOIN [Order Details] ON [Order Details].ProductID = Products.ProductID
INNER JOIN Orders ON Orders.OrderID = [Order Details].OrderID
WHERE Products.ProductName = 'Chai'
GROUP BY Products.ProductName, Orders.ShipCountry
HAVING COUNT(*) > 2
ORDER BY OrderCount DESC


