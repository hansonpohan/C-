--	Module 9   04-1.Demo - Explicit Transaction(1st window).sql

--	�~����(Explicit transaction):
--	�����z�LBegin Tran�BCommit Tran�PRollback Tran�����O�ԭz����������覡

-- Step 1 - Open a query window to the tempdb database
use LabDB2 ;
go

-- Step 2 - Create and populate a test table

select * from NewTable

-- Step 3 - Update the test table 
--	AutoCommit Transaction Management Mode 
update NewTable set  info = 'Update 3' where   ID = 3 ;


-- Step 4 - What they would expect to see if you now tried to rollback the transaction
select * from NewTable ;
go


-- Step 5 - Then attempt to roll it back (An ERROR occurs as there is no transaction current)
select @@trancount

rollback tran ;					--	Error
go


-- Step 6 - Requery the table and show that the update was not rolled back
select * from NewTable ;
go


-- Step 7 - Now try the same in a transaction
--	Explicit Transaction Management Mode
begin tran;
update NewTable set  info = 'Update 2' where   ID = 2 ;
update NewTable set  info = 'Update33' where   ID = 3 ;

select @@trancount
-- Step 8 - What they would expect to see if they queried the table from within this transaction
select * from NewTable ;
go


-- Step 9 - What they would expect to see at this point in another query window 
--               that selected from the table.  


-- Switch to �i2nd window�j



-- Step 12 - Then back in the �i1st window�j, roll the transaction back
rollback tran;
go


-- Step 13 - Note that the �i2nd window�j has completed 
--                 and the data in the same state it was prior to the transaction starting
select * from NewTable ;
go


-- Step 14 - Clean up 
--	drop table NewTable ;

