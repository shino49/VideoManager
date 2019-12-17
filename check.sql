go
create procedure username_not_repeat @rt_isRep int output,@give_name varchar(40)
as
begin
	select @rt_isRep = count(username) from appuser where username = @give_name;
end;