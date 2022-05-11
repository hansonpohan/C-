--	Module 16 �h����p��(Join) ���ܧάd�߻y�k
--		16-1 : �~���p��(Outer Joins) 
--		16-2 : ��e�p��(Cross Joins)
--		16-3 : �ۧ��p��(Self-Joins)

--			�����p��(Inner Joins) : �N�Ҧ���ƪ�����Ƶ����@�Ӹ�ƪ�C
--			�~���p��(Outer Joins) : �����X�Ĥ@�Ӹ�ƪ�A�A�ھ����p���N��L��ƪ�̦��[�J�C
--			��e�p��(Cross Joins) : �N�Ĥ@�Ӹ�ƪ����C�@����ƻP�ĤG�Ӹ�ƪ�����ư����n�B�z(���֨ϥ�)�C
--			�ۧ��p��(Self-Joins) : �N�P�@�Ӹ�ƪ�����ƨ̧P�_������X�һݪ���ơC

--	Lab01 OUTER JOIN 
--	Outer Joins �~���s�� : LEFT JOIN�BRIGHT JOIN�BFULL JOIN

--	INNER JOIN					�Y	A �� B�A��AB���涰�C
--	LEFT JOIN						�Y	A�C
--	RIGHT JOIN					�Y	B�C
--	FULL JOIN						�Y	A �� B�A��AB���p���C
--	CROSS JOIN					(��e�p���κٲåd�୼�n) �A�YA �� B�A��AB���n���C
--	SELF JOIN						�ۧ��p���C�Y	A �� A....

--	SQL Server 2017/ 2019 p 9-2

use Northwind

--	�ϥ� INNER JOIN �d�߲��~��Ƥ����O
select * from Employees					-- 9 records
select * from EmployeeTerritories	-- 49 records

--  ���ͨ��EmployeeID �����|����Ʈw
select * into #EmpTemp from Employees where EmployeeID <=6							-- 6 records
select * into #EmpTerTemp from EmployeeTerritories where EmployeeID >=3		-- 40 records

select * from #EmpTemp
select * from #EmpTerTemp

--	�ϥ� INNER JOIN �d��
select e.EmployeeID, LastName, et.TerritoryID   
from #EmpTemp as e
inner join #EmpTerTemp as et	
on e.EmployeeID= et.EmployeeID


-- ��2
select * from Orders						-- 830
select * from [Order Details]		--2155

--  ���ͨ��OrderID �����|����Ʈw
select * into #OrderTemp from Orders where OrderID <=10280
select * into #OrderDeTemp from [Order Details] where OrderID between 10270 and 10300

select * from #OrderTemp			-- 33
select * from #OrderDeTemp		-- 83


--	�ϥ� INNER JOIN �d��
select o.OrderID, CustomerID, od.UnitPrice   
from #OrderTemp as o
inner join #OrderDeTemp as od
on o.OrderID= od.OrderID


--	�ϥ� LEFT OUTER JOIN �d�߲��~��Ƥ����O
select * from #EmpTemp
select * from #EmpTerTemp

select e.EmployeeID, e.LastName, et.TerritoryID   
from #EmpTemp as e
left join #EmpTerTemp as et						
on e.EmployeeID= et.EmployeeID


-- ��2
select * from #OrderTemp			-- 33
select * from #OrderDeTemp		-- 83

select o.OrderID, o.CustomerID, od.UnitPrice   
from #OrderTemp as o
left join #OrderDeTemp as od						
on o.OrderID= od.OrderID


--���� RIGHT OUTER JOIN �����G
select * from #EmpTemp
select * from #EmpTerTemp

select e.EmployeeID, e.LastName, et.TerritoryID   
from #EmpTemp as e
right join #EmpTerTemp as et						
on e.EmployeeID= et.EmployeeID

-- ��2
select * from Orders						-- 830
select * from [Order Details]		--2155

select o.OrderID, o.CustomerID, od.UnitPrice   
from #OrderTemp as o
right join #OrderDeTemp as od						
on o.OrderID= od.OrderID


--���� FULL OUTER JOIN �����G
select * from #EmpTemp
select * from #EmpTerTemp

select e.EmployeeID, e.LastName, et.TerritoryID   
from #EmpTemp as e
full join #EmpTerTemp as et						
on e.EmployeeID= et.EmployeeID
order by EmployeeID

-- ��2
select * from Orders						-- 830
select * from [Order Details]		--2155

select o.OrderID, o.CustomerID, od.UnitPrice   
from #OrderTemp as o
full join #OrderDeTemp as od						
on o.OrderID= od.OrderID
order by OrderID

