 --  Module 3 �Ȧs��ƪ�(Temporary Table)�P�q�θ�ƪ�B�⦡
--				(Common Table Expressions,CTE)���ϥ�
--				3-1: �ϰ�Ȧs��ƪ�(Local Temporary Tables)
--				3-2: ����Ȧs��ƪ�(Global Temporary Tables)
--				3-3: �ϥγq�θ�ƪ�B�⦡(Common Table Expressions)

--		�ΨӴ����{�ɩʻݨD�ϥΩҲ��ͪ���ƪ�, �O����s�b�� tempdb�A

--		�Ȧs�� [#Table]
--			�i�إ߯���(index)�A��SQL Server�����ɡA#Table�|�۰�DROP�A���̦n�ۤv���DROP�C

--		�Ȧs�� [##Table]
--			## ��̧��btempdb��Ʈw���إ߰_��ƪ�(�s��DISK��)�A�i�Q�� DROP TABLE �R���Ȧs��ƪ�A
--			�άO�إ߸ӼȦs��ƪ� "�s�u����" �ɡASQL Server �|�۰ʱN��R���C��̪��t���b��A
--			#Table�u���إߪ̥i�H�ϥΡA��L�H���i�ϥ�(��L��Ʈw)�A
--			��##Table�h�O "����" ����ƪ�A�Ҧ��H���i����(��L��Ʈw�]�i�ϥ�)�C

--		�Ȧs���ܼ� [@Table]
--			�٬���ƪ��ܼơA�N��ƪ��@�O�@���ܼƨӨϥΡA��妸���O���槹����Y�۰ʱq�O���餤�Q�R���C
--			@Table �P #Table & ##Table���t���b��A�e�̤��ݨϥ�DROP���O�A�������O���槹��|�۰ʳQ�R���F
--			��̥i�ϥ�DROP�άO�ݳs�u������Ȧs��~�|�����C


--	01.Lab - Temporary Tables.sql : ��u�@���q���_��, �R����ƪ�

--	create �@Local Temporary��ƪ�
use LabDB2

create table #Customer (					
	CustomerID	int,
	CustomerName nvarchar(12),
	Address nvarchar(100)
);

insert #Customer 
values(1, 'Apple', 'Taiwan, Taipei')

select * from #Customer


--	insert into �@Local Temporary��ƪ�
select * into #Department				
from AdventureWorks.HumanResources.Department ;
go

select * from #Department


--Global Temporary Tables

--	create �@Global Temporary��ƪ�
create table ##Customer(				
	CustomerID	int,
	CustomerName nvarchar(12),
	Address nvarchar(100)
);
insert ##Customer values(1, 'Apple', 'Taiwan, Taipei')
select * from ##Customer


--	insert into �@Global Temporary��ƪ�
select * into ##Department
from AdventureWorks.HumanResources.Department ;
go
insert ##Department						
values ('Test', 'Test', getdate());
go

select * from 	##Department	;
go



--  Demo --

use AdventureWorks;

select * from Sales.SalesOrderHeader

--	2007�~�Ȥ�[�`�ʶR���B
select customerID, sum(subTotal) as sum2007 into #yr2007   --  select into
from Sales.SalesOrderHeader
where year(orderdate) =2007
group by CustomerID

select * from #yr2007

--	2008�~�Ȥ�[�`�ʶR���B
select customerID, sum(subTotal) as sum2008 into #yr2008
from Sales.SalesOrderHeader
where year(orderdate) =2008
group by CustomerID

select * from #yr2008
select * from #yr2007

--	#yr2007 full join #yr2008, �� storeID �b SalesCustomer DB ��
select	y7.CustomerID, y8.sum2008, y7.sum2007,
			coalesce ((y8.sum2008 - y7.sum2007) /	y7.sum2007 *100., 0) as percentgrow
from #yr2007 as y7
full join #yr2008 as y8 on y7.CustomerID = y8.CustomerID    -- 18691 records
where y7.CustomerID is not null and y8.CustomerID is not null
--order by y7.CustomerID     
order by percentgrow desc


--	#yr2007 join #yr2008 join SalesCustomer ���o storeID, 
--		�� store Name �b Sales.Store ��......  storeid in Sales.Customer table
select	c.CustomerID,	c.StoreID, y8.sum2008, y7.sum2007,
			coalesce ((y8.sum2008 - y7.sum2007) /	y7.sum2007 *100., 0) as percentgrow
from Sales.Customer as c                       -- from Customer and join with 2007 & 2008 by customer ID
right join #yr2008 as y8 on c.customerid = y8.CustomerID
right join #yr2007 as y7 on c.customerid = y7.CustomerID
where c.CustomerID is not null and c.StoreID is not null
order by c.customerid, c.storeid ;


--	@Table �ܼ� :
--		�إߪ��y�k�������{�� @Table�A�ϧO�N�b��إߪ��ɭԡA�����n�����R�W�C
--		@Table�ܼƬO�ܼƪ��@�ءA@Table�ܼƤ]���������Υ��쪺��ءA
--		����Table�ܼƪ��W�ٳ��O�H��@�������X�A�u���b������e���Τ�s�����~�i�H�X�ݡC
--		���쪺Table�ܼƪ��W�ٳ��O�H��@@�������X�A�@�볣�O�t�Ϊ��`���ܼơA���ڭ̱`�Ψ쪺�A
--		�p@@Error�NTable���~�����A@@RowCount�NTable�v�T����ơC

declare @Customer table (			-- �ܼ� @Customer table ���A�O�¶q��;  like create table
	CustomerID	int,
	CustomerName nvarchar(12),
	Address nvarchar(100)
)
insert @Customer values(1, 'Apple', 'Taiwan, Taipei')
select * from @Customer

--	Error : �P declare �@���ܼƤ@��, ��W select �X�ݷ|�X��
select * from @Customer				-- �����ŧi��ƪ��ܼ� "@Customer"


--	@@Table �ܼ� :
declare @@Customer table (
	CustomerID	int,
	CustomerName nvarchar(12),
	Address nvarchar(100)
)
insert @@Customer values(1, 'Apple', 'Taiwan, Taipei')
select * from @@Customer

--	Error : �P declare �@���ܼƤ@�� ��W select �X�ݷ|�X��
select * from @@Customer			-- �����ŧi��ƪ��ܼ� "@@Customer"


