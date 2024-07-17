using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribEdificacoesInsencoesMinhaCasa
    {
        public TribEdificacoesInsencoesMinhaCasa()
        {
            ImoIddivida = new HashSet<TribDividasImo>();
            ImoIddividaNavigation = new HashSet<TribDividasImo>();
        }

        public long IdIsencao { get; set; }
        public DateTime? DtContrato { get; set; }
        public long? EdificacaoId { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TribEdificaco? Edificacao { get; set; }

        public virtual ICollection<TribDividasImo> ImoIddivida { get; set; }
        public virtual ICollection<TribDividasImo> ImoIddividaNavigation { get; set; }
    }
}
