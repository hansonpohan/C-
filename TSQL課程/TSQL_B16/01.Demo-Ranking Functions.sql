--	Module 16.   �����������(Window Functions)    
--		16-1 : �z�L OVER �l�y�إ� SQL ���� (Windows)     
--		16-2 : ���Ǩ��(Ranking functions)-RANK()�BDENSE_RANK()�BROW_NUMBER()�B
--				   NTILE() ���B��     
--		16-3 : ����������(/�첾)���-���R���-LAG()�BLEAD()�BFIRST_VALUE()�B
--				   LAST_VALUE() ���B��     


--	01.Demo - Ranking Functions.sql
--			�Ω������������Ƥ��e�A�z�LOVER�l�y�ӨM�w��ƦC�� "��Ƥ���" �M "�Ƨ�"�A
--			��YOVER�l�y�|�w�q�d�ߵ��G�����������ΨϥΪ̫��w����ƦC���A����
--			������Ʒ|�w����������C�Ӹ�ƦC�ӭp���
--			RANK : �Ǧ^���G�����ΰϤ��A�C�Ӹ�ƦC�����ǡC ��ƦC������
--						����@�[�W�e�z��ƦC���e�����ǼƥءC

-- �ƦW���Ĩ��(Ranking functions)���B��	Ranking Data by Using �iRANK�j  ���Ҥl
--	RANK()��ƻPROW_NUMBER()�����A�J��ۦP�ƭȪ���Ʒ|���ۦP�ƦW�B���ƦW�|���L
--			ROW_NUMBER �|�̧Ǭ��Ҧ���ƦC�s��	(�Ҧp 1�B2�B3�B4�B5)�C 
--			RANK �h��ô�����ѬۦP���ƭ� (�Ҧp 1�B2�B2�B4�B5)�C
--			RANK �O�d�ߦb����ɩҭp�⪺ "�Ȧs��"�C �Y�n�N�Ʀr�O�s�b��ƪ��A
--						�аѾ\ IDENTITY �ݩʩM SEQUENCE�C

use AdventureWorks ;

select * from Production.Product
select * from Production.ProductSubCategory


select psc.Name as Category, p.Name as Product, p.ListPrice, 
         rank() over( partition by psc.Name order by p.ListPrice desc ) as Rank_Cat_ListPrice,--  �u�ݺ�����, ����ƦW
         rank() over( order by p.ListPrice desc ) as Rank_ListPrice		--  �u�ݻ���ƦW
from Production.Product as p  
join  Production.ProductSubCategory as psc
on p.ProductSubCategoryID = psc.ProductSubCategoryID
order by psc.Name, p.ListPrice desc										-- no group by
--order by p.ListPrice desc																 --  �u�ݻ���ƦW


--	Ranking Data by Using �iDENSE_RANK�j  ���Ҥl
--  DENSE_RANK()��� : �PRank()�����A�J��ۦP�ƭȪ���Ʒ|���ۦP�ƦW
--	�����ƦW���|���L(1,1,1,2,2,2)
select psc.Name as Category, p.Name as Product, p.ListPrice,   -- partition by psc.Name
         dense_rank() over( partition by psc.Name order by p.ListPrice desc ) as PriceRank_Cat_ListPrice,
         dense_rank() over( order by p.ListPrice desc ) as PriceRank_ListPrice
from Production.Product as p  
join  Production.ProductSubCategory as psc
on p.ProductSubCategoryID = psc.ProductSubCategoryID
order by psc.Name, p.ListPrice desc
--order by p.ListPrice desc


--	Ranking Data by Using �iROW_NUMBER�j  ���Ҥl
--  �̫��w���N�Ҧ���ƶi��ƧǨô��ѫ��w�Ǹ�
select row_number() over( partition by pc.Name order by ListPrice ) as row,  --  partition by pc.Name
          pc.Name as Category, p.Name Product, p.ListPrice
from Production.Product as p  
join Production.ProductSubCategory  as psc
on p.ProductSubCategoryID = psc.ProductSubCategoryID
join Production.ProductCategory as pc
on psc.ProductCategoryID = pc.ProductCategoryID ;



--  NTILE()���  : �N�H�ƧǸ�Ƥ��Τ�����Ƥ��G��Ҧ����w�ƥت��s�դ� (�s��, ������, �ƦW)
--	Ranking Data by Using �iNTILE�j  ���Ҥl
select NTILE(3) over( partition by pc.Name order by ListPrice ) as row,    -- NTILE(3) �N Cat. ������ 3 ��
          pc.Name as Category, p.Name Product, p.ListPrice
from Production.Product as p   
join Production.ProductSubCategory  as psc
on p.ProductSubCategoryID = psc.ProductSubCategoryID
join Production.ProductCategory as pc
on psc.ProductCategoryID = pc.ProductCategoryID ;
go



select psc.Name as Category, p.Name as Product, p.ListPrice, 
         sum(p.ListPrice) over( partition by psc.Name order by ListPrice) as PriceSum_Cat_ListPrice,  -- by Category + ListPrice
         sum(p.ListPrice) over( partition by psc.Name) as PriceSum_Cat,      -- by Category
         sum(p.ListPrice) over(order by ListPrice) as PriceSum_ListPrice,      --sum by ListPrice order
		 sum(p.ListPrice) over() as PriceSum                                           -- no partition, no order,  just total ListPrice
from Production.Product as p  
join  Production.ProductSubCategory as psc
on p.ProductSubCategoryID = psc.ProductSubCategoryID
--order by psc.Name, p.ListPrice
order by p.ListPrice

