using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbPermisso
    {
        public string DsLogin { get; set; } = null!;
        public int IdBancoDados { get; set; }
        public string? DsLoginInclusao { get; set; }
        public DateTime? DtInclusao { get; set; }

        public virtual TbBancosDado IdBancoDadosNavigation { get; set; } = null!;
    }
}
