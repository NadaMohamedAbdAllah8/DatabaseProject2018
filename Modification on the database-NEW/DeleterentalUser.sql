create or replace
procedure DelrentUser
(sentSSN number, SentRegNum NUMBER,SentDate DATE)
as 
begin

delete  cusrent 
where cus_snn=sentSSN and car_reg_num=SentRegNum and starting_date=SentDate;

end ;
