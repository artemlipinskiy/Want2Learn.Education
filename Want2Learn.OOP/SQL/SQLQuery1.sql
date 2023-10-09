CREATE TABLE Owner (
  Id INT PRIMARY KEY,
  Fullname VARCHAR(50) NOT NULL
);

CREATE TABLE City (
  Id INT PRIMARY KEY,
  Name VARCHAR(50) NOT NULL,
  Population INT NOT NULL
);

CREATE TABLE Street (
  Id INT PRIMARY KEY,
  Name VARCHAR(50) NOT NULL,
  CityId INT NOT NULL,
  FOREIGN KEY (CityId) REFERENCES City(Id)
);

CREATE TABLE Building (
  Id INT PRIMARY KEY,
  StreetId INT NOT NULL,
  Number INT NOT NULL,
  AdditionalName VARCHAR(50),
  FOREIGN KEY (StreetId) REFERENCES Street(Id)
);

CREATE TABLE Flat (
  Id INT PRIMARY KEY,
  BuildingId INT NOT NULL,
  Number INT NOT NULL,
  AdditionalName VARCHAR(50),
  FOREIGN KEY (BuildingId) REFERENCES Building(Id)
);

CREATE TABLE OwnerFlat (
  OwnerId INT NOT NULL,
  FlatId INT NOT NULL,
  PurchaseDate DATE NOT NULL,
  FOREIGN KEY (OwnerId) REFERENCES Owner(Id),
  FOREIGN KEY (FlatId) REFERENCES Flat(Id),
  PRIMARY KEY (OwnerId, FlatId)
);

/****** Select  ******/
SELECT * FROM City

SELECT Id, Name, Population
FROM City
WHERE Id > 3 AND Population > 1176187

SELECT Id AS #, Name AS CityName, Population AS CityPopulation
FROM City
WHERE Id > 3 AND Name = 'Казань'

SELECT Id AS #, Name AS CityName, Population AS CityPopulation
FROM City
WHERE Id > 3 AND Name LIKE '%а%а%'

SELECT * FROM City
WHERE Id > 2
ORDER BY Population DESC


SELECT TOP (1) * FROM City
WHERE Id > 2
ORDER BY Population DESC

SELECT 
	SUM(Population) AS PopulationSum,
	MIN(Population) AS MinPopulation,
	MAX(Population) AS MaxPopulation,
	COUNT(*) AS CityCount,
	AVG(Population) AS AvgPopulation
FROM City
WHERE Name LIKE '%а%'

SELECT Flat.Id AS FlatId,
	Flat.BuildingId AS BuildingId,
	Flat.Number AS Flat#,
	Flat.AdditionalName AS FlatAdditionalName,
	Building.Number AS Building#,
	Building.AdditionalName AS BuildingAdditionalName
FROM Flat
JOIN Building ON Flat.BuildingId = Building.Id

  
SELECT *
FROM Flat
INNER JOIN OwnerFlat ON Flat.Id = OwnerFlat.FlatId
INNER JOIN Owner ON OwnerFlat.OwnerId = Owner.Id;

SELECT *
FROM Flat
LEFT JOIN OwnerFlat ON Flat.Id = OwnerFlat.FlatId
LEFT JOIN Owner ON OwnerFlat.OwnerId = Owner.Id;

SELECT *
FROM Flat
RIGHT JOIN OwnerFlat ON Flat.Id = OwnerFlat.FlatId
RIGHT JOIN Owner ON OwnerFlat.OwnerId = Owner.Id;

SELECT *
FROM Flat, Owner


SELECT 
	s.Name,
	b.Number,
	COUNT(*) AS TotalFlats
FROM Flat AS f
JOIN Building AS b ON b.Id = f.BuildingId 
JOIN Street AS s ON s.Id = b.StreetId
GROUP BY s.Name, b.Number

SELECT 
	s.Name AS StreetName,
	b.Number AS BuildingNumber,
	COUNT(*) AS TotalFlats
FROM Flat AS f
JOIN Building AS b ON b.Id = f.BuildingId 
JOIN Street AS s ON s.Id = b.StreetId
GROUP BY s.Name, b.Number;

UPDATE [dbo].[City]
   SET [Name] = 'Kazan'   
 WHERE Name = 'Казань'

DELETE FROM [dbo].[City]
      WHERE Id = 16

DECLARE @SomeId INT;
SET @SomeId = 5;

SELECT * FROM FLAT WHERE Id = @SomeId