using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProtestoLote
    {
        public TribProtestoLote()
        {
            TribProtestoLoteCda = new HashSet<TribProtestoLoteCdum>();
            TribProtestoLoteCdahistoricoSituacaoDivida = new HashSet<TribProtestoLoteCdahistoricoSituacaoDividum>();
        }

        public int IdLote { get; set; }
        public DateTime? DtLote { get; set; }
        public string? FlSituacao { get; set; }
        public string? DsNomeArquivo { get; set; }
        public string? DsNomeArquivoRetorno { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsUsuarioInclusao { get; set; }
        public long? LoteNumero { get; set; }
        public short? LoteAno { get; set; }
        public int? IdDivisao { get; set; }

        public virtual Diviso? IdDivisaoNavigation { get; set; }
        public virtual ICollection<TribProtestoLoteCdum> TribProtestoLoteCda { get; set; }
        public virtual ICollection<TribProtestoLoteCdahistoricoSituacaoDividum> TribProtestoLoteCdahistoricoSituacaoDivida { get; set; }
    }
}
