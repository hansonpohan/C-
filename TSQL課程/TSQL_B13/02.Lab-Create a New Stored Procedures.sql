--	Module 13   02.Lab - Create a new stored procedure.sql

--	User-Defined Stored Procedure (�ϥΪ̦ۭq�w�s�{��) : 
--				�ѨϥΪ̦ۭq���w�s�{�ǡA�x�s��� "��Ʈw���i�{���ʶ��ت��w�s�{�Ǥ�"

use LabDB2
go

--  check : LabDB2 �� �i�{���� �� �w�s�{�� 

--  Create Proc Proc_A
drop proc if exists Proc_A

create procedure Proc_A
as
select * from Northwind.dbo.Employees


select * from sys.procedures
select object_definition (object_id('Proc_A')) as Obj_def

exec Proc_A			--	check : LabDB2 �� �i�{���� �� �w�s�{�� �� dbo.Proc_A



--  Create Proc Proc_B
drop proc if exists Proc_B			--	�R���w�s�{��

--	���]�w nocount on �ɴN�i�H���� SQL Server �^�� ���� "�T��" ����ƪ��欰�A
--	�o�˹�į�|���������ﵽ�A�]���������ǿ�q�|���C���֡C
create proc Proc_B
as
set nocount on					
select * from Northwind.dbo.Employees

exec Proc_B


-- Alter Proc
alter proc Proc_B				--	�ק�w�s�{��
as 
select * from Northwind.dbo.Employees where TitleOfCourtesy = 'Ms.' 

exec Proc_B


exec sp_helptext 'Proc_A'
exec sp_helptext 'Proc_B'

select * from sys.sql_modules where object_id =object_id ('Proc_A')
select * from sys.sql_modules where object_id =object_id ('Proc_B')

drop proc if exists Proc_A, Proc_B



-- �ҤG

-- Step 1: Open a new query window to the AdventureWorks database
select * from AdventureWorks.Production.ProductReview
select * from AdventureWorks.Production.Product

-- Step 2: Create a new stored procedure:  Production.GetReviews 
 --             that gets reviews for all products.


drop proc if exists GetReviews

create proc GetReviews
with encryption						-- �[�K
as
select p.ProductID, p.Name, pr.ReviewDate, pr.ReviewerName, pr.Rating, pr.Comments
from AdventureWorks.Production.ProductReview as pr
join AdventureWorks.Production.Product as p
on p.ProductID = pr.ProductID
order by p.Name, pr.ReviewDate


-- Step 3:Test stored procedure

exec GetReviews

-- Step 4: Query sys.procedures to see the list of procedures
select * from sys.procedures


-- Step 5-1: Query the definition of the stored procedure.
exec sp_helptext 'GetReviews'


-- Step 5-2: Query the definition of the stored procedure.
select * from sys.sql_modules
where object_id = object_id('GetReviews')

-- Step 5-3: Query the definition of the stored procedure.
select object_definition (object_id('GetReviews')) as Obj_def


-- Step 6: Drop the stored procedure
drop proc if exists GetReviews
