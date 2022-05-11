--	04.Lab - AFTER DROP, ALTER, CREATE Trigger.sql

use LabDB2


--  �ְ���F DROP_TABLE, ALTER_TABLE, CREATE_TABLE
drop trigger tg_MoniterTables on database

create trigger tg_MoniterTables on database�@�@--�M�Φb�ثe "��Ʈw"
for drop_table, alter_table, create_table
as
    declare @user nvarchar(50);
    set @user = system_user;
	print '�֦b���� DDL : '+@user

-- ��m���P
--  check :   LabDB2 �� �i�{���� �� ��ƮwĲ�o�{�� 

--Create
create table  Department(
	deptno       int ,
	dname       nvarchar (20) ,
	loc              nvarchar(10) ,
	constraint PK_Department  primary key (deptno)
) ;
go


-- Alter
alter table Department add birthday date


-- Drop
drop table  dbo.Department

drop trigger tg_MoniterTables on database

