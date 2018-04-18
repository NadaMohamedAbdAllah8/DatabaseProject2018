create or replace
procedure GetCarHireCost
(SentYear NUMBER,SentMonth NUMBER,HireCost out NUMBER)
is
totalVal NUMBEr(15,4);

cursor c1 is
select rentalcost from car ,cusrent 
where car.registration_number=cusrent.car_reg_num
and
 SentYear=EXTRACT(YEAR FROM cusrent.starting_date)
and sentmonth=EXTRACT(Month FROM cusrent.starting_date);

begin
 totalVal:=0;
FOR Hcost in c1
   LOOP
   totalVal:=totalVal+Hcost.rentalcost; 
   END LOOP;
   
  HireCost:= totalVal;
end;

