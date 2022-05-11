--	Module 4 - Lab02 ��ƪ� FOREIGN KEY �������

--	FOREIGN KEY (�~��������) �O�Ψӱj�������ƪ������p���@�ر�������C
--	FOREIGN KEY (�~��������) �u����V�D������ (PK) �άO UNIQUE ��ơC
--	FOREIGN KEY (�~��������) �Ѧҥ~����ƪ�A�H�O�Ҹ�ƪ����T�ʡC
--	���p����Ʈw���A��ƪ��������Y�O�Q�� FOREIGN KEY (�~��������) �ӫإߪ��C
--	�����p�����A��ƫ��O�Ϊ��ץ��ݬۦP�C���O�W�٥i�H���P�A�u�O�ߺD�W�|�άۦP���R�W�A�H�Q���O�C
--	FOREIGN KEY (�~��������) ����ƥi�H���ơA


--  �ϥΦ��p���Ѧҧ���ʱ�������A�N�i�H�w�q�ϥΪ̹��էR���Χ�s�{���~��������ҫ��V��������ɡA
--	Database Engine �ұĨ����ʧ@�C �i�H�w�q�U�C���p���ʧ@�C

--	NO ACTION		: Database Engine �|�޵o���~�A�ӥB�|�^�_�����ƪ���ƦC���R���Χ�s�ʧ@�C
--	CASCADE		: ��s�ΧR������ƪ���������ƦC�ɡA�]�|��s�ΧR���ѦҸ�ƪ����Ӹ�ƦC�C 
--	SET NULL		: ��s�ΧR������ƪ���������ƦC�ɡA�Ҧ��զ��~�������䪺�ȳ��|�]�w�� NULL�C
--  SET DEFAULT: �p�G��s�ΧR������ƪ���������ƦC�A�h�Ҧ��զ��~�������䪺�ȳ��|�]�w����w�]�ȡC 
-- https://docs.microsoft.com/zh-tw/sql/relational-databases/tables/primary-and-foreign-key-constraints?view=sql-server-ver15


--	�U�C�d�ҷ|�إ߸�ƪ�æb TempID ��Ʀ�W�w�q FOREIGN KEY ��������A
--	�Ӧ���Ʀ�|�Ѧ� AdventureWorks ��Ʈw Sales.Customer ��ƪ��� CustomerID ��Ʀ�C

--	�� Sales.Customer ��ƪ�Ұ����ܧ�|�۰ʧ�s�� TempCustomer ��ƪ�C

drop table if exists AdventureWorks.dbo.TempCustomer

use LabDB;
go
--  use AdventureWorks		-- ���~�d�� : ���䴩���Ʈw���~��������ѦҡC�~��������
create table TempCustomer (
      TempID int not null ,
          constraint PK_TempCustomer primary key nonclustered (TempID),
          constraint FK_TempCustomer_SaleCustomer foreign key (TempID)
              references AdventureWorks.Sales.Customer (CustomerID)
              on delete cascade
              on update cascade,
      Name nvarchar(50)
   );
go --- see TempID (pk, fk)

--	�R���W���إߪ� FOREIGN KEY

alter table TempCustomer
	drop constraint FK_TempCustomer_SaleCustomer;
go

--	�U�C�d�ҷ|�b TempCustomer ��ƪ��� TempID ��Ʀ�W�إ� FOREIGN KEY�A
--	�÷|�Ѧ� AdventureWorks ��Ʈw Sale.Customer ��ƪ��� CustomerID ��Ʀ�C
alter table TempCustomer
  add constraint FK_TempCustomer_SaleCustomer foreign key (TempID)
      references Sales.Customer (CustomerID)
      on delete cascade
      on update cascade
go  

--	ALTER AUTHORIZATION ON DATABASE:: DBName TO [NewLogin] 
alter authorization on database :: AdventureWorks to sa

drop table if exists TempCustomer



-- �ҤG delete cascade

use LabDB

drop table if exists TempOrders, TempOrderDetails

select * into  TempOrders from Northwind.dbo.orders
select * into  TempOrderDetails from Northwind.dbo.[Order Details]

select * from TempOrders
select * from TempOrderDetails

alter table TempOrders
		add constraint PK_TempOrders_OrderID primary key (OrderID)

alter table TempOrderDetails
		add constraint FK_TempOrderDetails_OrderID foreign key (OrderID)
              references TempOrders (OrderID)
              on delete cascade
              on update cascade

-- delete OrderID in ������ƪ�
delete from TempOrders where OrderID=10248

select * from TempOrders
select * from TempOrderDetails
--  OrderID 10248 �b���ƪ��������F



