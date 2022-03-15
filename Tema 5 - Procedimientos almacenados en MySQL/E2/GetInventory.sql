CREATE DEFINER=`root`@`localhost` PROCEDURE `GetInventory`(in _productid int)
BEGIN
	select 
		pt.idproductTypes ID,
		pt.name,
        pt.brand,
        i.quantity
    from producttypes pt inner join inventory i
    on pt.inventory_idinventory = i.idinventory
    where pt.idproductTypes = _productid;
END