CREATE DATABASE CadastroUsersTecProgII;

CREATE TABLE tb_users (
    id_user INT IDENTITY (1,1), 
    user_name VARCHAR (50), 
    user_email VARCHAR (200),
    user_password VARCHAR(200),
    user_role VARCHAR(50), 
    user_active BIT
);