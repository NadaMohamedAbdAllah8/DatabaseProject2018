create or replace procedure InsertNewCar
(CarregNum  number,
required_insu number,
BlockNo Number,
DPurch  Date, 
BStreet  varchar2,
Bgovernorate VARCHAR2,
manu VARCHAR2,
Carmodel VARCHAR2,
TheRentalcost NUMBER,
eSize NUMBER
,PassNO NUMBER,
ProducYear NUMBER
, CarIsRented char
,purch_cost NUMBER
,fType VARCHAR2
,BeRepaired VARCHAR2
)
as
begin
insert  into  car
(company_name,registration_number, required_insurance, block_num , street, governorate,
maker
, cmodel, rentalcost, purchase_date, engine_size,number_passengers, year_production,
is_rented, purchase_cost, fule_type, needrepair)
Values ('2N2Y' ,CarregNum,required_insu,BlockNo,BStreet,Bgovernorate,manu,Carmodel,
TheRentalcost,DPurch,eSize, PassNO,ProducYear,CarIsRented,purch_cost,fType,BeRepaired) ;
End ;