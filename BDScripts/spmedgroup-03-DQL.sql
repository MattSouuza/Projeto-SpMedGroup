USE SpMedGroup;

SELECT Consulta.IdConsulta,
		Consulta.Descricao,
		Consulta.DataConsulta,
		Consulta.Situacao,
		Prontuario.IdProntuario,
		Prontuario.Descricao,
		Usuario.NomeUsuario,
		Clinica.NomeClinica
FROM Consulta
INNER JOIN Prontuario ON Consulta.IdProntuario = Prontuario.IdProntuario
INNER JOIN Usuario ON Prontuario.IdUsuario = Usuario.IdUsuario
INNER JOIN Clinica ON Prontuario.IdClinica = Clinica.IdClinica

SELECT Consulta.IdConsulta,
		Consulta.Descricao,
		Consulta.DataConsulta,
		Consulta.Situacao,
		Prontuario.IdProntuario,
		Prontuario.Descricao,
		Usuario.NomeUsuario,
		Medico.IdMedico,
		Clinica.NomeClinica
FROM Consulta
INNER JOIN Prontuario ON Consulta.IdProntuario = Prontuario.IdProntuario
INNER JOIN Usuario ON Prontuario.IdUsuario = Usuario.IdUsuario
INNER JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
INNER JOIN Clinica ON Prontuario.IdClinica = Clinica.IdClinica 

CREATE PROCEDURE MedicoEspecialidade
@CampoBusca INT
AS
SELECT Medico.IdMedico, Especialidade.NomeEspecialidade
FROM Medico
INNER JOIN Especialidade ON Medico.IdEspecialidade = Especialidade.IdEspecialidade
WHERE Medico.IdEspecialidade = @CampoBusca;

EXECUTE MedicoEspecialidade 2;