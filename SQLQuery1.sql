create database aula

create table teste
(
	id integer primary key identity,
	nome varchar(50)
)

begin transaction

insert into teste values ('teste');
insert into teste values (1,2);

if(@@error > 0)
	begin
		rollback transaction;
	end
else
	begin
		commit transaction;
	end
