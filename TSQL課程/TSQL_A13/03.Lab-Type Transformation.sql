--	Module 13 - Lab03 �`������ƫ��O�ഫ���D

--	�bSQL Server ������ظ���ഫ��k�G�@�جO��ʸ���ഫ�F�t�@�جO���ʸ���ഫ�C
--	����ഫ�O�N��ƫ��A�ϥ��ഫ�禡���T���ഫ���t�@�ث��A�A�`�Ϊ��覡�O CAST �M CONVERT �禡�C
--	�����ഫ�O����ؤ��P��������i�����ιB��A�]�����e�i�H�����ۮe�A
--			�ҥH SQL Server �|�۰ʶi��B�z�A�۰ʧP�_�N��ƫ��A�ഫ�C
--			�Ҧp�@�� smallint ���ܼƸ�@�� int ���ܼư���ƹB��Asmallint ���ܼƦb�B��e�|�Q�����ഫ�� int ���A�C
--	�����ഫ�γ\��K�A�o���i��]�t���w����b�����I�A�p�ഫ�����~�άO����B��į઺���C�C
--	�����ഫ�]���n�ഫ���ۦP���������~�|�i��B��A�o�|���ͮį���D�A�n�ɶq�קK�C

-- �����ഫ
select 1 + '2';
select '1' + 2;

-- �U�C�d�ҷ|�w�q�@�� VARCHAR �������ܼơA�N��ƭȫ������ܼơA�M��ϥΦr��N�ܼƦ�s�C
declare @str varchar(10);                  -- @str is varchar
set @str = 100;                                   --���ɷ|�N���100�ഫ���r��
select @str + ' ���@�r��' as Result;
select @str + 200 as Result;				--  300 �n���S��^ int ���

--	�]�� int �� varchar ���󰪪��ഫ�u�����ǡA�ҥH SQL Server �|���ձN�r���ഫ����ơA

--	���ѩ󦹦r��L�k�ഫ����ơA�]���|�^���ഫ���ѡC 
declare @num1 int;
set @num1 = '100';
select @num1 + ' is not a string.' as Result;  -- Error : num1 is INT
-- select @num1 as Result;                 -- int is OK

-- �p�G���ѥi�i���ഫ���r��A�h���z���|���\�A�p�U�C�d�ҩҥܡG
declare @num2 int;
set @num2 = '100';         -- str to int
select @num2 + ' 1' as Result;  -- int + int

-- �r��I�_
select cast (N'ab����' as char(3));  -- 8 bytes to 3 bytes

use Northwind;
select * from dbo.Orders

select	cast (ShipName as varchar(5)), 
			cast (ShipAddress as char(5))
from dbo.Orders

--	CAST �ƭ��ഫ, 10.6496 �ഫ�� int �� numeric �����i��|�Q�I�_�Υ|�ˤ��J
select  cast(10.6496 as int),               -- �Q�I�_
			cast(10.6496 as numeric);     -- �|�ˤ��J

select cast(10.3496847 as money);     -- �|�ˤ��J

--	Error : �ഫ���~varchar �� 'A' �ഫ��������� int �ɡA�ഫ���ѡC
select cast('A' as int);

--	��Ŧr�� (' ') �Q�ഫ�� numeric �� decimal �ɡASQL Server �]�|�Ǧ^���~�C

select cast(' ' as numeric);
select cast(' ' as decimal);

--	�Ŧr���ରint�|�۰��ܬ�0
select cast(' ' as int);

