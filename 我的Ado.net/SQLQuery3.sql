select * from persons where 姓名 Like '%小%';  -- %代表任意字元或空字元
select top 100 * from persons;
insert into persons values ('David Wang', '0922999111', '台北市內湖區港湖路','david@ppp.com.tw','1977-3-4',1,2800)
delete from persons where id =10;
update persons set 姓名='David Wang', 電話='0922999111',地址= '台北市內湖區港湖路',email='david@ppp.com.tw',生日='1977-3-4',婚姻狀態=1,點數=3400 where id=12;
