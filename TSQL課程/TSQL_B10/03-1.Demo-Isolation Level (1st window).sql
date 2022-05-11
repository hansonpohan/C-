--	Module 10  03-1.Demo - Isolation Level (1st window).sql

--	����j������(Transaction Isolation Level) ���]�w
--			�j����(Isolation) : ��ܦb�U������L�{���ҷ|�Ψ쪺��ơA�����U�������ƿW�ߦU�ۥ���A
--			�~���|�y���U��ƶ����ۼv�T�A��ƿ��áA�i�z�L�����w���覡�ӹF���A
--			�j���ʶV����æ��(�h����P�ɳB�z)�N�V�C�A�����o����	�B�@���ŻP�Ĳv�A�i�z�L�]�w�j�������Ũӧ���

--	����j������ :	�Ψӳ]�w���Ū����ƪ��j�����A�A�̹j���ʪ����C�i�Ϥ���5�ӵ���
--		1.ReadUncommitted :			(Isolation Level 0)
--				�����L�j���AŪ��������H�ɦ��Q���(��s�ΧR��)�����|�A	�]"�i��Ū����|��������s�����"

--		2.ReadCommitted(�w�]) :	(Isolation Level 1)
--				�����\Ū���|��Commit����ơA�]�����|Ū����|��������s����ơA��ƳQ��s�����|�]���C

--		3.RepeatableRead :			(Isolation Level 2)
--				����ɩ�Ū������Ƥ����\�Q���(��s�ΧR��)�A�T�O�C��������Ҩ��o�ۦP��Ƥ��e�A
--				������i�� "����Ū�����" �ɡA�i��|�]��L����i��s�W��Ʋ��͸�ƼW�[������

--		4.Snapshot :						(Isolation Level 3)
--				�ַӸ�Ʈw(Database Snapshots)�i�H���Ѹ�Ʈw�S�w�ɶ��I���R�A�˵��A
--				���O��Ū����Ʈw�A�g�`�Q�ϥΦb����γ~�A�ѩ����R��b���w���ɶ��I�A
--				�i�H�����קK�s����y���������Ʀr�t���C��Ʈw�ַ�(Snapshot)
--				�O�@�ӥi�H�N��Ʈw�ֳt�����ͤ@�Ӹ�Ʈw�� "�ƥ�" ���@�ا޳N�A
--				�ӱqSQL Server 2005�}�l

--		5.Serializable :						(Isolation Level 4)
--				�ݭn�i�檺��������ƶ��A�N�ҥΨ쪺��ƥ����i����w�A�����\��L������i��
--				�s�W�B�ק�ΧR�����ʧ@�A���ثe������������L����~��i��


use  AdventureWorks ;

-- Use the SPID to identify the connection �Ǧ^�ثe�ϥΪ̳B�z�Ǫ��u�@���q�ѧO�X�C

select @@spid as 'id', system_user as 'login name', user as 'user name';
--	select * from sys.schemas


dbcc useroptions ;					-- isolation level: Read Committed (�w�])

set tran isolation level serializable

dbcc useroptions ; -- isolation level: Serializable (Level 4)
--	SERIALIZABLE: Prevent other users from accessing rows  that match the criteria in a WHERE clause.

--  Step 1
begin tran
	select * from Person.Person 
	where  BusinessEntityID = 6 ;
	 

--  Step 2 Open �i2nd window�j
--	for the purpose of the exercise, 
--  commit transaction or rollback transaction are not used 


--	Step 5 run rollacb tran�[�� windows2 �O�_�Ѱ��i update
rollback tran;

-- Step 6 �^�_ read committed
set tran isolation level read committed

dbcc useroptions ; -- isolation level: Read Committed