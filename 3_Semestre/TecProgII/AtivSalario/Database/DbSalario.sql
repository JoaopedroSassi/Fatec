CREATE DATABASE DbSalario

CREATE TABLE TbFuncionario (
	id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
	nome VARCHAR(200),
	cargo VARCHAR(200),
	caminhoFoto VARCHAR(250),
	dataAdmissao DATETIME,
	salarioBruto DVARCHAR(200),
	salarioLiquido VARCHAR(200),
	INSS VARCHAR(200)
);