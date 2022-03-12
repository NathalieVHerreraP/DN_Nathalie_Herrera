/*Cities on Countries*/
Select 
	ci.city_id, 
    ci.city, 
    ci.country_id, 
    co.country, 
    ci.last_update 
From country co inner join city ci /*Selecting tables and asigning shorter names*/
on co.country_id = ci.country_id 
where co.country_id = 2;

Select distinct(rating) from film f; /*leaving it just in case-*/

/*Count on movies rating*/
Select
	c.name, 
    sub.rating,
    sub.total_films
from film f inner join film_category fc 
	on f.film_id = fc.film_id
inner join category c 
	on fc.category_id = c.category_id
inner join 
(
	Select 
		count(*) total_films /*name asigned to column*/, 
		rating from film f 
	group by rating having count(*) > 200
) 
sub on f.rating = sub.rating
group by 
	c.name, 
    sub.rating,
    sub.total_films
order by sub.total_films desc;


/*actor with the most movies in*/
Select 
	'Most movies in' query_type,
	sub2.total_films,
    a.actor_id,
    a.first_name,
    a.last_name
from 
(
	Select max(total_films) max_films
	from
	(
		Select 
			count(*) total_films, 
			actor_id 
		from film_actor
		group by actor_id
	) sub
) sub_max
inner join 
(
	Select 
	count(*) total_films, 
	actor_id 
	from film_actor
	group by actor_id
) sub2 on sub_max.max_films = sub2.total_films
inner join actor a on a.actor_id = sub2.actor_id

/*union of both queries*/
union 

/*actor with less movies in*/
Select 
	'Less movies in' query_type,
	sub2.total_films,
    a.actor_id,
    a.first_name,
    a.last_name
from 
(
	Select min(total_films) min_films
	from
	(
		Select 
			count(*) total_films, 
			actor_id 
		from film_actor
		group by actor_id
	) sub
) sub_min
inner join 
(
	Select 
	count(*) total_films, 
	actor_id 
	from film_actor
	group by actor_id
) sub2 on sub_min.min_films = sub2.total_films
inner join actor a on a.actor_id = sub2.actor_id;

