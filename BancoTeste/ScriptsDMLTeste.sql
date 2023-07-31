--DML- Data Manipulation Language 
USE Teste;

--INSERIR DADOS
INSERT INTO Funcionarios(nome)
VALUES ('Evelyn')

--ALTERAR DADOS NA TABELA
--alteração usando o id
UPDATE Funcionarios
SET Nome ='Caua' WHERE Idfuncionario = 3 

--UPDATE Funcionarios
--alteração feita pelo nome
SET Nome ='Caua' WHERE nome = 'Evelyn'

--EXCLUIR DADOS NA TABELA
DELETE FROM Funcionarios 
WHERE Idfuncionario = 2

DELETE FROM Funcionarios
WHERE Nome = 'Caua'