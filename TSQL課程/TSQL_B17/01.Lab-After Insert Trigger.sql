--	Module 17. �z�L DMLĲ�o�{��(DML Triggers)�ӳB�z�������     
--		17-1:�p��إ� AFTER INSERT Triggers     
--		17-2:�p��إ� AFTER DELETE Triggers     
--		17-3:�p��إ� AFTER UPDATE Triggers     

--		Ĳ�o�{�ǬO���Ʈw���A���o�ͨƥ�ɡA�|�۰ʰ��檺�S��w�s�{�ǡA�ҿת��ƥ�
--		�i��O��ƪ��s�W�B�ק�ΧR�����ʧ@�A��]�w���ƥ�ʧ@�o�ͮɷ|����۰�Ĳ�o�{�ǡA
--		�Ҧp : �إ�	DML (�PInsert�BUpdate�PDelete�������ާ@)�B
--							DDL (�PCreate�BAlter�BDrop�PGrant�������ާ@) �εn�J(Logon)Ĳ�o�{��

--	FOR | AFTER | INSTEAD OF
--	FOR					�G�P�� AFTER �C
--	AFTER				�G	�u�bĲ�o�� SQL ���z�����w���Ҧ��@�~ "�����榨�\" �ɡA
--								�~�޵oDML Ĳ�o�{�ǡC�˵�����w�q AFTER Ĳ�o�{�ǡC
--	INSTEAD OF	�G	���w�HDML Ĳ�o�{�Ǩ� "���NĲ�o" �� SQL ���z���A
--								�]���A�|�мgĲ�o���z�����ʧ@�C

--		inserted �N�� insert ����� �� update �u��v�����
--		deleted �N�� delete ����� �� update �u�e�v�����
--		inserted �M deleted  ������ƪ�ܬ� UPDATE �A
--			�i�H�ϥ� IF EXISTS (select 1 from inserted) and 
--			EXISTS (select 1 from deleted)  �ӧP�_

-- Step 1: Open a new query window and use the LabDB2 database
use LabDB2
select * from Book

-- table book �o��insert �N select 
drop trigger if exists tg_book_insert_select

create trigger tg_book_insert_select on Book
for insert
as
begin
	declare @ISBN nvarchar(20)
	select @ISBN = ISBN from inserted			-- inserted �N�� insert ����� �u��v�����
	print 'insert occured ISBN no. : ' + @ISBN

	if update(PublisherID) or update(Title)
		print 'Title �� PublisherID ���Q��s'
	select * from Book
	select * from Book where @ISBN=ISBN				--  �浧 select 
end

--  check :   LabDB2 �� ��ƪ� �� BOOK �� Ĳ�o�{�� �� �ק�

-- Step 3: Execute the following code to test the trigger 
insert Book values ('34', 'SQL Server ', '2010-1-1', 20)
--select * from Book


--	check : LabDB2 �� dbo.Book �� Ĳ�o�{��
select * from sys.objects where type = 'TR'
select * from sys.sysobjects where xtype = 'TR'




--  PublisherID �j��50  ��� rollback
drop trigger if exists tg_book_insert_rollback

create trigger tg_book_insert_rollback on Book
for insert
as
begin
	declare @PublisherID int
	select @PublisherID = PublisherID from inserted
	print 'insert occured ISBN no. with PublisherID : ' + str(@PublisherID)
	if @PublisherID >50										--  PublishID �Y�j�� 50 �N �^�u rollback
		begin
				print 'PublisherID �j��50  ��� rollback'
				print 'tran count : '+str(@@trancount)		--  @@trancount = 1 ? �O�_���ʳQ on
				rollback;
		end
end


insert Book values ('69', 'SQL Server ', '2010-1-1', 80)		-- try PublisherID < 50
select * from Book


--���� DML Ĳ�o
disable trigger  tg_book_insert_rollback on Book;
disable trigger  tg_book_insert_select on Book;

--�ҥ� DML Ĳ�o
enable trigger  tg_book_insert_rollback on Book;
-- drop trigger if exists tg_Book_insert_select ;



