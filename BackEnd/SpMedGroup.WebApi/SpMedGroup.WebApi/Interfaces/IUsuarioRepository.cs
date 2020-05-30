using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> Listar();
        Usuario BuscarId(int id);
        void Cadastrar(Usuario usuarioNovo);
        void Atualizar(int id, Usuario novoUsuario);
        void Deletar(int id);
        Usuario Login(string email, string senha);
    }
}
