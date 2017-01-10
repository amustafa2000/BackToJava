-- https://www.youtube.com/watch?v=Kd3HTph0Mds&list=PL6n9fhu94yhXcztdLO7i6mdyaegC8CJwR&index=2

select * from Employees;

with EmplyeesCTE as
(
-- The next two lines execution becomes the EmplyeesCTE
    select EmployeeID, EmployeeName, ManagerId from Employees
    where EmployeeID = 7

	union all

	select Employees.EmployeeID, Employees.EmployeeName, Employees.ManagerId from Employees
	join EmplyeesCTE 
	on Employees.EmployeeID = EmplyeesCTE.ManagerId
)
select EmployeeID, EmployeeName, ManagerId from EmplyeesCTE



/*
Create table Employees
(
EmployeeID int primary key identity,
EmployeeName nvarchar(50),
ManagerID int foreign key references Employees(EmployeeID)
)
GO

Insert into Employees values ('John', NULL)
Insert into Employees values ('Mark', NULL)
Insert into Employees values ('Steve', NULL)
Insert into Employees values ('Tom', NULL)
Insert into Employees values ('Lara', NULL)
Insert into Employees values ('Simon', NULL)
Insert into Employees values ('David', NULL)
Insert into Employees values ('Ben', NULL)
Insert into Employees values ('Stacy', NULL)
Insert into Employees values ('Sam', NULL)
GO

Update Employees Set ManagerID = 8 Where EmployeeName IN ('Mark', 'Steve', 'Lara')
Update Employees Set ManagerID = 2 Where EmployeeName IN ('Stacy', 'Simon')
Update Employees Set ManagerID = 3 Where EmployeeName IN ('Tom')
Update Employees Set ManagerID = 5 Where EmployeeName IN ('John', 'Sam')
Update Employees Set ManagerID = 4 Where EmployeeName IN ('David')
GO
*/