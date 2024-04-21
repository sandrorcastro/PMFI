using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribParcelamentoSn
    {
        public int ParcSnid { get; set; }
        public string? ParcSnprocesso { get; set; }
        public DateTime? ParcSndata { get; set; }
        public string? ParcSnmotivo { get; set; }
        public string? ParcSnquitado { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public long? EmprCmc { get; set; }
        public long? ConId { get; set; }
        public DateTime? ParcSndataConsolidacao { get; set; }
    }
}
