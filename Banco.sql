CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno
(
	id				int					NOT NULL AUTO_INCREMENT,
	matricula		varchar(15)			NOT NULL,
	dt_nascimento	datetime			NOT NULL,
	nome			varchar(100)		NOT NULL,
	endereco		varchar(100)		NOT NULL,
	bairro			varchar(100)		NOT NULL,
	cidade			varchar(100)		NOT NULL,
	estado			varchar(02)			NOT NULL,
	senha			varchar(60)			NOT NULL,
	PRIMARY KEY(id)

	
);
