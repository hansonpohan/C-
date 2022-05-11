--	Module 14 - Lab02 IIF()�BCHOOSE()�BCASE �B�⦡
--			MSSQL ��������޿���- CHOOSE �M IIF
--			�޿��ƬO�ھڶǤJ���޿�P�_����ӧP�_�A�p�G�ŦX�N�Ǧ^�������ƭ�
--			�޿��ƶǤJ���O�P�_����Ӥ��O�ƭ�
--			�޿��ƥi�H���� CASE �B�⦡��²�ơC

--	IIF ��Ʒ|�ھڲĤ@�ӥ��L�B�⦡���P�_�ӨM�w�^�� true_value �� false_value�C

--	CHOOSE ��Ʒ|�ھڶǤJ�����ޭȨӶǦ^���w�����ظ�ơC
--			index : ��ܥH 1 ���򩳤����زM�椤����Ư��ޡC
--			�p�G���w�� index �W�L���زM�檺�ƭȰ}�C�W���A�|�^��NULL�C
--			CHOOSE �@�������}�C�������ޡA�䤤���}�C�O�ƭȲM��Ҳզ��C

--  CASE �B�⦡����خ榡�G
--			²�檺 CASE �B�⦡�|����B�⦡�M�@��²��B�⦡�ӱo�X���G�C
--			�j�M CASE �B��|�����@�ե��L�B�⦡�ӱo�X���G�C

--	IIF �ܽd
declare @x int = 500, @y int = 100;  
select iif ( @x > @y, 'TRUE_Value', 'FALSE_Value' ) as result;  

--	Error :�@�^�ǿ��~�ACASE �W�椤�����G�B�⦡�ܤ֭n���@�ӬO NULL �`�ƥH�~���B�⦡�C
select iif ( 45 > 30, null, null) as result;  

--	�p�G�u�ݭn���G�����P�_,�ϥ�IIF��²��T-SQL�ԭz��
declare @bool bit = 0;
select 
	case @bool
		when 0 then '�k'
		when 1 then '�k'      -- select '�k'
	end;

declare @bool bit = 1;
select iif (@bool = 0, '�k', '�k');
select iif (@bool = 1, 'False', 'True');

--	�G�����P�_ in database
select * from [Order Details]

select *, iif(UnitPrice>10,  '�j��10',  ' ' )
from [Order Details]
--order by UnitPrice desc


--	CHOOSE : SQL Server 2012 �H�᪺�����A���ѤF CHOOSE �s���޿��Ӱ��o�ؤG���H�W���޿�P�_
select choose(3, 'Manager', 'Director', 'Developer', 'Tester' ) as result;

select choose(0, 'Manager', 'Director', 'Developer', 'Tester' ) as result; 
select choose(5, 'Manager', 'Director', 'Developer', 'Tester' ) as result; 

--	�U�C�d�ҷ|�ھ� EmployeeID �Ǧ^²�檺�r���r��C
use Northwind;
go

select * from Orders

select CustomerID,  EmployeeID, EmployeeID%5,
       choose (EmployeeID%5, 'A', 'B', 'C', 'D') as EmpID_Level    -- 0 : NULL
from Orders;  


--	�U�C�d�ҷ|�Ǧ^���έ��u���u�`�C MONTH ��ƥΩ�q HireDate ��Ʀ�Ǧ^������ȡC  */
select CustomerID,  ShipCity, OrderDate,
       choose(month(OrderDate), 'Winter', 'Winter',  'Spring', 'Spring', 'Spring', 'Summer', 'Summer',   
									'Summer', 'Autumn', 'Autumn', 'Autumn', 'Winter') as QuarterShip
from Orders 
where  year(OrderDate) >= 1997 
order by year(OrderDate) asc;  


--	�U�C�d�ҧQ�� CASE �B�⦡���ܧ󲣫~���O�ؿ�����ܤ覡�A�ϥ��̧�e���F�ѡC
select * from Orders

select CustomerID, ShipVia, ShipViaCategory =  
	case  ShipVia
		when '1' then 'Road'  
        when '2' then 'Mountain'  
        when '3' then 'Touring'  
        else 'No via'						-- choose �i��L�k�B�z
     end
from Orders  
order by ShipVia;  
go  

--  same as following
select CustomerID, ShipVia,
			choose (shipVia, 'Road', 'Mountain', 'Touring' , 'No via') as ShipViaCategory
from Orders  
order by ShipVia;  
go  

--	�j�M�� CASE �B�⦡���\�H����Ȭ���¦�Ө��N���G��������
--	�U�C�d�ҥH���~������d�򬰰�¦�A�N�л���ܬ���r���ѡC

select CustomerID, ShipName, ShipAddress, Freight, "PriceRange" =   
	case   
         when Freight =  0  then 'no Freight'  
         when Freight < 10 then 'Under $10'  
         when Freight < 20 then 'Under $20'  
         when Freight < 30 then 'Under $30'  
         else 'Over $30'  					-- choose �i��L�k�B�z
      end  
from Orders  
order by CustomerID, Freight ;  
go  


--	����ϥ�CASE�B�⦡��CHOOSE���(²��) 
declare @qq int = datename(quarter, '2020-10-18');
select @qq,
	case 
		when @qq = 1 then '�Ĥ@�u'
		when @qq = 2 then '�ĤG�u'
		when @qq = 3 then '�ĤT�u'
		when @qq = 4 then '�ĥ|�u'
	end;
go

-- (²��)
declare @qq int = datename(quarter, '2020-10-18');
select choose (@qq, '�Ĥ@�u', '�ĤG�u', '�ĤT�u', '�ĥ|�u');
go


