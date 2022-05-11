 --	Module 18 �l�d��(Subquery) ���B��
--		18-1 : ���g�Ǧ^��@�¶q�Ȫ��l�d��
--		18-2 : ���g�Ǧ^�h�ӭȪ��l�d��
--		18-3 : �f�t EXISTS �H�� NOT EXISTS ���l�d��

--	�l�d�ߤ]�٬������d�ߡA�ӥ]�t�l�d�ߪ����z���S�٬��~���d�ߡC
--	�i��h�Ӹ�ƪ��d�ߡA���F�ϥ��p��(JOIN)�~�A�]�i�H�ϥ� SQL �l�d�� (Subquery)�C
--	�l�d�ߴN�O�b�@�� SELECT ���O���A��J�@�� SELECT �i��d�ߡC
--	�l�d�߰򥻻y�k�M SELECT �d�߬ۦP�C�i�H�N�d�ߵ��G������ƨӷ��Ϊ̬O�P�_�ȡC
--	�p�G�l�d�߭n������ƨӷ��ϥΡA�����n���O�W�A�H�Q��SQL�G�ѡC

--	2017/ 2019  SQL Server		p 9-22 

--	Lab01���g�Ǧ^��@�¶q�Ȫ��l�d��
use Northwind;
go

-- �l�d�ߤ��\�b�B�⦡�������m�ϥ�
--	��XOrders �Ǧ^OrderID ��, �A�� Order Detail ���d���X��
--  �l�d�ߥi�bwhere ��
select * from Orders
select * from [Order Details]

select count(*) 
from [Order Details]
where OrderID = (select OrderID from Orders where OrderID = '10248')	-- �n�s�b Orders ���� True ������
--where OrderID = (select OrderID from Orders where Freight= 32.38)
--where OrderID in (select OrderID from Orders where Freight>32.38)
							

select * from Products
select * from [Order Details]

--  �l�d�ߤ]�i�bselect ��
--  Order Detail ������ ProductID �hProduct ���ɤ��T�{

select ProductID, ProductName,
			(select sum(od.UnitPrice) from [Order Details] as od where od.ProductID = p.ProductID) as sale
from Products as p
order by sale desc


--	�U�C���z���M��w���j�󥭧��w�����Ҧ����~�W�١C
select * from [Order Details]

select OrderID, UnitPrice
from [Order Details]
where UnitPrice > (select avg(UnitPrice) from [Order Details])


--	�U�C�d�ߴ��ѤF�@�ӥH ANY ����B��l���X���l�d�߽d�ҡC 
--	���|�M��M�����j��ε�����󲣫~�l���O���̤j�M����檺���~�C

select * from Orders
select * from [Order Details]

select OrderID, UnitPrice
from [Order Details]
where UnitPrice >=								--  > min in any (> = 9.8)
		any (select UnitPrice from [Order Details] where OrderID in ( '10248', '10249'))

--where UnitPrice >=								--  > max (42.4)
	--	all (select UnitPrice from [Order Details] where OrderID in ( '10248', '10249'))


--	�̲��~���O��X�Ҧ����~���W��
--	=ANY �B��l���P�� IN
--	�H�U��ӽd�ҵ��G�ۦP
select * from Products
select * from [Order Details]

select ProductID, ProductName
from Products
where ProductID = any (select ProductID from [Order Details] where Quantity > 10)
-- where ProductID = any (select distinct  ProductID from [Order Details] where Quantity > 10)

-- same as above
select ProductID, ProductName
from Products
where ProductID in (select ProductID from [Order Details] where Quantity > 10)


--	�U�C�d�߷|���`�� >2000 ��X���~�W�١C
select * from Products
select * from [Order Details]

select ProductName
from products
where ProductID 
in (select distinct ProductID from [Order Details] where UnitPrice*Quantity>2000 )


--	�y�����l�d�ߡz�ܽd
--		�d�߲��~�򥻸�ơB�̰�����Υ������
select * from Products
select * from [Order Details]

--  �`�N�l�d�ߥi�b�ܦh��b�a�� ex. select, where
select ProductID, ProductName, 
	(select max(UnitPrice) from [Order Details]where ProductID = p.ProductID) as maxP,
	(select avg(UnitPrice) from [Order Details]where ProductID = p.ProductID) as avgP
from Products as p
order by maxP desc


--	EXISTS �p�G�l�d�ߥ]�t�����ƦC�A�K�Ǧ^ TRUE�C
select * from Products				-- 77 records
select * from [Order Details]	-- 2,155 records

select ProductName, Quantity                -- 165,935 records
from Products, [Order Details] 

select ProductName, Quantity                -- 111,881 records, not null������
from Products as p, [Order Details] as od
where exists (select * from [Order Details] where ProductID = p.ProductID and
                         od.Quantity>12)
-- where 1=1

select ProductName                -- 54,054 records
from Products as p, [Order Details] as od
where not exists (select * from [Order Details] where ProductID = p.ProductID and
                         od.Quantity>12)


--	�ϥ�IN�Ӫ�ܡA���G�P�W�@�d��
select ProductName
from Products
where ProductID in (select ProductID from [Order Details] where Quantity>100)

--�U�C�d�ߨϥ� = ANY�C
select ProductName
from Products
where ProductID = any (select ProductID from [Order Details] where Quantity>100)


--	��X�D 'Mexico' , 'Germany' �a�Ϫ��Ȥ�Ȥ���
select * from orders
select * from Customers

select orderID, CustomerID
from Orders
where CustomerID in 
	(select CustomerID from Customers where Country not in ('Mexico', 'Germany'))


--	�b�l�d�ߤ��ϥ� NULL�A���|�Ǧ^���G��
select CustomerID, CompanyName, [Address]
from Customers
where exists (select null)		-- ������ null ������


