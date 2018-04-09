create or replace
procedure InserTelePhoneNum
(UserSSN number,Tele NUMBER)
as 
begin

insert into Customer_tele values(UserSSN,Tele);

end InserTelePhoneNum;
