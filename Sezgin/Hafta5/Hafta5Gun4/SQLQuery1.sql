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

SELECT * FROM Kisi1