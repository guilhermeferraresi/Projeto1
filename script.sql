-- Criando a DB
-- drop database dbexemplo;
create database dbProjeto1;
use dbProjeto1;

create table tbUsuarios(
 Id int primary key auto_increment,
 Nome varchar(50) not null,
 Email varchar(50) not null,
 Senha varchar(50) not null
);

select * from tbUsuarios;

insert into tbUsuarios(nome, email, senha) values("Long", "longtechnology2025@gmail.com", "long@2025");