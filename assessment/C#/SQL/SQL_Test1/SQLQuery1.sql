create database test
use test
--ques 1 start
CREATE TABLE Books (
    id INT PRIMARY KEY,
    title VARCHAR(100),
    author VARCHAR(50),
    isbn VARCHAR(30) UNIQUE,
    publication_date DATE,
)
--adding data to table book
insert into books values
(1,'My first sql book','Mary Parker',981483029127,'2012-02-22 12:08:17'),
(2,'My second sql book','john Mayer',853700927313,'1972-07-03 09:22:45'),
(3,'My third sql book','Cary flint',523120967812,'2015-10-18 14:05:44')
select*from books
--1.query to fetch the details of the books written by author whose name ends with er.
select * from books where author LIKE '%er';
--create table reviews
create table reviews( id INT PRIMARY KEY, book_id int,reviewer_name varchar(100),content varchar(50), rating int,published_date DATE,)
--inserting values in this table
insert into reviews (id, book_id, reviewer_name, content, rating, published_date)values
(1, 1, 'John Smith', 'My first review', 4, '2017-12-10 05:50:11'),
(2, 2, 'John Smith', 'My second review', 5, '2017-10-13 15:05:12'),
(3, 2, 'Alice Walker', 'Another review', 1, '2017-10-12 23:47:10')
--Display the Title ,Author and ReviewerName for all the books from the above table
select b.title, b.author, r.reviewer_name
from books b
JOIN reviews r on b.id = r.book_id;
--Display the reviewer name who reviewed more than one book.
select reviewer_name
from reviews
group by reviewer_name
having count (DISTINCT book_id) > 1;

--question 2 start
--creating table customer
create table customer(ID int primary key, NAME varchar(50),AGE int,ADDRESS varchar(50),SALARY int)
insert into customer values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP', 4500.00),
(7, 'Muffy', 24, 'Indore', 10000.00);
select*from customer
--display the names of customers who live in the same address that has the character 'o' anywhere in the address
select name
from customer
where ADDRESS LIKE '%o%';
--ques 4
create table orders(OID int primary key, DATE DATE,CUSTOMER_ID int, AMOUNT int)
insert into orders values(102, '2009-10-08', 3, 3000),
(100, '2009-10-08', 3, 1500),
(101, '2009-11-20', 2, 1560),
(103, '2008-05-20', 4, 2060)
--query to display the Date,Total no of customer placed order on same Date
select*from orders
select DATE, count(DISTINCT CUSTOMER_ID) as Total_Customers
from orders
group by DATE;
--question 5
create table Employee(ID int primary key, NAME varchar(50),AGE int,ADDRESS varchar(50),SALARY int)
insert into Employee values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 6500.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'MP',null),
(7, 'Muffy', 24, 'Indore',null)
select lower(NAME) AS Lowercase_Name
from Employee
where SALARY is null
--student details 
create table StudentDetails (StudentID int primary key,RegisterNo int,Name varchar(50),Age int,Qualification  varchar(50), MobileNo bigint, Mail_id  varchar(100),Location NVARCHAR(50),Gender CHAR(1))
insert into StudentDetails (StudentID, RegisterNo, Name, Age, Qualification, MobileNo, Mail_id, Location, Gender) values
(1, 2, 'Sai', 22, 'B.E', 9952836777, 'sai@gmail.com', 'Chennai', 'M'),
(2, 3, 'Kumar', 20, 'BSC', 7890125648, 'kumar@gmail.com', 'Madurai', 'M'),
(3, 4, 'Selvi', 22, 'B.Tech', 8904567342, 'selvi@gmail.com', 'Salem', 'F'),
(4, 5, 'Nisha', 25, 'M.E', 7834672310, 'Nisha@gmail.com', 'Theni', 'F'),
(5, 6, 'SaiSaran', 21, 'B.A', 7890345678, 'saran@gmail.com', 'Madurai', 'F'),
(6, 7, 'Tom', 23, 'BCA', 8901234675, 'Tom@gmail.com', 'Pune', 'M')
select 'Male' as label,
count(case when Gender = 'M' THEN 1 END) AS Value
FROM StudentDetails
union all
select'Female'as label,
count(case when Gender = 'F' then 1 end) as value
from StudentDetails
union ALL
select'Total' AS Label,
count(*) AS Value
from StudentDetails;


