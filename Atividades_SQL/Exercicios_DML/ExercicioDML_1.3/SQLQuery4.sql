--DQL

--AS = Altera Nome da Tabela Na hora de exibir
--SELECT = Traz Colunas
--FROM = de quais Tabelas
--Where= codi��o para filtrar os cadastros a serrem exibidos
SELECT 
Pessoa.Nome,
Pessoa.CNH, 
Email.Endere�o AS Email,
Telefone.Numero AS Telefone
 
FROM 
Pessoa,
Email,
Telefone 

WHERE
Pessoa.IdPessoa = Email.IdPessoa 
AND Pessoa.IdPessoa = Telefone.IdPessoa

ORDER BY Nome DESC