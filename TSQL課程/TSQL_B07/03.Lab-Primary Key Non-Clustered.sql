--	Module 7    03.Lab - PRIMARY KEY NONCLUSTERED.sql

--		���� :	�w��S�w�@�Φh������ư����ޡA�åH����޹w���ƧǡA��M��o������Ʈ�
--					�N�|��L�h���`�����j�M�֦��������Ĳv�]���ֳt
--		���޺���:
--					1. �O������ (Clustered)
--					2. �D�O������ (Non-Clustered)

-- Step 1: �ϥΡiLabDB2�j��Ʈw
use  LabDB2 ;
go

drop table if exists PhoneLog ;

-- Step 2: Create a table with a primary key nonclustered specified
--	�N PRIMARY KEY �إ߬��y�D�O�����ޡz
create table PhoneLog(
	PhoneLogID  int  identity(1,1)  constraint  PK_PhoneLog  primary key nonclustered,		-- nonclustered
	LogRecorded datetime2  not null,
	PhoneNumberCalled  nvarchar(100)  not null,
	CallDurationMs  int not null
);


insert PhoneLog values ('2020-1-1', '0999999', '1')
go 100

-- Step 3: Query sys.indexes to view the structure
-- (note also the name chosen by SQL Server for the constraint and index)
select * from sys.indexes
where object_id = object_id('PhoneLog');	-- index_id = 2, type_desc = 'HEAP', 'NONCLUSTERED'
go

select * from sys.partitions
where object_id = object_id ('PhoneLog');		-- index_id = 0, 2 
go        

--  check : AdventuresWorks  ��  table  HumanResources.Employee  ��  ����

-- Step 4: Drop the table
drop table if exists PhoneLog;
go

