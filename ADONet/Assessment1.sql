create database Employeemanagement
use Employeemanagement
--create table
CREATE TABLE Employee_Details (
    Empno INT PRIMARY KEY IDENTITY,
    EmpName VARCHAR(32) NOT NULL,
    Empsal NUMERIC(10,2) CHECK(Empsal >= 25000),
    Emptype CHAR(1) CHECK(Emptype IN ('P', 'C'))
)

	
CREATE or alter PROCEDURE AddEmployee2
    @EmpName VARCHAR(50),
    @Empsal NUMERIC(10,2),
    @Emptype CHAR(1)
AS
BEGIN
    DECLARE @Empno INT;
    SELECT @Empno = ISNULL(MAX(Empno), 0) + 1 FROM Employee_Details;

    INSERT INTO Employee_Details ( EmpName, Empsal, Emptype)
    VALUES ( @EmpName, @Empsal, @Emptype);

END;
