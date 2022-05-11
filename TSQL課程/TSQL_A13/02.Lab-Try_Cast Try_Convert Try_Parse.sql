--	Module 13 - Lab02  TRY_CAST()�B TRY_CONVERT() �H�� TRY_PARSE() 

--	TRY_CAST, TRY_CONVERT, TRY_PARSE�Ǧ^���w����������ȡA�p�G���ѷ|�Ǧ^NULL
--			�y�k : TRY_CAST ( expression AS data_type [ ( length ) ] ) 
--			�y�k : TRY_CONVERT ( data_type [ ( length ) ], expression [, style ] ) 
--			�y�k : TRY_PARSE ( string_value AS data_type [ USING culture ] )

--	�H�U���d�ҥܽd���ഫ���ѮɡATRY_CAST �|�Ǧ^ null�C
select cast ('test' as float);								-- error : str to float
select try_cast ('test' as float);                         -- NULL

--  Error :�@�H�U���d�ҥܽd����T�����\�ഫ�ɡATRY_CAST �|�Ǧ^���~�C
select try_cast(4 as xml); 

--TRY_CAST ���\
select try_cast ('2020-4-14' as datetime2) as result;  

--�ϥ� CAST �� TRY_CAST �ഫ���s�b�����
select cast ('2020-2-30' as datetime2) as Result;
select try_cast ('2020-2-30' as datetime2) as Result;


--�ഫ���ѮɡATRY_CONVERT �|�Ǧ^ null
select try_convert (float, 'test');

--����T�����\�ഫ�ɡATRY_CONVERT �|�Ǧ^���~�C
select try_convert (xml, 4) as result;   -- �����\�q������� int ���T�ഫ�� xml�C

--TRY_CONVERT ���\
select try_convert (datetime2, '12/31/2019') as result; 

--�� CONVERT �� TRY_CONVERT �ഫ���s�b�����
select convert (datetime2, '2/31/2019') as result; 
select try_convert (datetime2, '2/31/2019') as result; 


--TRY_PARSE �ഫ����
select try_parse ('abcdefg' as datetime2 using 'en-US') AS Result;

-- TRY_PARSE() �ഫ��ơG�h���f���Ÿ�
select try_parse ('NT$123,456' as money using 'zh-TW') N'���B(�x��)'
go
 

-- TRY_PARSE() �P�_��J���r��A�O�_�i�H�ഫ�����w���f��
declare		@Input varchar(20)='NT$1234.567', 
				@Price money;
set @Price = try_parse (@Input as money using 'zh-TW');
if @Price is not null
	select @Price as '���B(�x��)';  -- �ܹ����`�B�z�{�����|�_�� try ... catch
else
	select '�ഫ����';
go

use Northwind
select  PostalCode from Suppliers
select cast (PostalCode as int)  from Suppliers; �@�@�@-- Error 'PostalCode' ������r
select convert (int, PostalCode) from Suppliers;  �@�@�@-- Error 'PostalCode' ������r
select parse (PostalCode as int using 'en-US') from Suppliers;  -- Error 'PostalCode' ������r

--  �{�����|�_��, �p�G�A�[�W isnull or coalesce �N�󧹬��F
select coalesce (try_cast (PostalCode as int), 0)  from Suppliers; 
select try_convert (int, PostalCode) from Suppliers;							--  try to add "coalesce"
select try_parse (PostalCode as int using 'en-US') from Suppliers;	--  try to add "coalesce"
