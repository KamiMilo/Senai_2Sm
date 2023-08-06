
--DQL

/* listar todos os alugueis mostrando as datas de início e fim, 
o nome do cliente que alugou e nome do modelo do carro*/

--Nome dos atributos que vão ser exibidas
SELECT 
Aluguel.Retirada,Aluguel.Devolucao,Cliente.Nome,Modelo.Nome as Modelo

--tabela referenciada
FROM
Aluguel
 
 --2° tabela on tabela referencida = 2°tabela.nome_da_coluna
 left Join
 Cliente ON Aluguel.IdCliente = Cliente.IdCliente

 left join
 Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo

 Left join
 Modelo ON Veiculo.IdModelo= Modelo.IdModelo


/*listar os alugueis de um determinado cliente mostrando seu nome, 
as datas de início e fim e o nome do modelo do carro
Nome das colunas*/
SELECT 
Aluguel.Retirada,Aluguel.Devolucao,Cliente.Nome,Modelo.Nome as Modelo

--tabela referenciada
FROM
Aluguel
 
 left Join
 Cliente ON Aluguel.IdCliente = Cliente.IdCliente

 left join
 Veiculo ON Aluguel.IdVeiculo = Veiculo.IdVeiculo

 Left join
 Modelo ON Veiculo.IdModelo= Modelo.IdModelo


 WHERE Cliente.Nome = 'Julia'


SELECT * FROM Cliente;
SELECT * FROM Marca;
SELECT * FROM Modelo;
SELECT * FROM Veiculo;
SELECT * FROM Aluguel;