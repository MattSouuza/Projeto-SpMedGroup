using System;
using System.Collections.Generic;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Prontuario
    {
        public Prontuario()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdProntuario { get; set; }
        public string Descricao { get; set; }
        public int IdClinica { get; set; }
        public int IdUsuario { get; set; }

        public Clinica IdClinicaNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
        public ICollection<Consulta> Consulta { get; set; }
    }
}
