Use Test

Create Table Customer
(
CustomerId int,
CustomerName varchar(20),
Email varchar(20),
Phone varchar(10)
)

Drop Table Customer

-- Create Table with primary key
Create Table Product
(
ProductId int primary key,
ProductName varchar(20),
Brand varchar(20),
Quantity int,
Price int
)
-- Modify table structure and add new column
Alter Table Product add ProductDescription varchar(50)

-- Modify the data type of column 
Alter Table Product alter column ProductDescription varchar(100) not null

-- Removing column from table
Alter Table Product drop column ProductDescription

-- Creating Table without primary key
Create Table Customers
(
CustomerId int,
CustomerName varchar(20),
Email varchar(20),
Phone varchar(20)
)

-- Altering table for making column not null
Alter Table Customers alter column CustomerId int not null

-- Altering table for adding primary key
Alter Table Customers add constraint pk1 primary key(CustomerId)

Create Table Employees
(
EmployeeId int primary key,
EmployeeName varchar(20),
Email varchar(20),
Phone varchar(20),
Age int check(Age>=18)
)

Drop Table Employees

Create Table Employees
(
EmployeeId int primary key,
EmployeeName varchar(20),
Email varchar(20),
Phone varchar(20),
Age int check(Age>=18)
)

-- Alter table for adding check constraint
Alter Table Employees add constraint check_age check(Age>=18)

-- Getting information about any database object
sp_help Employees

--Alter table for adding unique constraint
Alter Table Employees add constraint uk1 unique(Email)

-- Alter table for removing constraint
Alter Table Employees drop constraint uk1

sp_rename 'Employees.PK__Employee__7AD04F118D5064C6', 'mypk1'

-- Adding new data in table using insert statement
insert into Product values(1, 'Laptop', 'Dell', 5, 200)

insert into Product(ProductId, ProductName, Brand) values(2, 'Tablet', 'Lenovo')

insert into Product values (4, 'Desktop', 'HP', 9, 499),(5, 'HardDrive', 'Kingston', 3, 299)

-- Modifying existing data in table
Update Product set Quantity=7, Price=299 where ProductId=2

-- Deleting data from table
Delete from Product where ProductId=5

Select * from Product

Create Table Orders
(
OrderId int primary key,
OrderDate datetime,
CustomerId int references Customers(CustomerId)
)
insert into Customers values (1, 'John', 'John@gmail.com', '23865283')
insert into Orders values(1, '2022-12-22', 1)
Select * from Customers


-------------------------------------------------------------------
Use Northwind
Select * from Customers

Select CustomerId, ContactName, CompanyName, ContactTitle, Address, City from Customers

Select * from Customers where CustomerID='BERGS'
Select * from Customers where City='London'

Select * from Products where UnitPrice>50

Select * from Customers where City='London' or City='Madrid'
Select * from Customers where City='Madrid' and Country='Spain'

Select * from Customers where Region is not null
Select * from Customers where not City='London'

Select ProductId, ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as TotalAmount,
(UnitPrice*UnitsInStock)*10/100 as Discount from Products

Select * from Products where ProductID between 5 and 10

Select * from Customers where City in ('Berlin','London','Madrid')

Select * from Customers where ContactName like 'A%'

Select * from Customers where Country like 'S____'

Select * from Customers where ContactName like '[^AS]%'

Select * from Customers where ContactName like 'A%S'

Select * from Customers order by ContactName desc

Select top 5 * from Customers
-- String functions
Select LEN('John')

Select CustomerID, ContactName, ContactTitle, LEN(ContactName) as 'Character Count' from Customers

Select TRIM('   welcome ')
Select LTRIM('   Hello')
Select REVERSE('Welcome')

-- Math Functions
Select POWER(2, 5)
Select ROUND(4.72, 1)
Select CEILING(4.2)
Select Floor(4.7)

-- Date Functions
Select GETDATE()
Select DATEPART(yy, '2022-12-22')
Select DATEADD(mm, 2, '2022-12-22')
Select DATEDIFF(dd, '2022-12-04', '2022-12-22')


Create Table Students
(
RollNo int primary key,
StudentName varchar(20),
Marks int
)

insert into Students values(1, 'John', 78),(2, 'James', 82),(3, 'Peter', 91),(4, 'Steven', 85),(5, 'Maria', 69),
(6, 'Tony', 90)

Select * from Students

Select Min(Marks) from Students

Use Northwind

Select * from Products

Select SupplierID, Sum(UnitsInStock) from Products group by SupplierID

Use Test

Select * from Students

Select StudentName from  Students where Marks=(Select Max(Marks) from Students)

Select * from Students where Marks=(Select Max(marks) from Students where marks<(Select Max(marks) 
from Students))


Create Table Person
(
PersonId int,
Name varchar(20),
Age int,
constraint check_person_age check(Age>=18),
constraint pk1 primary key(PersonId)
)








