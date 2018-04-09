create or replace procedure updateTested
(rCost NUMBER,BNum NUMBER,Thstreet VARCHAR2,gov VARCHAR2,
Cmod VARCHAR2,m VARCHAR2,ft VARCHAR2
, es NUMBER,Pyear NUMBER,inc NUMBER,
pdate DATE, pcost NUMBER, regNum NUMBER ,passNo NUMBER, nr CHAR, r CHAR)
as
begin
UPDATE car SET 
rentalcost=rCost,
block_num=BNum, 
street=Thstreet, governorate=gov, 
cmodel=Cmod, maker=m, fule_type=ft, engine_size=es, year_production=Pyear, 
required_insurance=inc,purchase_date=pdate
,purchase_cost=pcost, number_passengers=passNO ,needrepair=nr,is_rented=r 
where registration_number=regNum ;
End ;


