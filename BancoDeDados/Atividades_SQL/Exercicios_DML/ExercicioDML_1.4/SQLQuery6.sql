USE Exercicio1_4

INSERT INTO Artistas(Nome)
VALUES
('Gorillaz'),
('Kali Uchis'),
('Queen'),
('Seulgi')

INSERT INTO Estilos(Nome)
VALUES 
('R&B'),
('Rock'),
('Pop'),
('Alternativo')

--Caso esteja ativo = 1
--Caso Não =0

INSERT INTO Albuns(IdArtista,IdEstilo,Titulo,DataLancamento,QDeMinutos,Ativo)
VALUES
(1,1,'Plastich Beach','26/07/2018',280,1),
(3,2,'Queen','05/07/1985',350,0),
(4,3,'28 Reasons','26/05/2022',269,1)


--Usuario
INSERT INTO Usuarios(Nome,Email,Senha,Permissao)
VALUES
('Desk','Desk@email.com','12345',1),
('Maju','Maju@email.com','54321',0)



SELECT *  FROM Artistas;
SELECT *FROM Albuns;
SELECT * FROM Estilos;
