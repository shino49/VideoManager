go
create procedure username_not_repeat @rt_isRep int output,@give_name varchar(40)
as
begin
	select @rt_isRep = count(username) from appuser where username = @give_name;
end;

go
create trigger 用户约束 on comment
for insert,update
as
begin
	declare @charnum int;
	select @charnum = len(content) from inserted;
	if(@charnum> 140)
	begin
		rollback;
	end 
end;