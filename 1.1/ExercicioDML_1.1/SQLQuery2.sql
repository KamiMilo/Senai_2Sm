--DML
USE ExercicioPessoa

INSERT INTO Pessoa (Nome,CNH)
VALUES ('Julia','0123456878')

INSERT INTO Email(IdPessoa,Endereço)
VALUES (1,'julia@mail.com')

INSERT INTO Telefone(IdPessoa,Numero)
VALUES (1,'112546897')

SELECT * FROM Pessoa
SELECT * FROM Email
SELECT * FROM Telefone

