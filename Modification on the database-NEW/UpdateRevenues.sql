/*
select  registration_number, rentalcost,cusrent.starting_date from cusrent,car 
where car.registration_number=cusrent.car_reg_num
--where cusrent.starting_date='__-Mar-18'

*/
--select car_hire, r_month, r_year, company_name from revenue;

create or replace
procedure UpdateRevenues
(SentYear NUMBER,SentMonth NUMBER,  HCost NUMBER)
as 
begin

UPDATE revenue SET
car_hire=HCost
where r_month=SentMonth and r_year= SentYear;

end ;
