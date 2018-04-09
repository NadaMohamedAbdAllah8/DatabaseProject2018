create or replace procedure inserSSNandPassword
(UserSSN number,UserPassword VARCHAR2)
as 
begin
insert into customer (ssn,cuspassword)values(UserSSN,UserPassword);

end ;
