select * from Departments;
select * from Employees;
select * from Genders;

/*select DepartmentName, Gender
from Employees
 join Departments on Employees.DepartmentID = Departments.DepartmentID 
 join Genders on Employees.GenderID = Genders.GenderID 
 group by  DepartmentName, Gender
 --order by  DepartmentName, Gender
 */
 select Departments.DepartmentName, COUNT(Employees.DepartmentID) 
 from Employees
 right join Departments
 on Departments.DepartmentID = Employees.DepartmentID
 group by DepartmentName