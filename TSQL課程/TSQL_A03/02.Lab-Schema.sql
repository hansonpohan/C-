--	Module 3 - Lab02 �ϥε��c�y�z
--		�ϥε��c�y�z�P��Ʈw����i�H�����Ʈw�ϥΪ̪��@�νd��C
--		���c�y�z(Schema)�O��Ʈw����(Table�BView�BTriggers�K����)���@�Ӷ��X�C
--		�i�H�z�L���c�y�z�ӳ]�p���󪺦s���v��

--	.\STUDENT-PC  ��  LabDB  ��  [dbo]Schema  �� student
--	dbo = db owner

--	https://www.itread01.com/content/1550139669.html

--  �ϥ�schema �n�B�O :
--	1.	�P�@��Ʈw���u�n�H schema �Ϥ��A�K�i�H�ϥΦP�@��ƪ�W��
--			Ex: sales.employees�Brd.employees �� fab.employees

--	2.	�n�]�w�v���ɡA�i�H�H schema �� Group ��H�A�������P���v�����ŻP�ϥΪ̡A
--		�N�Y��Y�@�s�i RD �ݭn�s�����RD��������ƪ�ɡADBA�u�ݭn�N��RD�[�J�� RD schema ��
--		�Χ����v�����]�w�A���A�ݭn�@�Ӥ@�Ӹ�ƪ�C�C�]�C

--  https://matthung0807.blogspot.com/2020/12/database-schema-meaning.html

use LabDB;
go

-- �Ыص��c�y�z schema
create schema lab;    -- check : LabDB ��  �w���� �� ���c�y�z
go

-- �إߤ@��ƪ�ϥ� lab ���c�y�z
create table lab.Teachers (
	id int,
	name varchar(10)
);
go

-- �˵�����Ʈw�����c�y�z
select * from sys.schemas;�@�@				-- LabDB �� �˵� �� sys.schemas
select * from information_schema.schemata  --�w��ثe��Ʈw���C�ӵ��c�y�z

-- �إߤG�Ӵ��ըϥΪ�
create user student01 without login;		-- check : LabDB �� �w���� �� �ϥΪ� �� student01 �� �ݩ� �� �w���ʹ��� (���v/�ڵ�)
create user student02 without login;
go

grant select on schema ::lab to student01  -- check �w���� �� �ϥΪ� �� student01 �� �ݩ� �� �w���ʹ��� (���v/�ڵ�)
deny select on schema ::lab to student02;
go

drop user if exists student01;
drop user if exists student02;

-- �קﵲ�c�y�z schema �� lab.Teachers ���ܬ� dbo.Teachers
alter schema dbo transfer lab.Teachers;
go

--	�R�����c�y�z
--		�p�G�o�Ϳ��~��L���󥿦b�Ѧҥ������������ѦҤ~��R��
drop schema if exists  lab;          -- check LabDB �� �w���� �� ���c�y�z
go

