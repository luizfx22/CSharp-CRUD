/*
DROP DATABASE cli_db;
DROP TABLE clientes;
DROP TABLE parentes;
GO
*/

-- CRIANDO BANCO DE DADOS;
CREATE DATABASE cli_db;

-- CRIANDO TABELA CLIENTES;
CREATE TABLE clientes (
	id INT IDENTITY(1,1) NOT NULL,
	nome_completo VARCHAR(255) NOT NULL,
	data_de_nascimento DATE NOT NULL,
	PRIMARY KEY (id)
);

-- CRIANDO TABELA DE PARENTES;
CREATE TABLE parentes (
	id_cliente int NOT NULL,
	id_parente int PRIMARY KEY NOT NULL,
	nome_completo_parente VARCHAR(255),
	telefone_parente VARCHAR(150)
);

GO