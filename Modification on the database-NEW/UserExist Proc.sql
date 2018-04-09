create or replace
procedure UserExists
(UserSSN number,UserPassword VARCHAR2
, Exist out number
)
as 
begin

select count(*) into Exist  from customer where ssn= userssn and cuspassword= userpassword;

end UserExists;



