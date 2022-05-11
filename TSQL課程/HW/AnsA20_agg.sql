-- 請練習撰寫底下指令 : 使用 Northwind.Products 產品資料表

-- Step1 確定打開的是 Northwind 資料庫 
use Northwind
select * from Products

-- Step2 請列出單價最高的前三項產品。
select top 3 UnitPrice from Products order by UnitPrice desc

-- Step3 請列出產品的平均單價, 平均庫存, 平均在途。
select avg(UnitPrice), avg(UnitsInStock) , avg(UnitsOnOrder) from Products

-- Step4 請列出產品的最高單價, 最高庫存, 最高在途。
select max(UnitPrice), max(UnitsInStock) , max(UnitsOnOrder) from Products


-- Step5 請列出各類產品的平均單價。
select avg(UnitPrice) , avg(UnitsInStock) , avg(UnitsOnOrder) 
from Products
group by CategoryID

-- Step6 挑選類別編號(CategoryID)為 1, 4, 8 為範圍, 計算挑選範圍內產品的平均單價, 平均庫存, 平均在途。
select CategoryID, avg(UnitPrice) , avg(UnitsInStock) , avg(UnitsOnOrder) 
from Products
where CategoryID in (1,4,8)
group by CategoryID



-- Step7 請列出平均單價最高的前三類產品。
select top 3 avg(UnitPrice) 
from Products
group by CategoryID
order by avg(UnitPrice) desc


-- Step8 找出 價格最高 的產品 (使用 TOP 關鍵字)
select top 1 * from Products
order by UnitPrice desc

-- Step9 找出 價格最低 的產品 (使用 TOP 關鍵字)
select top 1 * from Products
order by UnitPrice

-- Step10 使用 MIN() 關鍵字改寫，取得價格最低產品單價是多少？
select * from Products
where UnitPrice = (select min(UnitPrice) from Products)

