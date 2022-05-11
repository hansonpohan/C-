 --	Module 2  ��ƪ�(Tables) ���i���[���B�]�p�P��@
--		2-1: �z�L�t���˵���(system views) �d��Meta-Data
--		2-2: �f�tuniqueidentifier��������M���ǥ�NEWID()�BNEWSEQUENTIALID()�Ӳ���GUID ����
--		2-3: ����timestamp �Prowversion����������ϥΤ覡


--	���~��ƨ�� 
--  https://docs.microsoft.com/zh-tw/sql/t-sql/functions/metadata-functions-transact-sql?view=sql-server-ver15
--			�Ҧ����~��ƨ�Ƴ�����M�w�ʡC �o��ܳo�Ǩ�ƨëD�C���I�s�ɡA���|�Ǧ^�ۦP�����G�A
--			�Y�K�ϥΦP�@�տ�J�Ȥ]�O�p���C

--	01.Lab : �z�L�t���˵���(system views) �d��Meta-Data

use LabDB2;
go

--  check : master �� �˵� �� �t���˵��� �� sys.tables
select schema_name(schema_id)+ '.' + name as tablename,  *		-- "type_desc"
from sys.tables;
go

use LabDB2
--  check : LabDB2 �� �˵� �� �t���˵��� �� information_schema.table_constraints
select *
from information_schema.table_constraints
where table_name = 'Employee';			--  Don't add schema name HR
go
--  �[����� : constrint_schema,  constraint_name, constraint_type



--	check : LabDB2 �� �˵� �� �t���˵��� �� sys.key_constraints
select *
from sys.key_constraints
where parent_object_id = object_id('HR.Employee')
go

