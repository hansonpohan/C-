 --	Module 15 �h����p��(Join) ���򥻬d�߻y�k
--		15-1 : �p��(Join) 
--		15-2 : �����p��(Inner Joins) 
--		15-3 : �ϥθ�ƪ��O�W(Table Aliases)

--			�p��(JOIN) �O�Q�Τ��P��ƪ�����쪺���s�ʡA�ӵ��X�G�өΦh�Ӹ�ƪ���ƦX�֬d�ߪ��y�k�C
--			�p��(JOIN) �O SQL Server ���p��ϥΤ@�Ӹ�ƪ���ơA�ӿ���t�@�Ӹ�ƪ���ƦC�C
--			�b��ӦU��ƪ��������ε��c���|�]���p���d�ߦӧ��ܡC
--			�z�L�p���i�H�N���W�Ƥ��᪺��ƪ��s�٭즨�K��ϥΪ̲z�Ѫ���ƫ��A�C

--			�����p��(Inner Joins) : �N�Ҧ���ƪ�����Ƶ����@�Ӹ�ƪ�C
--			Inner Join (�����s��) ���W�c�Q�ϥΡA�]�O�̭��n���p���覡�C

--	2017/2019 SQL Server (p 9-3~6)

--  �[�� Orders & [Order Details] ���Y

use Northwind;
go

select * from Orders
select * from [Order Details]

--	Lab01 INNER JOIN - �����s��

--	�����w join_type, �åB�b WHERE �l�y���w�p������
select count(*) from Orders								-- 830
select count(*) from [Order Details]					--2155

select * from Orders, [Order Details]               -- 830 * 2155 = 1,788,650


--	take a look column contents
select * from Orders
select * from [Order Details]


--	�H�U�G�g�k�����ۦP
--	�ϥ� Where �d��, �åB�b = ���w�p���ھڪ�����C
select o.OrderID, CustomerID, ShipCity, ProductID -- Orders.OrderID ���ƪ���, ����ҸW��i
from Orders as o, [Order Details] as od
where o.OrderID = od.OrderID                                  -- Orders.OrderID ���ƪ���, ����ҸW��i
--where o.OrderID = 10248 and od.OrderID=10248


--	�ϥ� INNER JOIN �d��,�åB�b ON ���w�p���ھڪ�����C
select o.OrderID, CustomerID, ShipCity, ProductID -- Orders.OrderID ����ҸW��i
from Orders as o
inner join [Order Details] as od					-- default join = inner join 
on o.OrderID = od.OrderID


--	���W�٥[��Ʈw�O�W, default join = inner join
select o.OrderID, o.CustomerID, o.ShipCity, od.ProductID -- Orders.OrderID ����ҸW��i
from Orders as o
join [Order Details] as od
on o.OrderID = od.OrderID


--	���w��ƪ��Ҧ����ίS�w���W��
select o.*, ProductID			--  try ���� 'o.'
from Orders as o
join [Order Details] as od
on o.OrderID = od.OrderID

--  Show :  Northwind  ��  ��Ʈw�Ϫ� ��  �k�� �� �s�W��Ʈw�Ϫ� (order, order detail, employees, customers)

-- �Y�H�W�L�k���,  �а���U�C���O :
--ALTER AUTHORIZATION ON DATABASE:: Northwind TO [sa]  

-- �ثe�U�� DB ���֦���:
--select name, suser_sname(owner_sid) from sys.databases
-- [NewLogin] �令�� Northwind  ��  �k���ݩ�  ��  ��Ʈw  ��  �֦��� �g���@��
-- https://dev-felix72.blogspot.com/2017/05/sql-server-error-15404.html

-- https://docs.microsoft.com/zh-tw/sql/relational-databases/errors-events/mssqlserver-15517-database-engine-error?view=sql-server-ver15


--	INNER JOIN �T�Ӹ�ƪ�
select o.OrderID, od.ProductID, c.CompanyName 
from Orders as o
join [Order Details] as od
on o.OrderID = od.OrderID
join Customers as c
on o.CustomerID = c.CustomerID 


--	��ƪ�O�W���ϥ�WHERE
select o.OrderID, od.ProductID, c.CompanyName -- Orders.OrderID ����ҸW��i
from Orders as o
join [Order Details] as od
on o.OrderID = od.OrderID
join Customers  as c
on o.CustomerID = c.CustomerID 
where o.OrderID = 10248					--  one to many
