 --	Module 9 �򥻸�ƪ��d�߻P�z��
--		9-1 : �ϥ� WHERE �l�y�ӿz����
--		9-2 : T-SQL���B��l���檺�u����
--		9-3 : �ϥ� LIKE �f�t�U�Φr��(Wildcard characters) �� "���r����"

--	�b SELECT �d�߻y�y�ϥ� WHERE ����r�f�t�B��l�ӫ��w���ŦX���󡨪���ơC
--	�]�i�Ω�UPDATE�BDELETE�A�p�G�O UPDATE �A�K�O���w�n��s�����"�C"�C 
--	�p�G�O DELETE�A�K�O���w�n�R������ƦC�C

--	WHERE �l�y�����w�d�ߩҶǦ^����ƦC���j�M����C
--	WHERE �i�H�ϥΦh�ӱ���ӧP�_�һݭn����ơC
--	�i�H�ϥ� AND �� OR �B��l�ӤU�F�h�� WHERE ���� :
--			AND : ���k�����Ҷ��ŦX�C
--			OR : ���k�����ܤֶ��ŦX�@�ӡC
--	�i�H�ϥΤp�A��()�Ӱ����������d�߱���A�p�A���������󦡷|�u���P�_�C
--			�Ҧp : WHERE ����A AND (����B OR ����C)�ASQL�|�u�������B�M����C�� OR �޿�B��A
--			�ұo�X�����G�A�P����A��AND�޿�B��C


-- Lab01 �ϥ� WHERE ����
use Northwind;
go

select * from Customers

--	(1)�ϥ�²�檺����
select CustomerID, ContactName, City
from Customers  
where City = 'Mexico D.F.';   -- �j�p�g�@��

select CustomerID, ContactName, City
from Customers  
where City != 'Mexico D.F.';
--where City <> 'Mexico D.F.';
--where NOT City = 'Mexico D.F.';    -- not prefer


--	(2)�M��ҧt�Ȭ��r�ꪺ�@����
select CustomerID, ContactName,City
from Customers
--where City like ('M%');    -- �r���O M
--where City like ('%M');
where City like ('%M%');

--	(3)�ϥΤ���B��l
select * from Orders

select OrderID, CustomerID, Freight, ShipCity, ShipName
from Orders 
where Freight >10
--where Freight !>10


--	(4)�ŦX�h�ӱ��󤤥���@�ӱ��󪺸�ƦC
select OrderID, CustomerID, Freight, ShipCity, ShipName
from Orders
where Freight > 10 and ShipCity = 'Oulu'

--	(5)�M��ŦX�ƭӱ��󪺸�ƦC
select OrderID, CustomerID, Freight, ShipCity, ShipName 
from Orders 
where Freight > 10 and CustomerID like '%VI%' and ShipName like '%VI%'

--	(6)�M����ȲM�椤����ƦC
select OrderID, CustomerID, Freight, ShipCity, ShipName 
from Orders
where CustomerID in ('VINET', 'TOMSP')
-- where CustomerID ='VINET' or CustomerID ='TOMSP'

--	(7)�M�����ӭȤ�������ƦC
select OrderID, CustomerID, Freight, ShipCity, ShipName 
from Orders 
where Freight between 10 and 20; 

--	��W��(7)�����G�@��
select OrderID, CustomerID, Freight, ShipCity, ShipName 
from Orders 
where Freight >= 10 and Freight <= 20; 



--  �Ч�X Northwind ��Ʈw�� [Order Details] ���`��� (UnitPrice*Quantity)> 1000 �M��






