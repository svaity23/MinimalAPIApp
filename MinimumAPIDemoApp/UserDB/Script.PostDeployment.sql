if not exists (select 1 from dbo.[User])
begin
	insert into dbo.[User] (FirstName, LastName)
	values	('Tim', 'Corey'),
			('Mary', 'Jones'),
			('Sue', 'Storm'),
			('John', 'Smith');
end