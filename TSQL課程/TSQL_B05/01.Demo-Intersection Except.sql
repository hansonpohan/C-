--	Module 5	���X�B��l���ϥ�
--		5-1: �ϥ�UNION(�p��)�BUNION ALL �B��l���g�d��
--		5-2: �ϥ�INTERSECT(�涰) �B��l���g�d��
--		5-3: �ϥ�EXCEPT(�t��) �B��l���g�d��

--		�b��Ʈw����h�Ӹ�ƪ�d�߮ɡA���F�ϥ� Join ���X�֬d�ߥ~�A
--		�]�i�H�ϥζ��X�B�� : �p�� Union�B�涰 Intersect�B�t�� Except �Ӱ����Ӹ�ƪ��X�֡C
--		��ⶰ�X�����n�i�����B���, ������� :
--				���Ӽ�, ��춶��, ���w�Ǥ覡�n�ۦP, ��쪺��ƫ��A�n�ۮe

--	reference : 
--  https://docs.microsoft.com/zh-tw/sql/t-sql/language-elements/set-operators-union-transact-sql?view=sql-server-ver15

--	01.Demo - Using Set Operators.sql

use LabDB2 ;
go

drop table  if exists table1
drop table  if exists table2

create table table1(column1 int, column2 int);
go

create table table2(column1 int, column2 int);
go

insert table1 values ( 1, 1), (2, 2), (2, 2), (3, 3), (5, 2), (3, 5)
insert table2 values ( 1, 1), (2, 2), (5, 5)
go

select * from table1
select * from table2


--  �i�涰 INTERSECT�j : �N��Ӹ�ƪ�ۦP���������X�ӡA�B�����ƪ���ƥu�|��ܨ䤤�@���C
--		Using the �iINTERSECT�j Operators  ���Ҥl

select column1 from  table1 
intersect										--���涰-- it different with inner join (where)
select column1 from table2 ; 
go

select * from  table1 
intersect										--���涰-- it different with inner join (where)
select * from table2 ; 
go



--	�t�� �iEXCEPT�j: �u���X�Ĥ@��select���O���O���s�b�ĤG��select���O�������C
--		Using the �iEXCEPT�j Operators   ���Ҥl

select * from table1
select * from table2

select * from  table1 
except											--�� table1 �t�� table 1 - table 2
select * from table2 ; 
go


select * from table1
select * from table2

select * from  table2 
except											--�� table2 �t�� table 2 - table 1
select * from table1 ; 
go



--  �p���iUNION�j : �N2�Ӹ�ƪ����� "����" ���X�A�@�_�A�����ƪ���ƥu�|��ܨ䤤�@���A
--	Using the �iUNION�j Operators  ���Ҥl 

select * from table1
select * from table2

select * from table1 
union											 
select * from table2 ;
go



--	�iUNION ALL�j : Union all �P Union���t���b��AUnion �|�N���ƪ��۰ʽ𱼡A
--	  �� Union all�N�|�O�d���ƪ��C
--	Using the �iUNION ALL�j Operators  ���Ҥl

select * from table1
select * from table2

select * from table1 
union all										--	including duplicates
select * from table2 ;
go



--	UNION  vs.  JOIN
--		UNION �P JOIN ���P���a��b��AJOIN �O�@��V���X (�X�֦h�Ӹ�ƪ��U���)�F
--				�� UNION �h�O�@�������X (�X�֦h�Ӹ�ƪ�������)�C

--		UNION �|��s�Ӧۨ�Ӭd�ߪ����G���C�� UNION ���|�q�����ۨ�Ӹ�ƪ���Ʀ�إ߭ӧO��"��ƦC"�C
--		JOIN �|����Ӧۨ�Ӹ�ƪ���Ʀ�A�H�إߥѨӦۨ�Ӹ�ƪ���Ʀ�Ҳզ������G��ƦC�C

select 23 as bah
union
select 45 as bah;

select * from 
(select 23 as bah) as foo 
join
(select 45 as bah) as bar
on (33=33);