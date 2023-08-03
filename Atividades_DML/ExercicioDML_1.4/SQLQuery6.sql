USE Empresa_Musical;

INSERT INTO Artistas(Nome)
VALUES ('Gorillaz')


INSERT INTO Estilos(Nome)
VALUES ('R&B')

--Caso esteja ativo = 1
--Caso Não =0

INSERT INTO Albuns(IdArtista,Titulo,DataLancamento,QDeMinutos,Ativo)
VALUES (3,'Plastich Beach','23/11/2015',190,0)

SELECT *  FROM Artistas;
SELECT *FROM Albuns;
SELECT * FROM Estilos;
