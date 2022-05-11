--	Module 9 - Lab02 �B��l���檺�u����

--	SQL��4���������B��l�A���O�O��ƹB��l�B�޿�B��l�B�����B��l�Τ���B��l
--		��ƹB��l�G�[�k(+)�B��k(-)�B���k(*)�B�Ӽ�(/)�B�l��(%)
--		�޿�B��l�GAND�BOR�BNOT : �зǥ��L�޿�B��l�C
--				LIKE : �f�t�U�Φr���A�P�_ "�r��" �O�_�ŦX���w���Ҧ��C
--				BETWEEN : �b�Y�d�򤺡C
--				IN : �O�_�b�@�C�Ȥ����C
--				ALL�BANY�BSOME : ��� "�¶q��" �P��@��Ʀ涰���ȡAALL�����X���ŦX�A
--							ANY�MSOME�����A���N�ժ������TRUE�h SOME �� ANY �|�Ǧ^ TRUE�C
--				EXISTS : ���w��ƦC�O�_�s�b��l�d�ߤ����C
--		�����B��l�G���w������(=)
--		����B��l�G�p��(<)�B�j��(>)�B�p�󵥩�(<=)�B�j�󵥩�(>=)�B����(=)�B������(!=, <>)


use Northwind;
go

--	��B�⦡����ӹB��l���ۦP���u���h�ŮɡA�|�̾ڥ��b�B�⦡������m�A�� "���ܥk" �Ӱ��B��C 
--	�Ҧp�A�b�U�C SET ���z�������Ʀr�B��A�|������k�B��l�A�A����[�k�B��l�C
declare @Number1 int;  
set @Number1 = 10 - 5 + 100;  
select @Number1							-- ���G
print @Number1;								-- �T��

--	��������[��A���k�B��l���u�����ǰ���[�k�B��l�C
declare @Number2 int;  
set @Number2 = 2 * 4 + 5;  
select @Number2;  

--	�A�����u���B��
declare @Number3 int;  
set @Number3 = 4 * (1 + 8);  
select @Number3;

--	�p�G�B�⦡���_���A���A�̤��h�A�����B�⦡�̥����B��C
declare @Number4 int;  
set @Number4 = 2 * (4 + (5 - 3) );  
select @Number4;  

declare @Number5 int;									-- Number5 is int
set @Number5 = '100';									-- Number5 is assigned '100' ��r
select @Number5;

declare @Number6 varchar;							-- Number6 is varchar
set @Number6 = 100;										-- Number6 is assigned 100 int �Ʀr
select @Number6;

--	�U�C�d�ҡA�p�G�A���ٲ��|�o�X���P�����G
select OrderID, CustomerID, Freight, ShipCity, ShipName 
from Orders 
where Freight > 10 and (CustomerID like '%VI%' or ShipName like '%VI%')
--where Freight > 10 and CustomerID like '%VI%' or ShipName like '%VI%'


--	��X�O�_�Ҧ�Freight�j��10
if 10 < any (select Freight from Orders)						-- try 0, ANY, SOME or where Freight >10
    print 'True'   
else  
    print 'False' ;  
select Freight from Orders

--	��X�O�_���j��65�������u; ANY��SOME���@��
if 65 < some (select (year(getdate())- year(BirthDate)) from Employees)   -- if boolean
	print 'True'   
else  
	print 'False' ;  
select (year(getdate())- year(BirthDate)) from Employees

--	�l�d�߶Ǧ^���u 1 �ӭȡC�o�ت��p�b�l�d�ߤ��ᦳ =�B!=�B<�B<=�B>�B>= 
--	�άO�l�d�ߧ@���B�⦡�ϥήɬO�����\���C
--  Error : select Freight from Orders �Ǧ^�h�Ӭd�ߵ��G, �]�� @myFreight int �O�@���
declare @myFreight int = (select Freight from Orders)		-- error
print @myFreight


--	Level	Operators
--	1	~ (�줸 NOT)
--	2	* (��), / (��), % (�l��)
--	3	+ (��), - (�t), + (�[), + (��s), - (��), & (�줸AND), ^ (�줸���� OR), | (�줸 OR)
--	4	=, >, <, >=, <=, <>, !=, !>, !< (����B��l)
--	5	NOT
--	6	AND
--	7	ALL, ANY, BETWEEN, IN, LIKE, OR, SOME
--	8	= (����)

--	��B�⦡���h�ӹB��l�ɡA�B��l���u�����Ƿ|�v�T�d�ߪ����G�C
--	�W�����������B��l���u�����ǡA�ѤW�ӤU�A�h�Ű����u�������C
--	�u������ : ��ƹB��l (��������[��) �� ����B��l �� �޿�B��l �� �����B��l
--	���ӹB��l�㦳�ۦP���u���h�ŮɡA�|�̷ӥ��b�B�⦡����m�A�ѥ��ܥk�Ӱ��B��C
--	�p�A��()�����Ҧ����ط|���B��A�èD�o��@�ȡA�A���~���B��l�A�ϥθӭȰ��B��C
