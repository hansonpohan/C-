--	Module 8   02.Demo - Design a more appropriate index.sql


use MarketDev;
go

--  check : Marketing.PostalCode �� ���� 

drop index if exists  IX_PostalCode_Perf_A on Marketing.PostalCode
drop index if exists  IX_PostalCode_Perf_B on Marketing.PostalCode

select * from Marketing.PostalCode

--  check : MarketDev  ��  table  Marketing.PostalCode  ��  ����   ��  �ݩ� (�D��O�� country & postalCode �զ�)

--�i��ܦ��p����p�e�j & �i�]�A��ڰ���p�e�j:
select PostalCode, Country
from Marketing.PostalCode 
where StateCode = 'KY'                   -- search on StateCode
order by StateCode, PostalCode;  -- �i��ܦ��p����p�e�j��� : �Ƨ�,  �O�����޷j�M Clustered
go
-- check :�i�]�A��ڰ���p�e�j  �i����p�e�j�����


-- INDEX IX_PostalCode_Perf_A
create nonclustered index IX_PostalCode_Perf_A
on Marketing.PostalCode (StateCode)              -- check ���� -> �ݩ�
include (Country, PostalCode);
go


--�i��ܦ��p����p�e�j & �i�]�A��ڰ���p�e�j:
select PostalCode, Country
from Marketing.PostalCode 
where StateCode = 'KY'        -- �i��ܦ��p����p�e�j��� : �Ƨ�,  ���޷j�M NonClustered, StateCode ���O����
order by StateCode, PostalCode;
go
-- check :�i�]�A��ڰ���p�e�j �i����p�e�j�����


--INDEX IX_PostalCode_Perf_B
create nonclustered index IX_PostalCode_Perf_B
on Marketing.PostalCode (StateCode, PostalCode)
include (Country);
go


--�i��ܦ��p����p�e�j & �i�]�A��ڰ���p�e�j:
select PostalCode, Country
from Marketing.PostalCode 
where StateCode = 'KY'  -- �i��ܦ��p����p�e�j��� : [�S���Ƨ�],  ���޷j�M NonClustered
order by StateCode, PostalCode;
go
-- check :�i�]�A��ڰ���p�e�j  �i����p�e�j�����