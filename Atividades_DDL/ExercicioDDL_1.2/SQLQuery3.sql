--Construa o Modelo Entidade Relacionamento considerando o seguinte cen�rio:

--uma empresa possui v�rios ve�culos
-- um ve�culo possui marca(gm, ford, fiat), modelo(onix, fiesta, argo) e placa
-- um cliente (cpf, nome) aluga um ou mais ve�culos

CREATE DATABASE ExercicioLocadora;

USE ExercicioLocadora;

CREATE TABLE Cliente (
IdCliente INT PRIMARY KEY IDENTITY,
Nome VARCHAR (30),
CPF VARCHAR (15)
)

CREATE TABLE Empresa (
IdEmpresa INT PRIMARY KEY IDENTITY,
Nome VARCHAR (30),
)
CREATE TABLE Marca (
IdMarca INT PRIMARY KEY IDENTITY,
Nome VARCHAR (30),
)

CREATE TABLE Modelo (
IdModelo INT PRIMARY KEY IDENTITY,
Nome VARCHAR (30),
)

CREATE TABLE Veiculo(
IdVeiculo INT PRIMARY KEY IDENTITY,
IdEmpresa INT FOREIGN KEY REFERENCES Empresa(IdEmpresa),
IdMarca INT FOREIGN KEY REFERENCES Marca(IdMarca),
IdModelo INT FOREIGN KEY REFERENCES Modelo(IdModelo),
Placa VARCHAR (10)
)

CREATE TABLE Aluguel (
IdAluguel INT PRIMARY KEY IDENTITY,
IdVeiculo INT FOREIGN KEY REFERENCES Veiculo(IdVeiculo),
IdCliente INT FOREIGN KEY REFERENCES Cliente(IdCliente),
--adicionar idmodelo
Retirada DATE,
Devolucao DATE,
)


