--	Module 4 - Lab03 UNIQUE �������

--	UNIQUE �M CHECK �����������������A�D�n�O�Ψӱj����� SQL Server ��ƪ�����Ƨ���ʡC
--	UNIQUE �T�O���b��ƪ����ߤ@�ʡA�����ƪ�����줣�঳���Ƹ�ơC
--	UNIQUE ���\ NULL �ȡC
--	�@�Ӹ�ƪ�u�঳�@�� PRIMARY KEY �A���O�i�H���h�� UNIQUE ��������C
--	UNIQUE �M PRIMARY KEY ���j��ߤ@�ʡA���O��Q�n�j��D�D�����䪺�ߤ@�ʮɡA
--			�N�|�ϥ� UNIQUE ��������Ӥ��O PRIMARY KEY ��������A
--			�Ҧp : �q���ƪ� �H�q�渹�X��PK, ���u�o�����X�v�o�����ڭ̷|�]�w�� UNIQUE ��������A
--						�Ӥ��|�N���]�w���D������C

use LabDB;
go

--	�H�U�d�ҷ|�إ� TestTable ��ƪ�åB�b TestID ��Ʀ�W�إ�UNIQUE��������C
create table TestTable (  
   TestID int,   
		constraint UQ_TestID unique (TestID) ,
	Name varchar(20)
);   
go  -- �å���ܦb��Ʀ椤

insert TestTable values (1, 'John')			--  insert twice
go 2

select * from TestTable


--	�R���W���إߪ�UNIQUE�������
alter table TestTable   
	drop constraint UQ_TestID;   -- UQ_TestID is UQ name
go  

insert TestTable values (1, 'John')
go 3

--	�b�{������ƪ�W�إ�UNIQUE�������, �@�˨ϥΤW���إߦn�� TestTable
--  �YTestID ��즳���ƭȥX�{, add Unique �|�X�{���~ 
alter table TestTable   
	add constraint UQ_TestID unique (TestID)   
go  

--	�յ۷s�W "�h�����" ���լݬ�(��Ʃ�NULL��) 
insert TestTable values (1, 'John')
go

drop table if exists TestTable

-- Conclusion 
--		1.		Primary Key [unique,  no null]
--		2.		Foreign Key  [no unique,	null]
--		3.		UNIQUE Key [unique,	one null]
