--  Module 10 ��쬰�ŭȮɪ��d���H�αN�d�ߪ����G���H�Ƨ�
--		10-1 : Null Value (�ŭ�)���N�q
--		10-2 : �ϥ� IS NULL �B��l 
--		10-3 : �ϥ� ORDER BY �l�y�N�d�ߵ��G�Ƨ�

--	NULL �O��Ʈw���ϥΪ��S��аO�A�N���O�������ݩʭ� (unknown property value)�C
--	NULL �O�@�ت��A�A���O�Ŧr��(�w��r���Τ������)�A�]���O�s��(�w��ƭ�����)�C
--	�N Null �����Ω��޿�B��O�S���N�q���C����ƭȻP Null �i��B��䵲�G���� Null �C
--  �b WHERE ������P�_�O�_�� NULL �ɡA�Ҧp  WHERE [address]=NULL �O�L�k���T���檺�A
--				�����g�� WHERE [address] IS NULL �άO WHERE [address] IS NOT NULL 


--	Lab01 �d�� NULL , IS NULL �� IS NOT NULL
use Northwind;
go

select 'Won'+null+'derful'				-- NULL is weired

select * from Orders						

--	show Null ���
select OrderID, EmployeeID, CustomerID, Freight, ShipCity, ShipName
from Orders 
--where Freight = null
where Freight is null


--	Null �B�� NULL * NULL = NULL            EmployeeID*Freight
select OrderID, EmployeeID, CustomerID, Freight, ShipCity, ShipName, EmployeeID*Freight
from Orders 


--	Null �r��ۥ[ NULL + NULL = NULL   CustomerID+ShipName
select OrderID, EmployeeID, CustomerID, Freight, ShipCity, ShipName, CustomerID+ShipName
from Orders


--	ISNULL �禡�O�P�_��쪺�ȡA�Y�� Null ���ɡA�i�H�N Null ���N���ۤv�ҭn���ȡC
--	�b���Ʀr�B��ɡA�i�H���P�_���p�G�� Null�A�N�������w�]�� 0�A�A���p��
--	�Ϋ��w���w�]�ȨӥN��NULL
select OrderID, EmployeeID, isnull(EmployeeID, 0) as EmpID, CustomerID, Freight, 
			ShipCity, ShipName, isnull(CustomerID+ShipName, 'info missing')
from Orders


--	COALESCE �|�Ǧ^�B�⦡���Ĥ@�ӫD Null ���ȡA�U�C�|�Ǧ^�ĤT�ӭȡC
--	COALESCE ���޼Ʀܤ֭n���@�ӬO�D Null �`�ƪ��B�⦡�C

--	ISNULL ��ƩM COALESCE �B�⦡�㦳�ۦ����ت��A���B�@�覡���P�C
--	ISNULL �u�|�����@���C COALESCE �|�����h���B�⦡����J�ȡC
--	ISNULL �u������ӰѼơACOALESCE �����ƥؤ��w���ѼơC

select coalesce (null, null, 'third_value', 'fourth_value');

--	Error : COALESCE ���޼Ʀܤ֭n���@�ӬO�D NULL �`�ƪ��B�⦡�C 
select coalesce (null, null, null, null, null);

--	�Ǧ^�B�⦡���Ҧ���줤,�Ĥ@�ӫD Null ����
select OrderID, EmployeeID, CustomerID, Freight, ShipCity, ShipName,
	coalesce (CustomerID,  ShipCity, ShipName) as FirstNotNull_coalesce,  
	isnull (CustomerID, isnull(ShipCity, ShipName)) as FirstNotNull_isnull 
from Orders


--	��Xorders ��ƪ��AEmployeeID is not null �BFreight�p��10�����
select OrderID, EmployeeID, CustomerID, Freight, ShipCity, ShipName
from Orders
where EmployeeID is not null and Freight < 10


--	��X�� shipname ���Ҧ� orders
select OrderID, EmployeeID, CustomerID, Freight, ShipCity, ShipName
from Orders
where ShipName is not null			-- try ShipName != NULL
order by CustomerID                  -- �Ƨ�
