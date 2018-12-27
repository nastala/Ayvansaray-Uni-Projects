--Soru 1
SELECT Products.ProductName, Categories.CategoryName FROM Products
INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID

--Soru2
SELECT Products.ProductName, Customers.CompanyName FROM Customers
INNER JOIN Orders ON Orders.CustomerID = Customers.CustomerID
INNER JOIN [Order Details] ON [Order Details].OrderID = Orders.OrderID
INNER JOIN Products ON Products.ProductID = [Order Details].ProductID

--Soru 3
SELECT Employees.FirstName + ' ' + Employees.LastName as Name, q1.TotalSales, Orders.OrderDate FROM Employees
INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
INNER JOIN (SELECT [Order Details].OrderID, COUNT([Order Details].OrderID) as TotalSales FROM [Order Details] GROUP BY [Order Details].OrderID) q1 ON q1.OrderID = Orders.OrderID

--Soru 4
SELECT Products.ProductName, Categories.CategoryName FROM Products
RIGHT JOIN Categories ON Categories.CategoryID = Products.ProductID

--Soru 5
SELECT Customers.ContactName, Orders.OrderDate FROM Customers
INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID

--Soru 6
SELECT Products.ProductName, Categories.CategoryName FROM Products
LEFT JOIN Categories ON Categories.CategoryID = Products.ProductID

--Soru 7
SELECT DISTINCT Employees.FirstName as 'Rapor Veren', q1.Name as 'Rapor Verilen' FROM Employees
LEFT JOIN (SELECT Employees.FirstName + ' ' + Employees.LastName as Name, Employees.EmployeeID FROM Employees WHERE Employees.EmployeeID IN 
										(SELECT Employees.ReportsTo FROM Employees )) q1
ON q1.EmployeeID = Employees.ReportsTo

--Soru 8
