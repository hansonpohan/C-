--	Module 6   02.Demo - WITH CHECK OPTION.sql
--			�j��W�w���˵����檺�Ҧ���ƭקﳯ�z��������` select_statement ���ҳ]�w���ǫh�C 
--			��Q���˵��ӭק��ƦC�ɡA
--			WITH CHECK OPTION �i�T�O�b�{�i�ק蠟��A���i�H�z�L�˵������ơC

use LabDB2;
go

select * into TpEmployees				-- like copy
from Northwind.dbo.Employees

drop view if exists vTpEmployee_Ms ;


--	WITH CHECK OPTION �b�˵���(Views) ���w�q���ϥ� 
create view vTpEmployee_Ms
as
select EmployeeID,  TitleOfCourtesy,  FirstName,  LastName, Title
from TpEmployees
where TitleOfCourtesy = 'Ms.'		-- �� View ���w�d�ݡiMs.�j�����
with check option;						-- �p�G�S�� with check option ��Ʒ|�Q�g�J 'Mr.'
go


exec sp_helptext 'vTpEmployee_Ms' ;					-- View

select * from vTpEmployee_Ms ;
select * from TpEmployees ;
go


--	�[�JWITH CHECK OPTION�ɡA���� "�z�L VIEW" �Q�ק�ηs�W�ɷ|�ˬd�˵���
--  "�إ߮ɪ�����]�w"�A�Y���ŦX�|�o�Ϳ��~�ڵ�����

-- Error : Mr.  �]���ؼ��˵����w�F WITH CHECK OPTION �θ�V���w�F
-- WITH CHECK OPTION ���˵����ͪ��@�өΦh�Ӹ�ƦC�b CHECK OPTION ��������U�ä��X��C
insert vTpEmployee_Ms  -- View
	values ( 'Mr.', 'Andy', 'Garcia', 'Movie Star') ;  
go


-- Ms. OK
insert vTpEmployee_Ms  -- View
	values	( 'Ms.', 'Nancy', 'Francis', 'Movie Star')		
select * from vTpEmployee_Ms
select * from TpEmployees

update vTpEmployee_Ms
set Title = 'Programmer'
where FirstName = 'Nancy';
select * from vTpEmployee_Ms
select * from TpEmployees


-- Error : Mr. again�]���ؼ��˵����w�F WITH CHECK OPTION �θ�V���w�F
-- WITH CHECK OPTION ���˵����ͪ��@�өΦh�Ӹ�ƦC�b CHECK OPTION ��������U�ä��X��C
update vTpEmployee_Ms
set TitleOfCourtesy = 'Mr.'			--Mr. is not Ms.
where FirstName = 'Janet'; 



--	WITH Encryption : �b�˵���(Views) ���w�q���ϥ� 
drop view if exists vTpEmployee_Ms_encryption ;

create view vTpEmployee_Ms_encryption
with encryption										--	�[�K��ݤ���䤤���y�k
as
select EmployeeID,  TitleOfCourtesy,  FirstName,  LastName, Title
from vTpEmployee_Ms				-- �q view (table) �� ���� view
where TitleOfCourtesy = 'Ms.'		-- �� View ���w�d�ݡiMs.�j�����
with check option;						-- �p�G�S�� with check option ��Ʒ|�Q�g�J 'Mr.'
go

exec sp_helptext 'vTpEmployee_Ms_encryption' ;	--	�[�K��ݤ���䤤���y�k

select * from vTpEmployee_Ms_encryption ;
go


insert vTpEmployee_Ms_encryption						        -- �[�K�ᤴ�i�W�[ insert
	values	( 'Ms.', 'Mary', 'Francis', 'Great Movie Star')		-- Ms. OK
select * from vTpEmployee_Ms_encryption ;	
go


update vTpEmployee_Ms_encryption
set Title = 'Programmer'
where FirstName = 'Nancy';

select * from vTpEmployee_Ms_encryption ;
go

-- Clean up :
drop table if exists TpEmployees
drop view if exists vTpEmployee_Ms ;
drop view if exists vTpEmployee_Ms_encryption ;
