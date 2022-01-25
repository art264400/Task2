CREATE OR REPLACE FUNCTION "FK".get_actual_films (startTime Date) 
	RETURNS table ( Title character varying )
AS $$
	v_sqlQUery text :='select m.* from "Timeslots" t
left join "Movies" m on m."Id" = t."MovieId" where t."StartTime" >'

	BEGIN
	if(startTime is not null) then
		v_sqlQUery := v_sqlQUery || ' t."StartTime" > ''' || startTime || '%''';
	end if;
	RETURN QUERY EXECUTE v_sqlQuery;
END;
$$ LANGUAGE plpgsql;