-- 請練習撰寫底下指令 : 使用 Northwind.Customer 客戶資料表

-- Step 01 打開 Northwind 資料庫 
use Northwind
go

-- Step 02 從dbo.Customers table 中, 挑選 所有 客戶 資料
select * from Customers;

-- Step 03 挑選 所有 客戶 資料，並用城市City排序
select * from Customers order by City;


-- Step 04 挑選 客戶 資料中指定欄位：CustomerID, CompanyName, ContactName, Phone
select CustomerID, CompanyName, ContactName, Phone from Customers;


-- Step 05 延續上題，請將欄位名稱分別改成以中文別名 客戶編號, 公司名稱, 聯絡人, 連絡電話顯示
select	CustomerID as '客戶編號', 
			CompanyName as '公司名稱', 
			ContactName '聯絡人' ,
			Phone '連絡電話'
from Customers;


-- Step 06  挑選 客戶 資料中指定欄位：CustomerID, CompanyName, ContactName, Phone
--					挑選 城市國家是 德國

select CustomerID, CompanyName, ContactName, Phone 
from Customers 
where Country = 'Germany';


-- Step 07 承上題  加入一欄位 ( Country +' , '+City) 並欄位名稱改成 'Country , City '
--				同時加入 國家德國, 墨西哥, 英國
select CustomerID, CompanyName, ContactName, Phone, Country +' , '+City as 'Country , City'
from Customers 
where Country in ( 'Germany', 'Mexico', 'UK');


-- Step 08 承上題  加入包含 CustomrID 中包含 AN 的資料
select CustomerID, CompanyName, ContactName, Phone, City+' /  '+Country as 'City / Country'
from Customers 
where Country in ( 'Germany', 'Mexico') and CustomerID like '%an%'


-- Step 09  承 Step 07  並依照 國家(大到小),  城市(小到大) 排序
select CustomerID, CompanyName, ContactName, Phone, Country +' , '+City as 'Country , City'
from Customers 
where Country in ( 'Germany', 'Mexico', 'UK')
Order by Country desc, City asc
