 --	Module 01 ���p����Ʈw���򥻷����P SQL Server ²��
--		1-1 : ���p�ҫ��P���p�B��l(operators)
--		1-2 : SQL ���O������-DDL�BDML�BDCL 
--		1-3 : SQL Server �}�o�u��²��


--  �w�� SQL Server 2017dev and SMSS �ѦҼv��
--  https://www.youtube.com/watch?v=F6YDfgIJoBA
--  https://www.796t.com/article.php?id=14457

--  �U��, �w�� SQL Server
--	SQL server �U�� : �}�o�H�� �� SQL�}�o�H���u��  �� �U�� 2017 dev edition
--  https://www.microsoft.com/zh-tw/sql-server/developer-tools


-- SSMS �U�� (SQL server �w�˵����ɤ]�i�s���� SMSS �w��)
--  https://docs.microsoft.com/zh-tw/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15

--  �d�� SQL Server �����~�����B�����s��
select right (left(@@version, 25), 4) N'���~�����s��' , 
serverProperty ('ProductVersion') N'�����s��',
serverProperty ('ProductLevel') N'�����h��',
serverProperty ('Edition') N'������鲣�~����',
databasePropertyEx ('master', 'Version') N'��Ʈw�������������X',
@@version N'�����������s���B�B�z���[�c�B�ظm����M�@�~�t��'

--	���[�T��Ʈw : Northwind, AdvantureWorks, MarketDev

--  �b C:�ѤU�ؤ@  C: \Temp\

--  Most Popular Databases In The World
--		https://www.c-sharpcorner.com/article/what-is-the-most-popular-database-in-the-world/

--	Structure Quary Language (SQL)
--		https://zh.wikipedia.org/zh-tw/SQL

--	Transact-SQL�]�S��T-SQL�^
--		https://zh.wikipedia.org/zh-tw/Transact-SQL

--- SQL Server 2017/2019
--		p 6-1	SQL ���c�Ƭd�߻y��
--		p 6-5	SQL�y�������O����
--		p 2-6	���p����Ʈw�ҫ� Excel file,  (p2-8)
--		p 2-15	���p���N�� (p2-16)
--		p 4-5	�u�� (Tools)
--		p 1-2	��Ʈw�t�Ϊ���¦	(p1-3, p1-28) 
--		p 4-17	SQL Server �޲z�u�㪺�ϥ�

--  2017/2019 SQL Server�� �U�����} :  http://books.gotop.com.tw/download/AED003900


--  ���� SQL Server Management Studio (SSMS)
--	���ҳ]�w�G
--		�u�� �� �ﶵ �� ���� �� �r���M��m �� �r��,  �j�p
--		�u�� �� �ﶵ �� ��r�s�边 �� (click) Transact-SQL �� �渹
--		�˵� �� �����`�� / ����`��


--  �Ѧ� : (p 4-28)
-- �����`�� �� ��Ʈw ���t�θ�Ʈw :
--			master		��Ʈw	�O�� SQL Server ������骺�Ҧ��t�μh�Ÿ�T�C
--							DataBase �[��  master �� �˵�view �� �t���˵��� �� sys.databases (�ƹ��k��)
--							�� 1000 �Ӹ�ƦC

--			model		��Ʈw	�Ψӷ�@ SQL Server �������W�إߤ��Ҧ���Ʈw���d���C 
--							�� model ��Ʈw�i�檺�ק� (�Ҧp�A��Ʈw�j�p�B�w�ǡB�_��Ҧ��M��L��Ʈw�ﶵ) 
--							�|�M�Ψ줧��إߪ������Ʈw�C
--			msdb		��Ʈw	�� SQL Server Agent �Ω�Ƶ{ĵ�ܩM�@�~�C
--			tempdb	��Ʈw	�O�O�s�Ȧs����Τ��~���G�����u�@�Ŷ��C


--	���A���W��			��	��Ʈw�W��	��  ���c�y�z�W��	�� ��ƪ�W��  (p 6-4)
--	.\STUDENT-PC	��	LabDB	    	��	[dbo]Schema	��	student

--		1.  ���A���W�� Server		: [.\STUDENT-PC] , �D���� �� IP(192 . 168 . xx . xxx)]
--		2.  ��Ʈw�W�� DbName	: [LabDB]
--					��ʫظm��Ʈw : LabDB
--					�����`�� �� ��Ʈw(�ƹ��k��) �� �s�W��Ʈw �� LabDB (�[��, ��Ʈw����, �ݩ�...)
--		3.  ���c�y�z     Schema	: [dbo]  -- �w�] dbo : DataBase Owner (p 1-14)
--					Schemas ���� - LabDB �� �w���ʡ� ���c�y�z
--					��ʫظm schemas  �w���� �� ���c�y�z(�ƹ��k��) �� ���c�y�z
--		4.  ��ƪ�W�� Table		:  student
--					��ʫظm  LabDB ��  ��ƪ� (�ƹ��k��) �� �s�W �� ��ƪ�  
--							�m�߫ظmstudent ��ƪ�
--									student_id :			varchar(10)
--									studentName :		nvarchar(20)
--									birthday :				date
--									height :					tinyint

