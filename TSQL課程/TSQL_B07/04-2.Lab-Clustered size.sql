--	Module 7   04-2.Lab - Clustered size.sql

--	Heap ����ƪ�ܮe������D����(������ƶq�ܤ֦��o�e���ܤj���Ŷ�)

use LabDB2;
go

--	�إߤ@�Ӵ��ո�ƪ�
drop table if exists clusteredTB;
go

create table clusteredTB (
	id int identity(1, 1)  primary key,
	name varchar(20)
);

insert clusteredTB values ('john')
go 10000


--  �Q��DBCC SHOWCONTIG���˵��@�U��ƪ������t�m
dbcc showContig('clusteredTB')

--  �N��iTABLE����ƥ����R��(�`�N : �Шϥ�Delete�ӫDTruncate Table)
delete from clusteredTB


--  �Q��DBCC SHOWCONTIG���˵��@�U��ƪ������t�m, ����@�U
dbcc showContig('clusteredTB')


--  �Q��sp_spaceused���˵���ƪ�i�H�����ݥX�A��rows��쳣�O0�F�A�� data...
exec sp_spaceused 'clusteredTB'



dbcc showContig('clusteredTB')
exec sp_spaceused 'clusteredTB'