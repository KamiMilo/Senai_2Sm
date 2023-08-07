--DML

--um registro de aluguel deve conter qual cliente alugou, o veículo alugado, data de retirada e data de devolução



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
(3,4,'05/08/2023','')
(2,1,'22/05/2023','25/05/2023'),
(1,2,'05/07/2023','13/07/2023'),
(3,4,'12/05/2023','14/05/2023'),












