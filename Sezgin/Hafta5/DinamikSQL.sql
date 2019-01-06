------Dinamik SQL �al��t�rmak (Execute())
declare @sorgu varchar(3000), @tablo varchar(20) --de�i�kenleri tan�ml�yoruz.
--De�i�kenleri de�er at�yoruz
set @tablo='Customers'
set @sorgu= 'Select * from ' + @tablo
--Execute ile �al��t�r�yoruz.
Exec(@sorgu)

--Store procedure ile exec() olu�turma
create proc Sorgular (
@sorgu varchar(3000)
)
as
exec(@sorgu)
--Store Procedure u �al��t�rmak i�in
exec Sorgular 'select * from Customers'

--London da bulunan ve m��terilerin ID si ContactName i ve City bilgilerini listeleyelim:
DECLARE @sqlCommand varchar(1000)
DECLARE @columnList varchar(75)
DECLARE @city varchar(75)
SET @columnList = 'CustomerID, ContactName, City'
SET @city = '''London'''
SET @sqlCommand = 'SELECT ' + @columnList + ' FROM customers WHERE City = ' + @city
EXEC (@sqlCommand)

----Dinamik SQL Sorgular� (sp_executesql)
--Northwind tablosunda ad� Nancy olan �al��an�n bilgilerine ula�abilmek i�in:
declare @sql nvarchar(300), @ad varchar(20), @params nvarchar(30)
set @ad='Nancy'
set @sql='select * from Employees where FirstName='''+ @ad + ''''
set @params=N'@ad varchar(20)'

execute sp_executesql @sql, @params, @ad=@ad


--London da bulunan ve m��terilerin ID si ContactName i ve City bilgilerini listeleyelim:
DECLARE @sqlCommand nvarchar(1000)
DECLARE @columnList varchar(75)
DECLARE @city varchar(75)
SET @columnList = 'CustomerID, ContactName, City'
SET @city = 'London'
SET @sqlCommand = 'SELECT ' + @columnList + ' FROM customers WHERE City = @city'
EXECUTE sp_executesql @sqlCommand, N'@city nvarchar(75)', @city = @city