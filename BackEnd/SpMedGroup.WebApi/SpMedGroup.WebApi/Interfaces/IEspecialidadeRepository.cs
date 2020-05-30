using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IEspecialidadeRepository
    {
        List<Especialidade> Listar();
        Especialidade BuscarId(int id);
        void Cadastrar(Especialidade EspecialidadeNova);
        void Atualizar(int id, Especialidade novaEspecialidade);
        void Deletar(int id);
    }
}
