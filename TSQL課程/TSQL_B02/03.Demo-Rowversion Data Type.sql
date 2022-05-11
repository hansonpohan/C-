--	Module 2   03.Demo - rowversion Data Type.sql
--			timestamp(rowversion) : ������Ƨ�s�۰ʲ��ͪ��ɶ��W�O, �D�n�ΨӴ��ѰO�������s��, 
--						�@��Ʈw���u�঳�@��

--			����������|���}�b "��Ʈw���۰ʲ��ͪ��ߤ@" �G�i��Ʀr�C 
--			rowversion �q�`�Ψӧ@�� "�����W�O��ƪ��ƦC������"�C�o�|�l�ܸ�Ʈw���� "�۹�ɶ�"�A
--							�Ӥ��O���p���������ڮɶ�, �P��������ڮɶ��L�� 
--			�x�s�Ϥj�p�� 8 �줸�աC rowversion ��������u�O�| "���W���Ʀr"�A
--			�]�� "���|�O�d����ήɶ�"�C �Y�n�O������ήɶ��A�Шϥ� datetime2 ��������C
--			rowversion ���A�X������ index �ΥD�� PK , �]���|��

--	Step 1: Open a new query window to the tempdb database
use  LabDB2 ;
go

drop table if exists Orders

--	Step 2: Create and populate a table that uses the rowversion data type
create table Orders ( 
	  OrderID  int  identity (1, 1) ,							       -- identity
	  OrderDate  datetime  not null ,
	  SalespersonID  int  null ,
      CreateTime datetime2 default getdate() not null,  -- default always work on insert, not for update
	  Concurrency  rowversion  not null,                       -- like update time
	 --  timestamp                                                         -- no column name
) ;


--	�Ǧ^�ثe��Ʈw���ثe rowversion / timestamp ��������ȡC 
--  �o�Ӯɶ��W�O�b��Ʈw�������O�ߤ@���C
select  @@dbts ;   -- dbts : time stamp values of db


--	Step 3: Add 2 new rows to dbo.Opportunity
insert Orders (OrderDate)
	values	(sysdatetime())      -- add  6 for OrderDate
go 6

		   
--	Step 4: Show that the "rowversion" column was populated automatically 
select * from  Orders;		   

select  @@dbts ;


-- Step 5: Try to update the rowversion column. This will fail as 
--         you cannot update a rowversion column directly. 
--  Error :  can't update
update Orders										--	�T�� 272�A�h�� 16�A�L�k��s�ɶ��W�O��Ʀ�C
set Concurrency = Concurrency +1
where OrderID =1;


select  @@dbts ;


--	Step 6: Try to insert an explicit value for the rowversion column.
--              This will fail as you cannot insert into a rowversion column directly.

insert Orders ( OrderDate,  Concurrency )				 
	values (sysdatetime() ,  0x00000000000007E7 ) ;    -- Error : can't insert
go 


-- Step 7: Update another column for OrderID 1
select  @@dbts ;

select * from Orders where OrderID = 1;

update Orders
set  SalespersonID = 35 
where OrderID =1;

select * from Orders						-- check :  Concurrency change

select @@dbts, * from Orders ;
