--	Module 12   T-SQL �{�������ҥ~�B�z
--		12-1: �ϥε��c�ƪ��ҥ~�B�zTRY/CATCH �y�k�ӳB�z���~�T��
--		12-2: �ϥ�RAISERROR() �N�@��T���Ϊ̬O���~�T���Ǧ^�����ε{��
--		12-3: �ϥ�THROW �Ӥ޵o�Ϊ̬O���s�޵o�ҥ~���p

--		��@������ Transact-SQL Visual C# �P Microsoft Visual C++ �y�������ҥ~���p�B�z�� 
--		Microsoft ���~�B�z�C �z�i�H�N Transact-SQL ���z���s�էt�A�b TRY �϶����C 
--		�p�G TRY �϶����o�Ϳ��~�A�N�|�N�����v�ǵ��t�A�b CATCH �϶������t�@�ӳ��z���s�աC


--	SQL Server �����C�ӿ��~�T�����]�t�H�U�X�Ӥ����G
--			���~�N�X�]Error number�^�G�C�@�h���~�T�������ߤ@����ƭȿ��~���X�A�d��� 1 �� 49999
--			���~�h�š]Severity level�^�G�Y���ʫ��X���~���Y���{�סC�d��� 0 �� 24
--							0-9 ��ܪ��A�Τ��Y�������~��T�A
--							10 ��ܿ�J��T�����T�A
--							11-16 ��ܨϥΪ̾ާ@���~�A
--							17-24 ��ܳn��εw��W�����~�A
--							20-24 ��ܷ��Y�������~�A
--					�Τ�ݳs���|�b����T�����ᤤ�_�A�ӿ��~�|�O���b���~�M���ε{���O���ɤ�
--			���~�T���]Error message�^�G���~�T���]�t���~��]����T�C�T�����׳̤j�� 255 Unicode �r��.
--			���A�X�]State�^ �G�d��� 0 �� 127 �A�ѵ{�������ϥΡC


--	01.Lab - SQL Server Error Handling.sql

-- Step 1: Open a new query window to LabDB2.
use  LabDB2 ;
go

-- Step 2: Use RAISERROR to raise an error of severity 10.
--              Note that in the results pane it is not displayed as an error.

--			���Ϳ��~�T���ð_�l�u�@���q�����~�B�z�C RAISERROR �i�H�Ѧ��x�s�b 
--			sys.messages �ؿ��˵����ϥΪ̦ۭq�T���A�άO�ʺA�إ߰T���C 
--			�T���H���A�����~�T���Ǧ^���I�s���ε{���A�ζǦ^�� TRY...CATCH �غc�������p CATCH �϶��C 
--			�s���ε{�����ӧ�� THROW�C

--	RAISERROR({msg_id|msg_string}, severity, state)
--	���� : {msg_id|msg_string}:��ܰT���s���Φr��A�Y���r���s����50000


declare @DataBaseID int = db_id()
declare @DataBaseName sysname = db_name()
RaisError('�ثe�Ҧbdata base �N���� : %d,  data base name �O : %s', 
				11,								--	Severity  try 11
				1,									--	State
				@DataBaseID,			--  first substitution argument
				@DataBaseName ) ;
go


-- Step 3: 11-16��ܨϥΪ̾ާ@���~�A17-24��ܳn��εw��W�����~�A20-24��ܷ��Y�������~
declare @DataBaseID int = db_id()
declare @DataBaseName sysname = db_name()
RaisError('�ثe�Ҧbdata base �N���� : %d,  data base name �O : %s', 
				19,								--	Severity  �令 18, 22 �ݬݿ��~�T��
				1,									--	State
				@DataBaseID,			--  first substitution argument
				@DataBaseName ) ;
go


-- Step 4: 
-- Step 4-1:  @@ERROR �y�a�Y�u, �ֳt�Q�M��
RaisError ('message', 16, 1);
--print @@error
if @@error != 0
	print 'Error : ' + cast(@@error as varchar(8))	  -- @@ERROR �y�a�Y�u, �ֳt�Q�M��


-- Step 4-2: �p���� @@ERROR value.
declare @ErrorValue int;
RaisError ('message', 16, 1);
set @ErrorValue = @@error
--print @ErrorValue
if @ErrorValue <> 0
	print 'Error : ' + cast(@ErrorValue as varchar(8));


-- Step 5: Use THROW to raise an error.

--  �y�k: THROW [{ error_number| @local_variable},
--								{ message | @local_variable},
--								{ state | @local_variable}][ ; ]
--	����:	error_number:��ܨҥ~���p���`�Ʃ��ܼơA�����O�j��ε���50000�B�p��
--							�ε���2147483647����ƭ�
--				message:��ܻ����ҥ~���p���r����ܼƪ��T���A���O��nvarchar(2048)
--				state:��ܭn�P�T�������p�����A�A����0-255�����O��tinyint���`�Ʃ��ܼ�

throw 51245, 'hi Siri. good morning', 1;

throw 50000, 'Google, good morning', 2;

throw 50001, 'Happy now', 3;

throw 823, 'Happy, Happy now', 4   -- �Ы��w���Ľd�� (50000 �� 2147483647) �������~���X�C


--  �U�C�d�ҥܽd�p��ϥ� THROW ���z���A���s�޵o�W���Y�^���ҥ~���p�C

declare @d1 decimal (5, 2)
begin try  
	set @d1 = 9999.99			--	suppose 99.99 (5, 2)
	print @d1
end try
begin catch
--print N'���~�N�X�G' + cast(error_number() as varchar(5)) + N'  ���~�T���G' + error_message();
--RaisError ('message', 15, 1);
--throw;
throw 50000, 'O!! my God!! ', 4;		
end catch



drop table if exists TestRethrow

create table TestRethrow  (id int primary key); 

begin try  
    insert TestRethrow(id) values(1);  
    insert TestRethrow(id) values(1);  --  Force error 2627, Violation of PRIMARY KEY constraint to be raised.  
end try  
begin catch  
--    print N'���~�N�X error code�G' + cast(error_number() as varchar(5)) + N' ���~�T�� info�G' + error_message();
--		RaisError ('message', 15, 1);
--     throw															--  ���� throw �ոլ�
   throw 50000, 'O!! my God!! ', 4;		
end catch ;  


--  �U�C�d�ҥܽd�f�t while loop ���z���A�Y�^���ҥ~���p�C
--	�ϥΰ��Ƥ��ର0���W�h�A�ӶǦ^�j�餤�����~�N�X�A�j��q1�}�l�A�C������1�A����-1����
declare @i int = 1
while @i >= (-1)
begin
	print ('@i = ' + convert(varchar, @i))
	begin try
		print ('1/@i = ' + convert(varchar, 1 / @i))
		print ('@@ERROR = ' + convert(varchar, @@ERROR))
		print ('--------------------')
		set @i = @i - 1
	end try

	begin catch
		print ('1/0 is wrong, @@ERROR = ' + convert(varchar, @@ERROR) + ', ���~�T���G ' +  ERROR_MESSAGE())
		print ('--------------------')
		set @i = @i - 1
		continue
	end catch
end



--  �ϥ� begin Tran.....commit....rollback
select * from TestRethrow

begin try 
	begin tran
		insert TestRethrow(id) values(2);  
		insert TestRethrow(id) values(1);  --  Force error 2627, Violation of PRIMARY KEY constraint to be raised.  
	commit tran
end try  
begin catch  
	rollback tran
    print N'���~�N�X�G' + cast(error_number() as varchar(5)) + N' ���~�T���G' + error_message();
--		RaisError ('message', 15, 1);
--	throw															--  ���� throw �ոլ�
--    throw 50000, 'O!! my God!! ', 4;		
end catch ;  
select * from TestRethrow



select  * from  sys.messages where message_id = 8134


