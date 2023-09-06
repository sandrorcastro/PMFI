using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TempTempTribFiscReclamaco
    {
        public long ReclId { get; set; }
        public int TipoFiscId { get; set; }
        public long ConId { get; set; }
        public string? ReclLogradouro { get; set; }
        public string? ReclNumero { get; set; }
        public string? ReclComplemento { get; set; }
        public string? ReclTelefoneContato { get; set; }
        public string? ReclBairro { get; set; }
        public string ReclDados { get; set; } = null!;
        public string? ReclRetorno { get; set; }
        public string ReclStatus { get; set; } = null!;
        public DateTime? DataInclusao { get; set; }
        public string? UsuarioInclusao { get; set; }
        public string? Assunto { get; set; }
        public string? Finalizado { get; set; }
        public string? RecTransversal1 { get; set; }
        public string? RecTransversal2 { get; set; }
    }
}
