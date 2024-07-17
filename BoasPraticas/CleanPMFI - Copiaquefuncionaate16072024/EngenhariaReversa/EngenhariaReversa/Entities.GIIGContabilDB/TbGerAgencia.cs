using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerAgencia
    {
        public TbGerAgencia()
        {
            TbGerContasCorrentes = new HashSet<TbGerContasCorrente>();
        }

        public int IdAgencia { get; set; }
        public string? NrAgencia { get; set; }
        public string? NrDv { get; set; }
        public string? NmAgencia { get; set; }
        public string? CdBanco { get; set; }
        public int? IdCidade { get; set; }
        public string? CdAgenciaTc { get; set; }

        public virtual TbGerBanco? CdBancoNavigation { get; set; }
        public virtual TbGerCidade? IdCidadeNavigation { get; set; }
        public virtual ICollection<TbGerContasCorrente> TbGerContasCorrentes { get; set; }
    }
}
