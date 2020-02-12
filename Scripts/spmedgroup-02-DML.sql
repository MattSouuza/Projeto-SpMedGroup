USE SpMedGroup;
GO

INSERT INTO Clinica (NomeClinica, HorarioFuncionamento, CNPJ, RazaoSocial)
VALUES ('Clínica São Paulo', '8h00 às 18h00', '12345678912345', 'São Paulo Medical Group'),
		('Clínica Santa Clara', '9h00 às 19h00', '12345678912345', 'São Paulo Medical Group');
GO

INSERT INTO TipoUsuario (TituloTipoUsuario)
VALUES ('Paciente'), ('Médico'), ('Administrador');
GO

INSERT INTO Especialidade (NomeEspecialidade)
VALUES ('Acupuntura'),
		('Anestesiologia'),
		('Angiologia'),
		('Cardiologia'),
		('Cirurgia Cardiovascular'),
		('Cirurgia da Mão'),
		('Cirurgia do Aparelho Digestivo'),
		('Cirurgia Geral'),
		('Cirurgia Pediátrica'),
		('Cirurgia Plástica'),
		('Cirurgia Torácica'),
		('Cirurgia Vascular'),
		('Dermatologia'),
		('Radioterapia'),
		('Urologia'),
		('Pediatria'),
		('Psiquiatria');
GO


INSERT INTO Usuario (NomeUsuario, Email, Senha, DataNasc, Telefone, RG, CPF, IdTipoUsuario)
VALUES ('Ricardo','ricardo.lemos@spmedicalgroup.com.br', 'Ric123','19/09/1999','1 2345-6789', '1232434', '2', 1),
		('Roberto','roberto.possarle@spmedicalgroup.com.br', 'Poss123', '19/09/1999','1 2345-6789', '32323', '1', 1),
		('Helena','helena.souza@spmedicalgroup.com.br', 'Hel123', '19/09/1999','1 2345-6789', '3244', '3', 1),
		('Ligia','Ligia@gmail.com', 'ligia123', '19/09/1999','1 2345-6789', '324432', '4', 1),
		('Alexandre','Alexandre@gmail.com', 'Alex123', '19/09/1999','1 2345-6789', '342', '5', 1),
		('Fernando','Fernando@gmail.com', 'Fer123', '19/09/1999','1 2345-6789', '4324', '6', 1),
		('Henrique','Henrique@gmail.com', 'Henr123', '19/09/1999','1 2345-6789', '7474', '7', 1),
		('João','Joao@gmail.com', 'Joao123', '19/09/1999','1 2345-6789', '457', '8', 2),
		('Bruno','Bruno@gmail.com', 'Bru123', '19/09/1999','1 2345-6789', '745', '9', 2),
		('Mariana','Mariana@gmail.com', 'Mari123', '19/09/1999','1 2345-6789', '7445745', '0', 2),
		('Administrador','adm@email.com', 'adm234', '19/09/1999','1 2345-6789', '123742434', '00', 3);
GO

INSERT INTO Medico (CRM, IdUsuario, IdEspecialidade, IdClinica)
VALUES ('54356-SP', 8, 2, 1), ('53452-SP', 10, 17, 2), ('65463-SP', 9, 16, 1);
GO

INSERT INTO Prontuario (Descricao, IdClinica, IdUsuario)
VALUES ('Paciente tem bronquite', 1, 3),
		('Paciente tem asma', 1, 2 ),
		('Paciente tem câncer', 2, 5),
		('Paciente tem corona vírus', 2, 4);
GO

INSERT INTO Consulta (Descricao, DataConsulta, Situacao, IdMedico, IdProntuario)
VALUES ('Consulta foi ok', '20/01/2020 15:00','Realizada', 1, 1),
		('Consulta foi ok', '20/01/2020 15:00','Cancelado', 2, 4),
		('Consulta foi ok', '20/05/2020 15:00','Agendada', 2, 4),
		('Consulta foi ok', '20/01/2020 15:00','Realizada', 3, 3),
		('Consulta foi ok', '20/01/2020 15:00','Realizada', 1, 2);
GO

INSERT INTO Endereco (Rua, Numero, Bairro, Cidade, Estado, Complemento, IdClinica)
VALUES ('Rua Barão', '32', 'República', 'São Paulo', 'SP', 'Ao lado de uma praça', 1),
		('Rua Camarão', '32', 'República', 'São Paulo', 'SP', 'Ao lado de uma praça', 2);
GO

INSERT INTO Endereco (Rua, Numero, Bairro, Cidade, Estado, Complemento, IdUsuario)
VALUES ('Rua Machado', '65', 'República', 'São Paulo', 'SP', 'Ao lado do mêtro', 8),
		('Rua Sara', '435', 'Barra Funda', 'São Paulo', 'SP', 'Ao lado do mêtro', 9),
		('Rua Matt', '666', 'Vila Buarque', 'São Paulo', 'SP', 'Ao lado do mêtro', 10);
GO

SELECT * FROM Clinica;
SELECT * FROM TipoUsuario;
SELECT * FROM Usuario; 
SELECT * FROM Especialidade;
SELECT * FROM Medico;
SELECT * FROM Consulta
SELECT * FROM Prontuario;
SELECT * FROM Endereco;