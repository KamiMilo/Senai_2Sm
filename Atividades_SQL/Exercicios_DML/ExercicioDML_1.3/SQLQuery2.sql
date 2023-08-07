
--DML

--cada atendimento deve registrar qual veterinário atendeu, qual pet foi atendido, descrição da consulta e data da consulta
USE Exercicio1_3

INSERT INTO Endereco(Rua,Bairro,CEP)
VALUES
('Bandeirantes','jardim Dourado','04250-000'),
('Ponte nova','Aurora Boreal','12569-000'),
('Estrela','Terra Luz','59876-000'),
('Dalva','Campo Nobre','698752-000')


INSERT INTO Clinica(Nome,IdEndereco)
VALUES
('PetLand',3),
('Centro Animal do Bairro',1),
('Hospital dos Bichanos',2),
('Império Pet',4)


INSERT INTO Veterinario (Nome,IdClinica)
VALUES 
('Enzo Batista',4),
('Julia Ferreira',4),
('Amelie Silva',2),
('Guilherme Strada',4),
('Ana souza',3),
('Pedro Jasmin',1)




INSERT INTO Dono (Nome,Numero)
VALUES 
('Evelyn','1125444789'),
('Maria','1123658749'),
('Eduardo','112698745'),
('Carlos','115698745')


INSERT INTO Tipo (Nome)
VALUES
('Peixe'),
('Cachorro'),
('Coelho'),
('Gato')


INSERT INTO Raca (Nome)
VALUES 
('Peixe-palhaço'),
('Rotweiller'),
('Mini-lop'),
('gato-Preto'),
('Mau-Egipcio'),
('Maltês'),
('Persa'),
('siamês'),
('Schnauzer')


INSERT INTO Pet (IdDono,Nome,DataDeNascimento,IdTipo,IdRaca)
VALUES 
(3,'Rob','07/03/2018',2,2),
(1,'belinha','12/08/2023',2,5),
(4,'Peter','30/03/2022',1,1),
(2,'Louise','07/05/2023',4,5),
(2,'nina','13/06/2022',3,3),
(2,'Lino','07/06/2019',4,5),
(2,'Astolfo','07/06/2019',4,4)


INSERT INTO Atendimento (IdPet,IdVeterinario,[Data])
VALUES
(3,1,'06/05/2023'),
(2,4,'07/05/2023'),
(3,2,'06/05/2023'),
(5,3,'08/06/2023')

SELECT * FROM Endereco
SELECT * FROM Veterinario
SELECT * FROM Pet
SELECT * FROM Dono
SELECT * FROM Raca
SELECT * FROM Tipo
SELECT * FROM Atendimento

