Use Northwind

-- Inner join query
Select Customers.CustomerId, ContactName, ContactTitle, City, OrderId, OrderDate, ShipName from Customers 
inner join
Orders on Customers.CustomerID = Orders.CustomerID order by Customers.CustomerID

-- Left outer join query
Select Customers.CustomerId, ContactName, ContactTitle, City, OrderId, OrderDate, ShipName from Customers 
left outer join
Orders on Customers.CustomerID = Orders.CustomerID order by Customers.CustomerID

-- Right outer join query
Select Customers.CustomerId, ContactName, ContactTitle, City, OrderId, OrderDate, ShipName from Customers 
right outer join
Orders on Customers.CustomerID = Orders.CustomerID order by Customers.CustomerID

-- Full outer join query
Select Customers.CustomerId, ContactName, ContactTitle, City, OrderId, OrderDate, ShipName from Customers 
full join
Orders on Customers.CustomerID = Orders.CustomerID order by Customers.CustomerID

Create Table EmpData
(
EmpId varchar(10),
EmpName varchar(20),
Mgr varchar(10)
)

insert into EmpData values ('E001', 'John', 'M002'),('E002', 'James', 'M003'), ('E003', 'Steve', 'M001'),
('E004', 'John', 'M004')

insert into EmpData (EmpId, EmpName) values ('M001', 'Maria'),('M002', 'Tony'),('M003', 'Edwin'),
('M004', 'Anthony')

Select * from EmpData
Delete from EmpData where EmpId in ('M001','M002','M003','M004')

Select EmpData.EmpName, EmpData2.EmpName as 'ReportsTo' from EmpData inner join EmpData as EmpData2 
on EmpData.Mgr=EmpData2.EmpId

Use Test

Select * from Students

Create Table Subjects
(
SubjectId int,
SubjectName varchar(20)
)

insert into Subjects values (1, 'English'),(2, 'Maths'),(3, 'Science')

Select * from Students cross join Subjects Order By Students.RollNo


Create View ProductView
as
Select ProductId, ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock TotalAmount from Products

Select * from ProductView where TotalAmount>300

Create Proc GetCustomers
as
Select * from Customers

Alter Proc GetCustomers
as
Select * from CustomerDemographics

Create Proc GetCustomerById @id varchar(10)
as
Select * from Customers where CustomerID=@id

Exec GetCustomerById 'BERGS'

Use Test
Select * from Students

Alter Proc AddStudent
@rollno int,
@name varchar(20),
@marks int
as
begin
	if(@marks<0 or @marks>100)
	begin
		Print 'Value of marks is not valid'
	end
	else
	begin
		insert into Students values (@rollno, @name, @marks)
	end
end

Exec AddStudent 8, 'Dhiraj', 80

Exec GetCustomers







