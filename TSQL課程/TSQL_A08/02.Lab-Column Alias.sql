--	Module 8 - Lab02 �ϥ����(Column) ���O�W


--	�Ǧ^�S�w���ó]�w�O�W
--		���O�W(Alias)�A�O�Ȯɵ��� table �� column ���{�ɦW�١C
--		�ϥΧO�W�O���F�W�[�iŪ�ʡC
--		�O�W���|�v�T���l���W�١C
--		�O�W�]�Ψӫ��w�B�⦡���G���W�١C
--		��d�߸�V�h�� table �ɨϥΧO�W�|�ܤ�K�C

use Northwind;
go

select * from Products

--	���[ Alias
select	ProductName			as '���~�W��',
			QuantityPerUnit		as '�C���ƶq',
			UnitPrice					as '�������',
			UnitPrice * 32			as '�x�����',
			UnitsInStock			as '�b�w�ƶq',
			UnitsOnOrder			as '�b�~�ƶq',
			UnitsInStock+UnitsOnOrder as '�b�w+�b�~�ƶq'
from Products;

--	�@�b�[ Alias
select	p.ProductName			as '���~�W��',
			p.QuantityPerUnit		as '�C���ƶq',
			p.UnitPrice					as '�������',
			p.UnitPrice * 32			as '�x�����',
			UnitsInStock			    as '�b�w�ƶq',
			UnitsOnOrder			    as '�b�~�ƶq',
			UnitsInStock+UnitsOnOrder as '�b�w+�b�~�ƶq'
from Products as p;


--	�X�������
select ProductName + ' /  ' + QuantityPerUnit as 'Name', UnitPrice 
from Products;

--	�f�t ROW_NUMBER ���,��ܸ�ƦC���X
select row_number() over (order by ProductName desc) as rowid, *		--  order by ProductName
from Products;

select * from Customers
select Address+', '+City as ship_to from Customers

select getdate() as '���� ���'