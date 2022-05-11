 --	Module 13 �w�s�{��(Stored Procedure)���]�p�P��@
--				13-1: �p��إ߻P����w�s�{��
--				13-2: �p��ק�w�s�{��
--				13-3: �p��R���w�s�{��

--	Stored Procedure(�w�s�{��)������:
--				System Stored Procedure(�t�ιw�s�{��)
--				Extended Stored Procedure(�X�R�w�s�{��)
--				User-Defined Stored Procedure(�ϥΪ̦ۭq�w�s�{��)


--	SQL Server �� Stored Procedure (�w�s�{��sp) : �ΨӱN�`�ν������u�@ "�w���]�p"
--			��SQL�{�����x�s���@�ӵ{�ǦW�١A�ݭn�ϥήɦA�H EXECUTE ���榹�{�ǧ���
--			�u�@�A���u�I���i���ƨϥΡB����Ĳv���B�w���ʨ� (�[�K�s�X) �P�ާ@�y�{�Τ@
--			�A�q�`���F�W�[��Ʀs�����w���P�O�K�A�|�N��ƪ���@��ϥΪ̵L�k "����" �s����
--			�إ� "�˵���" �� "�w�s�{��" �ѨϥΪ� "����" �s���S�w����Ƥ��e�P�{��,  
--			���I�������@�Ө�Ʀs�b�@���ܼƸ̡A����I�s�o���ܼƪ��ɭԴN�i�H�]�̭����{���X�C

--	01.Demo - System Stored Procedures.sql

-- Step 1: Open a new query window to the tempdb database
use  LabDB2 ;
go

-- Step 2: Browse the list of �uSystem Stored Procedures �v

--				System Stored Procedure (�t�ιw�s�{��) : SQLServer ���ت��w�s�{�ǡA�H
--				sp_�}�Y�ΨӰ���t�ά������]�w�B�޲z�P��T�����o
--            �imaster�j���i�i�{���ʡj���i�w�s�{�ǡj���i�t�ιw�s�{�ǡj�C
--				ex. : sp_attach_db,   sp_detach_db,  sp_help, 

-- Step 3: Execute some system stored procedures to see how they could be used
exec  sys.sp_configure ;
go

exec  sys.sp_helpdb ;
go


--				Extended Stored Procedure (�X�R�w�s�{��) : �ѵ{���y�����g��DLL�ɴ���
--				�X�R�\��s�����(�Ҧp:C++�y��)�A�H xp_ ���}�Y���
--            �imaster�j���i�i�{���ʡj���i�X�R�w�s�{�ǡj���i�t���X�R�w�s�{�ǡj�C

--				�� set facet = true  �w���Ҷq
--				�����`�� �� \SQLEXPRESS(SQL...) (�k��) �� Facet �� XPCmdShellEnable (Ture)
--				���� xp_ �}�Y���w�s�{�ǥ����ƥ����w�Ҧb��Ʈw��m�A�B���t�Φw���ʭ�G
--				�w�]�|���� xp_ �}�Y���w�s�{�ǻݨƥ��]�w�}�Ҥ~�i�ϥ�

 
exec xp_cmdshell 'dir c:\'

--  xp_cmdshell �X�R�w�s�{���]�|��ĳ�Ǧ^���A�C �Ǧ^�X���x�s�b�ܼ� @result ��
declare @result int;  
exec @result = xp_cmdshell 'dir c:\*.exe';    -- try : remove *.exe
if (@result = 0)  
   print 'Success'  
else  
   print 'Failure';



--  �p��Ū���Y��Ʈw���Ҧ��w�s�{�ǦW��(Stored Procedure name)
select * from sysobjects
where xtype= 'PK' 
order by name

   