using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAcoesMeta
    {
        public TbPlaAcoesMeta()
        {
            TbPlaAcoesMetasMovimentos = new HashSet<TbPlaAcoesMetasMovimento>();
        }

        public int IdAcao { get; set; }
        public short NrAno { get; set; }
        public int? IdVersaoCriacao { get; set; }
        public int? IdMovimento { get; set; }
        public string? TpComando { get; set; }

        public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;
        public virtual ICollection<TbPlaAcoesMetasMovimento> TbPlaAcoesMetasMovimentos { get; set; }
    }
}
