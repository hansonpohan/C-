--	Module 14 �t�Τ��ب����l��ƥH��CASE �B�⦡����
--		14-1 : �ϥ��޿���
--		14-2 : �ŭ�(NULL) �B�z���:ISNULL() vs. COALESCE()
--		14-3 : IIF()�BCHOOSE()�BCASE �B�⦡ 

--		ISNULL �Ϋ��w�����N�ȨӨ��N NULL�C
--				�y�k : ISNULL ( check_expression , replacement_value )

--		COALESCE �̷ӶǤJ�Ȫ����Ķ̌ǧP�_�DNULL���ȡA�öǦ^�Ĥ@�ӧP�_���DNULL���ȡC
--				�y�k : COALESCE ( expression [ ,...n ] )

--		ISNULL�u�|�P�_�@���ACOALESCE �i��|�P�_�h��


--	Lab01 �ŭ�(NULL) �B�z��� : ISNULL()�BCOALESCE() 

use Northwind;
go

select  * from Orders

--	�U�C�d�ҷ|�M��q���ƪ��Ҧ�Freight , ShipVia �ƭȪ��[�v������
--	�|�N Weight �������줤�� 10 �Ө��NNULL
select  avg(isnull(Freight, 10)),  avg(Freight), avg(ShipVia),  avg(ShipVia*1.0), avg(convert(decimal, ShipVia))
from Orders;  

select sum(isnull(Freight, 10)),  sum(Freight), sum(ShipVia), sum(ShipVia*1.0), sum(convert(decimal(10, 2), ShipVia))
from Orders;  


--	�U�C�d�Ҩϥ� ISNULL ���ո�Ʀ椤�� NULL �ȡA�p�G��NULL�N��� 0�C
select Freight, isnull(Freight, 0) as MinPayment, CustomerID, isnull(CustomerID, 0)
from Orders  
--order by CustomerID
order by Freight


--	�U�C�d�ҥܽd COALESCE �Ǧ^�Ĥ@�ӧP�_���DNULL���ȡC
select CustomerID, ShipName, ShipAddress, Freight,
              coalesce (ShipName, ShipAddress) as FirstNotNull,
			  isnull(ShipName, isnull(CustomerID, '000000')) as isnull_func
from Orders 
 