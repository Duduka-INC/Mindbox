DROP TABLE IF EXISTS Products
DROP TABLE IF EXISTS Categories
DROP TABLE IF EXISTS ProductsCategories

CREATE TABLE Categories
(
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(20)
)

CREATE TABLE Products
(
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(20)
)

CREATE TABLE ProductsCategories
(
    Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ProductId INT,
	CategoryId INT,
	FOREIGN KEY (ProductId) REFERENCES Products(Id),
	FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
)

INSERT INTO Products (Name) VALUES ('iPhone 15')
INSERT Products (Name) VALUES ('Pixel 8')
INSERT Products (Name) VALUES ('Samsung 24')
INSERT Products (Name) VALUES ('Notebook 1')
INSERT Products (Name) VALUES ('Notebook 2')
INSERT Products (Name) VALUES ('Tablet 1')
INSERT Products (Name) VALUES ('Tablet 2')
INSERT Products (Name) VALUES ('SomeProduct')

INSERT Categories (Name) VALUES ('Phone')
INSERT Categories (Name) VALUES ('Tablet')
INSERT Categories (Name) VALUES ('Notebook')
INSERT Categories (Name) VALUES ('Electronics')
INSERT Categories (Name) VALUES ('Portable')

INSERT INTO ProductsCategories (ProductId, CategoryId)
	VALUES (1, 1),
		(1, 5),
		(2, 1),
		(2, 5),
		(4, 3),
		(7, 2),
		(7, 5)

INSERT INTO ProductsCategories (ProductId)
	VALUES (1), (2), (7)

INSERT INTO ProductsCategories (CategoryId)
	VALUES (5), (2), (1)

SELECT * FROM Products
SELECT * FROM Categories
SELECT * FROM ProductsCategories

SELECT pc.Id, p.Name AS ProductName, c.Name AS CategoryName
FROM Products AS p
INNER JOIN ProductsCategories AS pc
	ON p.Id = pc.ProductId
LEFT JOIN Categories AS c
	ON pc.CategoryId = c.Id
ORDER BY pc.Id