--	Module 17 - Lab02 SELECT�ԭz���i���d��
--	�ϥ� TOP �H�� OFFSET-FETCH �ӿz����

--	�ϥ� OFFSET �M FETCH �i�H����Ǧ^����ƦC�A�i�H�L�o�z��S�w�d�򪺸�ƦC�C
--	OFFSET-FETCH �O�t�X ORDER BY �l�y�������\��C
--	OFFSET �M FETCH �l�y�O�̾� ANSI�зǡA�ҥH��TOP����n���ۮe�ʡC
--	OFFSET �i�H���w���L��ơC	FETCH �i�H���w�ݭn���X����Ƽƶq�C


use Northwind;
go

select * from Orders

--	�Ǧ^�H ShipCity �Ƨǫ᪺�e20�ӭq��
select top (20) ShipName, ShipAddress, ShipCity  
from Orders 
order by ShipCity;  


--	�Ǧ^�H ShipCity �Ƨǫ᪺�e 20% �q��
select top (20) percent ShipName, ShipAddress, ShipCity  
from Orders 
order by ShipCity;


--	�Ǧ^�Ҧ����q����
select ShipName, ShipAddress, ShipCity  
from Orders 
order by ShipCity;


--	�ϥΤl�y OFFSET 100 ROWS ���L�e 100 ����ƦC
select ShipName, ShipAddress, ShipCity     -- try top 20/ 5 percent
from Orders 
order by ShipCity 
offset 100 rows;


--	�ϥΤl�y OFFSET 0 ROWS �q�Ĥ@�Ӹ�ƦC�}�l�A
--	�M��A�ϥ� FETCH NEXT 10 ROWS ONLY�A�N�Ǧ^����ƦC����b�w�Ƨǵ��G����10����ƦC�C

select * from Orders

select  row_number() over(order by orderid) as RowNo, orderid, ShipName, ShipAddress, ShipCity     -- try top 20/ 5 percent
from Orders 
order by ShipCity 
offset 10 rows 
fetch next 100 rows only; 

--	�H�U�d�Ҩϥ� OFFSET �M FETCH �l�y�A�ӹ�@�d�ߪ�����
--	�ŧi3���ܼ� @Pages(����)�B@PageSize(�C������)�B@RowNumber(��N����ƶ}�l)
--	�i�H��ʫ��w@Page�Ȭ� 1~10(�`���Ƭ�830)
--	�ϥ� @RowNumber = ((@Pages-1)*@PageSize) + 1 �B�⦡�ӫ��wOFFSET��

declare		@Pages int = 80, @PageSize int = 10,  @RowNumber int;
set @RowNumber = ((@Pages-1)*@PageSize) + 1; -- ((80-1)*10)+1=791

select  ShipName, ShipAddress, ShipCity
from Orders 
order by ShipCity 
	offset @RowNumber - 1 rows 
 	fetch next @PageSize rows only;


-- �ϥ� OFFSET �M FETCH
-- �̾ڤ���ƧǡA���O���L�e 10 ����ƦC�A�A�� 10 ����ƦC�F�]�N�O���G�̾ڤ���ƧǡA
-- ���Ȭd�߲� 11 �� 20 ������ƦC�C
use Northwind

declare @offset tinyint =10, @fetch tinyint =10
select OrderID, CustomerID, EmployeeID, OrderDate
from Orders
order by OrderDate desc
offset @offset rows
fetch next @fetch rows only

