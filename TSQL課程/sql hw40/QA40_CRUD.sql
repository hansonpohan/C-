-- �H�U�O���u��� :
-- id			first name			last name		salary			birthday
-- 100		�p��						��				30000.5		2000-01-01
-- 200		����						��				40000.8		1998-02-01
-- 300		�j��						�i				45000.9		1995-03-01
-- 400		�p��						��				35000.1		2002-05-01

--  �нm�߼��g�H�U"���O", �Ш��D�N�^��


--  1.  �Ф����� LabDB ��Ʈw�U, �P�� drop ��, �p�G�w�s�b�� table  employee 
use LabDB;
go
drop table if exists employee; 
go  

--  2.  �Х��إߤ@employee ��ƪ�ȥ]�t �U�C�|�����, id �O primary key  (��� birthday �����n�إ�)
--       id			first name			last name		salary
create table employee(
    id int primary key identity (1, 2) not null ,			      
    firstname nvarchar (50) not null,
	lastname nvarchar (50) not null,
    salary decimal (20,1) sparse null);		
go
select * from employee;
go


-- 3.  �Х��λy�k�s�W���u�򥻸��     id			first name			last name		salary
SET IDENTITY_INSERT employee On;
insert  employee(id, firstname,lastname,salary)		
    values (100, '�p��','��',30000.5);
insert  employee(id, firstname,lastname,salary)		
    values (200, '����','��',40000.8);
 insert  employee(id, firstname,lastname,salary)		
    values (300, '�j��','�i',45000.9	);
insert  employee(id, firstname,lastname,salary)		
   values (400, '�p��','��',35000.1);
go
	
--  4.  �d�ߤ@�U�Ҧ����u���

select * from employee;
go	

--  5.  �d�ߤ@�U�~���j��40000 �Ҧ����u���, �å��~���� �Ѥj��p�Ƨ�

alter table employee
�@alter column salary smallmoney
select  salary  from employee
where  salary > 40000
order by salary DESC


--  6.  �N��ƪ� employee �W�[�@"�ͤ����", 
--  �դ@�ձN"�ͤ����"�]�� not null �M null ���t�O, ���G���P������?

alter table employee
add birthday  datetime  ;
go
select * from employee;
go


--  7.  �@���u�s�� �ק�/�W�[  �ͤ���**


update employee set birthday='2000-01-01'  
where id = 100;	
update employee set birthday='1998-02-01'
where id = 200;	
update employee set birthday='1995-03-01' 
where id = 300;	
update employee set birthday='2002-05-01' 
where id = 400;	

	select * from employee;
go
		



-- 8.  �p��@�U�Ҧ����u�~���`�M

select sum(salary) as �~���`�M
from employee

-- 9.  �p��@�U���u�ӧO���~��(�~��~�Y�i)

select year(getdate())-year(birthday)
from employee

-- 10. �ЦC�L�X�~��̤֭��u���Ҧ����

select  top(1) * from employee
order by salary 
select * from employee;
go
		



-- 11.  �ЧR�� ���p�� �H�Ƹ��

delete  top(1)  from employee
  select * from employee;
go
		 


-- ú��@�~�бH��@�U�H�c :
-- Email : jungan0914@gmail.com
