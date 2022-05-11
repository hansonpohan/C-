--	Module 8 - Lab03 �ϥ� DISTINCT

--	�@�Ӹ�ƪ� "�Y�����" ���i��|���h���������O�ۦP�����p�A
--	�b SELECT �d�߻y�k���ڭ̥i�H�ϥ� DISTINCT ����r�L�o���ƥX�{�������ȡC
--	�p�G SELECT DISTINCT �᭱�����w�h�����A�h�n�ŦX�Ҧ���쳣���ƪ����p�U�A
--	�ӵ���Ʀ�~�|�Q�L�o���A�_�h�N���|���o�ӵ���ơC

--	DISTINCT ����r�Ω��^�ߤ@���P���ȡC
--	�b SQL ���O�Ω�d�߬Y����줤�����ƪ���ƭȡC
--	DISTINCT �i�H�Ω�έp : COUNT�BAVG�BMAX etc�K
--	�@�Ӭd�߻y�k�u��ϥΤ@�� DISTINCT ����r�A ������h�� DISTINCT�C

use Northwind;
go

select * from Orders

--	�C�X���~��Ƥ������Ъ� CustomerID ���
select distinct CustomerID from Orders;
go

--	��X���~��Ƥ��@���X�� CustomerID
select count(distinct CustomerID) from Orders;		-- Count uncount NULL
select distinct CustomerID from Orders;					-- Distinct count in NULL 
select count (CustomerID) from Orders;
go

--	�C�X���~��Ƥ������Ъ� CustomerID + ShipName ���
select distinct CustomerID, ShipName from Orders;
go
