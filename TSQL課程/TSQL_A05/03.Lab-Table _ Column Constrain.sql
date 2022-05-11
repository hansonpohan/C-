--	Module 5 - Lab03 Table-level constraint vs. Column-level constraint

--	CONSTRAINT(�������) �@��:
--			NOT NULL (�����\ NULL ��)
--			PRIMARY KEY (�D������)
--			FOREIGN KEY (�~��������)
--			UNIQUE (�ߤ@��)
--			DEFAULT (�w�]��)
--			CHECK (����ˬd)

--	CONSTRAINT(�������) �i�b�إ߸�ƪ�(CREATE TABLE)���ɭԫ��w"�@��"��"�h��"�@�Τ@�ӭ���y�k�A
--			�άO���ƪ�إ߫�[�J(ALTER TABLE)�A�i�H������ؼh�� :
--			Column-level constraint (���h��) : 
--						�i�H���U�O�����w��������A�@�����W�d���@�����C
--			Table-level constraint (��ƪ�h��) :
--						�i�H���@�өΦh�����զ���������A������ƪ�w�q����������C

--	��Ʈw����ʬO���F�T�O��Ʈw������ơA�O���T�B���ĥB�@�P���C
--	�i�H�Q�α������(Constraints)�ӹ�@��Ʈw����Ƨ���ʡC
--	���駹��� : ��ƪ���Ʀ檺��Ƨ���ʡA�Ҧp : ��ƪ�u�঳�@�ӥD������A
--						�åB�D�䥲�����ߤ@�B�����\NULL�A�i�H�ϥ� NOT NULL�BPRIMARY KEY�BUNIQUE 
--						��������ӭ����ƪ�����ʡC
--	�짹��� : ��ƪ���Ʀ檺�ȥ��������S�w����������A
--						�p : CHECK�BFOREIGN KEY�BDEFAULT�BNOT NULL �����ݩ�짹��ʪ��d��C
--	�Ѧҧ���� : �z�L FOREIGN KEY ��������ӭ����ƪ�����ʡA��{�F��ƪ�P��ƪ��������p�C

use LabDB;
go

--	�b�إ߸�ƪ��
-- �� Table-level constraint �� Column-level constraint �ӫإ߱�����������ؤ覡���t��
drop table if exists Member0, Member1;
go

--	Column-level constraint : ��@��쪺���� unique
create table Member0 (
	ID int not null,									-- constraint
	Name varchar(50) not null,				-- constraint
	Birthday date,
	Gender char(1) default 'M',				-- constraint
	Email varchar(20) unique				-- constraint
	);
go

--	Table-level constraint �إ�UNIQUE : �h���(�h�b�Φb�����Primary Key)������
create table Member1 (
	ID int not null,
	Name varchar(50) not null,
	Birthday date,
	Gender char(1) default 'M',
	Email varchar(20),
			constraint UQ_Email unique (Email)				-- Table-level constraint �@�����
);
go

--	�h���(�h�b�Φb�����Primary Key)������
create table Member2 (
	ID int not null,
	Name varchar(50) not null,
	Birthday date,
	Gender char(1) default 'M',
	Email varchar(20),

	constraint PK_ID primary key clustered (ID asc),
	constraint UQ_codes unique nonclustered (Name, Birthday)   --  �����
) 
go


--	Column-level constraint �إߥD������
  create table Member3 (
	ID int primary key,            -- column level
	Name varchar (50) not null,
	Gender char (1) not null default 'M'
);
go


--	Table-level constraint �إߥD������
create table Member4 (
	ID int,
	Name varchar (50) not null,
	Gender char (1) not null default 'M'

	constraint PK_ID4 primary key(ID)
);
go
