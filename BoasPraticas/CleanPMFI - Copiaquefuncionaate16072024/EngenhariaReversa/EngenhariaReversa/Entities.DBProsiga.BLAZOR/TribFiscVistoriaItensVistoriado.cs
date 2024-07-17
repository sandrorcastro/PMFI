using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFiscVistoriaItensVistoriado
    {
        public int VistId { get; set; }
        public int ItemVistId { get; set; }
        public string? Regular { get; set; }
        public string? VistItemInformacaoAdicional { get; set; }
        public DateTime? DataInclusao { get; set; }
        public short? ItemVistPrazo { get; set; }

        public virtual TribFiscItensVistorium ItemVist { get; set; } = null!;
        public virtual TribFiscVistoria Vist { get; set; } = null!;
    }
}
