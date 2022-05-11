--	Module 11 �t�Τ��ب���ƾǡB����P�ɶ�����Ƥ���
--		11-1 : �ƾǨ�� 
--		11-2 : ����P�ɶ���� 
--		11-3 : �p����oSQL Server�D���W������M�ɶ� 

--	��Ʒ|����p��A�q�`�O�H��J�Ȭ���¦�A�öǦ^�ƭȡC
--	SQL ���ت��ƾǨ�� : 
--		�T������� :			SIN�ACOS�ATAN�ACOT�AASIN�AACOS�AATAN
--		���׬����B�z :		DEGRESS�ARADIANS�AATN2�ϥ���
--		����� :				ROUND�AFLOOR�ACEILING
--		���� :					SQUARE�APOWER�ASQRT
--		�ƾǲŸ� :			PI�AEXP�ALOG�ALOG10
--		���t�� :				ABS�ASIGN
--		�H���� :				RAND

-- Lab01 �ƾǨ��

-- �T�����
select sin(pi()), cos(pi()), tan(pi()/4), asin(1);  


-- ABS ������(��)��
select abs(-1.0), abs(0.0), abs(1.0);  


-- Error : int ��ƫ��O�Ȫ��d��b -2,147,483,648 �� 2,147,483,647
declare @i int;  
set @i = -2147483648;    -- error
select  abs(@i);                  
go


-- �Ǧ^�j�󵥩�̤p��ƭ�,�U�٤Ѫ�O��ơA�ɶq���j������
select  ceiling ($123.45),  ceiling($-123.45),  ceiling($0.0);		-- with $ sign
select  ceiling(123.45),  ceiling(-123.45),  ceiling(0.0);			-- without $ sign

-- �Ǧ^�p�󵥩�̤j��ƭ�,�U�٦a�O��ơA�ɶq���p������
select  floor($123.45), floor($-123.45), floor($123.45); 
select  floor(123.45), floor(-123.45), floor(123.45); 

-- �Ǧ^���� 0 �� 1 (���t) ���������H�� float
-- �����w�ؤl�ȡARAND��ƱN�H�����͵��G�C
select  rand(100), rand(15), rand(), rand()  ;
go 5

select rand(100), rand(), rand(), rand()
go 10

select rand()

--	�p�󲣥�  0 ~ 10 �������ü� ??


--	�p�󲣥�10 ~ 15 �������ü� ??


--	�p�󲣥� -1 ~ 1 �������ü� ??



-- ���w�p���I��X��å|�ˤ��J
select  round(123.9194, 2), round(123.9995, 3), round(123.456789, -2)    -- -2

-- �Ǧ^���w�B�⦡���� (+1)�B�s (0) �έt (-1) ���C
select  sign(-125), sign(0), sign(564);   

-- �Ǧ^2��10����=1024
select power(2.0, 10), power(2.5, 5),  round(power(2.5, 0.5), 5);  

declare @input1 float;  
declare @input2 float;  
set @input1= 2.;  
set @input2 = 2.5;  
select power(@input1, 3), power(@input2, .5) ;

select   
power(cast (2 as float), -100.0) as FloatResult,  
power(2, -100.0) as IntegerResult,  
power(cast (2.0 as int), -100.0) as IntegerResult,  
power(2.0, -100.0) as Decimal1Result,  
power(2.0000000, -100.0) as Decimal2Result,  
power(cast (2.0 as decimal (5,2)), -100.0) as Decimal2Result;  
go

-- ��^���w�B�I�ƪ�����
select square(5.0)

-- ��^���w�B�I�ƪ������
select sqrt(25)

-- �Ǧ^��P�v PI ���`�ƭ�
select pi(), pi()*5; 


select * from Northwind.dbo.orders
select Freight, sin(Freight) from Northwind.dbo.orders

