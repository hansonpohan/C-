--  Module 12   02-1.Demo - Deadlock Retry - (1st Window).sql

-- Step 1 : �b���������A�Х�����U�����󦺵��譱�����յ{���X(deadlock retry code)
--              �M��A "�ߧY" ����i2nd Window�j(�ĤG����)���{���X
--              (�Ф�����i2nd Window�j(�ĤG����))


-- Step 2 : �Ъ`�N�A�o��ӵ��������S����~��ܪ�������~�T���C
--  �� while �j��h�ѨM deadlock 

use  LabDB2 ;
go

declare @RetryCount int = 5 ;	   -- retry 5 times
while (@RetryCount > 0)				-- retry update if deadlock victim
begin
	begin try
		begin tran  ;
			update DeadlockProduct 
			set ProductName = 'ProductID = 1 ~~Modified (1st Window)'
            where ProductID = 1 ;

			waitfor delay  '00:00:06' ;

			update DeadlockProduct 
			set ProductName = 'ProductID = 2 ~~Modified (1st Window)'
            where ProductID = 2 ;

			set @RetryCount = 0 ;		-- stop trying
			select @@trancount  as  Tran_Count ;		--	1
		commit tran ;
		select @@trancount  as  Tran_Count ;			--  0
	end try

	begin catch 
		if (error_number() = 1205)									-- deadlock victim
			begin
				set @RetryCount = @RetryCount - 1 ; 
				waitfor delay  '00:00:02' ;								-- wait for 2 sec.
				print  N'ĵ�i�G(1st Window) ������(Deadlock) ���p�o�͡I' ;
			end 
		else 
			set @RetryCount = -1 ;  -- ���X while �j��
		if xact_state() != 0  -- �ϥ�XACT_STATE�ӽT�{������ѴN�٭��ӥ��(rolled back the transaction)�A
			print '�^�u rollback tran ���p�o�͡I'
			rollback tran ;
	end catch ;
end ;

select * from DeadlockProduct

