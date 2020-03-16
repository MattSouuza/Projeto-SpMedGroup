using System;
using System.Collections.Generic;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Endereco = new HashSet<Endereco>();
            Medico = new HashSet<Medico>();
            Prontuario = new HashSet<Prontuario>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime? DataNasc { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public int IdTipoUsuario { get; set; }

        public TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Medico> Medico { get; set; }
        public ICollection<Prontuario> Prontuario { get; set; }
    }
}
