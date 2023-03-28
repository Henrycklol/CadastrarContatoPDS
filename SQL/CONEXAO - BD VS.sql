#Pedro Henrique dos Santos Xavier Araujo - 3ºB
create database app_contato_bd;

use app_contato_bd;

create table contato(
id_con int not null auto_increment primary key,
nome_con varchar (100) not null,
data_nasc_con date,
sexo_con varchar (20) not null,
email_con varchar(50) not null,
telefone_con varchar (20) not null
);

insert into contato (id_con,nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values 
(1, "Mallorie Liddyard","2022-12-06", "Female", "mliddyard0@washingtonpost.com", "984-300-8220");

insert into contato (id_con,nome_con, data_nasc_con, sexo_con, email_con, telefone_con) values 
(2,"Jocelin Lesaunier","2022-12-07", "Female", "jlesaunier1@prweb.com", "299-242-1719");

select * from contato;

select * from contato;