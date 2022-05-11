--	Module 6 - Lab02 �����F�榡

--	SQL Server �w�]��������� datetime ���w�]�榡�O yyyy-mm-dd hh:mm:ss.mmm
--	�b INSERT �� UPDATE ���ɭԡA��r�Τ�������ȶ��γ�޸��A�_�ӡC
--	��޸��]�_�Ӫ�����r��ȥ����ŦX SQL Server �i��������F�榡�C
--	datetime2 �� datetime �󬰺�T�C
--	datetimeoffset ���X�F�㦳�ɰϪ�����ɶ��C


use LabDB;
go

drop table if exists DateTimeTable;
go

create table DateTimeTable (
	TestID int identity,
	TestTime time null,
	TestDate date null,
	TestSmallDateTime smalldatetime null,
	TestDateTime datetime null,
	TestDateTime2 datetime2 null,
	TestDateTimeOffset datetimeoffset null
);
select * from DateTimeTable
go

--  �s�W time �������
insert DateTimeTable(TestTime) values('15:25:28');
select * from DateTimeTable
go

--  �s�W date �������
insert into DateTimeTable(TestDate) values('1998-3-21');
select * from DateTimeTable
go

--  �s�W smalldatetime �������
insert into DateTimeTable(TestSmallDateTime) values('1998-3-21 18:23:36');
select * from DateTimeTable
go

--  �s�W datetime �������
insert into DateTimeTable(TestDateTime) values('1998-3-21 18:23:36.123');
select * from DateTimeTable
go

--  �s�W datetime2 �������
insert into DateTimeTable(TestDateTime2) values('1998-3-21 23:59:59.12345678');
select * from DateTimeTable
go

--  �ϥθ�����T�ת��t�Τ���M�ɶ���ƨӷs�W����������
--	SYSDATETIME() �� GETDATE() ���󰪪���T�סC

insert into DateTimeTable(TestTime, TestDate, TestSmallDateTime, TestDateTime, TestDateTime2, TestDateTimeOffset) 
values(sysdatetime(), sysdatetime(),  sysdatetime(), sysdatetime(),  sysdatetime(), sysdatetime());
select * from DateTimeTable
go


--  ���o�ثe���t�Τ���M�ɶ�
select 'SysDatetime()'         , SysDatetime();  
select 'SysDatetimeOffset()', SysDatetimeOffset();  
select 'SysUtcDatetime()'    , SysUtcDatetime();  
select 'Current_TimeStamp', Current_TimeStamp;   -- no ()
select 'GetDate() '               , GetDate();  
select 'GetUtcDate()'           , GetUtcDate();  


--  �Ǧ^�r���r��A�N����w�� date �����w datepart�C
select	datename(year, getdate())			as 'Year',
			datename (month, getdate())		as 'Month',
			datename (day, getdate())			as 'Day',
			datename (hour, getdate())			as 'Hour',
			datename (week, getdate())		as 'Week',
			datename (weekday, getdate())	as 'WeekDay',
			datename (hour, getdate())			as 'Hour',
			datename (minute, getdate())		as 'Minute',
			datename (second, getdate())		as 'Second';



--  ISDATE �P�_�O�_�����T����榡
--  datetime  ��ƽd�� 1753-01-01 �� 9999-12-31
--  datetime2 ��ƽd��O 0001-01-01 �� 9999-12-31�C
select isdate ('2019-05-12 10:19:41.177');
select isdate ('2019-05-12');
select isdate ('1752-1-1');
select isdate ('abc');


-- https://docs.microsoft.com/zh-tw/sql/t-sql/functions/getdate-transact-sql?view=sql-server-ver15

drop table if exists DateTimeTable
