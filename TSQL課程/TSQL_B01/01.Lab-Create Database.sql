 --	Module 01  �إ߸�Ʈw
--		1-1 : �p��إ߻P�R����Ʈw
--		1-2 : �p������P���[��Ʈw
--		1-3 : �p��פJ�P�ץX���

--  SQL Server ����Ʈw�ɮצ@�ϥΤT�Ӱ��ɦW�A�]�A.mdf�Bndf �� ldf ���A
--			�䤤.mdf �O�D�n��Ʈw�ɮסA��Ʈw���w�q�Ψt�Ϊ����x�s�b���A
--			.ndf �O�i���i�L�����n�ɮסA.ldf �O����O���ɡA�@�Ӹ�Ʈw�ܤַ|��.mdf �� .ldf �ɮסC


--	1-1: �p��إ߻P�R����Ʈw

use master;
go

--  �˵� : DB :  model(�k��) �� �˵� ��  �t���˵��� �� sys.databases

if db_id ('LabDB2') is null   
--	begin         
		create database LabDB2;		-- ����γo�ؼg�k : create database if not exists LabDB2
--	end
else
	print 'db exists'
go

--  �A���˵� : ��Ʈw model(�k��) �� �˵� �� �t���˵��� �� sys.databases (�k��)

--	�إߤ@�ӵ��c�y�z(Schema)�W��:  HR, 
use LabDB2

create schema HR					-- �˵� : LabDB2�U �� �˵� �� �t���˵��� �� sys.schemas (�k��) �� �s��200
	--authorization dbo ;
go

select  * from sys.schemas		-- LabDB2�U �� �w���� �� ���c�y�z �� HR


--	�إ߳�����ƪ�(Department Table)
use LabDB2
create table  HR.Department(
	deptno       int ,
	dname       nvarchar (20) ,
	loc              nvarchar(10) ,
	constraint PK_Department  primary key (deptno)
) ;
go


--	�إ߭��u��ƪ�(Employee Table)  table-constraint
create table  HR.Employee(
	empno		int identity (100, 1) ,
	ename		nvarchar(20) ,
	gender		nvarchar(1) ,
	job           nvarchar(18) ,
	birthday   datetime ,
	salary      int ,
	bonus      int ,
	deptno     int ,
   constraint	PK_Employee  primary key (empno),
   constraint FK_Employee_Department  foreign key (deptno) references  HR.Department (deptno)
) ;
go


use LabDB2
go

-- Create DataBase
drop database if exists Class

create database Class
on primary 
		(name ='class', filename = 'c:\Temp\Class.mdf' , 
			size = 6MB , maxsize = unlimited, filegrowth = 1MB ),
filegroup secondary 
		(name = 'class_ndf', filename = 'c:\Temp\Class_ndf.ndf' , 
			size = 6MB , maxsize = unlimited )     --filegrowth = 1MB,      64MB
log on -- �۰ʲ���
		(name = 'class_ldf', filename = 'c:\Temp\Class_ldf.ldf' , 
			size = 6MB , maxsize = 2GB , filegrowth = 1MB )
go

-- check : Class (�k��) �� �ݩ�  �� �ɮ�

-- check : �����`�� �� �޲z �� SQL Server �O����(�k��) �� �˵� �� SQL Server �O����

