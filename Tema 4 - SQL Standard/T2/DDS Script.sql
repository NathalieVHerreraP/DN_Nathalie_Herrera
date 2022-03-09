CREATE TABLE Users
(
	iduser int not null,
    username varchar(100) not null,
    email varchar(500),
    primary key (iduser)
);

CREATE TABLE Company
(
	idcompany int not null,
    companyname varchar(100) not null,
    createdon varchar(500),
    primary key (idcompany)
);

alter TABLE Company
add column
(
	location char(2)
);

alter TABLE Company
drop column createdon;

alter TABLE users
add column 
(
	idcompany int not null
);

alter TABLE users
ADD CONSTRAINT company_users
	FOREIGN KEY (idcompany)
	REFERENCES company (idcompany);

alter TABLE users
ADD INDEX company_users_idx (idcompany ASC) VISIBLE;

Create View companyusers
as
select c.idcompany, u.iduser, u.email, c.location from users u
inner join company c 
on u.idcompany = c.idcompany;

SELECT * FROM sqltest.companyusers;

insert into country (idcountry, name)
values 	(1,'USA'),
		(2,'Argentina'),
		(3,'Colombia'),
        (4,'México'),
        (5,'Cuba');
        
insert into company (idcompany, companyname, location)
values 	(1,'Company Test', 'SU'),
		(2,'Contoso', 'NO'),
        (3,'Menjurge', 'AM');
        
insert into users (iduser, username, email, idcompany)
values 	(1,'Admin','admin@test.com', 1),
		(2,'Admin','admin@contoso.com', 2),
        (3,'Nath','nath@menjurge.com', 3);
    
insert into city (idcity, name, idcountry)
values 	(1,'CDMX', 4),
		(2,'Tlaxcala', 4),
        (3,'Aguascalientes', 4);
        
insert into city (idcity, name, idcountry)
values 	(4,'Los Angeles', 1),
		(5,'New York', 1),
        (6,'Washington DC', 1);

insert into city (idcity, name, idcountry)
values 	(7,'Buenos Aires', 2),
		(8,'La habana', 5);

update city set name = 'Los Ángeles' where idcity = 4;

update city set name = 'La Habana' where idcity = 8;

insert into city (idcity, name, idcountry)
values 	(9,'Medeyin', 5),
		(10,'Barranquiya', 5);
        
Select * From city ci inner join country co on ci.idcountry = co.idcountry;

update city set name = 'Medellín', idcountry = 3 where idcity = 9;

update city set name = 'Barranquilla', idcountry = 3 where idcity = 10;

delete from city where idcity = 2; /*tlaxcala no existe*/

insert into city (idcity, name, idcountry)
values 	(11,'Monterrey', 6),
		(12,'Reynosa', 6); 
/* doesn't allows to insert like in tutorial bc there's no match at foreign keys (6)*/


