create or replace
procedure Insertexpenditures
(SentYear NUMBER,SentMonth NUMBER, ins NUMBER, rCost NUMBER, mCost NUMBER,pCost NUMBER)
as 
begin
insert into expenditures (x_month, x_year, cars_paid_insurance, company_name,
maintenance_cost, purchases_cost, repair_cost)
values(SentMonth,SentYear,ins,'2N2Y',mCost,pCost,rCost);

end ;


