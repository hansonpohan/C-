--	Module 6 DML���O���ϥ��p�󰵸�ƪ��s�W
--		6-1 : �ϥ� INSERT �s�W���
--		6-2 : �w�]�������F�榡
--		6-3 : �ѧO���(IDENTITY) ���ϥ� 


--	Lab01 �ϥ� INSERT �s�W���

--	INTO �O�@�ӿ�ܩʪ�����r�A"�i�H���ϥ�"�C
--	���M�� (column_list) �O���n���J��ƪ��@�өΦh�Ӹ�Ʀ�Ҳզ����M��A�άA���]�_�ӡA�åγr�����j�C
--	VALUES ���n�s�W����ƭȲM��A�p�G�����w column_list �h���w����쳣�����@�Ӹ�ƭȡA
--			�p�G�����w���M��(column_list)�A�h��ƪ��C�Ӹ�Ʀ泣�������ȡA�B�����n�̸�Ʀ檺���ǱƦC�C

--	��r�Τ�����ȶ��[��޸��C
--	�i��ܩʷs�W�������C
--	�p�G��Ʀ椣�b���M��(column_list) �����A��Ʀ�ŦX�U�C����ASQL Server �|�۰ʴ������� :
--			IDENTITY : �ϥΤU�@�Ӳ֥[�ȡC
--			DEFAULT : �ϥθ�Ʀ檺�w�]�ȡC
--			timestamp : �ϥΥثe���ɶ��W�O�ȡC
--			NULL : �ϥ� NULL �ȡC
--			�p���Ʀ� : �ϥέp�⪺�ȡC
--	��������� Unicode �r��������(nchar�Bnvarchar�Bntext)�A��ƭȲM�檺�e���i�H�[�j�g�r����N���A
--			�p�G�����w��N���ASQL Server �|�ϥιw�]���r���s�X�C


use LabDB;
go

--	�إߤ@�Ӵ��ո�ƪ�
drop table if exists Member;
go

create table Member (
	ID int identity,
	Name nvarchar(100),
	MsMr char (6) default ('Ms.'),
	BirthDate date default (getdate())
);
select * from Member
go

-- �s�W�@�����
insert into Member values ('�ϥΪ�1', 'Mr.', '1-1-1999');   -- try insert into
select * from Member;
go

-- �s�W�h�����
insert Member values 
	('�ϥΪ�2', '', '2010-10-20'),
	('�ϥΪ�3', default , '2012-5-1'),
	('�ϥΪ�4', 'Mr.', default);
select * from Member;
go

-- ���w���s�W���,Gender / BirthDate�|�ϥιw�]��
insert Member (Name) values ('�ϥΪ�5');

select * from Member;
go

-- �s�W�]�tNULL����Ʀ�- unknow
insert Member(Name, MsMr, BirthDate) values ('�ϥΪ�6', null, null);
insert Member values ('�ϥΪ�5', null, null);

select * from Member;
go

-- �s�W�@�����, Name ���ȫ��w�� Unicode �s�X
insert Member (Name) values (N'�ϥΪ�7');

select * from Member;
go


--  �Q��SELECT...INTO �N Northwind.dbo.Employees ��ƪ�
--  �bLabDB�W���ظ�ƪ�, �åB�u�s�WCity = 'London'���
select * from Northwind.dbo.Employees

select * into TempEmployees
from Northwind.dbo.Employees
where City = 'London';
go

--  check :  LabDB �� DataTable �� dbo.TempEmployees
select * from TempEmployees;
go


--	�ϥ� INSERT INTO�KSELECT, �N TempEmployees ����Ʒs�W��Member��ƪ�
--	�i�H�f�t�ϥ� INSERT INTO�KSELECT �A���Ĳv���N�j�q��Ʊq�Y����ƪ�ǰe�ܥt�@����ƪ�C
--	�åB �� @@ROWCOUNT �禡�^�Ƿs�W����Ƶ���
insert  Member (Name, MsMr, BirthDate)
select LastName+' '+FirstName, TitleOfCourtesy, BirthDate from TempEmployees;  -- �q�O����Ʈw������ select �� insert
print '�@�s�W ' + convert (varchar(3), @@rowcount) + ' �����';
go

select * from Member
select * from TempEmployees


--	���ץX member to member.csv �� first  --  need file name xxxx.csv
-- LabDB(�ƹ��k��) �� �u�@ �� �ץX��� �� ��ƨӷ�(Microsoft OLE DB Provider for SQL Server ) 
--			�� ... Flat File Desitination �� ...c:\Temp\member.csv  �� ......

bulk insert Member
from 'C:\Temp\member2.csv'
with (
	FieldTerminator = ',',
    RowTerminator = '\n',
	FirstRow           = 2,
    LastRow           = 25,
    --CodePage        ='utf8',
	keepnulls
)
select * from Member

-- https://docs.microsoft.com/zh-tw/sql/t-sql/statements/bulk-insert-transact-sql?view=sql-server-ver15

