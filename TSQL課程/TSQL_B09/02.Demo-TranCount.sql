--	Module 9   01.Demo-1 - TranCount.sql

--	@@TRANCOUNT ���ȻPCOMMIT�BROLLBACK �����Y
--	@@TRANCOUNT : ���o�ثe�s�u���� BEGIN TRAN �ԭz������ӼơA
--			����� COMMIT TRAN �|����1�A����� ROLLBACK TRAN �|�k 0

use  LabDB2 ;

--	START TRANSACTION HERE
select @@trancount  as  Tran_Count ;							--    0

begin tran																		--	1st
		select @@trancount  as  Tran_Count ;
		begin tran																--	2nd
				select  @@trancount  as  Tran_Count ;
				begin tran														--	3rd
						select @@trancount  as  Tran_Count ;
----------------------------------------------------------------------------------
				commit tran ;													--	2nd
				select @@trancount  as  Tran_Count ;
		commit tran ;															--  1st		
		select @@trancount  as  Tran_Count ;
commit tran ;																	--    0
select @@trancount  as  Tran_Count ;
----------------------------------------------------------------------------------
rollback tran ;													            	--	rollback transaction  all become 0
select @@trancount  as  Tran_Count ;