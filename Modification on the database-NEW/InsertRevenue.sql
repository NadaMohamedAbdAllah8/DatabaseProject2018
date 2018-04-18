create or replace
procedure InsertRevenue
(SentYear NUMBER,SentMonth NUMBER, Hcost NUMBER)
as 
begin
insert into revenue (r_month, r_year ,car_hire, company_name)
values(SentMonth,SentYear,Hcost,'2N2Y');

end ;

--select r_month, r_year car_hire, company_name from revenue
