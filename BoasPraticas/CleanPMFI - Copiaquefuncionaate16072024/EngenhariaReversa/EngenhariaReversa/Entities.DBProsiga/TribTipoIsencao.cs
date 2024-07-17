using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTipoIsencao
    {
        public TribTipoIsencao()
        {
            TribEdificacoesIsencaos = new HashSet<TribEdificacoesIsencao>();
            TipoTribs = new HashSet<TribTipoTributo>();
        }

        public int TipoIseId { get; set; }
        public string? Descricao { get; set; }
        public int? TipoBxId { get; set; }

        public virtual TribTipoBaixa? TipoBx { get; set; }
        public virtual ICollection<TribEdificacoesIsencao> TribEdificacoesIsencaos { get; set; }

        public virtual ICollection<TribTipoTributo> TipoTribs { get; set; }
    }
}
