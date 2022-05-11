 --	Module 12 �t�Τ��ب���r���Ƥ���
--		12-1 : LEN() �PDATALENGTH() 
--		12-2 : �ϥ�SUBSTRING()�BLEFT()�BRIGHT()�Ǧ^�����r���B��r���B�⦡
--		12-3 : �ϥ�STR()�N�ƭȸ���ഫ���r����� 

--	LEN ��ƬO�Ψӭp��B�⦡���ת���ơA�B�⦡�i�H�O�r��B�Ʀr�θ�Ʀ�C
--	LEN ��Ʒ|�۰ʩ��� "�r��" ���Ů�C
--	����r�x�s�ɨϥ� 2 �줸�A���L LEN �p��ɥu�|�� 1�C
--	�Y�n�Ǧ^�B�⦡���줸�ռƥءA�n�ϥ� DATALENGTH ��ơC


-- Lab01 LEN()�PDATALENGTH()

-- �Ǧ^���w�r��B�⦡���r���ơA�����ݪŮ椣��C
select len('TESTSTRING');
select len(1234567890);

--	����r�x�s�ɨϥ�2�줸�A���LLEN�p��ɥu�|��1
select len('����r��123');

--	LEN �|�ư��r����ݪ��Ů�
select len('   ����r��123   ');

--	DATALENGTH �|�p��B�⦡��"�줸����"�C
--	DATALENGTH �|�p��r������Ů�C
--	����r�e 2 �줸�A�ҥH�ϥ� DATALENGTH �p��ɷ|�O2�C
--	�ϥ� LEN �r��B�⦡���r���ƥءA�ϥ� DATALENGTH �h�Ǧ^�ҵ��w�r��B�⦡���j�p (�H�줸�լ����)�C

select Len('abc'), Len('a b c'), Len('a b c ')
select DataLength('abc'), DataLength('a b c'), DataLength('a b c ')   -- �|�p��r������Ů�

select Len('appleī�G')
select Len(N'appleī�G')

select datalength('appleī�G')
select datalength(N'appleī�G')

--	�w�� NULL �ȡALEN �� DATALENGTH ���|�Ǧ^ NULL
select len(null);
select DataLength (null);

--	�ϥ� DATALENGTH �h�Ǧ^�ҵ��w�r��B�⦡���j�p (�H�줸�լ����)�C
select DataLength('Hello!');
select DataLength(N'Hello!');

--	�U�C���d�ҷ|�ܽd LEN �M DATALENGTH �G�ب�ơA��󦳧��ݪťժ��^�ǭȡA
--	�H����������� Unicode �ɦ^�ǭȪ��t���C

declare @val1 varchar(40),  @val2 nvarchar(40);  
set @val1 = 'Test of 22 characters ';						--  varchar(40)
set @val2 = 'Test of 22 characters ';						--	nvarchar(40)
select len(@val1) as varchar_Len ,  DataLength(@val1) as varchar_DataLength;  
select len(@val2) as nvarchar_Len,  DataLength(@val2) as nvarchar_DataLength;  