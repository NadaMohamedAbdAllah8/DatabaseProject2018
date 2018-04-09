create or replace
procedure GetInsuranceCosts
(SentYear NUMBER,SentMonth NUMBER,IncCost out NUMBER)
is
totalVal NUMBEr(15,4);

cursor c1 is
select required_insurance,nvl(required_insurance,0)
from car
where SentYear=EXTRACT(YEAR FROM car.purchase_date)
and sentmonth=EXTRACT(Month FROM car.purchase_date);
begin
 totalVal:=0;
FOR Icost in c1
   LOOP
   totalVal:=totalVal+Icost.required_insurance; 
   END LOOP;
   
  IncCost:= totalVal;
end;

