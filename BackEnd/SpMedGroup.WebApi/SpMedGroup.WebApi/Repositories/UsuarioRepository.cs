using Microsoft.EntityFrameworkCore;
using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        SpMedGroupContext ctx = new SpMedGroupContext();

        public void Atualizar(int id, Usuario novoUsuario)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);

            if(usuarioBuscado != null)
            {
                if (novoUsuario.Email != null)
                {
                    usuarioBuscado.Email = novoUsuario.Email;
                }

                if (novoUsuario.Senha != null)
                {
                    usuarioBuscado.Senha = novoUsuario.Senha;
                }

                if (novoUsuario.NomeUsuario != null)
                {
                    usuarioBuscado.NomeUsuario = novoUsuario.NomeUsuario;
                }

                if (novoUsuario.DataNasc != null)
                {
                    usuarioBuscado.DataNasc = novoUsuario.DataNasc;
                }

                if (novoUsuario.Telefone != null)
                {
                    usuarioBuscado.Telefone = novoUsuario.Telefone;
                }

                if (novoUsuario.Email != null)
                {
                    usuarioBuscado.Email = novoUsuario.Email;
                }

                if (novoUsuario.IdTipoUsuario != 0)
                {
                    usuarioBuscado.IdTipoUsuario = novoUsuario.IdTipoUsuario;
                }

                ctx.Usuario.Update(usuarioBuscado);

                ctx.SaveChanges();
            }
        }

        public Usuario BuscarId(int id)
        {
            Usuario usuarioBuscado = ctx.Usuario

                .Select(u => new Usuario() 
                { 
                    IdUsuario = u.IdUsuario,
                    NomeUsuario = u.NomeUsuario,
                    Email = u.Email,
                    DataNasc = u.DataNasc,
                    Telefone = u.Telefone,

                    IdTipoUsuarioNavigation = new TipoUsuario()
                    {
                        IdTipoUsuario = u.IdTipoUsuarioNavigation.IdTipoUsuario,
                        TituloTipoUsuario = u.IdTipoUsuarioNavigation.TituloTipoUsuario,
                    }

                })
                .FirstOrDefault(u => u.IdUsuario == id);

            if (usuarioBuscado != null)
            {
                return usuarioBuscado;
            }
            else
            {
                return null;
            }
        }

        public void Cadastrar(Usuario usuarioNovo)
        {
            ctx.Usuario.Add(usuarioNovo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuario usuarioBuscado = ctx.Usuario.Find(id);
            ctx.Usuario.Remove(usuarioBuscado);
            ctx.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return ctx.Usuario.Select(u => new Usuario()
            {
                IdUsuario = u.IdUsuario,
                NomeUsuario = u.NomeUsuario,
                Email = u.Email,
                DataNasc = u.DataNasc,
                Telefone = u.Telefone,

                IdTipoUsuarioNavigation = new TipoUsuario()
                {
                    IdTipoUsuario = u.IdTipoUsuarioNavigation.IdTipoUsuario,
                    TituloTipoUsuario = u.IdTipoUsuarioNavigation.TituloTipoUsuario,
                }

            })
            .ToList();
        }

        public Usuario Login(string email, string senha)
        {
            Usuario usuarioBuscado = ctx.Usuario
                .Include(u => u.IdTipoUsuarioNavigation)
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (usuarioBuscado != null)
            {
                return usuarioBuscado;
            }
            else
            {
                return null;
            }
        }
    }
}
