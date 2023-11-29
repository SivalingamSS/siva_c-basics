use Training2023
SELECT * from  Student

CREATE TABLE Student(
StudentID int,
fristname varchar(30),
lastname varchar(20),
age int,
Subject varchar(50),
Address varchar(50)
);
INSERT INTO Student
VALUES(1,'mani','s','cs','abcd')
INSERT INTO Student
values(2,'siva','c','math','yuipo')
INSERT INTO Student
values(3,'saran','e','sci','dfgh')
INSERT INTO Student
values(4,'kapilan','p','cs','dsbk')

SELECT DISTINCT fristname ,lastname
FROM Student
SELECT COUNT (DISTINCT fristname )
FROM Student

UPDATE Student
SET ADDRESS = 'DUBAI'
WHERE Address = 'dfgh'
 
 ALTER TABLE STUDENT
 DROP COLUMN AGE 

 DELETE FROM Student
 WHERE StudentID= 1
 
 SELECT * FROM Student
ORDER BY ADDRESS DESC

SELECT * FROM Student
ORDER BY ADDRESS 
SELECT * FROM Student
WHERE  ADDRESS = 'DUBAI' OR StudentID=  3



