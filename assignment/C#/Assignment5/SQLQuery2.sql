
create or alter procedure generateslip 
   @emp_no int
as
begin
    -----Declaring Variables float type becuase value can be in decimal------
    declare @sal float;
	declare @ename varchar(10)
    declare @hra float;
    declare @da float
    declare @pf float
    declare @it float
    declare @deductions float
    declare @gross_sal float
    declare @net_sal float
 
    select @sal = salary from employees where empno = @emp_no
 
    --  HRA, DA, PF, IT
    set @hra = @sal * 0.10
    set @da = @sal * 0.20
    set @pf = @sal * 0.08
    set @it = @sal * 0.05
 
    ----- Deductions
    set @deductions = @pf + @it
 
    ----- Gross Salary
    set @gross_sal = @sal + @hra + @da
 
    ----- Net Salary
    set @net_sal = @gross_sal - @deductions
 
    -----Print all the calculated details
    print 'Payslip for Employee no: ' + cast(@emp_no as varchar(10))
    print '---------------------------------'
    print 'Salary: ' + cast(@sal as varchar(20))
    print 'HRA: ' + cast(@hra as varchar(20))
    print 'DA: ' + cast(@da as varchar(20))
    print 'PF: ' + cast(@pf as varchar(20))
    print 'IT: ' + cast(@it as varchar(20))
    print '---------------------------------'
    print 'Deductions: ' + cast(@deductions as varchar(20))
    print 'Gross Salary: ' + cast(@gross_sal as varchar(20))
    print 'Net Salary: ' + cast(@net_sal as varchar(20))
    print '---------------------------------'
end
--selecting from Employee tables

select*from Employees
exec generateslip 7369
 
 
