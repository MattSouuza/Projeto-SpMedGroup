using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IClinicaRepository
    {
        List<Clinica> Listar();
        Clinica BuscarId(int id);
        void Cadastrar(Clinica ClinicaNovo);
        void Atualizar(int id, Clinica novoClinica);
        void Deletar(int id);
    }
}
