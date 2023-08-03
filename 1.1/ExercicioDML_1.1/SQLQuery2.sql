--DML
USE ExercicioPessoa

INSERT INTO Pessoa (Nome,CNH)
VALUES ('Julia','0123456878')

INSERT INTO Email(IdPessoa,Endereço)
VALUES (1,'julia@mail.com')

INSERT INTO Telefone(IdPessoa,Numero)
VALUES (1,'112546897')


--DQL

--Seleciona as colunas que irão aparecer
--AS= Altera o nome da coluna.
SELECT 
Pessoa.Nome AS Cliente,
Email.Endereço AS Email,
Pessoa.CNH,
Telefone.Numero AS Telefone

--FROM é tabela que vai ser Referenciada.  
--Traz todas as pessoas cadastradas mesmo tendo ou não tendo correspondecia(Dados) 
--nas tabelas email , ou telefone.
FROM
Pessoa

--JOIN= Traz apenas os cadrastros que tiverem os dados das tabelas correspondentes(Preenchidos); EMail e Telefone.

--LEFT JOIN = dá preferencia para a tabela da esquerda (Pessoa),e traz todos os cadrastros dessa tabela
--mesmo sem os outros dados correspondentes(Email e Telefone).

--RIGTH JOIN = Dá preferencia para a tabela da direita.

  LEFT JOIN 
Email ON Pessoa.IdPessoa = Email.IdPessoa
 LEFT JOIN 
Telefone ON Pessoa.IdPessoa = Telefone.IdPessoa



WHERE Telefone.Numero IS NULL

SELECT * FROM Pessoa
SELECT * FROM Telefone
SELECT * FROM Email




