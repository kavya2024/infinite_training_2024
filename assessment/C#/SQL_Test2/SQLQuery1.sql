create database test2
use test2
create table EMPLOYEE
(Empno numeric(4) primary key,
Ename varchar(20) not null,
job varchar(15),
salary numeric(7),doj DATE,deptno int)
insert into EMPLOYEE values
(7001,'Sandeep','Analyst',25000,'2020-02-01',1),
(7002,'Rajesh','Designer',30000,'2022-05-01',3),
(7003,'Madhav','Developer',40000,'2021-02-01',8),
(7004,'Manoj','Developer',40000,'2000-02-01',10),
(7005,'Abhay','Designer',35000,'2023-07-01',4),
(7006,'Uma','Tester',30000,'2023-02-09',7),
(7007,'Gita','Tech. Writer',30000,'2007-02-01',8),
(7008,'Priya','Tester',35000,'2023-05-09',6),
(7009,'Nutan','Developer',45000,'2022-05-01',8),
(7010,'Smita','Analyst',20000,'2003-04-05',2),
(7011,'Anand','Project Mgr',65000,'2006-05-12',1)
select* from EMPLOYEE
drop table EMPLOYEE

--question 1 Write a query to display your birthday( day of week)
--question 1
create table birthday (
	Name varchar(50),
	BirthDate Date)
 insert into birthday(Name, BirthDate) Values 
('ramesh', '2007-04-06'),
('satish', '2004-07-09'),
('kavya', '2000-08-10')
 
select datename(dw, BirthDate)as day_of_week
from birthday
where BirthDate = '2004-07-09'
--question 2
--it will find the age in days
--date difference 
select datediff(day, '2004-07-09', getdate()) as age_in_Days
--question 3
--joined before 5years
select *from EMPLOYEE 
where doj<'2019-03-28'

--Question 4
--we start a transaction by using begin transaction
begin transaction
--adding 3 new rows values
insert into EMPLOYEE (Empno, Ename,job,salary, doj) VALUES
(7087,'kuldeep','Analyst',29000,'2020-02-01',4),
(7458,'shyam','Designer',36700,'2022-05-01',3),
(7578,'ram','Developer',40580,'2021-02-01',2)
-- b. Update the second row sal with 15% increment
UPDATE EMPLOYEE
SET salary = salary * 1.15
WHERE Empno =7002
select*from EMPLOYEE

-- c. Delete first row
DELETE FROM EMPLOYEE WHERE Empno = 7001
select*from EMPLOYEE

-- Commit the transaction
COMMIT
select*from EMPLOYEE

--question 5
--taking parameters for function
create or alter function dbo.CalculateBonus
(@job VARCHAR(50),@sal DECIMAL(10, 2),@deptno INT
)
returns decimal(10, 2)
as
begin
--calculating bonus
    DECLARE @bonus DECIMAL(10, 2)
     if @deptno = 10
        set @bonus = @sal * 0.15;
    else if @deptno = 20
        set @bonus = @sal * 0.20;
    else
        set @bonus = @sal * 0.05;
 return @bonus;
end
select Ename, job, salary, dbo.CalculateBonus(job, salary, deptno) AS bonus
from EMPLOYEE;

