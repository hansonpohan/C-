--	Module 4 �ϥ�Keys������� (Constraints)�ӹ�@��ƪ������ 
--		4-1 : PRIMARY KEY �������		[unique,  no null]
--		4-2 : FOREIGN KEY �������	[no unique,	null]
--		4-3 : UNIQUE �������				[unique,	one null]

--	CONTRAINT(�������) �i�H�Ψӱj����� SQL Server ��ƪ�����Ƨ���ʡC
--					�T�O��Ʈw������ƬO�ǽT�B���ġB�@�P���C
--	CONTRAINT(�������) �O�������x�s���ƪ����y�k�A�]���g�J����Ƴ�������u�o�ӷǫh�C
--	CONTRAINT(�������) �o�ǭ���y�k�i�H�bCREATE TABLE �Ψƫ�� ALTER TABLE �y�y�ӫ��w�C


--	PRIMARY KEY(�D������) �O�Ψӿ��Ѭ��������A�T�{��ƪ��C�@����Ƴ��O��椤���ߤ@�ȡC
--				�������A���O�ΨӿW�@�L�G�a�T�{�@�Ӫ�椤���C�@���ơC
--	PRIMARY KEY(�D������)�i�H��{��Ʈw�����駹��ʡC
--			�D������Ȥ��i���ơA�åB�����w�q�� NOT NULL�C
--			�@�Ӹ�ƪ�u�঳ "�@�ӥD�����䪺�������"�A�i�H�ϥΤ@�����A�άO���w�h�����զX�_�Ӱ����ƦX������C
--			��ƪ� "�i�H���㦳�D������"�A���O�@�볣��ĳ�̦n�O���C

use LabDB;
go
--	Lab01 ��ƪ� PRIMARY KEY �������
--	�U�C�d�ҷ|�إߤ@�Ӹ�ƪ�A�æb��Ʀ�W�w�q�D������C
--	�n�`�N��쥲����� "NOT NULL" �ݩʡA�B"�S�����ƭ�" , NOT NULL �i�g�i���g
create table Product(
    id_identity int identity (1, 1),
    ProductID int  not null, constraint PK_ProductID primary key clustered (ProductID),
	ProdName nvarchar(50)
);
go

insert Product values(1, 'Apple')
insert Product values(2, 'Banana')
insert Product values(3, 'Cherry')

insert Product values(1, 'Apple')		-- Error PK constrain 

select * from Product

-- check : LabDB �� ��ƪ� �� dbo.Product �� ��Ʀ� �� ProductID


--	�R�����ո�ƪ� constraint PK, not column
alter table Product  
	drop constraint PK_ProductID;
go  

insert Product values(1, 'Apple')	-- success

delete from Product where ProductID=1;
--	�U�C�d�ҷ|�b�{������ƪ�إߥD������C
--		�n�`�N��쥲����� NOT NULL �ݩʡA�B�S�����ƭ�

alter table Product
    add constraint PK_ProductID primary key clustered (ProductID);
go

select * from Product

update Product set ProductID=5 where ProductID=2


-- �[�� [Order Datail] ����Ʀ椤�X�{����"�_��"

drop table if exists Product