--	Module 12 - Lab02 SUBSTRING() LEFT() RIGHT() ���

--  SUBSTRING() �O�^�ǹB�⦡���w��������ơC
--	�B�⦡�i�H�O character�Bbinary�Btext�Bntext �� image�C
--	�y�k�O SUBSTRING ( expression, start, length )
--	�ݭn���w�q���̶}�l���Φr��A���ΥX�X�Ӧr�զ��@�Ӧr��C

--	start �s���O�H 1 ����¦�A�o��ܹB�⦡�����Ĥ@�Ӧr���� 1�C�p�G�W�L�d��A�|�^�ǪŦr��C
--	length �p�G�W�L�d��A�|�^�Ǳq start ��r�굲�����r��C�p�G���t�ơA�|���Ϳ��~�C


select SubString ('abcdef', 2, 3);
select SubString ('SQL Server ��ުѥ��������q', 5, 9);

-- start �j��B�⦡�����r����,�|�^�ǪŦr��
select SubString ('abcdef', 10, 1);

--	Error :�@length �p�G���t�ơA�|���Ϳ��~�C
select SubString ('abcdef', 2, -1);


--	SUBSTRING + LEN ���,���r��̫�@�Ӧr��
declare @str varchar(40);
set @str = 'SQL Server ��ުѥ��������q';
select SubString (@str, 1, 13) +'(' +SubString (@str, 14, 1) +')'+ SubString (@str, len(@str)-1, 2);
	

--	LEFT() �|�^�ǳ̥��䪺 N �Ӧr���ơC
--	�y�k LEFT ( character_expression , integer_expression )
--	character_expression �i�H�O�`�ơB�ܼƩθ�Ʀ�C
---	character_expression �O Unicode ��������ɷ|�Ǧ^ nvarchar �A�_�h�O�Ǧ^ varchar�C
--	integer_expression ���w���צp�G�W�L�r����סA�|�Ǧ^�������r�ꤺ�e�C
--	integer_expression �p�G���t�Ʒ|���Ϳ��~�C

--	LEFT() �^�Ǧr�ꥪ����_����Ӧr��
select left ('abcdefg', 2);

--	�^�ǥ����r��
select left ('abcdefg', 20);

--	Error : �p�G���t�ơA�|���Ϳ��~�C
select left('abcdefg', -2);


--	RIGHT() �|�^�ǳ̥k�䪺N�Ӧr����
--	�y�k : RIGHT ( character_expression , integer_expression )
--	character_expression �i�H�O�`�ơB�ܼƩθ�Ʀ�C
---	character_expression �O Unicode ��������ɷ|�Ǧ^ nvarchar �A�_�h�O�Ǧ^ varchar�C
--	integer_expression ���w���צp�G�W�L�r����סA�|�Ǧ^�������r�ꤺ�e�C
--	integer_expression �p�G���t�Ʒ|���Ϳ��~�C

--	RIGHT() �^�Ǧr��k����_����Ӧr��
select right ('abcdefg', 2);

--	�^�ǥ����r��
select right ('abcdefg', 20);

--	Error : �p�G���t�ơA�|���Ϳ��~�C
select right ('abcdefg', -2);


--	���禡�|�b�ĤG�Ӧr���B�⦡���j�M�@�Ӧr���B�⦡�A�öǦ^�Ĥ@�ӹB�⦡��"�}�l��m" (�p�G��쪺��)�C
--	charindex ( expressionToFind , expressionToSearch [ , start_location ] ) 
select charindex('is', 'This is a string')
select charindex('is', 'This is a string', 4)

--  �Ϋ��O charindex(),  substring ��X NorthWind �� Employees �� 
--  ���HomePhone �����ϰ츹�X���t()
use Northwind
select HomePhone from Employees
























use Northwind
select	HomePhone, 
			charindex('(', HomePhone),
			charindex(')', HomePhone),
			SubString (HomePhone, charindex('(', HomePhone)+1, charindex(')', HomePhone)-2)
from employees