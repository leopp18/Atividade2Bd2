create database gremio;

select * from teste2

create table teste2
(
	id integer primary key identity,
	nome varchar(50)
)

create table pessoas2
(
	id integer primary key identity,
	nome varchar(50),
	idade integer,
	altura integer
)

create login usuario2 with password='senha1234';
create user usuario2 from login usuario2;
exec sp_addrolemember 'DB_DATAREADER', 'usuario2';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario2';

select database_id, name, create_date from sys.databases where database_id > 4;


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
