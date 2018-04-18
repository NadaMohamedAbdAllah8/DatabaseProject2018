create or replace procedure MonthYearExistRev
(SentMonth number,SentYear VARCHAR2
, Exist out number
)
as 
begin

select count(*) into Exist  from revenue where r_month= SentMonth 
and r_year= SentYear;

end ;

