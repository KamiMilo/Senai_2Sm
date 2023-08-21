CREATE DATABASE Filmes
USE Filmes

CREATE TABLE Genero
(
	IdGenero INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(50)
)

CREATE TABLE Filme
(
	IdFilme INT PRIMARY KEY IDENTITY,
	IdGenero INT FOREIGN KEY REFERENCES Genero(IdGenero),
	Titulo VARCHAR(50)
)

INSERT INTO Genero (Nome)
VALUES
('Fantasia'),
('Suspense'),
('Romance')

INSERT INTO Filme (IdGenero,Titulo)
VALUES
(1,'Barbie'),
(2,'Noite passada em soho'),
(3,'Emma')


SELECT * FROM Filme
SELECT * FROM genero