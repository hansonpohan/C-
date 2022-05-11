--	Module 15.   02.Lab - Inline TVF.sql
--			���O��ƪ�Ȩ��(Inline TVFs) Table-valued Function
--			�P�˵��� (VIEW) �Q���ۦ� (�t�O�b TVF �i�ǰѼ�,  �a���Ѽƪ� VIEW)

--			���O��ƪ�Ȩ��(Inline TVFs) : ������Ƥ��e�ȷ|����@ Select  �ԭz�A
--						��^�ȫ��O�� "SELECT ���d�ߵ��G"�A�]�٬� "�椺��ƶ����"

use  LabDB2 ;
go

--  Example 1
drop function if exists fn_SaleInYear

create function dbo.fn_SaleInYear(@SalesYear int)
returns table																-- return table
as
return  select * 
			from Northwind.dbo.Orders
			where year(OrderDate) =@SalesYear 

--  check : LABDB2  ��  �i�{����  ��  ���  ��  ��ƪ���
select * from dbo.fn_SaleInYear(1996)


-- Example 2
drop function if exists fn_SalesStoreBySalesID

create function dbo.fn_SalesStoreBySalesID (@SalesPersonID int )
returns table
as
return	select top(3) SalesPersonID, BusinessEntityID, Name
			from AdventureWorks.Sales.Store
			where SalesPersonID = @SalesPersonID				--  @SalesPersonID
			order by name desc													-- order by name

select * from dbo.fn_SalesStoreBySalesID(279)			-- 279, 282, 286
