using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IProntuarioRepository
    {
        List<Prontuario> Listar();
        Prontuario BuscarId(int id);
        void Cadastrar(Prontuario prontuarioNovo);
        void Atualizar(int id, Prontuario novoProntuario);
        void Deletar(int id);
    }
}
