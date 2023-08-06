--DQL

/*listar todos os veterinários (nome e CRMV) de uma clínica (razão social)*/ 
Select
Veterinario.Nome,Clinica.Nome as clinica

From
Veterinario

left Join
Clinica ON Veterinario.IdClinica = Clinica.IdClinica

WHERE Veterinario.IdClinica = 4

/*listar todas as raças que começam com a letra S*/

Select
Raca.Nome

from 
Raca

WHERE Raca.Nome LIKE 'S%'
ORDER BY Raca.IDRaca

/* listar todos os tipos de pet que terminam com a letra O*/
Select
Pet.Nome

from 
Pet

WHERE Pet.Nome LIKE '%o'
ORDER BY Pet.IdPet

/*listar todos os pets mostrando os nomes dos seus donos*/ 

Select
Pet.Nome as Pet ,Dono.Nome as Dono

from
Pet

Left Join
Dono on Pet.IdDono = Dono.IdDono

/* listar todos os atendimentos mostrando o nome do veterinário que atendeu, o nome,
a raça e o tipo do pet que foi atendido,o nome do dono do pet e o nome da clínica onde o pet foi atendido.*/


SELECT
Veterinario.Nome as Veterinario,
Pet.Nome as Pet,
Tipo.Nome as Tipo,
Dono.Nome as Dono,
Clinica.Nome as Clinica

FROM 
Atendimento

Left Join
Veterinario on Atendimento.IdVeterinario= Veterinario.IdVeterinario

left Join
Pet on Atendimento.IdPet = Pet.IdPet

left join
Tipo on Pet.IdTipo = Tipo.IdTipo

left join
Dono on Pet.IdDono= Dono.IdDono

left join
Clinica on Veterinario.IdClinica= Clinica.Idclinica


SELECT * FROM Pet
SELECT * FROM Atendimento
SELECT * FROM Veterinario
SELECT * FROM Tipo
SELECT * FROM Dono
Select * from Clinica
SELECT * FROM Raca