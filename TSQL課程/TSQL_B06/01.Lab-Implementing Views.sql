--	Module 6 �˵���(Views) ���]�p�P��@
--		6-1: �ϥ�CREATE VIEW �إ��˵�����
--		6-2: �p��d�߬Y�@�˵����l�w�q�����e
--		6-3: �p��ק��˵���B�R���˵���

--		View(�˵���) : �Ψӫإ߬d�߸�Ʈw���@�өΦh�Ӹ�ƪ���ƪ��˵�(��Ʀ�M��ƦC)
--		�� "������ƪ�"�A���@�� "�Q�ᤩ�W�٪� select �d��" �� "���W�٪���ƪ�B�⦡"
--		�P��ƪ��t���b�� View �� "���x�s���"�A�ȭt�d�x�s SQL �d�߱ԭz�ñN�d�ߵ��G���

--		View(�˵���)�u�I:
--			a. �w��C��ϥΪ̳]�p�d�ݸ�Ʈw��ƨ�²�Ƭd�ߥ\��
--			b. ���ϥΪ̯���z�L�˵��s����Ʀ� "���N�����s���ӷ�����ƪ�"�A�W�[�w����
--			c. �z�L "���ε{��" �s���˵���ɡA���ƪ��c���ܮɥu���ܧ��˵���]�w�A���ݭק�{��

--	2017/ 2019 SQL Server p11-1


use LabDB2
go

drop view if exists vSalesPerson, vPerson

select * from AdventureWorks.Sales.SalesPerson

--  Task 2 : Create a view using a single table 
create view vSalesPerson
as
select BusinessEntityID, TerritoryID, SalesQuota, rowguid
from AdventureWorks.Sales.SalesPerson   -- from adventureworks
where BusinessEntityID <=280

select * from vSalesPerson

select * from sys.syscomments			--	LabDB2  ��  �˵�
where id = object_id('vSalesPerson') ;
go

select object_definition (object_id ('vSalesPerson'));
go

exec sp_helptext 'vSalesPerson';
exec sp_help 'vSalesPerson';


-- Task 3: Complex views: Create a view using a multi-table join
create view vPerson
as
select pp.BusinessEntityID, pp.Title, pp.FirstName, pp.LastName, sp.name
from AdventureWorks.Person.Person as pp
join AdventureWorks.Person.StateProvince as sp
on pp.BusinessEntityID = sp.StateProvinceID			--  check : LabDB2 �� �˵�

--	�[�� vPerson 
select * from vPerson

select * from sys.syscomments			--	LabDB2  ��  �˵�
where id = object_id('vPerson') ;
go

select object_definition (object_id ('vPerson'));
go

exec sp_helptext 'vPerson';
exec sp_help 'vPerson';


--	�ҤG
select * from AdventureWorks.Production.ProductReview		--	PR
select * from AdventureWorks.Production.Product					--	PP
--  select * from sys.foreign_keys

create view vPR_PP
as
select pr.ProductID, pr.ReviewerName, p.Name, p.ProductNumber 
from AdventureWorks.Production.ProductReview as pr
join AdventureWorks.Production.Product as p 
on pr.ProductID = p.ProductID

-- Select from the view
select * from vPR_PP



-- Task 4: ALTER VIEW
alter view vPR_PP
with encryption					-- �[�K
as
select pr.ProductID, pr.ReviewerName, pr.EmailAddress, p.Name, p.ProductNumber  -- �[�@��� EmailAddress
from AdventureWorks.Production.ProductReview as pr
join AdventureWorks.Production.Product as p on pr.ProductID = p.ProductID
go
select * from vPR_PP


--  �[�� encryption vs. no encryption
select * from sys.syscomments 
where id = object_id('vPR_PP') ;		--  encryption, check : column ctext, text
go
select * from sys.syscomments		--  no encryption, check : column ctext, text
where id = object_id('vPerson') ; 
go


select object_definition (object_id ('vPR_PP')) as view_definition; --  encryption
go
select object_definition (object_id ('vPerson')) as view_definition; --  no encryption
go

--  ���� 'vPR_PP' ����r�w�[�K�C
exec sp_helptext  'vPR_PP';--   encryption
exec sp_helptext  'vPerson';--  no encryption

--  ��̮t�O���j
exec sp_help 'vPR_PP';--   encryption
exec sp_help 'vPerson';--  no encryption

-- Task 5: Clean up
drop view if exists vPerson, vPR_PP, vSalesPerson ;
