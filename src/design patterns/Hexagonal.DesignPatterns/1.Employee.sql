-- Create EmployeeDB database
CREATE DATABASE Employee
GO

USE Employee
GO

-- Create Employee Table
CREATE TABLE Employee
(
  EmployeeID INT PRIMARY KEY IDENTITY(1,1),
  Name VARCHAR(100),
  Gender VARCHAR(100),
  Salary INT,
  Department VARCHAR(50)
)
GO

-- Populate some test data into Employee table
INSERT INTO Employee VALUES('Hanumanth', 'Male', 100000, 'CEO' )
INSERT INTO Employee VALUES('Manu', 'Male', 15000, 'IT' )
INSERT INTO Employee VALUES('Priyanka', 'Female', 22000, 'HR' )
INSERT INTO Employee VALUES('Harsh', 'Male', 20000, 'IT' )
INSERT INTO Employee VALUES('Deepu', 'Female', 25000, 'IT' )
INSERT INTO Employee VALUES('Hina', 'Female', 20000, 'MR' )
GO
