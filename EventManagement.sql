Create database EventManagement;

use EventManagement;

create table Admin( admin_id varchar(20) primary key,
						password varchar(50) not null
						);

create table UsersTable ( user_id int primary key identity(100,1),
					first_name varchar(50) not null,
					last_name varchar(50) not null,
					email varchar(50) not null,
					password varchar(50) not null,
					phone int not null,
					address varchar(100) not null
					);

create table EventsTable( event_id int primary key identity(1000,1),
						  event_type varchar(50) not null,
						  guests int not null,
						  book_date date not null,
						  user_id int references UsersTable(user_id) on delete cascade );

create table FoodOrder ( food_order_id int primary key identity(500,1),
						 food_type varchar(50) not null,
						 meal_type varchar(50) not null,
						 dish_type varchar(50) not null,
						 food_cost int not null,
						 event_id int references EventsTable(event_id),
						 user_id int references UsersTable(user_id) on delete cascade );

create table FlowerOrder ( flower_order_id int primary key identity(700,1),
						 flower_name varchar(50) not null,
						 flower_cost int not null,
						 event_id int references EventsTable(event_id),
						 user_id int references UsersTable(user_id) on delete cascade );

create table BookingStatus (booking_id int primary key identity,
							food_request bit,
							flower_request bit,
							user_id int references UsersTable(user_id) on delete cascade,
							status varchar(50) not null);



insert into Admin values('Rakesh26', 'Rakesh1999');

select * from Admin;

select * from FlowerOrder

select * from UsersTable

select * from EventsTable

select * from FoodOrder;