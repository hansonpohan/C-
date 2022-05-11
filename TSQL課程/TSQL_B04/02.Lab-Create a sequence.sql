--  Module 4   02.Lab - Create a sequence.sql
--			�إ߶��Ǫ���A�ë��w���ݩʡC �ǦC�O�ϥΪ̩w�q�����c�y�zô��������A
--			�Ӫ���|�ھګإߧǦC�ҨϥΪ��W�沣�ͤ@�s�ꪺ�ƭȡC 
--			�ƭȧǦC�|�b�w�q�����j�̷ӻ��W�λ���ǨӲ��͡A�ӥB�b�Χ��ɥi�]�w�����s�Ұ� (�`��)�C

--  reference : 
--	https://docs.microsoft.com/zh-tw/sql/t-sql/statements/create-sequence-transact-sql?view=sql-server-ver15

--			Script Object:  Sequence [dbo].[BookingID]     
--			create sequence [dbo].[BookingID]
--			as [int]												-- tinyint, smallint.....
--			start  with 1
--			increment by 1
--			minvalues -2147483648
--			maxvalues 2147483647
--			cycle | { no cycle }									�w�]�`���ﶵ�O no cycle
--			[ cache [<constant> ] | NO CACHE ] 

--			�ǥѴ�ֲ��ͧǸ��һݪ��Ϻ� IO �ƥءA��ϥζ��Ǫ������ε{�����ɮį�C �w�]�� CACHE�C

use  LabDB2  ;
go

--	Step 1: Create a sequence
drop sequence if exists BookingID ;

create sequence BookingID
	as int
	start with 1
	increment by 1
	cache 5;
go

-- check : LabDB2 �� �i�{���� �� ���� �� �ݩ�

select * from sys.sequences 
where name = 'BookingID'	-- LabDB2 �� �˵� �� �t���˵���

select next value for BookingID			--	�U1�ө⸹�X�P

 -- ( Sequence Object: �i�i�{���ʡj �� �i���ǡj)

create table t1(
	id int not null
	constraint DF_t1_ID default (next value for BookingID)
	constraint PK_t1 primary key);

create table t2(
	id int not null
	constraint DF_t2_ID default (next value for BookingID)
	constraint PK_t2 primary key);

create table t3(
	id int not null
	constraint DF_t3_ID default (next value for BookingID)
	constraint PK_t3 primary key);

insert t1 default values
go 5
insert t2 default values
go 3
insert t3 default values
go 6
insert t1 default values
go 5

select * from t1
select * from t2
select * from t3

drop table if exists t1, t2, t3



--	Demo
-- Step 2: Create the tables using the sequence for default values
drop table if exists FlightBookings
drop table if exists CarBookings
drop table if exists HotelBookings

create table FlightBookings(
	FlightBookingID int not null
		constraint DF_FlightBookings_FlightBookingID default (next value for BookingID)
		constraint PK_FlightBookings primary key ,
	DepartureAirportCode varchar (4) not null ,
	ArrivalAirportCode varchar (4) not null ,
	CustomerID int not null ,
	DepartingAt DateTimeOffset (0) not null ,
	EstimatedArrival DateTimeOffset (0) not null  ,
	IataAirlineCode varchar (2) not null ,
	FlightNumber varchar (4) not null ,
	ShortBookingDescription as 'Flight-' + cast(CustomerID as varchar(8)) 
                                                       + '-' + DepartureAirportCode + '-' + ArrivalAirportCode
                                                       + '-' + IataAirlineCode + FlightNumber
) ;

create table CarBookings(
  CarBookingID int not null
		constraint DF_CarBookings_CarBookingID default (next value for dbo.BookingID)
		constraint PK_CarBookings primary key ,
  CollectionPointCode varchar(3) not null ,
  ReturnPointCode varchar(3) not null ,
  CustomerID int not null ,
  CollectingAt DateTimeOffset(0) not null ,
  ReturningBy DateTimeOffset(0) not null ,
  VehicleTypeID int not null ,
  ShortBookingDescription as 'Car-' + cast(CustomerID as varchar(8))
                                                       + '-' + CollectionPointCode + '-' + ReturnPointCode
                                                       + '-' + cast(VehicleTypeID as varchar(8))
) ;

create table HotelBookings
(	HotelBookingID int not null
		constraint DF_HotelBookings_HotelBookingID default (next value for dbo.BookingID)
		constraint PK_HotelBookings primary key ,
  HotelCode varchar(5) not null ,
  CustomerID int not null ,
  CheckinTime DateTimeOffset(0) not null ,
  CheckoutTime DateTimeOffset(0) not null ,
  RoomTypeId int not null ,
  ShortBookingDescription as 'Hotel-' + cast(CustomerID as varchar(8))
                                                        + '-' + HotelCode + '-' + cast(RoomTypeID as varchar(4))
) ;

-- Step 3: Insert the data
insert FlightBookings 
  (DepartureAirportCode, ArrivalAirportCode, CustomerID, DepartingAt, EstimatedArrival, IataAirlineCode, FlightNumber)
values ('MEL','LAX', 4, '2011-07-30 13:30:00 +10:00', '2011-07-30 07:45:00 -8:00', 'QF', '25') ,
           ('LAX', 'SEA', 3, '2011-07-30 16:30:00 -8:00', '2011-07-30 18:00:00 -8:00', 'AS', '245') ;
select * from FlightBookings ;


insert CarBookings 
  ( CollectionPointCode, ReturnPointCode, CustomerID, CollectingAt, ReturningBy, VehicleTypeID )
values ( 'MEL', 'BNE', 8, '2011-07-30 13:30:00 +10:00', '2011-07-31 07:45:00 +10:00', 6) ,
           ( 'LAX', 'LAX', 7, '2011-07-31 13:30:00 +10:00', '2011-07-31 07:45:00 -8:00', 6) ;
select * from CarBookings  ;


insert dbo.HotelBookings ( HotelCode, CustomerID, CheckinTime, CheckoutTime, RoomTypeId )
values ( 'HLMEL', 15, '2011-07-30 13:30:00 +10:00', '2011-07-31 07:45:00 +10:00', 4) ;
select * from HotelBookings  ;

-- Step 3.1: repeat Step 3   Insert the data


-- Step 4: Note the values now appearing in the view
select FlightBookingID as BookingID, ShortBookingDescription 
from FlightBookings 
union all
select CarBookingID, ShortBookingDescription 
from CarBookings 
union all
select HotelBookingID, ShortBookingDescription 
from HotelBookings 
order by BookingID;
go

-- Step 6: Ū�� sequence infomation
select cache_size, current_value,*
from sys.sequences
where name = 'BookingID';
go

--  exec sp_help 'sys.sequences' ;
exec sp_help 'sp_sequence_get_range' ;		--  LabDB2 �� �i�{���� �� �w�s�{�� �� �t�ιw�s�{��


--Step 7: Fetch a range of sequence values

declare @FirstValue  sql_variant;
declare @LastValue  sql_variant;
exec sp_sequence_get_range					
	@sequence_name = 'BookingID',
	@range_size = 100,						--	�w���O�d�@�w���d�� 100
	@range_first_value = @FirstValue output,
	@range_last_value = @LastValue output;
select @FirstValue, @LastValue;
go

select cache_size, current_value
from sys.sequences
where name = 'BookingID';
go


select * from sys.sequences


--�קﭫ�s�]�w���Ǫ����l�Ȫ��覡
select next value for BookingID

alter sequence BookingID restart with 1

select next value for BookingID

--�R�����Ǫ��󪺤覡:

drop sequence if exists BookingID

--	�z�LSSMS�޲z�u��]�w�覡:
--	�I���Ʈw�W��LabDB2 �� �i�{���� �� ���� �� �s�W����
