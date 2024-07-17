using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFiscTermoDeDevolucao
    {
        public TribFiscTermoDeDevolucao()
        {
            TribFiscTermoDeDevolucaoDocumentos = new HashSet<TribFiscTermoDeDevolucaoDocumento>();
            FiscIdtermoRetencaos = new HashSet<TribFiscTermoDeRetencao>();
        }

        public int FiscIdtermoDevolucao { get; set; }
        public long? TextoId { get; set; }
        public string? FiscProntuario { get; set; }
        public string? FiscMotivo { get; set; }
        public string? FiscUsuario { get; set; }
        public DateTime? FiscDataInclusao { get; set; }
        public string? FiscSituacao { get; set; }

        public virtual ICollection<TribFiscTermoDeDevolucaoDocumento> TribFiscTermoDeDevolucaoDocumentos { get; set; }

        public virtual ICollection<TribFiscTermoDeRetencao> FiscIdtermoRetencaos { get; set; }
    }
}
