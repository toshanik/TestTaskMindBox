CREATE TABLE Products(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

CREATE TABLE Category(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

CREATE TABLE ProductCategory(
products_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(products_id) REFERENCES Products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES Category(id) ON DELETE CASCADE);

CREATE UNIQUE INDEX prodcat ON ProductCategory(products_id, category_id);

INSERT INTO Products VALUES('Хлеб'), ('Мясо'), ('Молоко'), ('Стул'), ('Диван');
INSERT INTO Category VALUES('Продукты'), ('Мебель');
INSERT INTO ProductCategory VALUES(1, 1), (2, 1), (3, 1), (4, 2), (5, 2);

SELECT p.name AS product, c.name AS category FROM Products AS p
LEFT JOIN ProductCategory AS pc ON p.id = pc.products_id
INNER JOIN Category AS c ON c.id = pc.category_id
ORDER BY product;