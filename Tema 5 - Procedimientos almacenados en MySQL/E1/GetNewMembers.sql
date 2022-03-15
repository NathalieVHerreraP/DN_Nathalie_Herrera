CREATE DEFINER=`root`@`localhost` PROCEDURE `GetNewMembers`()
BEGIN
	declare _membersince datetime;
    declare _monday int;
    declare _daycount int;
    
    set _daycount = 0;
    set _membersince = now();

	set _monday = dayofweek(_membersince);
    
    while _monday != 2 do
		if _monday = 1 then
				set _monday = 7;
				set _daycount = _daycount + 1;
        end if;
        set _daycount = _daycount + 1;
		set _monday = _monday - 1;
	end while;
        
	select 
		m.idmembers, 
        m.membersince, 
        mt.type 
	from members m inner join membershiptypes mt 
    on m.membershiptypes_idmembershiptypes = mt.idmembershiptypes
    where membersince >= DATE_ADD(DATE(_membersince), interval - _daycount day);
    
END