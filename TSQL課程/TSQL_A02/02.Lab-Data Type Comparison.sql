--	Module 2 - Lab02	����T�ؼƭȸ���������~�t�� / �����������ഫ

--	�ΤG�i���k�s: float�Areal
--			�ΤG�i��s�Q�i��p�Ʈɥѩ�L�k��T���ഫ�A�ҥH�s�i�h���ȳ��|�O�����
--			�ѩ�ϥΤG�i���k�s�ҥH�i�H�s���������Ƥ�����|�e�Ŷ�
--			float �M real �Ψӷf�t�B�I�ƭȸ�ƨϥΪ�����ƭȸ�������C
--			float �M real ���O����T���ƭ������A�ഫ�ɳ��|���~�t�C

--	�ΤQ�i���k�s: decimal
--			�ΤQ�i���k�s�����O���p���I�k�䪺��Ʀ��X��A�|������
--			�ۤ�G�i���x�s�A��Ƹ���(�`��Ƥp�󵥩�38��)�ݭn�e���j�Ŷ�

--	real�G�i�x�s�C�즳�ļ�
--	float�G�i�x�s�Q���즳�ļ�
--	decimal�G�i�x�s�T�Q�C��ơ]�]�t�p���I�e����᭱�^ex�Gdecimal(10,2)�N��p���I�e8��ơA
--			�p���I��2������Mdecimal�ҥe�Ϊ��Ŷ�����j�A�����F�O�s�ƭȪ����T�ʤW�A
--			�٬O��ϥ�real�Bfloat�Ӫ��n�j�����ɭԨ�곣��decimal������ƴN�����F


use LabDB;
go


-- �إߤ@���ո�ƪ�,�åH10000����ƨӥ[�`
-- ����T�ظ���������~�t��
create table Test (
	n1 real,
	n2 float,
	n3 decimal(14, 8)
);
go


declare @CNT int;
set @CNT=0;
while (@CNT<10000)
begin
	insert into Test VALUES(0.1, 0.1, 0.1)
	set @CNT=@CNT+1
end
select n1, n2, n3 from Test;
go

select sum(n1) as [real] , sum(n2) as [float], sum(n3) as [decimal] from Test;		-- �����
go
-- �i�H�ݥXReal��Float���O�����ͤF�~�t�AFloat�]�����Ħ�Ƹ����ҥH�~�t����p

drop table if exists Test

--  data type : image (p7-7) 
--	check Northwind Emloyees column : Photo