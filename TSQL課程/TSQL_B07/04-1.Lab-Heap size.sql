--	Module 7   04-1.Lab - Heap size.sql

--	Heap ����ƪ�ܮe������D����(������ƶq�ܤ֦��o�e���ܤj���Ŷ�)
-- �P�ɶ}�ҡi04-2.Lab - Clustered size�j�����ñ�

use LabDB2;
go

--	�إߤ@�Ӵ��ո�ƪ�
drop table if exists heapTB;
go

create table heapTB (
	id int identity(1, 1)  not null,
	name varchar(20)
);

insert heapTB values ('john')
go 10000


--  �Q��DBCC SHOWCONTIG���˵��@�U��ƪ������t�m
dbcc showContig('heapTB')

--  �NTABLE����ƥ����R��(�`�N : �Шϥ�Delete�ӫDTruncate Table)
delete from heapTB


--  �Q��DBCC SHOWCONTIG���˵��@�U��ƪ������t�m, ����@�U
dbcc showContig('heapTB')


--  �Q��sp_spaceused���˵���ƪ�i�H�����ݥX�A��rows��쳣�O0�F�A�� data...
exec sp_spaceused 'heapTB'


--  �hRebuild��Table�A���O�]����L�覡���ۦP�@�ΡC
--			1.  �Ҧp�bHeapTB�W�إ�Clustered Index�άO
--			2.  ���s���ͤ@�i�Ū���ƪ�ñN HeapTB ����ƭ˶i�h�����A
--	���~�G���O���ظ�ƪ��ʧ@�C�g�LRebuild��A�ڭ̥i�H�ݨ�HeapTable�����ƤU����1��Page�C

alter table heapTB rebuild

dbcc showContig('heapTB')
exec sp_spaceused 'heapTB'