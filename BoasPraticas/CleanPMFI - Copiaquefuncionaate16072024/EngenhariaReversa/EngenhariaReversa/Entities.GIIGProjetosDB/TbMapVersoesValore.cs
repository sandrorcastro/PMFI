using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProjetosDB
{
    public partial class TbMapVersoesValore
    {
        public int IdVersaoValores { get; set; }
        public int IdVersao { get; set; }
        public string? DsValor { get; set; }
        public DateTime? DtCadastro { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbMapVerso IdVersaoNavigation { get; set; } = null!;
    }
}
