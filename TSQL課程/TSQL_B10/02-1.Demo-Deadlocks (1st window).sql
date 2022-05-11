--	Module 10  02-1.Demo - Deadlocks (1st window) 

--			��h�ӥ������w�ۦP�귽�A�P�ɩ������ݳQ�����w���귽�ɧY�o�ͦ����A
--			�q�`��Ʈw�|�w�ɦ۰ʰ����������D���o�͡A��o�ͮɷ|�N�b�䤤��X "�u���ư��W��"
--			�i����w������A���Ѩ�L����i�H�~�򧹦�, �� DeadLocks ���ͮɡA
--			�o�� Lock Manager �N�|���̷Ӧ����u���v�A��ܵ����u���v���C Process �A
--			�p�G��� Process �������u���v�ۦP���ܡA���N�|�b���⨺�U Rollback Cost 
--			���C�õ�����Process �A�����t�@�U Process �i�H���Q�����C

--			�귽�i��O : ���(RID, �襤�����)�B���ޤ�����(KEY, ����)�B��(PAGE, 8KB)�B
--			�ϵ��c(EXT, �s��8��)�B���B��(HOBT) �B��(TAB, �]�A��ƩM����)�B�ɮ�(File, ��Ʈw�ɮ�)�B
--			���ε{���M�θ귽(APP)�B�����(METADATA)�B���t�椸(Allocation_Unit)�B��Ӹ�Ʈw(DB)�C

--			�N����(Deadlocks) ���ͪ����v����̧C����k
--				1.  �ϥάۦP���s������ : ��Ҧ�����ҥH�ۦP�����Ǧs���ɡA�]�Ĥ@����w���
--					���~����i��U����w�A�]����ƱN���|����Block(���ݹ��)�����D

--				2.  �Y�u����ɶ� : �ɶq�N��ƥ����b�P�ӧ妸����A��֥�����Ƹ�ɶ��A��
--					�b������קK���ݨϥΪ̪�����(�Ҧp:���ݨϥΪ̿�J���)

--				3.  �ϥθ��C���j������ : ���C���j�����Ū������w�i�Ѧh�H�P��Ū���A�������o�ͦ���

-- Step 1: �}�ҡi�u��j���iSQL Server Profiler�j�� �i�ϥνd���j�b�u��U�Ԧ���椤�iTSQL_Locks�j
-- Step 2: ���ҡi�ƥ����d��j�� �ȤĿ�iDeadlock Graph�j�ƥ󪺷s�l��(trace) �� ����C

-- Step 3: �b���������A�Х�����U�誺������O�X
--              �M��A�ߧY����i2nd Window�j(�ĤG����)�����O�X (�Ф�����i2nd Window�j(�ĤG����))

use  LabDB2 ;
go

-- select * from DeadlockProduct
select  @@spid  AS  'spid' ;
begin tran
	  update DeadlockProduct set ProductName = 'Prod 2 Modified 1'
	  where ProductID = 2 ;

	  waitfor delay '00:00:08' ;

	  update DeadlockProduct set ProductName = 'Prod 1 Modified 1'
	  where ProductID = 1 ;
commit ;

select * from DeadlockProduct

-- Step 4: ���[��@�U�s�����@��|�X�{ 1205 �����~�N���B�@��������� (Deadlocks)���묹��(victim) �C

-- Step 5: ���������l�ܨìd�ݳo�� Deadlock Graph�C

-- Step 6: �бN Deadlock Graph �����G�[�H�ץX �C(�ɮ� �� �ץX ��  �^�� SQL Server �ƥ� ��  �^�������ƥ� )

