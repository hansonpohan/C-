 --	Module 11    02.Lab - Exception Handling.sql

--			ERROR_NUMBER() �|�Ǧ^���~�X�C
--			ERROR_SEVERITY() �|�Ǧ^�Y���ʡC�ƭȽd��0-24, �䤤�Y���ʧC(�Ҧp:0~9)�����~
--							��ܬO�ѦҰT���ΧC��ĵ�i�Y���ʰ������~������Ӿ��ֳB�z�����D
--			ERROR_STATE() �|�Ǧ^���~���A�X�C�i�H�z�L�����A�X�ܤ��t���w�����D����Ʈw�P�_
--							�ҰO�������D�P�ҹJ�쪺���~�O�_�ۦP�A��K�B�z���~
--			ERROR_PROCEDURE() �|�Ǧ^�o�Ϳ��~���w�s�{�ǩ�Ĳ�o�{�Ǫ��W�١C
--			ERROR_LINE() �|�Ǧ^�{���妸�B�w�s�{�ǡBĲ�o�{�ǩΨ�Ƥ��y�����~���渹�C
--			ERROR_MESSAGE() �|�Ǧ^���~�T���������r�C ��r�]�A���ѵ�����i���N�Ѽƪ��ȡA
--							�Ҧp�A���סB����W�٩Φ��ơC

use LabDB2
select * from NewTable;

--	�t�Ψ��@@ERROR �PERROR_NUMBER()�������t��
--				@@ERROR : �P�_SQL Server�����~�o�ͪ������ܼƪ��Ȱ��P�_�A
--								��@@ERROR��0�ɪ�ܥ��T����
--				ERROR_NUMBER():�ΨӨ��o�bCATCH�϶��ҵo�Ϳ��~�����~���X�A
--								�bCATCH�϶��~�I�s�|�^��NULL

begin tran
	Insert NewTable values(1, 'eeee');       -- error :  identitiy id
	print @@error			--  @@ error ���n����
	print @@error			--
	if @@error !=0
		begin
			print 'error happen'
			rollback tran
		end
	else 
		commit tran;


select @@trancount
select * from NewTable;


declare @TestTryCash int
begin try
		select @TestTryCash = 1000/0    -- error  /0
end try
begin catch
		if @@error !=0
			select	error_number()		as [err number],
						error_severity()		as [error severity], 
						error_state()				as [error state],
						error_procedure()	as [error procedure],
						error_line()				as [error line], 
						error_message()		as [error message]
		else
			print 'OK'
end catch
