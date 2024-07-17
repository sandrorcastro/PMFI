using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribEditalLanc
    {
        public TribEditalLanc()
        {
            TribCmoficios = new HashSet<TribCmoficio>();
            TribCmprocessos = new HashSet<TribCmprocesso>();
            TribEditalLancDivida = new HashSet<TribEditalLancDivida>();
            TribEditalLancVencs = new HashSet<TribEditalLancVenc>();
            TribEmpresasTiposAlvaras = new HashSet<TribEmpresasTiposAlvara>();
            TribOrigemDivida = new HashSet<TribOrigemDividum>();
        }

        public int EdiId { get; set; }
        public int? EdiNumero { get; set; }
        public short? EdiAno { get; set; }
        public DateTime? EdiData { get; set; }
        public long? TextoId { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        public string? Host { get; set; }

        public virtual ICollection<TribCmoficio> TribCmoficios { get; set; }
        public virtual ICollection<TribCmprocesso> TribCmprocessos { get; set; }
        public virtual ICollection<TribEditalLancDivida> TribEditalLancDivida { get; set; }
        public virtual ICollection<TribEditalLancVenc> TribEditalLancVencs { get; set; }
        public virtual ICollection<TribEmpresasTiposAlvara> TribEmpresasTiposAlvaras { get; set; }
        public virtual ICollection<TribOrigemDividum> TribOrigemDivida { get; set; }
    }
}
