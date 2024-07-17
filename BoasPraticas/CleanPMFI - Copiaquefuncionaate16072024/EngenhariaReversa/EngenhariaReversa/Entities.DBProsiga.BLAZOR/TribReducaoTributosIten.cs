using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribReducaoTributosIten
    {
        public TribReducaoTributosIten()
        {
            TribReducaoTributosItensDivida = new HashSet<TribReducaoTributosItensDivida>();
        }

        public int IdReducaoTributo { get; set; }
        public int IdReducao { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? VlReducao { get; set; }
        public decimal? VlComposicao { get; set; }
        public long? ImoIddividaDeducao { get; set; }
        public long? EmprIddividaDeducao { get; set; }
        public long? ConIddividaDeducao { get; set; }

        public virtual TribReducaoTributo IdReducaoNavigation { get; set; } = null!;
        public virtual ICollection<TribReducaoTributosItensDivida> TribReducaoTributosItensDivida { get; set; }
    }
}
