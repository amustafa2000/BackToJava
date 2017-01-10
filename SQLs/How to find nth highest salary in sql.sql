-- How to find nth highest salary in sql
-- https://www.youtube.com/watch?v=fvPddKyHxpQ&list=PL6n9fhu94yhXcztdLO7i6mdyaegC8CJwR
-- Data base 
/*
Create table Employees
(
ID int primary key identity,
FirstName nvarchar(50),
LastName nvarchar(50),
Gender nvarchar(50),
Salary int
)
GO

Insert into Employees values ('Ben', 'Hoskins', 'Male', 70000)
Insert into Employees values ('Mark', 'Hastings', 'Male', 60000)
Insert into Employees values ('Steve', 'Pound', 'Male', 45000)
Insert into Employees values ('Ben', 'Hoskins', 'Male', 70000)
Insert into Employees values ('Philip', 'Hastings', 'Male', 45000)
Insert into Employees values ('Mary', 'Lambeth', 'Female', 30000)
Insert into Employees values ('Valarie', 'Vikings', 'Female', 35000)
Insert into Employees values ('John', 'Stanmore', 'Male', 80000)
GO
*/
select * from Employees;

with SalDes as
(
   select distinct top(3) Salary from Employees order by Salary desc
)

select top(1) Salary from SalDes order by Salary asc