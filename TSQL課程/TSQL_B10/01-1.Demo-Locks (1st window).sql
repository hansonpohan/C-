 --	Module 10  ��Ʈw����w(Locks) �޲z²��
--				10-1: ��w������
--				10-2: �N����(Deadlocks) ���ͪ����v����̧C����k
--				10-3: ����j������(Transaction Isolation Level) ���]�w

--	�������w������:
--		1. �W������w (Exclusive Lock)
--		2. �@�Φ���w (Shared Lock)
--		3. ��s����w (Update Lock)
--		4. �N�Ϧ���w (Intent Lock)

--	��w�Ҧ�	�y�z
--		1.�W������w(Exclusive Lock)(X) : �T���L�����H "�s, ������w" ��ơA
--				��i��A����ɸ�ƨϥοW������w��AB����Y��ۦP��Ʊ��i���������w
--				�N�|�Q�ڵ�(���Ʈw�i��s�W�B�ק�B�R���P�d�߮ɡA�|���N��ƶi�榹��
--				�w�A������������~�|����æb�ݭn�ɥi�H�i��ROLLBACK), �Ω��ƭק�ʧ@�A
--				�Ҧp INSERT�BUPDATE �� DELETE�C �T�O�����ۦP�귽�P�ɶi��h����s�C

--		2. �@�Φ���w(Shared Lock) (S): �N��Ƴ]�w����Ū�A
--				���� "�T��" ��L������ƶi��W������w(Exclusive Lock)�A�����\��L�������
--				�A�i��@�Φ���w�A��Y��ƥi�P�ɳQ�h�ӥ�����@�Φ���w "Ū�����" ���e�A
--				���O "���i�H�i��W������w�P����Ƥ��e" (��"��Ū����Ʈw���"������ʤ��e�ɡA
--				�|�N��ư��@�Φ���w�A�����L�H�����), �Ω� "���ܧ�Χ�s" ��ƪ�Ū���@�~�A
--				�Ҧp SELECT ���z���C

--		3. ��s����w(Update Lock)(U) : ��s����w�P�@�ɦ�����ۦP�A
--				�������ݭn�N��� "�i��ק��s�ɷ|�۰ʴ��ɦ��W����" ��w�íק���
--				(���ɨõL��L�@�ɦ���w�s�b), �Ω�i��s���귽�W�C �����h�Ӥu�@���q���bŪ���B
--				��w�Ϋ�ӥi���s�귽�ɵo�ͱ`���������C

--		4. �N�Ϧ���w(Intent Lock) : ��ܱ�����w���󤤪� "�����귽"�A��D�n���ت���
--				���ɿW�e����w�ɪ���ƳB�z�į�A�ΨӼХܥX�Y���󤤪� "������w���"�A��
--				�ݦA�ˬd��ƪ����C�@���귽�O�_�w�g�Q��w�A�w�M�w�Ӹ�ƬO�_�i�i��W�e����w
--				�N�Ϧ���w������:
--						1. IntentShared(IS) : ��ܱ��i�� "�@�ɦ���w" ��Ū�����w���󤤪� "�����귽"
--						2. IntentExclusive(IX) : ��ܱ��i��"�W������w" �ç����w���󤤪� "�����귽"
--						3. SharedWithIntentExclusive(SIX) : ��ܱ��i��@�ɦ���w��Ū�����w����
--									�������귽�A�P�ɶi�� "�W������w�ç����w���󤤪������귽"

--		5.  ���c�y�z	����̩ۨ��ƪ��c�y�z���@�~�ɨϥΡC ���c�y�z��w���������G
--				���c�y�z�ק� (Sch-M) �P���c�y�zí�w�� (Sch-S)�CDDL���ƪ�L��

--		6. �j�q��s (BU)	�Ω�j�q�ƻs��ƨ��ƪ�A�B�w���w TABLOCK ���ܮɡC

--		7. ������d��	��ϥΥi�ǦC�ƥ���j�����ŮɡA�O�@�d��Ū������ƦC�d��C 
--				�T�w��L����L�k���J��ƦC�A�o�Ǹ�ƦC�b�d�߭��s����ɥi���w�i�ǦC�ƥ�����d�ߡC


--	01-1.Demo - Locks (1st window)

-- Step 1 - Open Activity Monitor�i���ʺʵ����j to view the current lock information.

-- Step 2 - Explain each of the rows returned

-- Step 3 - Open a new query window to the Deadlock database
use  LabDB2 ;
go


-- �ؤ@ DeadlockProduct �ǳƤu�@
drop table if exists DeadlockProduct ;

select  * into DeadlockProduct
from  MarketDev.Marketing.Product ;
go

alter table DeadlockProduct
	add constraint PK_DeadlockProduct  primary key (ProductID) ;
go
select * from DeadlockProduct

-- Use the SPID to identify the connection �Ǧ^�ثe�ϥΪ̳B�z�Ǫ��u�@���q�ѧO�X
select  @@spid  AS  'spid' ;


-- Step 4 - Update product 1 in a transaction
begin tran ;
	update DeadlockProduct 
	set  ProductName = 'Update from window 1'
	where  ProductID = 1 ;							-- not commit yet

select * from DeadlockProduct
select @@trancount						-- trancount = 1

-- Step 5 - Switch to the�i2nd window�j


-- Step 15 - Roll back the transaction in the�i1st window�j
rollback ;
go