--		Table �[��  LabDB �� view ���t���˵��� �� sys.tables

--	��ʫظm��Ʈw
--		��Ʈwdbname  : LabDB (p 6-7, p 6-15) �ݩ��[��
--			LabDB(�ƹ��k��) �� �ݩ�
--		�@��ﶵ : Chinese_Taiwan_Stroke_CI_AS (p 6-20) �x�W�a�Ϫ��c�餤��
--			https://docs.microsoft.com/zh-tw/sql/t-sql/statements/windows-collation-name-transact-sql?view=sql-server-ver15

--				Stroke		:��ܫ����e���ǱƦC
--				Bopomofo: ��ܫ��`�����ǱƦC
--				CI				:���Case Insensitive(���Ϥ��j�p�g)
--				CS			:���Case Sensitive(�Ϥ��j�p�g)
--				AS			:���Accent Sensitive(�Ϥ������`)
--				AI				:���Accent Insensitive(���Ϥ������`)
--				90��100	:��ܸ��s������

--			�ɮ׸s�� : mdf, ndf, ldf
--			https://docs.microsoft.com/zh-tw/sql/relational-databases/databases/database-files-and-filegroups?view=sql-server-ver15


--  ���[�W�ҥθ�Ʈw
--			���Ѱ� TSQL_DB ����v�� Northwind, AdventureWorks, MarketDev
--			��Ʈw(�ƹ��k��) �� ���[ �� �[�J �� TSQL_DB��Ƨ��U���



use LabDB
select * from student    --- dbo.student

--		set Primary Key PK
--				dbo.student(�ƹ��k��) �� �]�p �� student_id(�ƹ��k��)  
--		set Foreign Key FK 
--				Northwind �� dbo.Orders �� �]�p �� OrderID(�ƹ��k��) �� ���p��


-- �ɥR��ơGDDL, DML, DQL, DCL (p 6-5)
-- https://social.technet.microsoft.com/wiki/contents/articles/34477.sql-server-commands-dml-ddl-dcl-tcl.aspx
--		SQL�y���@���|�����O�����O�G
--			DDL (Data Definition Language) ��Ʃw�q�y��
--				�Χ@�}�s��ƪ�B�]�w���B�R����ƪ�B�R�����A�޲z�Ҧ�������Ʈw���c���F��A
--				�`�������O��
--				�� Create	�G�إ߸�Ʈw������C
--				�� Alter		�G�ܧ��Ʈw������C
--				�� Drop		�G�R����Ʈw������C

--			DML (Data Manipulation Language) ��ƾާ@�y��
--				�Χ@�s�W�@����ơA�R���B��s���u�@�A�`�������O��
--				�� Insert	�G�s�W��ƨ� Table ���C
--				�� Update	�G��� Table ������ơC
--				�� Delete	�G�R�� Table ������ơC

--			DQL (Data Query Language) ��Ƭd�߻y��
--				�u����^�d�ߵ��G�A���O�u��1��
--				�� Select	�G�����Ʈw������ơC

--			DCL (Data Control Language) ��Ʊ���y��
--				�Χ@�B�z��Ʈw�v���Φw���]�w�A�`�������O��
--				�� Grant	�G�ᤩ�ϥΪ̨ϥΪ����v���C
--				�� Revoke	�G�����ϥΪ̨ϥΪ����v���C
--				�� Commit	�GTransaction ���`�@�~�����C
--				�� Rollback�GTransaction �@�~���`�A���ʪ���Ʀ^�_�� Transaction �}�l�����A


-- �ɥR��ơG�ϥ� SQL Server Management Studio (SSMS) �s�u�� SQL Server �������öi��d��
-- https://docs.microsoft.com/zh-tw/sql/ssms/tutorials/connect-query-sql-server?view=sql-server-ver15


--	�ק� student ���c
--		�u�� �� �ﶵ �� �]�p�v �� ����   �����x�s........


--	Steve �Ѯv�����ݪ��� iCoding : https://www.facebook.com/groups/icoding
--  email : jungan0914@gmail.com
