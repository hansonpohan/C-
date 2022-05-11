--	Module 9 - Lab03 �ϥ� like �f�t�U�Φr��(Wildcard characters)�Ӥ��r����

-- �P�_�S�w�r���r��O�_�ŦX���w���Ҧ��C �Ҧ����i�H�]�t�@��r���θU�Φr���C 
-- �b�Ҧ��������A�@��r�������P�r���r�ꤤ�ҫ��w���r�������۲šC 
-- ���L�A�U�Φr���i�H�ŦX���N�r���r����q�C �ϥθU�Φr���n��ϥ� = �P != �r��
-- ����B��l���� LIKE �B��l�󦳼u�ʡC �p�G������@�Ӥ޼Ƥ��O�r���r���������A
-- SQL Server Database Engine �|�N���ഫ���r���r�������� (�Y�i�઺��)�C

use Northwind;
go

-- ��X CustomerID �� V�r���}�Y���Ȥ�
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
 where CustomerID like 'V%'
--where CustomerID like 'V____'   -- ���w 5 �Ӧr��
--where CustomerID like 'V___T'   -- ���w 5 �Ӧr��


select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
--where CustomerID like '%V'
where CustomerID like '____V'     -- ���w 5 �Ӧr��


select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '%V%'


-- ��X CustomerID  �̫�2�Ӧr���� sp ���Ȥ�
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '%sp'

-- ��X CustomerID ����2�Ӧr���� an ���Ȥ�
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '%an%'

-- ��X CustomerID ��1�Ӧr���� abc �����@�r�����Ȥ�
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '[a-c]%'  -- a to c

select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '[ac]%'   -- a or c

-- ��X CustomerID ��1�өM��2�Ӧr���� abc �����@�r�����Ȥ�
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '[a-c][a-c]%'

-- ��XShipPostalCode�}�Y��1��3��order
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where ShipPostalCode like '[1-3]%'

-- ��XShipPostalCode�}�Y��1��2,�B��2�ӼƦr��0��1��order
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where ShipPostalCode like '[1-2][0-1]%'


-- ��X CustomerID ��1�Ӧr�����O�� t~v �����@�r�����Ȥ�
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where CustomerID like '[^t-v]%'


-- ��X ShipPostalCode �}�Y���O51��order
select OrderID, CustomerID, Freight, ShipCity, ShipName, ShipPostalCode
from Orders 
where ShipPostalCode not like '51%'


-- �ϥ� ESCAPE �l�y �j�M�]�t�U�Φr�����r��
--	�U�Φr��
--		%		����t���s�Φh�Ӧr�����r��C
--		_      �����@�r���C
--		[ ]		�b���w�d�� ([a-f]) �ζ��X ([abcdef]) ���������@�r���C
--		[^]    ���b���w�d�� ([^a-f]) �ζ��X ([^abcdef]) ���������@�r���C

--	�{���X���� ESCAPE �l�y�A�ҫ��w���r���O !�]��ĸ��^�A��ܻ��A
--	�b LIKE �l�y���� ! ���᪺���Ӧr���]�]�N�O %�^�N�Q�����O�@�ӱ`�ƪ��r����ơA
--	�Ӥ��O�U�Φr���C

select 1 where 'AB30%CDE' like '%%%'                         -- �r���� %
select 1 where 'AB30%CDE' like '%40%%'                     -- �r���� 40%
select 1 where 'AB30%CDE' like '%30!%%' escape '!'    -- �r���� 30%, �����n�� !

-- ���n�z�| escape �᭱���r
select 1 where '^ABCDE' like '!^aBCDE' escape '!'; 
select 1 where '-ABCDE' like '!-ABCDE' escape '!'; 
select 1 where ']ABCDE' like '!]ABCDE' escape '!';  
select 1 where '%ABCDE' like '\%ABcDE' escape '\'; 
select 1 where '%ABCDE' like '!%ABCDE' escape '!'; 
select 1 where '%ABCDE' like '#%ABCDE' escape '#'; 
select 1 where '%ABCDE' like '@%ABCDE' escape '@';  
select 1 where '[ABCDE' like '![ABCDE' escape '!'; 
select 1 where ']ABCDE' like '!]ABCDE' escape '!'; 

