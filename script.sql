-- Criando a DB
-- drop database dbexemplo;
create database dbExemplo;
use dbExemplo;

create table tbUsuarios(
 Id int primary key auto_increment,
 Nome varchar(50) not null,
 Email varchar(50) not null,
 Senha varchar(50) not null
);

select * from tbUsuarios;