create or replace
procedure UpdateExpenditures
(SentYear NUMBER,SentMonth NUMBER, ins NUMBER, rCost NUMBER, mCost NUMBER,pCost NUMBER)
as 
begin

UPDATE expenditures SET
cars_paid_insurance=ins,maintenance_cost=mCost,purchases_cost=pCost,repair_cost=rCost
where x_month=SentMonth and x_year= SentYear;

end ;
