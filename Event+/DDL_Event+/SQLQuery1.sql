--DDL
CREATE DATABASE [Event+_manha];
USE [Event+_manha];

CREATE TABLE TiposDeUsuario
( IdTiposDeUsuario INT PRIMARY KEY IDENTITY,
  TituloTipoUsuario VARCHAR (20) NOT NULL UNIQUE
)

--Adicionar Coluna
/*(ALTER TABLE nome_da_coluna
 ADD nome_Nova_Coluna TIPO (20)
)*/

CREATE TABLE Instituicao 
( IdInstituicao INT PRIMARY KEY IDENTITY,
 CNPJ CHAR (14) NOT NULL UNIQUE,
 Endereco VARCHAR (50) NOT NULL,
 NomeFantasia VARCHAR(50) NOT NULL
)

CREATE TABLE TiposEvento
( IdTiposDeEvento INT PRIMARY KEY IDENTITY,
  TituloTipoEvento VARCHAR (50) NOT NULL UNIQUE
)

CREATE TABLE Usuario 
( IdUsuario INT PRIMARY KEY IDENTITY,
  IdTiposDeUsuario INT FOREIGN KEY REFERENCES TiposDeUsuario( IdTiposDeUsuario) NOT NULL,
 Nome VARCHAR(50)NOT NULL,
 Email VARCHAR(100)NOT NULL UNIQUE,
 Senha VARCHAR(50)NOT NULL
)

CREATE TABLE Evento 
( IdEvento INT PRIMARY KEY IDENTITY,
 TiposDeEvento INT FOREIGN KEY REFERENCES TiposEvento(IdTiposDeEvento) NOT NULL,
 IdInstituicao INT FOREIGN KEY REFERENCES Instituicao(IdInstituicao)NOT NULL,
 NomeEvento VARCHAR(50)NOT NULL,
 Descricao VARCHAR(100)NOT NULL,
 DataEvento DATE NOT NULL,
 HorarioEvento TIME NOT NULL,
)

CREATE TABLE ComentarioEvento
( IdComentario INT PRIMARY KEY IDENTITY,
  IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)NOT NULL,
  IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento) NOT NULL,
  Descricao VARCHAR(100)NOT NULL,
  Exibe BIT DEFAULT(0)
 )

 CREATE TABLE PresencasEvento 
( IdPresencasEvento  INT PRIMARY KEY IDENTITY,
  IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario)NOT NULL,
  IdEvento INT FOREIGN KEY REFERENCES Evento(IdEvento) NOT NULL,
  Situacao BIT DEFAULT(0)
 )






