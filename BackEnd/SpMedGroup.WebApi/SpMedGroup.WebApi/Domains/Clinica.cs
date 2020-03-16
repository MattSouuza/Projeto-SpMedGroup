using System;
using System.Collections.Generic;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Endereco = new HashSet<Endereco>();
            Medico = new HashSet<Medico>();
            Prontuario = new HashSet<Prontuario>();
        }

        public int IdClinica { get; set; }
        public string NomeClinica { get; set; }
        public TimeSpan HorarioComeço { get; set; }
        public TimeSpan HorarioTermino { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }

        public ICollection<Endereco> Endereco { get; set; }
        public ICollection<Medico> Medico { get; set; }
        public ICollection<Prontuario> Prontuario { get; set; }
    }
}
