USE Clinica

INSERT INTO Clinica(Endereco)
VALUES('Rua do bomfim, Cep:0000-000 N 215')

INSERT INTO Veterinario (Nome,IdClinica)
VALUES ('Amelie',1)

INSERT INTO Dono (Nome,Numero)
VALUES ('Evelyn','1125444789')

INSERT INTO Tipo (Nome)
VALUES ('Marinho')

INSERT INTO Raca (Nome)
VALUES ('Peixe-Palhaço')

DELETE FROM Raca WHERE Nome = 'Felino'

INSERT INTO Pet (IdDono,Nome,DataDeNascimento,IdTipo,IdRaca)
VALUES (,'Rob','07/03/2018',2,2)

INSERT INTO Atendimento (IdPet,IdVeterinario)
VALUES(3,1)

SELECT * FROM Veterinario
SELECT * FROM Pet
SELECT * FROM Dono
SELECT * FROM Raca
SELECT * FROM Tipo
SELECT * FROM Atendimento