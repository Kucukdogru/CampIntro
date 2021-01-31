-- SELECT
-- ANSII
SELECT ContactName Ad, CompanyName SirketAdi, City Sehir FROM Customers

SELECT * FROM Customers WHERE City='London'

-- CASE INSENSITIVE
SELECT * FROM Products WHERE CategoryID=1 OR CategoryID=3

SELECT * FROM Products WHERE CategoryID=1 AND UnitPrice>=10

SELECT * FROM Products WHERE CategoryID=1 ORDER BY UnitPrice DESC   -- ASCENDING  -- DESCENDING

SELECT COUNT(*) PIECE FROM Products WHERE CategoryID=2

-- Hangi kategoride kaç farklı ürünümüz var?
SELECT CategoryID, COUNT(*) FROM Products
GROUP BY CategoryID

-- Ürün sayısı 10 dan az olan kategorileri listele
SELECT CategoryID, COUNT(*) 
FROM Products
WHERE UnitPrice>20
GROUP BY CategoryID
HAVING COUNT(*)<10


SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
FROM Products
INNER JOIN Categories ON Products.CategoryID=Categories.CategoryID
WHERE Products.UnitPrice>10
-- DTO DATA TRANSFROMATION OBJECT

-- Hiç satış yapamadığımız ürünler nelerdir?
SELECT *
FROM Products P
LEFT JOIN [Order Details] OD ON P.ProductID=OD.ProductID
INNER JOIN Orders O ON O.OrderID=OD.OrderID


-- Hangi müşteriler bizden hiç ürün almamış
SELECT * FROM Customers C
LEFT JOIN Orders O ON C.CUSTOMERID=O.CUSTOMERID
WHERE O.CustomerID IS NULL


