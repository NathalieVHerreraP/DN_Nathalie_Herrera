insert into cities (idcities, name)
values 	(1,'Aguascalientes'),
		(2,'Jalisco'),
        (3,'Zacatecas'),
        (4,'San-Luis Potosi'),
        (5,'Guanajuato');

insert into equipmenttype (idequipmentType, name, brand, cost, units)
values 	(1,'dumbbells','Atlantis',368.15, 10),
		(2,'treadmill','Precor',3650.15, 2),
        (3,'bike','Precor',6670.99, 4),
        (4,'dumbbells','Hammer Strength',757.85, 10),
        (5,'treadmill','Cibex',8635.49, 5);

insert into inventory (idinventory, quantity)
values 	(1,15),
		(2,23),
        (3,25),
        (4,30),
        (5,7),
        (6,0);

insert into measuretype (idmeasureType, size, weight, cost)
values 	(1,'M', 600, 78.23),
		(2,'S', 50, 35.26),
        (3,'L', 2000, 438.26),
        (4,'L', 1500, 334.84),
        (5,'S', 350, 27.99);

insert into members (idmembers, name, lastname, membersince, email, allowNewsLetter, cities_idcities, membershiptypes_idmembershiptypes)
values 	(1,'Nathalie','Herrera','2021-11-11', 'nath@test.com', 1, 1, 3),
		(2,'Ness','Padilla','2021-11-17', 'ness@test.com', 1, 1, 5),
        (3,'Pedro','Picapiedra','2021-10-22', 'pedro@test.com', 1, 3, 2),
        (4,'Eddie','Brock','2021-09-07', 'eddie@test.com', 1, 5, 4),
        (5,'Kike','Flores','2022-01-25', 'kike@test.com', 1, 2, 1);

insert into membershiptypes (idmembershiptypes,type,cost)
values 	(1,'Arm-pack', 300),
		(2,'Leg-pack',200),
        (3,'Full-pack',920),
        (4,'Cardio-pack',450),
        (5,'Abdomen-pack',320);
	
insert into producttypes (idproductTypes, name, brand, measureType_idmeasureType, inventory_idinventory)
values 	(1,'protein','Nutritech',5,1),
		(2,'dumbbells','LifeFitness',1,4),
        (3,'protein','Isolate',3,5),
        (4,'energizer','Volt',4,3),
        (5,'jump ropes','LifeFitness',2,6);

insert into roles (idroles,rol,salary)
values 	(1,'Operations Manager', 2500),
		(2,'Group Fitness Instructor',3200),
        (3,'Maintenance Personnel',1030),
        (4,'Front Desk Staff',1000),
        (5,'Marketing and Outreach Manager',1500);
        
insert into sales (idsales, totalcost, selldate, productquantity, productTypes_idproductTypes)
values 	(1, 520.63 ,'2022-02-12',10,1),
		(2,439.55,'2022-02-22',4,4),
        (3,224.85 ,'2022-01-09',25,5),
        (4,35.26,'2021-12-13',6,2),
        (5,177.34,'2022-01-05',8,3);


insert into users (idusers, name, lastname, email, phonenumber)
values 	(1,'Drake','Parker', 'drake@test.com', 4951357865),
		(2,'Josh','Nicols', 'josh@test.com', 4956782536),
        (3,'Lucy','Goméz', 'lucy@test.com', 4498976482),
        (4,'Daniel','Lewis', 'dan@test.com', 4495573125),
        (5,'María','Flores', 'maria@test.com', 4957354284);
        
insert into usersinroles (idusersInRoles, inrolsince, users_idusers, roles_idroles)
values 	(1,'2021-10-12', 5, 3),
		(2,'2021-08-20', 3, 4),
        (3,'2021-11-13', 1, 2),
        (4,'2022-01-10', 2, 5),
        (5,'2021-11-25', 4, 1);
        

Create View Productsinstock
as
select pt.idproductTypes, pt.name, pt.brand from producttypes pt
inner join inventory i
on pt.inventory_idinventory = i.idinventory
where i.quantity>0;


Select 
	'Most selled product' query_type,
    pt.idproductTypes,
    pt.name,
    pt.brand
 from 
(
	Select 
		max(productquantity) quantity
		from sales 
) sub_max
inner join 
(
	Select 
		productquantity,
		productTypes_idproductTypes
	from sales 
) sub2
on sub_max.quantity = sub2.productquantity
inner join producttypes pt on pt.idproductTypes = sub2.productTypes_idproductTypes;

Select 
	sub2.membersince MemberSince,
	sub2.name Name,
	sub2.lastname LastName,
    mt.type MembershipType
from 
(
	Select max(membersince) registered from members
) sub
inner join 
(
		Select 
			membersince,
            name,
            lastname,
			membershiptypes_idmembershiptypes
        from members
) sub2
on sub.registered = sub2.membersince
inner join membershiptypes mt on mt.idmembershiptypes = sub2.membershiptypes_idmembershiptypes;




