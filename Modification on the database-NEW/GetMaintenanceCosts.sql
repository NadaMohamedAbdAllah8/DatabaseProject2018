create or replace
procedure GetMaintenanceCosts
(SentYear NUMBER,SentMonth NUMBER,MainCost out NUMBER)
is
totalVal NUMBEr(15,4);

cursor c1 is
select maintenance.g_maintair_cost,nvl(maintenance.g_maintair_cost,0)
from maintenance
where SentYear=EXTRACT(YEAR FROM maintenance.maintenance_sending_date)
and sentmonth=EXTRACT(Month FROM maintenance.maintenance_sending_date);

begin
 totalVal:=0;
 
FOR Mcost in c1
   LOOP
   totalVal:=totalVal+Mcost.g_maintair_cost; 
   END LOOP;
   
  MainCost:= totalVal;
end;

