--	Module 3 02.Lab - Common Table Expressions (CTE).sql

--			�w�٬��q�θ�ƪ�B�⦡ (CTE) ���Ȧs��W���G���C �o�O�q²��d�߭l�ͦӨӡA
--			�Ψӫإ߼Ȧs��ƪ��Ѥl�d�ߨϥΡA��Ӭd�ߨϥΫ�A�ӼȦs��ƪ�N�|�۰�����
--			�w�q�b��@ SELECT�BINSERT�BUPDATE�BDELETE �� MERGE ���z��������d�򤺡C 
--			�z�]�i�H�b CREATE VIEW ���z�����ϥγo�Ӥl�y�A�@���Ψөw�q SELECT ���z�����@�����C 
--			�q�θ�ƪ�B�⦡�i�H�]�A���V�������ѦҡC �o�٬����j�q�θ�ƪ�B�⦡�Ccheck PDF


--		�T�Ӹ�Ʈw���T�����Y 2007, 2008 & Sales.Customer
use AdventureWorks;

--	�ؤ@�Ȧs��ƪ� y8,   y7�]�i�ΦP�˪���k
with y8 (custid, salesamt2008) 
as (select customerID, sum(subTotal)
	from Sales.SalesOrderHeader					--  from SalesOrderHeader 2008
	where year(orderdate) =2008
	group by customerID
)
select * from y8;	-- �����s�b, �å��g�JtempDB, ��Ӭd�ߨϥΫ�A�ӼȦs��ƪ�N�|�۰����� like @table, �i�A����@��

-- �����ŧi @xxxxx �ܼ�

-- Error : ��W select �X�ݷ|�X��
select * from y8			-- ���s�b
go;

--	�ب�ӼȦs��ƪ�c2008, c2007
with y8 (custid, salesamt2008) 
as (select CustomerID, sum(subTotal)
	from Sales.SalesOrderHeader				--  from SalesOrderHeader 2008
	where year (orderdate) =2008
	group by customerID
),
y7 (custid, salesamt2007)  
as (select	customerID, sum (subTotal)
	from Sales.SalesOrderHeader				--  from SalesOrderHeader  2007
	where year (orderdate) =2007
	group by customerid
)
select	c.customerid, c.storeid, y8.salesamt2008, y7.salesamt2007,
			coalesce ((y8.salesamt2008 - y7.salesamt2007) /
							y7.salesamt2007 *100., 0) as PercentGrow
from Sales.Customer as c							-- from Customer and join with 2007 & 2008 by customer ID
left join y8 on c.customerid = y8.custid
left join y7 on c.customerid = y7.custid
order by PercentGrow desc ;
go
