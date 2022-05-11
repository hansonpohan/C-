 --	Module 9   ��Ʈw����� (Transactions) ����²��
--			9-1: ���(Transactions) �� A.C.I.D. �|���ݩ�
--			9-2: SQL Server �D�n������޲z�Ҧ� (Transaction Management Mode)
--			9-3: @@TRANCOUNT ���ȻP COMMIT�BROLLBACK �����Y

--	A. C. I. D.
--		���i���������ʡ]Atomicity�^: �������������������all�A�n���N�O����������nothing�C
--		�@�P�ʡ]Consistency�^: ��������ɡA��������ƥ��������@�P�ʪ����A�C
--		�j���ʡ]Isolation�^: ���������Ʒ|�B��j�����A�A�L�k�Q�䥦����s���C
--		�@�[�ʡ]Durability�^:	�����������A��@�ΫK�û��s�b��t�Τ���


--	SQL Server��������3�ӥ���Ҧ�:
--			1. �۰ʻ{�i��� (Autocommit transaction) : "�w�]" �Ҧ�
--				�� "�C�� T-SQL �ԭz����" �ɳ��۰ʵ��� "�@��" ����A��ԭz���槹���ɦ۰ʻ{�i����A
--				�Y�����~�o�ͥ���K�|�۰ʦ^�_ (�^�u) rollback (���L�ëD�Ҧ� T-SQL ���O���䴩�۰ʻ{�i���)�A
--				�ثe���䴩�����O�p�U:
--				Alter Table, Create, Delete, Drop, Fetch, Grant, Insert, Open, Revoke,
--				Select, Truncate Table, Update

--			2. �~����(Explicit transaction):
--				�����z�L Begin Tran�BCommit Tran �P Rollback Tran �����O�ԭz����������覡

--			3. ���t���(Implicit transaction default OFF) : 
--				�u�� �� �ﶵ �� �d�߰��� �� SQL Server �� ANSI  ��  Set_Implicit_Transaction�A
--				�z�L Set IMPLICIT_TRANSACTIONS ON �� OFF ���覡�ҰʻP�������t����A
--				���Ʈw�i�J���Ҧ����}�l����K TRANCOUNT=1�A"������� COMMIT TRAN 
--				�� ROLLBACK Tran���O" �۰ʶi��U�ӥ��

--	2017/ 2019 SQL Server p 13-4

--	�� SET XACT_ABORT �O ON �ɡA�p�G Transact-SQL ���z�����Ͱ��涥�q���~�A
--			�N�|�פ�M"�^�_" rollback ��ӥ���C
--	�� SET XACT_ABORT �O OFF �ɡA�b�Y�Ǳ��p�U�A�u�|"�^�_"���Ϳ��~�� Transact-SQL ���z���A
--			����|�~��i��C

set xact_abort on

use LabDB2;
go

--	Create and populate a test table
drop table if exists NewTable ;

create table NewTable (
		Id int primary key, 
		Info char(10)
)

rollback tran			--  �N transaction count �k 0,  �n�D�S�������� BEGIN TRANSACTION

--	 case 1: �iCompile Errors�j All Rollback �����L�k�g�J
select @@trancount
insert NewTable values (1, 'aaa') ;
insert NewTable values (2, 'bbb') ;
insert NewTable VALUSE (3, 'ccc') ;		-- Syntax error. (�y�k���~!)

select * from NewTable ;							-- �����L�k�g�J.



--	case 2: �۰ʻ{�i���(Autocommit transaction) : "�w�]" �Ҧ�  Partial commit, Partial rollback
select @@trancount
insert NewTable values (1, 'aaa') ;			-- �����g�J Partial commit
insert NewTable values (2, 'bbb') ;          -- �����g�J Partial commit
insert NewTbl	   values (3, 'ccc')				-- Table name error. (����ѪR���~!)
insert NewTable values (4, 'bbb') ;
select @@trancount

select * from NewTable ;							-- �ȼg�J�ⵧ



-- case 2.1  �~����(Explicit transaction)  all rollback
--  ��@�q���O�Q begin tran ..... commit tran �]�Ю�, �O�B������, �� "����@�ӿ��~" , ��]�^�u rollback
begin tran
	select @@trancount
	insert NewTable values (10, 'aaa') ;
	insert NewTable values (20, 'bbb') ;
	insert NewTbl    values (30, 'ccc')				-- Table name error. (����ѪR���~!)��]�^�u rollback
	insert NewTable values (40, 'bbb') ;
	select @@trancount
commit tran

select * from NewTable ;	



--	case 3: �۰ʻ{�i���(Autocommit transaction) : "�w�]" �Ҧ�  Partial commit, Partial rollback
select * from NewTable 

insert NewTable values (3, 'aaa') ;
insert NewTable values (4, 'bbb') ;
insert NewTable values (2, 'bbb') ;		-- Duplicate key error.
insert NewTable values (5, 'bbb') ;

select * from NewTable 



--	case 3.1 : �~����(Explicit transaction)  all rollback
begin tran
		select @@trancount
		insert NewTable values (30, 'aaa') ;
		insert NewTable values (40, 'bbb') ;
		insert NewTable values (2, 'bbb') ;		-- Duplicate key error.
		insert NewTable values (50, 'bbb') ;
		select @@trancount
commit tran

select * from NewTable 

set xact_abort off

