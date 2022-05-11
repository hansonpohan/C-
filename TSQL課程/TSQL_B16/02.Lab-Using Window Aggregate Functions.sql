--  Module 16.   02.Lab - Using Window Aggregate Functions.sql

--  �J�`�禡�|�ھڤ@�խȨӰ���p��A�öǦ^��@�ȡC ���F COUNT(*) ���~�A
--  �J�`�禡�|���� Null �ȡC �J�`�禡�g�`�Ψӷf�t SELECT ���z���� GROUP BY �l�y�ϥΡC

--  �Ҧ��J�`�禡���㦳�M�w�ʡC ���y�ܻ��A�ϥΤ@�կS�w��J�ȩI�s�ɡA
--  �J�`�禡�|�b�C���I�s�ɶǦ^�ۦP���ȡC �p�ݨ禡�T�w�ʪ��ԲӸ�T�A
--  �аѾ\�M�w�ʩM�D�M�w�ʨ禡�C OVER �l�y�i�H��b�Ҧ��J�`�禡����A
--  �� STRING_AGG�BGROUPING �M GROUPING_ID �禡���~�C

use AdventureWorks ;
go

-- Using �iOVER�j:
-- Rank products by price from high to low
select * from Purchasing.PurchaseOrderDetail

select PurchaseOrderID, OrderQty, ProductID, UnitPrice,
			rank() over (order by UnitPrice desc) as PriceRank,			
			dense_rank() over (order by UnitPrice desc) as PriceDense_Rank,
			row_number() over (order by UnitPrice desc) as PriceRow_Number,
			NTILE(100) over (order by UnitPrice desc) as PriceNTILE			-- try dense_rank
from Purchasing.PurchaseOrderDetail
order by PriceRank


-- Rank products by price in descending, order in each category.
select PurchaseOrderID, OrderQty, ProductID, UnitPrice,	
			rank() over (Partition by PurchaseOrderID order by UnitPrice desc) as PriceRank,
			dense_rank() over (Partition by PurchaseOrderID order by UnitPrice desc) as PriceDense_Rank,
			row_number() over (Partition by PurchaseOrderID order by UnitPrice desc) as PriceRow_Number,
			NTILE(3) over (Partition by PurchaseOrderID order by UnitPrice desc) as PriceRank_NTILE
from Purchasing.PurchaseOrderDetail
order by PriceRank



select PurchaseOrderID, OrderQty, ProductID, UnitPrice,
			sum(UnitPrice) over (Partition by PurchaseOrderID order by UnitPrice desc) as PriceSum,
			sum(UnitPrice) over (Partition by PurchaseOrderID) as PriceSum,
			sum(UnitPrice) over (order by UnitPrice desc) as PriceSum,
			sum(UnitPrice) over () as PriceSum
from Purchasing.PurchaseOrderDetail
order by PurchaseOrderID


