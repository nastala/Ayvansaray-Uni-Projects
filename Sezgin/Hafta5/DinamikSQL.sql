------Dinamik SQL Çalýþtýrmak (Execute())
declare @sorgu varchar(3000), @tablo varchar(20) --deðiþkenleri tanýmlýyoruz.
--Deðiþkenleri deðer atýyoruz
set @tablo='Customers'
set @sorgu= 'Select * from ' + @tablo
--Execute ile çalýþtýrýyoruz.
Exec(@sorgu)

--Store procedure ile exec() oluþturma
create proc Sorgular (
@sorgu varchar(3000)
)
as
exec(@sorgu)
--Store Procedure u çalýþtýrmak için
exec Sorgular 'select * from Customers'

--London da bulunan ve müþterilerin ID si ContactName i ve City bilgilerini listeleyelim:
DECLARE @sqlCommand varchar(1000)
DECLARE @columnList varchar(75)
DECLARE @city varchar(75)
SET @columnList = 'CustomerID, ContactName, City'
SET @city = '''London'''
SET @sqlCommand = 'SELECT ' + @columnList + ' FROM customers WHERE City = ' + @city
EXEC (@sqlCommand)

----Dinamik SQL Sorgularý (sp_executesql)
--Northwind tablosunda adý Nancy olan çalýþanýn bilgilerine ulaþabilmek için:
declare @sql nvarchar(300), @ad varchar(20), @params nvarchar(30)
set @ad='Nancy'
set @sql='select * from Employees where FirstName='''+ @ad + ''''
set @params=N'@ad varchar(20)'

execute sp_executesql @sql, @params, @ad=@ad


--London da bulunan ve müþterilerin ID si ContactName i ve City bilgilerini listeleyelim:
DECLARE @sqlCommand nvarchar(1000)
DECLARE @columnList varchar(75)
DECLARE @city varchar(75)
SET @columnList = 'CustomerID, ContactName, City'
SET @city = 'London'
SET @sqlCommand = 'SELECT ' + @columnList + ' FROM customers WHERE City = @city'
EXECUTE sp_executesql @sqlCommand, N'@city nvarchar(75)', @city = @city