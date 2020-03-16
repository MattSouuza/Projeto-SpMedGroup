using System;
using System.Collections.Generic;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Endereco
    {
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public int? IdClinica { get; set; }
        public int? IdUsuario { get; set; }

        public Clinica IdClinicaNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
