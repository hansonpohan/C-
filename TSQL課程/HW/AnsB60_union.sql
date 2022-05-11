-- �нm�߼��g���U���O�A�ϥ� AdventureWorks.Sales.SalesPerson ��Ʈw
-- ����� BusinessEntityID <=286 �M >=280 ���j�����select
-- �[�� row ���ܤ�

use AdventureWorks ;
go

--	Using UNION ALL : to return all rows from both tables " including duplicates "
select *	 from Sales.SalesPerson
where BusinessEntityID <=286
union all
select *	 from Sales.SalesPerson
where BusinessEntityID >=280


--	Using UNION : to return all rows from both tables " excluding duplicates "
select *	 from Sales.SalesPerson
where BusinessEntityID <=286
union
select *	 from Sales.SalesPerson
where BusinessEntityID >=280


--	Using INTERSECT : to return only rows found in both tables
select *	 from Sales.SalesPerson
where BusinessEntityID <=286
intersect
select *	 from Sales.SalesPerson
where BusinessEntityID >=280


--	Using EXCEPT : to return only rows from left table
select *	 from Sales.SalesPerson
where BusinessEntityID <=286
except
select *	 from Sales.SalesPerson
where BusinessEntityID >=280


--	Reverse position of tables, return only rows from left table
select *	 from Sales.SalesPerson
where BusinessEntityID >=280
except
select *	 from Sales.SalesPerson
where BusinessEntityID <=286
