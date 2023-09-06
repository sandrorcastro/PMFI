using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbRelParametrizacoesDetalhesFormula
    {
        public TbRelParametrizacoesDetalhesFormula()
        {
            TbRelParametrizacoesExecucos = new HashSet<TbRelParametrizacoesExecuco>();
        }

        public int IdDetalheFormula { get; set; }
        public int? IdDetalhe { get; set; }
        public short? NrColuna { get; set; }
        public string? NmColuna { get; set; }
        public string? DsFormula { get; set; }

        public virtual ICollection<TbRelParametrizacoesExecuco> TbRelParametrizacoesExecucos { get; set; }
    }
}
