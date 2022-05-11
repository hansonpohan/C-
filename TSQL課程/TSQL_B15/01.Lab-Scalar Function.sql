--	Module 15. �ϥΪ̦ۭq���(UDF) ���]�p�P��@    (User Defined Function)
--		15-1 : �p��إ߯¶q���(Scalar Functions)     
--		15-2 : �p��إߤ��O��ƪ�Ȩ��(Inline TVFs)     
--		15-3 : �p��إߦh���y�y��ƪ�Ȩ��(Multi-Statement TVFs)     

--		�ϥΪ̦ۭq���(UDF) : �������Ʈw���ب�ơA�Ψ����ϥΪ̯�ۦ�w�q����ơA
--		�����Ω��Ʈw�� SQL �ԭz�ιB�⦡
--		UDF���u�I:
--				�i�i��Ҳդƪ��{�����g
--				�W�[����t��
--				���C�����ǿ�q

--		�¶q��� (Scalar-Valued Functions) : ������Ʒ|�Ǧ^ "��@��"�A��ȫ��O
--		���i�� text�Bntext�Bimage�Bcursor �P rowversion(timestamp)


--	01.Lab - Scalar Function.sql
use  LabDB2 ;
go

--  �إ߯¶q���(Scalar Functions)  :  �]�N�O��^�@�ӭȡA���i��O�r��, �ƭ�, datetime
drop function if exists sf_myDate

--	DateAdd �禡�|�N���w�� number ��(�H�a���t������ƧΦ�) 
--	�[���J date �Ȫ����w datepart�A�M��Ǧ^�ӭק�L���ȡC

create function sf_myDate(@myDate as date)
returns date
as
begin   -- ���i���ѱ�
	return DateAdd(year, -10, @myDate)
end		-- ���i���ѱ�

--  check : LABDB2  ��  �i�{����  ��  ���  ��  �¶q�Ȩ��

--  �B�� dbo.sf_myDate �b��Ʈw��
select LastName, FirstName, BirthDate,
			dbo.sf_myDate(BirthDate) as 'BirthDate_10'					-- year -10
from Northwind.dbo.Employees




select dbo.sf_myDate(getdate()) as result		-- �`�N : dbo ���i��
select dbo.sf_myDate('2020-01-05') as result
select dbo.sf_myDate('01/05/2020') as result


-- Step 1 - Open a new query window against the tempdb database.
use  LabDB2 ;
go


-- Step 2 - Create a function
--          Note that SQL Server 2012 now includes a new function
--          for calculating the end of the current month (EOMONTH)

drop function if exists EndOfPreviousMonth

create function EndOfPreviousMonth (@DateToTest date)
returns date
as
begin
	return DateAdd(day, 0 - Day(@DateToTest), @DateToTest);   -- end day of last month
end


-- Step 3 - Query the function. 
select dbo.EndOfPreviousMonth (sysdatetime())   -- dbo ���i��
select dbo.EndOfPreviousMonth ('2016/03/04')   -- dbo ���i��

select eomonth ('02/04/2016')
select eomonth ('2016/02/04')
select eomonth ('2016/02/04', -1)   -- �W�Ӥ�



--	���d�߷|�p����Ӷ��ا馩���檺�`�M
drop function if exists discount_price

create function dbo.discount_price(@price decimal(12, 2), @discount decimal(12, 2)) 
returns decimal (12, 2)
as
begin
	return @price * (1 - @discount/100);
end

select dbo.discount_price(100, 3)  -- (price, %) 


--  �B�� dbo.discount_price �b��Ʈw��
select OrderID, ProductID, UnitPrice, dbo.discount_price(UnitPrice, 3) as '�馩��'   -- 3% off
from Northwind.dbo.[Order Details]


-- Step 4 - Drop the function




