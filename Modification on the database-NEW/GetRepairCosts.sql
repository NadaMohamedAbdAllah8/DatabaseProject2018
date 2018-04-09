create or replace
procedure GetRepairCosts
(SentYear NUMBER,SentMonth NUMBER,repairCost out NUMBER)
is
totalVal NUMBEr(15,4);

cursor c1 is
select g_repair_cost,nvl(g_repair_cost,0)
from repaircar
where SentYear=EXTRACT(YEAR FROM repaircar.repair_sending_date)
and sentmonth=EXTRACT(Month FROM repaircar.repair_sending_date);
begin
 totalVal:=0;
 
FOR Rcost in c1
   LOOP
   totalVal:=totalVal+Rcost.g_repair_cost; 
   END LOOP;
   
  repairCost:= totalVal;
end;

/*
select registration_number, purchase_date, purchase_cost from car 

select g_repair_cost
from repaircar
*/
