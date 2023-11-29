use training2023

SELECT * FROM  Customers
 
 CREATE TABLE Customers(
 customersid int,
 customersname varchar(50),
 Age int,
 Address varchar(40),
 product varchar (30)
 );

 INSERT into customers
 values(1,'siva',22,'qwet'),
 (2,'maddy',23,'abcd'),
 (13,'uma',24,'jklh'),
 (10,'saran',29,'yuio'),
 (12,'mani',28,'trew'),
 (11,'kapilan',30,'query')

 --UPDATE   CUSTOMERS
 --WHERE produc
 INSERT into customers
 values(1,'anna',22,'qwet')

 SELECT * FROM Customers
WHERE CustomersName LIKE 'a%'

SELECT * FROM Customers
WHERE CustomersName LIKE '%a'

SELECT CustomersName ,age
From Customers
WHERE age IS NOT NULL

SELECT TOP 3 *FROM Customers;

SELECT  * FROM Customers WHERE CustomersID =1

SELECT * FROM Customers WHERE AGE =22

SELECT * FROM Customers WHERE AGE <>22

SELECT * FROM Customers WHERE AGE >=22

SELECT * FROM Customers WHERE  AGE IN (22,30);

SELECT * FROM Customers WHERE  CUSTOMERSID BETWEEN 2 AND 10

SELECT * FROM Customers
WHERE AGE=22 AND ADDRESS ='qwet';

SELECT * FROM Customers
WHERE AGE=23 AND(AGE = 22 OR ADDRESS = 'ABCD')

SELECT * FROM Customers
WHERE AGE=23 OR ADDRESS ='qwet';

SELECT * FROM Customers
WHERE  NOT ADDRESS ='qwet';

ALTER TABLE Customers 
ADD CITYNAME varchar (50);

UPDATE Customers
SET  CITYNAME ='INDIA',CITY='FGHJ'
WHERE customersid =12

SELECT * FROM Customers WHERE CITY IS NULL