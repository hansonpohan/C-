--	Module 7 - Lab02�ϥ� DELETE �R�����

--	�q��ƪ��R���@���Φh����ơC
--	[FROM] ����ܩʪ�����r�C
--	�R����ƫe�O�o���T�{ WHERE ���󦡡C
--	�p�����w WHERE ���󦡡A�|�N��ƪ���ƥ����R���C
--	�i�H�ϥ� @@ROWCOUNT �禡�A�N�R������ƦC�ƥضǦ^�Τ�����ε{���A�Ϊk�P�W�@�p�`���Ϊk�C

use LabDB;
go

-- �R����ƪ��Ҧ����
select * from TempEmployees;
delete from TempEmployees;   -- FROM �i�ٲ�
insert TempEmployees (LastName, FirstName) values ('Green', 'Tom') -- EmployeeID �|�~��W�[
go
select * from TempEmployees;

-- �R����ƪ����w���@�ո��
select * from TempProduct
delete TempProduct where UnitPrice >20;
go

select * from TempProduct

-- �ϥ�2�ر���
delete TempProduct 
where ProductID<35 and UnitPrice > 16;
select * from TempProduct

go

-- �R����10����Ʀ�
delete top(10) TempProduct;
go
select * from TempProduct


-- �R���� 10% ��Ʀ�
delete top(10) percent TempProduct;
go

select * from TempProduct 
