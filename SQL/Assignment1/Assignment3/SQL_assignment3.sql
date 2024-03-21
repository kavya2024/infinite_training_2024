use Sql_assignment2
select * from Employees
select * from Department

--Retrieve a list of MANAGERS.
select Ename,salary from Employees
where job='Manager'

--get the names and salaries of all employees who earn more than 1000 per month.
select Ename,salary from Employees
where salary>1000

-- Display the names and salaries of all employees except JAMES.
select Ename,salary from Employees 
where Ename!='James'

--details of employees whose names begin with S
select * from Employees
where Ename like 'S%'

--Names of all employees that have A anywhere in their name.
select Ename from Employees
where Ename like '%a%'
	
--Names of all employees that have L as their third character in their name. 
select * from Employees
where Ename like '__L%'

--Compute daily salary of JONES. 
select Ename,salary as MonthlySal,salary/30 as DailySal 
from Employees where Ename='Jones'

--Calculate the total monthly salary of all employees.
select sum(salary) as totalSal 
from Employees

--Print the average annual salary 
select avg(salary*12) as 'Avarage Annual Salary'
from Employees
declare @sal int
set @sal=(select avg(salary*12) from Employees)
print 'The avarage annual salary for employees ->'+' '+cast(@sal as varchar(10))

--Select the name, job, salary, department number of all employees except salesman from department number 30.
select Ename,job,salary,deptno 
from Employees
where job not like 'Salesman' and deptno  not like 30

--List unique departments of the EMP table.
select distinct deptno from Employees
select distinct dname from Department
	
--List the name and salary of employees who earn more than 1500 and are in department 10 or 30. 
select Ename as Employee, salary as 'Monthly Salary',deptno as Department
from Employees
where salary>1500 and deptno in (10,30)

--Display the name, job, and salary of all the employees whose job is manager or analyst and their salary is not equal to 1000, 3000, or 5000.
select Ename,job,salary
from Employees
where job in('Analyst','Manager') and salary not in(1000,3000,5000)

--Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%
select Ename,salary as 'Old Salary',comm as 'commision',(salary*1.10)as'10% Hike'
from Employees where salary<comm

--Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select Ename	
from Employees
where Ename like '%l%l%' and deptno=30 or Mgr_id=7782

--Display the names of employees with experience of over 30 years and under 40 yrs.
 select Ename
from Employees
where DATEDIFF(yy,hiredate,getdate()) 
between 30 and 40 
			
--Retrieve the names of departments in ascending order and their employees in descending order. 
select dname,ename 
from Employees join Department 
on Department.deptno=Employees.deptno
order by dname asc,ename desc

--Find out experience of MILLER. 
declare @experince date
select @experince=hiredate
from Employees 
where Ename like 'Miller'
select datediff(YY,@experince,getdate()) as Experience

