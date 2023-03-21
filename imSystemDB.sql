create database imSystemDB
use imSystemDB

create table customer(
cust_id int not null identity primary key,
cust_name varchar (50) not null, 
cust_phone varchar (50) not null,
cust_address varchar(50) not null, 
cust_total_amount int not null,
cust_amount_paid int not null,
cust_rem_bal int not null,
cust_area varchar(50) not null,
cust_shop_name varchar(50 ) not null
)

create procedure st_insertCust
@name varchar(50), 
@phone varchar(50),
@address varchar(50),
@t_amount int,
@p_amount int, 
@rem_amount int,
@area varchar(50),
@shop varchar(50)
as
insert into customer(cust_name, cust_phone, cust_address,cust_total_amount, cust_amount_paid, cust_rem_bal, cust_area, cust_shop_name) 
values(@name, @phone,@address, @t_amount,@p_amount,@rem_amount, @area, @shop)


create procedure st_updateCust
@name varchar(50), 
@phone varchar(50),
@address varchar(50),
@t_amount int,
@p_amount int, 
@rem_amount int,
@area varchar(50),
@shop varchar(50),
@id int
as
update customer
set
cust_name = @name,
cust_phone = @phone,
cust_address = @address,
cust_total_amount = @t_amount,
cust_amount_paid = @p_amount,
cust_rem_bal = @rem_amount,
cust_area = @area,
cust_shop_name = @shop
where
cust_id = @id

create procedure st_delCust
@id int
as
delete from customer where cust_id = @id

create procedure st_getCust
as
select
c.cust_id as 'ID',
c.cust_name as 'Name',
c.cust_phone as 'Phone',
c.cust_address as 'Address',
c.cust_total_amount as 'Total Amount',
c.cust_amount_paid as 'Amount Paid',
c.cust_rem_bal as 'Remaining Amount',
c.cust_area as 'Area',
c.cust_shop_name as 'Shop'
from customer c