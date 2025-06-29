create database exe2;
use  exe2;

CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(100),
    Department VARCHAR(50),
    Salary INT
);

INSERT INTO Employees (EmpID, EmpName, Department, Salary) VALUES
(101, 'Asha', 'HR', 30000),
(102, 'Bala', 'IT', 60000),
(103, 'Charan', 'Finance', 45000),
(104, 'Divya', 'IT', 55000),
(105, 'Esha', 'HR', 32000);

DELIMITER $$

CREATE PROCEDURE GetEmployeesByDepartment(IN DeptName VARCHAR(50))
BEGIN
    SELECT EmpID, EmpName, Salary
    FROM Employees
    WHERE Department = DeptName;
END$$

DELIMITER ;


