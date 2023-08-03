--DML

--um registro de aluguel deve conter qual cliente alugou, o veículo alugado, data de retirada e data de devolução

USE ExercicioLocadora

INSERT INTO Cliente(Nome,CPF)
VALUES
('Joao','04562000'),
('Julia','1256548'),
('Maria','45698787'),
('Allan','36698878')

       
INSERT INTO Empresa(Nome)
VALUES 
('Toyota'),
('Volkswagen')


INSERT INTO Marca(Nome)
VALUES 
('Fiat'),
('ford'),
('gm')


INSERT INTO Modelo(Nome)
VALUES 
('Onix'),
('fiesta'),
('argo'),
('palio')


INSERT INTO Veiculo(IdEmpresa,IdMarca,IdModelo,Placa)
VALUES 
(1,1,3,'KAJI487'),
(2,2,3,'AJKSIU7'),
(1,2,2,'KAJI487')


INSERT INTO Aluguel(IdVeiculo,IdCliente,Retirada,Devolucao)
VALUES
(5,1,'22/05/2023','25/05/2023'),
(6,2,'05/07/2023','13/07/2023'),
(4,1,'12/05/2023','14/05/2023')


DELETE FROM Cliente WHERE IdCliente = 4

SELECT 
Aluguel.Retirada,Aluguel.Devolucao ,Cliente.Nome,Modelo.Nome

FROM
Aluguel

JOIN
Cliente ON Aluguel.IdAluguel






--SELECT * FROM Cliente;
--SELECT * FROM Empresa;
--SELECT * FROM Marca;
--SELECT * FROM Modelo;
--SELECT * FROM Veiculo;
SELECT * FROM Aluguel;

--DQL








