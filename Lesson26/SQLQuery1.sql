SELECT * 
FROM Persons
WHERE Gender = 'male'
ORDER BY FirstName, LastName

SELECT *
FROM Persons
WHERE Age >= 18

SELECT *
FROM Persons
WHERE Address IS NULL

UPDATE Persons
SET Age = Age + 1

DELETE FROM Persons
WHERE Address IS NULL

SELECT COUNT(*) as CountOfRows
FROM Persons

SELECT COUNT(*) as CountByAge, Age
FROM Persons
GROUP BY Age
