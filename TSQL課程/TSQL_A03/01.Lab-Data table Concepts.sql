-- Module 3 - ��ƪ� (Tables) ����¦�[���B�]�p�P��@ 
--		3-1 : ��ƪ���¦�[��
--		3-2 : ����O���c�y�z
--		3-3 : �p��إߡB�ק�P�R����ƪ�

--	2017/ 2019 SQL Server 
--		3-22 ���W��
--		6-6~15	��Ʈw���c (Excel file)

--	Lab01 �إ߸�ƪ�÷s�W���ո��
use LabDB;
go


-- SQL Server Database Engine �|�ϥθ�Ʀ�w�q���� SPARSE (���P) ����r�A
-- �̨ΤƸӸ�Ʀ椤�Ȫ��x�s�覡�C �]���A���ƪ������ƦC����Ʀ�ȬO NULL �ɡA
-- �o�ǭȴN���ݭn�x�s��m�A���O�ݭn��h���x�s�Ŷ����x�s�D NULL �ȡC
--	���P��Ʀ楲���i�� NULL, ���P��Ʀ椣�঳�w�]��

create table Employees(
    id int identity (1, 2) not null ,			        -- not null �i�g�i���g
    name nvarchar (50) not null,
    address nvarchar (200) sparse null);		-- ���P sparse null
go
-- dbo.Employees �� ��Ʀ� �� address (�ƹ��k��) �� �����P True


--����W�ҡA�s�W�@����ơA�óq�L@@IDENTITY���o�s�W��ƪ�ID��
insert into Employees(name, address)		-- into �i���i�L
    values ('Kevin', 'Test Identity');
select @@identity
go 5

select * from Employees;
go

--  ALTER ��w�s�b����ƪ��ܰ�

--  ALTER �s�W���
alter table Employees
   add phone_no  nvarchar (50),
          email  nvarchar (20);
go

--  ALTER �ק����
alter table Employees
�@alter column name nvarchar(80)				--  �����r��Ʀr, �Ʀr���r
--  ALTER �R�����
alter table Employees
    drop column phone_no, email

-- take a look table employee �U����Ʀ�, ��ܸ�ƪ��c

select * from information_schema.tables

drop table if exists Employees

