--	Module 8   ���ΫD�O������(Nonclustered Index) �[�֬d�߮Ĳv
--			8-1: �D�O�����ު����c
--			8-2: �D�O�����ު��W���P�إ�

--	�D�O������(Non-Clustered):�@��SQL Server��ƪ�i��"�h�ӫD�O������" (�@�����
--			�ΰߤ@����)�A�D�O�����ޤ��|�̷Ө������Ȫ����Ǩ� "�s��" ��ơA�������
--			�̨�]�w�����ާֳt���һݪ���Ƥ��e, non-clustered �]�|�ھڸ�ƫإߥX Balance Tree�A

--	SQLServer �|�۰ʱN UNIQUE ���إߦ�"�D�O������"�A��W�ٳq�`�� UK_TableName_xxx


--	01.Lab - CREATE NONCLUSTERED INDEX.sql

-- Step 1: Use the tempdb database.
use LabDB2;
go

drop table if exists Book

-- Step 2: Create a table:  dbo.Book
create table Book(
  ISBN  nvarchar(20)  not null ,
  Title  nvarchar(50)  not null ,
  ReleaseDate  date  not null ,
  PublisherID  int  not null
) ;
go

insert book values('1', 'aaaaa', '2020-1-1', 1)
insert book values('2', 'bbbbb', '2020-1-2', 2)
insert book values('3', 'ccccc', '2020-1-3', 3)
insert book values('4', 'ddddd', '2020-1-4', 4)
insert book values('5', 'eeeee', '2020-1-5', 5)

select * from book


--   �� highlight / mark �A�n���p���d��
-- �i��ܦ��p����p�e�j for a query that needs lookups
select title from Book where  ISBN='5'      -- �i��ܦ��p����p�e�j��� : ��ƪ��y
select title from Book where  Title='5'

alter table book add primary key(ISBN)

--  after primary key adding�i��ܦ��p����p�e�j for a query that needs lookups again
select title from Book where  ISBN='5'      -- �i��ܦ��p����p�e�j��� : �O�����޷j�M
select title from Book where  Title='5'


-- Step 3: Create a nonclustered index on PublisherID and ReleaseDate DESC
create nonclustered index IX_Book_Publisher
	on Book (PublisherID, ReleaseDate desc);
go


-- Step 4: Request an ��estimated execution plan���i��ܦ��p����p�e�j for a query that needs lookups
select PublisherID, Title, ReleaseDate
from Book 
where ReleaseDate > DateAdd(year, -1, sysdatetime())
order by PublisherID, ReleaseDate desc;
go

select * from book

--  include �l�y�̪�����Ʒ|�\��b�D�O������(Nonclustered Indexes)�������h�ŭ���(leaf-level pages)��
-- Step 5: Replace the index with one that includes the Title column
--	Index covers the Query
create nonclustered index IX_Book_Publisher
	on Book (PublisherID, ReleaseDate desc)
	include (Title)                             -- include Title : index on PublisherID, ReleaseDate & Title
	with drop_existing;
go


-- Step 6: Again, request an��estimated execution plan���i��ܦ��p����p�e�jfor the query
select PublisherID, Title, ReleaseDate
from dbo.Book 
where ReleaseDate > DateAdd(year, -1, sysdatetime())
order by PublisherID, ReleaseDate desc;
go

