--	Module 5	 02.Lab - Using Set Operators.sql
--  ���X�B��l���ϥ�

use Northwind ;
go

select country, region, city  from Employees
select country, region, city  from Customers;	


--	Using UNION ALL : to return all rows from both tables " including duplicates "
select country, region, city from Employees		-- HR.Employee : 9 rows,   try city �� else
union all																-- 9 + 91  rows
select country, region, city from Customers;		-- Sales.Customers : 91 rows


--	Using UNION : to return all rows from both tables " excluding duplicates "
select country, region, city from Employees		-- HR.Employee : 9 rows
union																	-- 71 rows *** �p��  **
select country, region, city from Customers;		-- Sales.Customers : 91 rows


--	Using INTERSECT : to return only rows found in both tables
select country, region, city from Employees		-- HR.Employee : 9 rows
intersect																-- 3 rows
select country, region, city from Customers;		-- Sales.Customers : 91 rows


--	Using EXCEPT : to return only rows from left table (Employees)
select country, region, city from Employees		-- HR.Employee : 9 rows
except																	-- 2 rows  (Employees - Customers)
select country, region, city from Customers;		-- Sales.Customers : 91 rows


--Reverse position of tables, return only rows from (Customers)
select country, region, city from Customers		--Sales.Customers : 91 rows
except																	-- 66 rows  (Customers - Employees)
select country, region, city from Employees;		-- HR.Employee : 9 rows



--  Error example

use AdventureWorks ;
go

--	Step1 Using UNION ALL : show NationalIDNumber, LoginID, HireDate, rowguid
--  �L�k�ѨM UNION ALL �B��l�� "Latin1_General_CS_AS" �P "SQL_Latin1_General_CP1_CI_AS" �������w�ǽĬ�A
select NationalIDNumber, LoginID, HireDate, rowguid from HumanResources.Employee
union all
select NationalIDNumber, LoginID, HireDate, rowguid from HumanResources.Employee2005;		-- Sales.Customers : 91 rows

--  check : 
--	table :HumanResources.Employee / 2005 �� ��Ʀ� �� ���"NationIDNumber / LoginID"(�ݩ�) �� �@�� �� �w��


select HireDate, rowguid from HumanResources.Employee
union all
select HireDate, rowguid from HumanResources.Employee2005;

