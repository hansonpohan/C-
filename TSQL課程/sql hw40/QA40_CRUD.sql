-- 以下是員工資料 :
-- id			first name			last name		salary			birthday
-- 100		小明						王				30000.5		2000-01-01
-- 200		中明						李				40000.8		1998-02-01
-- 300		大明						張				45000.9		1995-03-01
-- 400		小花						陳				35000.1		2002-05-01

--  請練習撰寫以下"指令", 請依題意回答


--  1.  請切換至 LabDB 資料庫下, 同時 drop 掉, 如果已存在的 table  employee 
use LabDB;
go
drop table if exists employee; 
go  

--  2.  請先建立一employee 資料表僅包含 下列四個欄位, id 是 primary key  (欄位 birthday 先不要建立)
--       id			first name			last name		salary
create table employee(
    id int primary key identity (1, 2) not null ,			      
    firstname nvarchar (50) not null,
	lastname nvarchar (50) not null,
    salary decimal (20,1) sparse null);		
go
select * from employee;
go


-- 3.  請先用語法新增員工基本資料     id			first name			last name		salary
SET IDENTITY_INSERT employee On;
insert  employee(id, firstname,lastname,salary)		
    values (100, '小明','王',30000.5);
insert  employee(id, firstname,lastname,salary)		
    values (200, '中明','李',40000.8);
 insert  employee(id, firstname,lastname,salary)		
    values (300, '大明','張',45000.9	);
insert  employee(id, firstname,lastname,salary)		
   values (400, '小花','陳',35000.1);
go
	
--  4.  查詢一下所有員工資料

select * from employee;
go	

--  5.  查詢一下薪水大於40000 所有員工資料, 並用薪水欄 由大到小排序

alter table employee
　alter column salary smallmoney
select  salary  from employee
where  salary > 40000
order by salary DESC


--  6.  將資料表 employee 增加一"生日欄位", 
--  試一試將"生日欄位"設為 not null 和 null 的差別, 結果不同為什麼?

alter table employee
add birthday  datetime  ;
go
select * from employee;
go


--  7.  一員工編號 修改/增加  生日資料**


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
		



-- 8.  計算一下所有員工薪水總和

select sum(salary) as 薪水總和
from employee

-- 9.  計算一下員工個別的年紀(年減年即可)

select year(getdate())-year(birthday)
from employee

-- 10. 請列印出薪資最少員工的所有資料

select  top(1) * from employee
order by salary 
select * from employee;
go
		



-- 11.  請刪除 王小明 人事資料

delete  top(1)  from employee
  select * from employee;
go
		 


-- 繳交作業請寄到一下信箱 :
-- Email : jungan0914@gmail.com
