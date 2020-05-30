using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IEnderencoRepository
    {
        List<Especialidade> Listar();
        Especialidade BuscarId(int id);
        void Cadastrar(Especialidade EspecialidadeNovo);
        void Atualizar(int id, Especialidade novoEspecialidade);
        void Deletar(int id);
    }
}
