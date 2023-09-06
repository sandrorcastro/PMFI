using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFiscOrdemFiscalizacao
    {
        public int FiscOfid { get; set; }
        public int? FiscOfnumero { get; set; }
        public short? FiscOfano { get; set; }
        public DateTime? FiscOfdata { get; set; }
        public long? EmprCmc { get; set; }
        public short? FiscOfprazoConclusao { get; set; }
        public string? FiscOfdefinicao { get; set; }
        public int? TipoFiscId { get; set; }
        public string? FiscOfstatus { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? FiscOfdtFinalizado { get; set; }
    }
}
