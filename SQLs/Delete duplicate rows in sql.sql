--The delete query should delete all duplicate rows except one. 
--Here is the SQL query that does the job. PARTITION BY divides the query result set into partitions.
WITH EmployeesCTE AS
(
SELECT *, ROW_NUMBER() OVER (PARTITION BY ID ORDER BY ID) AS RowNumber
FROM Employees
)
select * from EmployeesCTE

-- The Next line can do it
--DELETE FROM EmployeesCTE WHERE RowNumber > 1


/*
drop table Employees;
Create table Employees
(
ID int,
FirstName nvarchar(50),
LastName nvarchar(50),
Gender nvarchar(50),
Salary int
)
GO

Insert into Employees values (1, 'Mark', 'Hastings', 'Male', 60000)
Insert into Employees values (1, 'Mark', 'Hastings', 'Male', 60000)
Insert into Employees values (1, 'Mark', 'Hastings', 'Male', 60000)
Insert into Employees values (2, 'Mary', 'Lambeth', 'Female', 30000)
Insert into Employees values (2, 'Mary', 'Lambeth', 'Female', 30000)
Insert into Employees values (3, 'Ben', 'Hoskins', 'Male', 70000)
Insert into Employees values (3, 'Ben', 'Hoskins', 'Male', 70000)
Insert into Employees values (3, 'Ben', 'Hoskins', 'Male', 70000)

*/