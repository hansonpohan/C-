--	Module 11   T-SQL �{�������~�T��
--		11-1: ���~�T���������Ψ�Ҩ㦳���ݩ�
--		11-2: �z�LERROR_XXX()�t�Ψ�ƨ��o���~�T��
--		11-3: �t�Ψ��@@ERROR �PERROR_NUMBER()�������t��

--	���~�T���s�� : �ΨӪ�ܿ��~�T���ҹ������ߤ@���~���X
--	https://docs.microsoft.com/zh-tw/sql/relational-databases/errors-events/database-engine-events-and-errors?view=sql-server-ver15

--  ���~�T���Y���ʼh��(Seveirity) : �|�Ǧ^�Y���ʡC�ƭȽd��0-24, �䤤�Y���ʧC (�Ҧp : 0~9) �����~
--					��ܬO "�ѦҰT��" �� "�C��ĵ�i" , �Y���ʰ������~������Ӿ��ֳB�z�����D
-- https://docs.microsoft.com/zh-tw/sql/relational-databases/errors-events/database-engine-error-severities?view=sql-server-ver15


--	01.Demo - Error types and Severities.sql
-- Step 1: Open a new query window to MarketDev
use  AdventureWorks ;
go

-- Step 2: Note the returned error from a "syntax error"
--              ��� WebSite ���~�T���s��

selec  *  from  Person.Person ;  --  'selec' ���� '*' ���B���y�k�����T�C
go

-- Step 3: Note the returned error from an "object resolution error"
--              Describe each returned entry in the error message
select  *  from  Dog ;						-- �L�Ī�����W�� 'Dog'
go


-- Step 4: Note the returned error from a runtime error
--              Describe each returned entry in the error message
--              and show how double-clicking the error in the messages
--              tab takes you directly to the error
select  12/0 ;								-- �o�{���H�s�����~�C
go

-- Step 5: Query the contents of the sys.messages view
--              Note the language_id settings
select * from sys.messages 
where language_id=1028
order by language_id, message_id;
go

-- Step 6: Query the English messages only with severity 19 or above. 
--              Note the is_event_logged column
select * from  sys.messages
where  language_id = 1033 and  severity >= 19
order by  severity,  message_id ;


select * from  sys.messages
where  language_id = 1028 and severity >= 19
order by severity,  message_id ;