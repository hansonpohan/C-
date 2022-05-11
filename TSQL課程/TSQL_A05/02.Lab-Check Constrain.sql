 --	Module 5 - Lab02 CHECK �������

--	UNIQUE �M CHECK �����������������A���O�Ψӱj����� SQL Server ��ƪ�����Ƨ���ʡC
--	CHECK ��������i�H����s�J��Ʈw�����ƭȡA���w�@�өΦh�Ӹ�Ʀ欰�i��������ƭȡC
--	�Ҧp : �~�֤@�w���i���t�� (Age>0, Age<120)�C

--	CHECK ������������� FOREIGN KEY ��������A�Ψӭ����J��Ʀ檺�ȡC 
--			�䶡�����P�b�󥦭̧P�w�ȬO�_���Ī��覡�G
--						FOREIGN KEY ������� : �q�t�@�Ӹ�ƪ���o���ĭȡC
--						CHECK ������� : �q�ۤv��ƪ�]�w���޿�B�⦡�ӧP�w���ĭȡC
--	�p�G�]�w CHECK ������������]�w�����\ NULL�A�����p�G���J NULL �ȡA
--			SQL Server �|���\���J NULL �ȥB���|�Ǧ^���~�A�o�O�]���@
--			CHECK ��������u�ڵ��B�⦡�P�_�� FALSE ���ȡA�� NULL �|�P�_�� UNKNOWN�C


use LabDB;
go

--	�إ� Member ��ƪ�ëإ� Age �ˬd�������
--	�� DROP �W�� LabDB ������ TABLE
drop table if exists Member;
go

--	�إ� Age �ˬd������� 0 < Age < 150
create table Member (
	ID int identity(1, 1) not null,     -- (1, 1) 1 �}�l, �W�q 1
	Name varchar (50) null,
	Age int null check (Age > 0 and Age < 150)  
);
go

--	�s�W���ո��  
insert into Member (Age) values (49);  
go  5

select * from Member

-- Error : 	Adding values that will be fail under the check constraint  
insert into Member (Age) values (200);  
go

--	Member ��ƪ�s�W�@�Ӧ~�����,�åB�W�w Age �����j�� Seniority
alter table Member
	add Seniority int null default 1,                     --���w�]��1, �������H�ϤW�� Age>0 ������W�w
	check(Age > Seniority);
go

select * from Member

-- �s�W���ո��  
insert into Member (Age, Seniority) values (49, 25);  
go  

insert into Member (Age, Seniority) values (25, 30);  
go