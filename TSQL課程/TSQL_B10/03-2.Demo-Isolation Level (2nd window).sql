--	Module 10   03-2.Demo - Isolation Level (2nd window).sql

use AdventureWorks ;

-- Use the SPID to identify the connection 

--	Step 3 
select  @@spid  as  'spid' ;

begin tran
	select *  from Person.Person		-- �iŪ
	where BusinessEntityID = 6 ;

    update Person.Person					-- ���i update, insert & delete 
    set FirstName = 'Fran'
    where BusinessEntityID = 6 ;

--	Step 4 �^ windows 1st
--	For the purpose of the exercise, 
--	COMMIT TRANASACTION or ROLLBACK TRANSACTION are not used.

rollback tran;

select * from Person.Person 
where  BusinessEntityID = 6 ;
	 
