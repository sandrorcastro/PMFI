using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEditalCompra
    {
        public TribEditalCompra()
        {
            TribEditalComprasContribuintes = new HashSet<TribEditalComprasContribuinte>();
        }

        public long EdiId { get; set; }
        public int? EdiAno { get; set; }
        public int? EdiNumero { get; set; }
        public string? EditObjetoDescr { get; set; }
        public byte[]? EditObjeto { get; set; }
        public DateTime? EditDataAbertura { get; set; }
        public string? EditHoraAbertura { get; set; }
        public int? LocId { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? EditValor { get; set; }
        public int? TplId { get; set; }
        public string? EditNomeArquivo { get; set; }

        public virtual Localizacao? Loc { get; set; }
        public virtual ICollection<TribEditalComprasContribuinte> TribEditalComprasContribuintes { get; set; }
    }
}
