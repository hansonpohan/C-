--	Module 12 - Lab03 T-SQL �`�Φr���� : 
--		STR�BTRIM�BLTRIM�BRTRIM�BUPPER�BLOWER�BREPLACE
--			TRIM :�����r���Y�����ťզr���æ^�ǡC
--			LTRIM : �����r��}�Y���ťզr���C
--			RTRIM : �����r�굲�����ťզr���C
--			�r��O�������r��������r������ (nvarchar�Bvarchar�Bnchar �� char) ���B�⦡�C
--			�r�ꤣ���\ nvarchar(max) �M varchar(max) �����C
--			�Ǧ^������ varchar �� nvarchar�C�p�G��J�r�ꬰ NULL�A�Ǧ^ NULL�C

--  https://docs.microsoft.com/zh-tw/sql/t-sql/functions/string-functions-transact-sql?view=sql-server-ver15

-- �U�C�d�ҷ|�N123.45�զ����B�⦡�ഫ�����Ӧ�ƪ��r���r��A�p���I��Ĥ@��|�|�ˤ��J�C
select str (123.45, 6, 1);     -- INT to STR,  try 16

-- ��B�⦡�W�X���w���׮ɡA�r��|�Ǧ^ **
select str (123.45, 2, 2);  

-- Error : �B�⦡�D�ƭȮɷ|�o�������ഫ���~
select str ('ABC');

-- �r����ƾa�k����A����|�ɪŮ�A�k��|��0
select str (123.45, 20, 5);

-- �U�C�d�ҷ|���� test �o�Ӧr�e���M�᭱���Ů�C
select trim ( '     test    ') as result;

--�U�C�d�ҷ|�Q�� LTRIM �Ӳ����r��}�Y���ťզr���C
select ltrim('     Five spaces are at the beginning of this string.');

--�U�C�d�ҶǦ^�y���S���Ů檺��r�C
select rtrim('Removes trailing spaces.   ');  

--�j�p�g�ഫ
select upper ('abcdefg');
select lower ('ABCDEFG');


--	�Q�� Lower, upper �M RTRIM ��� �ӲզX�æ�s�m�W�C
use Northwind;
go

select * from Orders

select lower(rtrim(CustomerID)) + ', ' + upper (CustomerID) as 'Name', CustomerID
from Orders  
order by CustomerID;  
go


--	�åB�Q�� LOWER�BUPPER�A�B�N UPPER ��Ʊ_����m�� LOWER ��Ƥ��C
select	lower(SubString(CustomerID, 1, 20)) as 'Lower',
			upper(SubString(CustomerID, 1, 20)) as 'Upper',
			lower(upper(SubString(ShipName, 1, 20))) as 'LowerUpper', CustomerID, ShipName
from Orders  
order by CustomerID;  
go


select	lower(SubString(CustomerID, 1, 20)) as 'Lower',
			upper(SubString (CustomerID, 1, 20)) as 'Upper',
			lower(upper(SubString(ShipName, 1, 20))) as 'LowerUpper', CustomerID, Freight, ShipName
from Orders  
where Freight between 11.00 and 20.00;  


--�U�C�d�ұN�r�ꤤ�� cde ���N�� xxx �r��C
select replace ('abcdefghicde', 'cde', 'xxx');  

--  stuff() ��ƥΩ�q���r�Ŧꤤ�R�����w���ת��r�ŧǦC�A�ñq���w���_�l���޴��J���w���r�ŧǦC�C
-- STUFF (source_string, start, length, add_string)
--			1. source_string�G�n�ק諸��l�r�Ŧ�C
--			2.�}�l�G�N�R�����w�r�Ū��רô��J�s�r�ŧǦC���_�l���ޡC
--			3.���סG�n�q��l�r�Ŧꪺ�_�l���ޤ��R�����r�żơC
--			4. add_string�G�n���J���s�r�Ŷ�(�r�Ŧ�)�N���q�_�l���ޤ��R�����r�šC

select stuff('GoogleFacebookGoogle', 7, 8, 'Google')
select stuff('GoogleFacebookGoogle', 1, 20, 'Google')


--�U�C�d�ұN�r�ꤤ�� abcde ���ର edcba �r��C
select reverse('abcde')

--�U�C�d�ұN�r�ꤤ�� abc �ƻs 10 ���C
select replicate('abc', 10)


