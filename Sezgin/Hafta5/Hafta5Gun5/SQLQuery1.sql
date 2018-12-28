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


