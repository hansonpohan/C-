--	Module 9   01.Demo-2 - SavePoint.sql

--  �x�s�I���ѤF�_�쳡�����������C �b SQL Server ���A
--	�z�i�H�ϥ� SAVE TRANSACTION savepoint_name ���z���ӫإ��x�s�I�C 
--	�y��A�z�i�H���� ROLLBACK TRANSACTION savepoint_name ���z���Ӧ^�_���x�s�I�A
--	�Ӥ��O�^�_�����}�l�C


-- Step 1 - Open a query window to the tempdb database
use  LabDB2 ;
go

select * from NewTable
insert NewTable values (5, 'ccc') ;


-- Step 3 - Now try the same in a transaction
--	Explicit Transaction Management Mode ***/
begin tran ;
	update NewTable  set  Info = 'Update 2' where  ID = 2 ;

	save tran  savepoint_test ;						--�b������]�w���x�s�I(savepoint)
 
	update NewTable set  info = 'Update 3' where   ID = 3 ;

	select * from NewTable ;			-- Update 2,  Update 3
	select @@trancount ;  -- 1
--  run to here first ------------
	rollback tran  savepoint_test ;		-- �u�� Update 2, ���� commit
commit tran ;	


select * from NewTable ;
select @@trancount  ;  -- 1

rollback tran  ;

select * from NewTable ;
select @@trancount  ;  -- 0

--	1. ����ӫO���קK��ƳB��@�ؤ��X�z���������A
--		�Ҥl�GA�׿���B�AA�b��|��֦s�ڡBB�b��|�W�[�s�ڡA����̪���������P�ɦ��\�A
--		�ΦP�ɥ��ѡA����s�b�u���@�誺�b����B���ܰ�(���X�z���������A)�A
--		�Q�Υ��������i�H�ѨM�o�Ӱ��D�C


-- �ҤG **********************************************************
select * from NewTable ;

print @@trancount				-- 0
begin tran
	print @@Trancount
	-- update NewTable  set  Info = 'Update 2' where  ID = 2
	Insert NewTable values(8, 'insert 8');	

	begin tran 
		print @@Trancount
		Insert NewTable values(9, 'insert 9');
		select * from NewTable		-- yes,  'inert 8' and 'inert 9' existed
	commit tran;
--  commit tran;    -- this one not commit yet.  @@Transcount = 1
print @@Trancount

rollback tran;
print @@Trancount

select * From NewTable		--  'inert 8' and 'inert 9' ���� because of rollback tran
