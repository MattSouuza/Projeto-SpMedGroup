using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IConsultaRepository
    {
        List<Consulta> Listar();
        Consulta BuscarId(int id);
        void Agendar(Consulta ConsultaNova);
        void Atualizar(int id, Consulta consultaAtualizada);
        void Deletar(int id);
    }
}
