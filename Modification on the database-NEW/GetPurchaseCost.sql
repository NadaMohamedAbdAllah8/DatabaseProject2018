create or replace
procedure GetPurchasingCost
(SentYear NUMBER,SentMonth NUMBER,purCost out NUMBER)
is
totalVal NUMBEr(15,4);

cursor c1 is
select purchase_cost
from car
where SentYear=EXTRACT(YEAR FROM car.purchase_date)
and sentmonth=EXTRACT(Month FROM car.purchase_date);
begin
 totalVal:=0;
FOR Pcost in c1
   LOOP
   totalVal:=totalVal+Pcost.purchase_cost; 
   END LOOP;
   
  purCost:= totalVal;
end;




