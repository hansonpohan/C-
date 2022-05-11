--	Module 16 - Lab02 ��e�p��(Cross Joins)�ۧ��p��(Self-Joins)

--	��e�s������Ӹ�ƪ����åd�୼�n (Cartesian product)�A��Ӹ�ƪ�b���X�ɡA
--			�����w�������A�Y�N��Ӹ�ƪ��Ҧ����i��ƦC�զX�X��
--			�èϥ� WHERE ���󦡭�����ܪ���Ƶ���(6x5=30)
--			�q�`�Ω���ո�Ʈw���A���į�C

use Northwind;
go
select * from Orders
where OrderID<10250    -- 2 ��

select * from [Order Details]
where ProductID<3        -- 82 ��

select o.OrderID, o.CustomerID, od.ProductID, od.UnitPrice
from Orders as o
cross join [Order Details] as od									--  2 tables �åd�����n 164 ��
where o.OrderID<10250 and od.ProductID<3


--�y�k�G,�P�W
select o.OrderID, o.CustomerID, d.ProductID, d.UnitPrice
from Orders as o, [Order Details] as d						--  2 tables �åd�����n
where o.OrderID<10250 and d.ProductID<3


--	�P�@�Ӹ�ƪ��p����ۤv�A�N�٬��ۧ��p���C
--	��ݭn���X�P�@�Ӹ�ƪ���������ƮɡA�N�i�H�ϥΦۧ��p���C
--	�ۧ��p�����ݨϥΧO�W���M SQL ��Ʈw�L�k�ѧO�C

--SELF JOIN �b���u��ƪ�,��X���u���D�ީm�W
select employeeID, ReportsTo from Employees

select EmployeeID, FirstName, LastName, Title, ReportsTo from Employees
go 2

--	SELF JOIN twice
select	e1.EmployeeID, e1.FirstName, e1.LastName, e1.ReportsTo, 
			e2.FirstName, e2.LastName, e2.ReportsTo
from Employees as e1 
join Employees as e2 on e1.ReportsTo=e2.EmployeeID
order by e1.EmployeeID


--	SELF JOIN triple
select	e1.EmployeeID, e1.LastName, e1.FirstName, e1.ReportsTo,
			e2.LastName, e2.FirstName,  e2.ReportsTo,
			e3.LastName, e3.FirstName,  e3.ReportsTo
from employees as e1
left join employees as e2 on e1.reportsto = e2.employeeID
left join employees as e3 on e2.reportsto = e3.employeeID


--�ϥ� LEFT JOIN �ӹ�{ SELF JOIN,�|��W�����Ҥl�h�X�@�����,���@�ӭ��u���D�޸�Ƭ�NULL
select e1.EmployeeID, e1.FirstName, e1.LastName, e1.ReportsTo, e2.FirstName, e2.LastName
from Employees as e1 
left join Employees as e2 on e1.ReportsTo=e2.EmployeeID
order by e1.EmployeeID


