--	Module 13 �t�Τ��ب���ഫ��Ƥ���
--		13-1 : CAST()�B CONVERT() �H�� PARSE() 
--		13-2 : TRY_CAST()�BTRY_CONVERT() �H�� TRY_PARSE() 
--		13-3 : �`�����ഫ���D 

-- Lab01 CAST()�B CONVERT() �H�� PARSE()

--		�o�Ǩ禡�|�N�Y�ظ���������B�⦡�ഫ���t�@�ظ�������C
--		CAST�ݩ�ANSI �з�SQL�y�k�榡�A�Ҧ�����Ʈw�����CAST�A��y�k�榡�]�@�P�C
--				�y�k : CAST ( expression AS data_type [ ( length ) ] )
				select cast(10.6496 as int), cast(10.6496 as numeric), cast(10.649666 as money);
				select cast('123' as int) + 1000;

--		CONVERT����OSQL�зǳW�w���y�k�A���Ǹ�Ʈw����B���Ǥ�����A�ӥB�t�q�]�|���P
--				�y�k : CONVERT ( data_type [ ( length ) ] , expression [ , style ] )
				select convert(int, '123') + convert(int, '456'); 
				select convert(varchar, getdate(), 111);

--		PARSE �ȾA�Ω�q�r���ഫ����/�ɶ��μƦr����, �Ǧ^ T-SQL �n�D����������B�⦡���G
--				�y�k : PARSE ( string_value AS data_type [ USING culture ] ) 
				select parse ('1234' as int) + 4567;
				select parse ('Monday, 13 December 2010' as date using 'zh-TW'); 

-- �ϥ�CAST�r����Ʀr

--	��r�ഫ�����
select cast ('123' as int) + 1000; 
select 1000+'123'
select '123'+1000
select 'Price : '+1000   -- error

use LabDB;
select * from Northwind.dbo.Orders

--  �ϥ� CAST �Ӧ�s�ƭȤΦr��B�⦡
select 'Price : '+cast (Freight as varchar(10)) as F_Price, Freight
from  Northwind.dbo.Orders
where Freight between 10.00 and 20.00;  
go

--  CAST ����ഫ
select	cast(getdate() as date) as [datetime as date],     -- ����Τ��A��[ ]? �]���Ů�  
			cast(getdate() as time) as [datetime as time];  

--  �p�G���Ҽ{ style �o�ӥi��ѼơACAST �M CONVERT �\��õL�t�O
declare @N1 varchar(30)='123', @N2 varchar(30)='456'
select @N1 + @N2; 
select cast(@N1 as int) + cast(@N2 as int); 
select convert (int, @N1) + convert(int, @N2); 
select cast(@N1 as int) + convert(int, @N2);


--  CONVERT ���w"�ĤT�ӰѼ�" STYLE "����榡�˦�" �榡�ഫ
select getdate()
select convert(varchar, getdate(), 100); -- mon dd yyyy hh:mmAM (or PM)  -- 10  2 2008 11:01AM          
select convert(varchar, getdate(), 101); -- mm/dd/yyyy - 10/02/2008                  
select convert(varchar, getdate(), 102); -- yyyy.mm.dd - 2008.10.02           
select convert(varchar, getdate(), 103); -- dd/mm/yyyy
select convert(varchar, getdate(), 104); -- dd.mm.yyyy
select convert(varchar, getdate(), 105); -- dd-mm-yyyy
select convert(varchar, getdate(), 106); -- dd mon yyyy
select convert(varchar, getdate(), 107); -- mon dd, yyyy
select convert(varchar, getdate(), 108); -- hh:mm:ss
select convert(varchar, getdate(), 109); -- mon dd yyyy hh:mm:ss:mmmAM (or PM)  -- Oct  2 2008 11:02:44:013AM   
select convert(varchar, getdate(), 110); -- mm-dd-yyyy
select convert(varchar, getdate(), 111); -- yyyy/mm/dd
select convert(varchar, getdate(), 112); -- yyyymmdd
select convert(varchar, getdate(), 113); -- dd mon yyyy hh:mm:ss:mmm  -- 02 Oct 2008 11:02:07:577     
select convert(varchar, getdate(), 114); -- hh:mm:ss:mmm(24h)
select convert(varchar, getdate(), 120); -- yyyy-mm-dd hh:mm:ss(24h)
select convert(varchar, getdate(), 121); -- yyyy-mm-dd hh:mm:ss.mmm
select convert(varchar, getdate(), 126); -- yyyy-mm-ddThh:mm:ss.mmm  -- 2008-10-02T10:52:47.513
select convert(varchar(7), getdate(), 126)                 -- yyyy-mm
select right (convert(varchar, getdate(), 106), 8)          -- mon yyyy

-- https://docs.microsoft.com/zh-tw/sql/t-sql/functions/cast-and-convert-transact-sql?view=sql-server-ver15

--PARSE �r����ƭ�
select parse ('1234' as int) + 4567;

--PARSE  �c�餤�� zh-TW�A��������ǬO�Gymd
--�^�� en-US�A��������ǬO�Gmdy
select	parse('01/02/03' as date using 'zh-TW') ,	-- yy/mm/dd
			parse('01/02/03' as date using 'de-DE') ,		--	dd/mm/yy
			parse('01/02/03' as date using 'en-US') ,		--	mm/dd/yy
			parse('01/02/03' as date );							--	yy/mm/dd

--PARSE �ϥγf���Ÿ�
select	parse ('NT$123,456.789' as money using 'zh-TW') as '�x��',
			parse ('��123.456,789' as money using 'de-DE') as '�ڤ�',		--  �`�N�J�`�M�p���I���t��
--    		parse ('��123,456.789' as money using 'de-DE') as '�ڤ�',		-- Error : ","   "."
			parse ('$123,456.789' as money using 'en-US') as '����';
			   
select parse ('��345,98' as money using 'de-DE') as Result

--CAST�BCONVERT�BPARSE �ϥΤ覡���
select cast ('123' as int), convert (int, '456'), parse ('789' as int);
select cast ('123' as int) + convert (int, '456') + parse ('789' as int);


--�ϥ� CAST�BCONVERT�BPARSE ����ഫ
declare @d varchar(20);
set @d = '2020-4-14';
select	cast (@d as datetime ),
			convert (datetime, @d, 111),
			parse (@d as datetime using 'zh-TW');
