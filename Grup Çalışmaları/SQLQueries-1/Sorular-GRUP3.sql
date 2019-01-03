--1-kimseye rapor vermeyen çalýsanlarýn satýþ yaptýðý müþterilerin ülkeleri ve o ülkeye kaç adet satýþ yaptýðýný listele
SELECT Country, COUNT(*) FROM Customers INNER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
WHERE Orders.EmployeeID IN (SELECT EmployeeID FROM Employees WHERE ReportsTo IS NULL)
GROUP BY Country

--2-Products tablosunda Unit Price larý ortalamanýn üzerinde olan ürün adlarý nelerdir ve hangi ülkelere satýlmýþtýr?
SELECT P.ProductName, C.Country FROM Products P INNER JOIN [Order Details] od on P.ProductID=od.ProductID
INNER JOIN Orders O ON od.OrderID=O.OrderID
INNER JOIN Customers C ON O.CustomerID=C.CustomerID
WHERE od.UnitPrice > (SELECT AVG([Order Details].UnitPrice) FROM [Order Details])
GROUP BY C.Country,P.ProductName


--3- Herhangi bir kategoride en çok satýþ yapan 5 firma
select top 5 s.CompanyName, SUM(od.Quantity) as adet,sum(od.Quantity*od.UnitPrice) as gelir,c.CategoryName
from Suppliers s 
	inner join Products p 
	on s.SupplierID=p.SupplierID
	inner join [Order Details] od 
	on p.ProductID=od.ProductID 
	inner join Categories c 
	on p.CategoryID=c.CategoryID  
	group by  c.CategoryName,s.CompanyName 
order by SUM(od.Quantity) desc


 --4 OrderDate ve RequiredDate arasý 30 günden fazla olanlarýn kategorisi ve adeti 
 SELECT C.CategoryName , Count(*) AS Amount FROM Orders O
 JOIN [Order Details] OD ON OD.OrderID=O.OrderID
 JOIN Products P ON P.ProductID = OD.ProductID
 JOIN Categories C ON P.CategoryID = C.CategoryID

 WHERE DATEDIFF(day, OrderDate,RequiredDate)>30
 GROUP BY C.CategoryName


 --5 ORDER DATE 1996.08.01 ile 1997.01.01 arasýndaki SHIPCITY Madrid olan kayýtlarýn COMPANYNAME bul.

select CompanyName,OrderDate, ShipCity from Orders inner join Customers 
on Orders.CustomerID=Customers.CustomerID where ShipCity='Madrid' and 
OrderDate between '1996.08.01' and '1997.01.01'


 
