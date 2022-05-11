--	Module 6 - Lab03  �ѧO���(IDENTITY)���ϥ�

--	�ѧO���i�H���򩳭Ȧ۰ʻ��W�ͦ����ƭȡA�ѧO���u�ର��������C
--	�C�Ӹ�ƪ�u��إߤ@���ѧO���C
--	�@��Ω󲣥ͬy�����ΰ����D��s���C
--	�ѧO���i�H�]�w��l�ȩM���W�ƭȡC
--	�y�k : IDENTITY [ (seed , increment) ]
--					seed  �˸�������Ĥ@�Ӧ�ҨϥΪ��ȡC
--					increment  �W�q�ȡA�ӭȳQ�s�W��e�@�Ӥw�˸����檺���ѭȤW�C
--					�����P�ɫ��w�ؤl�M�W�q�A�Ϊ̤G�̳������w�C�p�G�G�̳������w�A�h���w�]�� (1,1)�C

--		�p�G�b�g�`�i��R���ާ@�����s�b�ۼ��ѦC�A����b���ѭȤ����i��|���ͮt�Z�C
--		�p�G�o�c���F���D�A����Ф��n�ϥ� IDENTITY �ݩʡC���O�A���F�T�O�����ͮt�Z�A
--		�Ϊ̬��F���ɲ{�����t�Z�A�b�� SET IDENTITY_INSERT ON �㦡�a��J���ѭȤ��e�A
--		�Х���{�������ѭȶi��p��C

use LabDB;
go

drop table if exists NewEmployees;
go

create table NewEmployees  (  
     IDNum int identity(1,1),  
     FirstName varchar(20),  
     LastName varchar(30),
     Gender char(1)
);
select * from NewEmployees
go

--  �s�W�@����� column_list ���ݫ��w�ѧO���
insert NewEmployees (FirstName, LastName, Gender)
	values ('Karin', 'Josephs', 'F');
go 5

select * from NewEmployees;
go

--  �}�Ҹ�ƪ� SET IDENTITY_INSERT �ﶵ�� ON
--  �åB�s�W�@����ƥ]�t�ѧO��쪺��
set identity_insert NewEmployees ON;�@�@-- ���\�ϥΪ̩w�q IDENTITY

insert NewEmployees(IDNum, FirstName, LastName, Gender)
	values (1, 'Tom', 'Cruise', 'M'), (99, 'Mary', 'Rosemary', 'F');

set identity_insert NewEmployees OFF;
select * from NewEmployees;
go

--  �s�W�@�����ո�ƨèϥ�@@IDENTITY��Ʀ^���ѧO����
insert NewEmployees(FirstName, LastName, Gender)
	values ('Angelina', 'Jolie', 'F');
select @@identity ;
select * from NewEmployees;
go

select ident_current('NewEmployees') as Current_Identity;

select scope_identity() as [scope_identity];

