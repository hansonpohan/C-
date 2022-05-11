--	Module 2  02.Lab - uniqueidentifier Data Type.sql
--			GUID : Globally Unique Identifier
--			uniqueidentifier �����������Ʀ�Υ����ܼƥi�H�Q�ΤU�C��k�A��l�Ƭ��@�ӭȡG
--			�ϥ� NEWID �� NEWSEQUENTIALID �禡�C
--			�q xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx �榡���r��`���ഫ�A
--			�䤤�C�@�� x �O�d�� 0-9 �� a-f ���Q���i��Ʀr�C 
--			32�ӤQ���i��Ʀr
--			�Ҧp�A6F9619FF-8B86-D011-B42D-00C04FC964FF �O���Ī� uniqueidentifier �ȡC

--			SQL Server ��������ߤ@�ѧO�X (GUID) ��������|�H uniqueidentifier ��������Ӫ�ܡA
--			���|�x�s 16 �줸�ժ��G�i��ȡC GUID �O�G�i��Ʀr�A�D�n���ѧO���ϥΡA
--			�b�\�h�q�����\�h���x�W���������A���ѧO�������O�ߤ@���C 
--			GUID �i�ǥѩI�s Transact-SQL NEWID ��ƨӲ��͡A�ëO�Ҧb "���@��" ���O�ߤ@���C 
--			�@�ɤW�������x�p��������|�ͦ����ƪ� GUID �ȡC

--			GUID �D�n�Ω�b�֦��h�Ӹ`�I�B�h�x�p����������Ψt�Τ��A���t�����㦳�ߤ@�ʪ����ѲšC

--  �����}�Ghttp://read01.com/NyKE3G.html

--         �㦳��s�q�\���X�֦��Ƽg�M���ʽƼg�A���ϥ� uniqueidentifier ��Ʀ�A�H�T�O��ƦC�i�H�b�h����ƪ�ߤ@�ѧO�C
--	https://docs.microsoft.com/zh-tw/sql/t-sql/data-types/uniqueidentifier-transact-sql?view=sql-server-ver15


--			�D�n���ѧO���ϥΡA�b�\�h�q�����\�h���x�W���������A���ѧO�������O�ߤ@���C
--  https://docs.microsoft.com/zh-tw/dotnet/framework/data/adonet/sql/comparing-guid-and-uniqueidentifier-values


--	Step 0: Create a table with a uniqueidentifier data type
use  LabDB2 ;
go

--	check : master �� �˵� �� �t���˵��� �� sys.databases

drop table  if exists TestGuid1, TestGuid2

-- Step 1-1: Create a table with a uniqueidentifier data type
create table TestGuid1 (
	id int not null identity(1, 1),
	[Guid_NewID] UniqueIdentifier default newid()
);


-- Step 1-2: Add 3 rows using the NEWID() function.	GUID : Globly Unique ID
insert TestGuid1 ([Guid_NewID]) default values ;
go 5


-- Step 1-3: Examine the resulting rows
select * from TestGuid1 ;


--  �ϥ� NEWID() ��ơA�H���B�ü�(random)��� N ����ƦC
use Northwind
go
select * from Customers  -- �^�Ǧ� 91 ���Ȥ���

 
--  �H�H���B�üƪ��ƧǤ覡�A��ܥ������Ȥ���
select  CustomerID, Phone
from Northwind.dbo.Customers
order by newid()


--  �[�� : an example about 'rowguid' on column : 'rowguid' & 'ModifiedDate'
use AdventureWorks
select * from Sales.Customer



-- Step 2-1: Create a table with a uniqueidentifier data type
--		���O�Ѻ����d�W�����ѼƦr(�C�Ӻ����d�����ߤ@�����Ѹ��B�`��Ůɶ��B����ID�X�M�\�h�i�઺�Ʀr)�H
--		�[�� : cmd �� ipconfig/all �� �A�Ӻ����d VMware Network Adapter VMnet8 �� �����} : 00-50-56-C0-00-08
--												 �� �L�u�ϰ���������d �ϰ�s�u* 2: �� �����} : 30-24-32-B8-A7-64

--		�� CPU �������ߤ@�Ʀr�ͦ������@�� 32 ��4�줸��(byte)�C
--		���I : �x�s�Ŷ��W�j�F���ޮɶ����C�C

use LabDB2
create table TestGuid2 (
	id int not null identity (1, 1),
	[Guid_NewSequential_ID] UniqueIdentifier default NewSequentialId()
);
go


-- Step 2-2: Add 3 rows using the NEWID() function.	
insert TestGuid2 ([Guid_NewSequential_ID]) default values
go 5
 

-- Step 2-3: Examine the resulting rows

select * from TestGuid1 ;
select * from TestGuid2 ;

--  newsequentialid �禡��_ newid �禡�̤j���n�B�O�G�p�G�A�b�@�� UNIQUEIDENTIFIER ���W�إ߯��ޡA
--  �ϥ� newid ���ͪ��s���ȬO���T�w���A�ҥH�s���ȾɭP����B+���ܤƬO�H�����C
--  �� newsequentialid ���ͪ��s���ȬO���W�ߪ��A�h����B+���ܤƬO���W�ߪ��C
--  ���W�ߩM�L�W�ߴN�|�a�Ӯį઺��i�C

--	 UNIQUEIDENTIFIER���D��(Primary Key)�O�@��ܤ�K���Ʊ��A�b��ƦX�ֵ��ާ@�������i���N���u��
--  ���O�ѩ󴶳q��GUID�������ʨϱo�p�G�D��[�W�E������(Clustered Index)�|�ɭP�b���J�O���ɮĲv�j�j���C

-- Step 3: Clean up by dropping the tables
drop table  if exists TestGuid1, TestGuid2
