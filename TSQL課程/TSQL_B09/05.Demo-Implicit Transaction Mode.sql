--	Module 9    05.Demo - Implicit Transaction Mode.sql

--			�u�� �� �ﶵ �� �d�߰��� �� SQL Server �� ANSI  ��  Set_Implicit_Transaction�A
--			�z�LSet IMPLICIT_TRANSACTIONS ON��OFF���覡�ҰʻP�������t����A
--			���Ʈw�i�J���Ҧ����}�l����K TRANCOUNT=1�A"�������COMMIT TRAN
--			��ROLLBACK Tran���O"�A�۰ʶi��U�ӥ��

-- Step 1 - Open a query window to the tempdb database
use  LabDB2 ;
go


-- Step 2 - Create and populate a test table
select * from NewTable ;
go

select  @@trancount  as  Tran_Count ;

-- Step 3 - Setting Implicit Transaction Mode �� ON

set implicit_transactions on
select  @@trancount  as  Tran_Count ;

-- Step 4 : 
select * from NewTable ;
select  @@trancount  as  Tran_Count ;


-- Step 5 : 
rollback tran
select  @@trancount  as  Tran_Count ;


-- Step 6 : 
insert NewTable values (100, 'ddd') 
select * from NewTable ;
select  @@trancount  as  Tran_Count ;



-- Step 7 : either rollback or commit 
rollback tran
select  @@trancount  as  Tran_Count ;
select * from NewTable ;

commit  transaction ;
select  @@trancount  as  Tran_Count ;
select * from NewTable ;

--	�Y���ʥ���@�� ON, �@����insert, update �o��, ��Ʈw�|�@���Q�����commit �o��

set implicit_transactions off
--	drop table if exists NewTable