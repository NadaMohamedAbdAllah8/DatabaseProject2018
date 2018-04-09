alter table car add(needRepair varchar2(1));
alter table car modify ( REGISTRATION_NUMBER number(6)); 
alter table car modify ( required_insurance number(8,4));
alter table car modify ( street varchar2(20));
commit;
insert into company values('2N2Y');

insert into company_address values('2N2Y',17,'El-Haram','Giza');
insert into company_address values('2N2Y',11,'El-Tahrir ','Cairo');

commit;

