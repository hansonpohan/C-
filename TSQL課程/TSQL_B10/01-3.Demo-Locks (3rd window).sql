--	 Module 10  01-3.Demo - Locks (3rd window).sql

-- Step 10 - Open the�i3rd window�jto the Deadlock database
use  LabDB2 ;
go

-- Step 11 - Query the system views to see the current locking
select  resource_type ,  request_mode ,  request_type ,  request_status ,  request_session_id
from  sys.dm_tran_locks ;  --LockList
go
--  �W������w(Exclusive Lock)(X)
--  IntentExclusive(IX) : ��ܱ��i��"�W������w" �ç����w���󤤪� "�����귽"

-- Step 12 - Make sure to locate the relevant info and explain it briefly


-- Step 13 - Cancel the query in the�i2nd window�jor go �i1nd window�jstep 15 rollback
-- �i2nd window�jrollback and �i1nd window�jstep 15 rollback

-- Step 14 - Then return to the�i1st window�j
