create database week2;
use week2;
CREATE TABLE Sales (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Region VARCHAR(50),
    Sales INT
);
INSERT INTO Sales (ID, Name, Region, Sales) VALUES
(1, 'Aakash', 'North', 5000),
(2, 'Bhavya', 'South', 7000),
(3, 'Charan', 'North', 7000),
(4, 'Deepika', 'East', 4000),
(5, 'Eshwar', 'North', 5000),
(6, 'Farhan', 'South', 5000),
(7, 'Gauri', 'East', 6000),
(8, 'Hema', 'North', 3000);
select*from sales;

SELECT
  ID,
  Name,
  Region,
  Sales,
  RANK() OVER (PARTITION BY Region ORDER BY Sales DESC) AS Region_Rank,
  DENSE_RANK() OVER (PARTITION BY Region ORDER BY Sales DESC) AS Region_DenseRank,
  ROW_NUMBER() OVER (PARTITION BY Region ORDER BY Sales DESC) AS Region_RowNum
FROM Sales;