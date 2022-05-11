--	 Module 10  01-2.Demo - Locks (2nd window) 


-- Step 6 - Open the�i2nd window�jto the Deadlock database
use  LabDB2 ;
go

-- Use the SPID to identify the connection 
select  @@spid  as  'spid' ;


-- Step 7 - Attempt to update the same product within a transaction
begin tran ;
	update DeadlockProduct 
	set  ProductName = 'Update from window 2'
	where  ProductID = 1 ;
go

-- Step 8 - Back in Activity Monitor�i���ʺʵ����j, note the lock information
--               and in particular note the process that is blocked and the other process�i���Y����̡j
--				 that is shown as being at the head of the blocking chain


-- Step 9 - Switch to the�i3rd window�j


rollback
go