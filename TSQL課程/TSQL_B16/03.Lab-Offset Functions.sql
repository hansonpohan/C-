 --  Module 16.    03.Lab - Offset Functions.sql


use AdventureWorks
go

select * from Sales.SalesPersonQuotaHistory

--  LAG �|���ѹ��ثe��ƦC���e���w����첾����ƦC���s���C 
--			�b SELECT ���z�����ϥγo�Ӥ��R��ơA����ثe��ƦC�����ȻP�e�@�Ӹ�ƦC�����ȡC
--	LAG(): ���o�ثe��ƪ��e����Ƭ������Ѥ�蠟��,  �Ҧp����S�v

select	BusinessEntityID, QuotaDate, year(QuotaDate), SalesQuota,
			lag(SalesQuota, 1, 0) over (order by (QuotaDate)) as PreSalesQuota,
			SalesQuota-lag(SalesQuota, 1, 0) over (order by (QuotaDate))
from Sales.SalesPersonQuotaHistory
where BusinessEntityID = 280 and year(QuotaDate) in ('2006', '2007', '2008')



-- LEAD �b���H�ثe��ƦC���w���w���� "�첾" ���A���Ѧs����ƦC�C 
--		�b SELECT ���z�����ϥγo�Ӥ��R��ơA����ثe��ƦC�����ȻP�U�C��ƦC�����ȡC
--	LEAD() : ���o�ثe��ƪ��᪺��ƦC���Ѥ�蠟��
select	BusinessEntityID, QuotaDate, year(QuotaDate), SalesQuota,
			lead(SalesQuota, 1, 0) over (order by (QuotaDate)) as PostSalesQuota,
			lead(SalesQuota, 1, 0) over (order by (QuotaDate)) - SalesQuota
from Sales.SalesPersonQuotaHistory
where BusinessEntityID = 280 and year(QuotaDate) in ('2006', '2007', '2008')


---------------------- first compare with previous record, cheaper ----------------------------------
select * from Production.Product

select ProductSubcategoryID, name, ListPrice
from Production.Product
where ProductSubcategoryID = 17
order by ListPrice


--	FIRST_VALUE(): �Ǧ^�w�Ƨǭ� "����" ���Ĥ@�ӭȡC
select ProductSubcategoryID, name, ListPrice, 
			First_value(name) over (order by ListPrice asc) as cheap
--			First_value(name) over (order by ListPrice desc) as expansive
from Production.Product
where ProductSubcategoryID = 17
order by ListPrice
------------------------------------- subcategory cheap---------------


select ProductSubcategoryID, name, ListPrice, 
			First_value(name) over (partition by ProductSubcategoryID order by ListPrice asc) as Cate_cheap,
			First_value(name) over (partition by ProductSubcategoryID order by ListPrice desc) as Cate_expensive
from Production.Product
where ProductSubcategoryID is not null
order by ProductSubcategoryID, ListPrice


--	LAST_VALUE() : ���o��ƪ�Ƨǭ� "��" ���̫�@�ӭ�
--  �Ƨǫ᪺��Ƨڭ̹w�]�n���X�q�Ĥ@����ثe�ڳo�@���A
--  �ҥH�� FIRST_VALUE �S���[�J RANGE ���󪺮ɭԡA�]���|�q�Ĥ@�����A�ҥH�S�����D�C
--  �� LAST_VALUE �S���[�J RANGE�A�w�]�N�O�q�Ĥ@�����ӵ���ơA�ҥH�ݰ_�ӷ|��ۤv�P�˪��ȡC
--  �������A�p�G�[�J RANGE ����q�ثe�ڳo�@����ƨ���̫�@�����ɭԡA
--  �h FIRST_VALUE �X�Ӫ��ȴN�|���� LAST_VALUE �S���[�J RANGE �����p�F�C�]���W�z���y�k�|�o��H�U�����G�C
select ProductSubcategoryID, name, ListPrice, 
			Last_value(name) over (order by ListPrice 
													range between unbounded preceding and 
													unbounded following) as expensive
from Production.Product
where ProductSubcategoryID = 17
order by ListPrice



select ProductSubcategoryID, name, ListPrice, 
			Last_value(name) over (partition by ProductSubcategoryID order by ListPrice
													range between unbounded preceding and 
													unbounded following) as expensive
from Production.Product
where ProductSubcategoryID is not null
order by ProductSubcategoryID, ListPrice