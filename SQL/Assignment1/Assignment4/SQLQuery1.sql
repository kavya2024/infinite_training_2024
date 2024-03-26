--question1 Write a T-SQL Program to find the factorial of a given number.
create procedure calculate_factorial1
@number int
as
begin
declare @factorial bigint = 1;
declare @counter int = 1;
if @number < 0
begin
print 'factorial is not defined for -ve numbers.';
return;
end
while @counter <= @number
begin
set @factorial = @factorial * @counter;
set @counter = @counter + 1;
end
print 'factorial of ' + cast(@number as varchar(10)) + ' is: ' + cast(@factorial as varchar(50));
end;
exec calculate_factorial1 5 --executing the calfactorial
 
--question2 Create a stored procedure to generate multiplication tables up to a given number.
create procedure GenerateMultiplicationTables
    @MaxNum int
as
begin
    declare @Multiplier int = 1;
    declare @Multiplicand int;
 
    while @Multiplier <= @MaxNum
    begin
        print 'Multiplication table for ' + cast(@Multiplier as varchar(10)) + ':';
        set @Multiplicand = 1;
        while @Multiplicand <= 10
        begin
            print cast(@Multiplier as varchar(10)) + ' * ' + cast(@Multiplicand as varchar(10)) + ' = ' + cast(@Multiplier * @Multiplicand as varchar(10));
            set @Multiplicand = @Multiplicand + 1;
        end
        print ''; -- Add a line break between tables
        set @Multiplier = @Multiplier + 1;
    end
end;
 
exec GenerateMultiplicationTables 5;
--question3
-- Create the holiday table
create table holiday4 (
    holiday_date date primary key,
    holiday_name varchar(50)
);
 
-- adding data to holiday list
insert into holiday4 (holiday_date, holiday_name)
values  
('2024-08-15', 'Independence Day'),
('2024-10-27', 'Diwali'),
('2024-01-01', 'New Year'),
('2024-05-01', 'Labour Day')
 insert into holiday4 (holiday_date, holiday_name)
values('2024-03-26', 'holi Day')

-- Create trigger to restrict data manipulation during holidays
create or alter trigger restrict_data_manipulation_during_holidays
on employees
-- Replace 'employees' with your actual table name
after insert, update, delete
as
begin
    declare @holidaycount int
-- Check if the current date is a holiday
    select @holidaycount = count(*)
    from holiday4
    where holiday_date = convert(date, getdate())
 
    if @holidaycount > 0
    begin
-- Rollback the transaction
        rollback;
-- Display the error message
        declare @holidayname varchar(50);
        select @holidayname = holiday_name
        from holiday4
        where holiday_date = convert(date, getdate());
 
-- Print the error message
print 'Due to ' + @holidayname + ', you cannot manipulate data.'
    end
end
insert into employees (empno, ename, salary) values (1018, 'John', 50000)