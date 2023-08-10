--DML

insert into TiposDeUsuario(TituloTipoUsuario)
Values('Administrador'),('Comum')

insert into Instituicao(CNPJ,NomeFantasia,Endereco)
Values('12345678911212','Senai','Rua nitéroi 104')


insert into TiposEvento(TituloTipoEvento)
Values('SQL Server')

insert into Usuario(IdTiposDeUsuario,Nome,Email,Senha)
Values(1,'admin','admin@email.com','12345')

insert into Evento(TiposDeEvento,IdInstituicao,NomeEvento,Descricao,DataEvento,HorarioEvento)
Values(1,1,'Introdução ao Banco SQL Server','Curso direcionado ao aprendizado dos conceitos basicos do banco de dados SQL Server','10/08/2023','09:00:00')

insert into ComentarioEvento(IdUsuario,IdEvento,Descricao,Exibe)
Values(1,1,'excelente evento',1)

insert into PresencasEvento(IdUsuario,IdEvento,Situacao)
Values(1,1,0)

select * from TiposDeUsuario
select * from Instituicao
select * from TiposEvento
select * from Usuario
select * from Evento
select * from ComentarioEvento
select * from PresencasEvento
