create or replace
procedure MonthYearExist
(SentMonth number,SentYear VARCHAR2
, Exist out number
)
as 
begin

select count(*) into Exist  from expenditures where x_month= SentMonth 
and x_year= SentYear;

end ;




