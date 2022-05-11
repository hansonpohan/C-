 --	Module 18. Ĳ�o�{��(DML Triggers)���i���[���B�]�p�P��@    
 --		18-1:�p��إ� INSTEAD OF Triggers     
 --		18-2:�ϥ� UPDATE() ��ƨӧP�_���ȬO�_�Q�ק�    
 --		18-3:�_��Ĳ�o�{��(Nested Triggers) ���B�@�覡�Ψ�`�N�ƶ�    

--			INSTEAD OF Ĳ�o�{�� : �i�Ψ��d�I�P���N���w�ާ@�A�]Ĳ�o�����O�ä��|�Q
--			����A�]���ݭn INSTEAD OF Ĳ�o�{�� "���N" ����O����ާ@�A�i�Ω� VIEW (��
--			����)�A�P�@�Ӹ�ƪ���˵���u��w�q�C�@�� INSERT�BUPDATE �P DELETE
--			���O�U�@�� INSTEAD OF Ĳ�o�{��

--  01.Lab - INSTEAD OF Trigger.sql

-- Step 1: Open a new query window and use the tempdb database
use  LabDB2 ;


drop table if exists CurrentPrice		-- drop table, drop trigger at the same time

-- Step 2: Create and populate the dbo.CurrentPrice table 
--              Note the additional ��IsValid�� column
create table CurrentPrice (
	CurrentPriceID  int, --identity (1, 1), 
		--constraint PK_CurrentPrice  primary key ,
	SellingPrice  decimal(18, 2)  not null ,
	ModifiedDate  datetime2  default sysdatetime() ,
	CreatedDate  datetime2  default sysdatetime() ,
	ModifiedBy  sysname  not null default original_login(),  -- �q���W��
	IsValid  bit  not null default 1									-- Add additional ��IsValid�� column
) ;


-- Populate the table
insert CurrentPrice (CurrentPriceID, SellingPrice)
	values (1, 2.3) ,  (2, 4.3) ,  (3, 5) ;


-- Select the current rows
select * from CurrentPrice ;

drop trigger if exists tg_CurrentPrice_Instead_of_Delete

-- Step 3: Create the trigger for INSTEAD OF DELETE
create trigger tg_CurrentPrice_Instead_of_Delete
on CurrentPrice
instead of delete				-- ��J�� delete �N�ন begin ...... end �������{��
as
begin
	set nocount on;
	update cp set cp.IsValid= 0,
				cp.ModifiedDate = sysdatetime()
	from CurrentPrice as cp
	inner join deleted as d
	on cp.currentPriceID = d.CurrentPriceID;
end


-- Step 4: Try to delete a row
--              Note the number of rows shown as being affected 
--              and that no errors are returned

select * from CurrentPrice
delete  CurrentPrice where  CurrentPriceID = 1 ;


-- Step 5: Requery the table and note that row 2 is still 
--              there but now "update" instead of "deleted"
select * from CurrentPrice ;


-- Step 6: Query sys.triggers and note the value in 
--              the ��is_instead_of_trigger�� column
select object_name(parent_id), object_name(object_id), * from sys.triggers;



-- �ҤG
 -- �p�G insert ����Ƥw�g�s�b table ��, �N�ন update ���, �_�h�N insert 
drop trigger if exists tg_CurrentPrice_Instead_of_Insert

create trigger tg_CurrentPrice_Instead_of_Insert
on CurrentPrice
Instead of Insert
as
begin
      if exists (select * from CurrentPrice 
					where CurrentPriceID = (select CurrentPriceID from inserted)) 
	      begin 
	          update CurrentPrice set CurrentPrice.SellingPrice = inserted.SellingPrice 
		      from CurrentPrice
			  join inserted
              on CurrentPrice.CurrentPriceID = inserted.CurrentPriceID
			  print 'update success instead of insert'
	      end;
      else
	     begin
		     Insert into CurrentPrice (CurrentPriceID, SellingPrice, IsValid)-- values (inserted.CurrentPriceID, inserted.SellingPrice)
			 select CurrentPriceID, SellingPrice, IsValid from inserted
			 print 'insert success'
		 end
end;
 
insert CurrentPrice (CurrentPriceID, SellingPrice, IsValid) values(2, 28.6, '1')

select * from CurrentPrice;



-- Drop the table (and with it, the trigger)
drop table if exists CurrentPrice ;


--	�_��Ĳ�o�{��(Nested Triggers) ���B�@�覡�Ψ�`�N�ƶ�

--  �Y TableA ���� AFTER Trigger �|�h��� TableB ������ơA
--	�� TableB �]���� Trigger �|�h��� TableA ������ơA�o�ر��p�٬��_�� AFTER Ĳ�o�{�ǡC 
--	�_�� AFTER Ĳ�o�{�ǳ̦h�u�|���� 32 ���A����N�|����C

exec sp_configure 'nested triggers'    --�d�߳]�w
