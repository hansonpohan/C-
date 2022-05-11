--	Module 7 �O������ (Clustered Index) ���W���P�إ�
--			7-1: �O�����ު����c
--			7-2: �p��إ��O������
--			7-3: �p��]�p���Ī��O������


--		�O���P�D�O�����޻���
--		https://docs.microsoft.com/zh-tw/sql/relational-databases/indexes/clustered-and-nonclustered-indexes-described?view=sql-server-ver15

--		Heap : ��n�O�@�بS���O�����ު���ƪ�C �@�өΦh�ӥi�H�إߦb�x�s����n����ƪ�W��
--					�D�O�����ޡC��Ʒ|�H�L���w���Ǫ��覡�x�s���n���C 
--					�@��ӻ��A��Ƥ@�}�l�O�|�H��ƪ����J��ƦC�������x�s�A
--					���O Database Engine �|���ʰ�n������ơA�H���Ĳv�a�x�s��ƦC�A
--					�]���L�k�w����ƶ��ǡC ���T�O�q��n���Ǧ^����ƦC���ǡA�����ϥ� ORDER BY �l�y�C

--		�Y�n���w�x�s��ƦC���ä[�޿趶�ǡA�Щ��ƪ�W�إ��O�����ޡA�p���@�Ӹ�ƪ�K���O��n


-- Step 1: �ϥΡiLabDB2�j��Ʈw
use LabDB2 ;
go

drop table if exists PhoneLog ;

-- Step 2: �إߤ@�ӥH Heap �����c����ƪ�, no any Primary Key
create table PhoneLog (
	PhoneLogID int identity(1, 1)  not null,
	LogRecorded datetime2  not null,
	PhoneNumberCalled nvarchar(100)  not null,
	CallDurationMs  int not null
);


-- Step 3: Query sys.indexes to view the structure.
select * from sys.indexes
where object_id = object_id('PhoneLog');			-- index_id = 0, type_desc = 'HEAP'
go


select * from sys.partitions
where object_id = object_id ('PhoneLog');			-- index_id = 0,
go        



--	Heap : ��Ʒ|�H�L���w���Ǫ��覡�x�s���n��, �ѩ󴡤J��Ʈɤ��|�j������Y�檺���ǡA
--				�]�����J�@�~�q�`�|��P�������J" �O������ " �@�~"��"�C

-- ���Ũϥΰ�n�����p :
--		�g�`���ƧǶ��ǶǦ^��ƮɡA�ФŨϥΰ�n�C 
--		�b�ƧǸ�Ʀ椤���O�����ޡA�i�K�h�i��Ƨǧ@�~�C
-- https://docs.microsoft.com/zh-tw/sql/relational-databases/indexes/heaps-tables-without-clustered-indexes?view=sql-server-ver15

-- Step 4: Drop the table
drop table if exists PhoneLog;
go

