using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinCompensacaoDiarioTesourarium
    {
        public int IdCompensacaoDiario { get; set; }
        public int? IdLancamentoDiario { get; set; }
        public short? NrSequencial { get; set; }
        public int? IdExtrato { get; set; }
        public int? IdConciliacao { get; set; }
        public DateTime? DtCompensacao { get; set; }
        public decimal? VlCompensacao { get; set; }
        public int? IdEstorno { get; set; }
        public string? FlTipo { get; set; }
        public string? FlOrigem { get; set; }

        public virtual TbFinExtratosBancario? IdExtratoNavigation { get; set; }
    }
}
