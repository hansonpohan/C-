--	Module 5 �ϥΤ@�몺������� (Constraints) �ӹ�@��ƪ������
--		5-1 : DEFAULT �������
--		5-2 : CHECK �������
--		5-3 : Table-level constraint vs. Column-level constraint

--	DEFAULT ��������Ψӳ]�w�����쪺�w�]�ȡC
--	�b�s�W��ƪ��ɭԦp�G�o�����S�����w�ȡA SQL Server �N�|�ϥιw�]�ȡC
--	�p�G�����쥼�]�w DEFAULT�A�ӥB�ϥΪ̥���J��ơA�i�঳��ر��p :
--		���\ NULL : �| NULL ���J��Ʀ�C
--		�����\ NULL : ��Ʀ�N�|�O�d�ťաA�����b���Ѹ�����ȫ�~���x�s��ơC

--	��Ʈw�]�p�W�i�H�ϥ� DEFAULT + NOT NULL �ӽT�O��즳�ȡA�i�H��ֵ{������W�����~���͡C
--	DEFAULT �Ȧp�G�O��r�r��A�Шϥγ�޸� (��) �]�_�ӡA�Ӥ��n�ϥ����޸� (��) �C
--	DEFAULT �Ȧp�G�O�Ʀr�A������J�Ʀr�A���Υ[�W�޸��C
--	�]�i�H�ϥΪ���Ψ�ư��� DEFAULT �ȡA�Ҧp�w�]�����쬰���Ѫ�����A�i�H�ϥ� GETDATE()�C


-- Lab01 DEFAULT �������
use LabDB;
go

--	�b CREATE TABLE �ɫإ� DEFAULT ����
create table Member (
	ID int not null,
	Name varchar(50) not null,
	MemEnable bit default 0             -- BIT �@�ؾ�Ƹ�������A��Ȧ� 1�B0 �� NULL �X�ءC
);
go

insert Member values (1, 'Helen', 0)
insert Member values (2, 'Mary', 1)
insert Member values (3, 'Tom', '')
insert Member values (3, 'Tom', Null)
select * from Member

--	�b CREATE TABLE �ɫإ� DEFAULT ����R�W CONSTRAINT
create table Member1 (
	  ID int not null,
	  Name varchar(50) not null,
	  MemEnable bit constraint DF_MemEnable default 0    -- use bit True, False
);
go

--	�b�{������ƪ�إ� DEFAULT ����
alter table Member1 drop DF_MemEnable;  -- ������ƪ� DEFAULT 0 ������

alter table Member1 add constraint DF_MemEnable default 1 for MemEnable;  -- �W�[��ƪ� DEFAULT 1����


-- ERROR : following DON'T work now -- set �y�k���D
alter table Member1 alter column MemEnable set default 1 ;			--		�y�k���D

alter table Member1 add constraint DF_SomeName default 0 for MemEnable;  -- ����


--	DROP TABLE
drop table if exists Member, Member1;
go