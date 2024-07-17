using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class RedeSimLevantamento
    {
        public int IdtTabela { get; set; }
        public int? EmprCmc { get; set; }
        public int? ConId { get; set; }
        public string? Cpfcnpj { get; set; }
        public string? RazaoSocial { get; set; }
        public DateTime? InicioAtividade { get; set; }
        public string? Natureza { get; set; }
        public string? ConsLocalizador { get; set; }
        public string? ArquivoXml { get; set; }
    }
}
