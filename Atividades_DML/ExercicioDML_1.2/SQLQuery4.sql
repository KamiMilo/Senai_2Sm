--DML

--um registro de aluguel deve conter qual cliente alugou, o veículo alugado, data de retirada e data de devolução

USE ExercicioLocadora

INSERT INTO Cliente(Nome,CPF)
VALUES ('Joao','04562000')

INSERT INTO Empresa(Nome)
VALUES ('Toyota')

INSERT INTO Marca(Nome)
VALUES ('Fiat')

INSERT INTO Modelo(Nome)
VALUES ('Fiesta')

INSERT INTO Veiculo(IdEmpresa,IdMarca,IdModelo,Placa)
VALUES (2,2,2,'D0P1C3')

INSERT INTO Aluguel(IdVeiculo,IdCliente)
VALUES (1,1)


SELECT * FROM Cliente;
SELECT * FROM Empresa;
SELECT * FROM Marca;
SELECT * FROM Modelo;
SELECT * FROM Veiculo;
SELECT * FROM Aluguel;



