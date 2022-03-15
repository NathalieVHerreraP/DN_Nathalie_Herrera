CREATE DEFINER=`root`@`localhost` PROCEDURE `NewSale`(in _productid int, in _userid int)
BEGIN
	declare _price int;
    declare _idsales int;
    
    select max(idsales) + 1 into _idsales from sales;
    
	select mt.cost into _price from producttypes pt 
    inner join measuretype mt on mt.idmeasureType = pt.measureType_idmeasureType
    where _productid = pt.idproductTypes;  
    
    insert into sales (idsales, totalcost, selldate, productquantity, productTypes_idproductTypes, users_idusers)
    values (_idsales,_price,now(),1,_productid,_userid);
END