create or replace
procedure InserCus_AddandDrivingLicence
(CusblockNum number,CusStreet VARCHAR2 ,gov VARCHAR2,drivingLic NUMBER,UserSSN NUMBER)
as 
begin
update customer
set 
block_num=CusblockNum,street=CusStreet, 
GOVERNORATE=gov,DRIVING_LICENCE=drivinglic
where  (ssn=userssn);
end ;
