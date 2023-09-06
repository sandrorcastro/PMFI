using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbGerPrazosEntrega
    {
        public TbGerPrazosEntrega()
        {
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbDspSolicitacoesEmpenhos = new HashSet<TbDspSolicitacoesEmpenho>();
            TbLicCotacaoItens = new HashSet<TbLicCotacaoIten>();
            TbLicLicitacos = new HashSet<TbLicLicitaco>();
        }

        public short IdPrazoEntrega { get; set; }
        public string? DsPrazoEntrega { get; set; }
        public short? NrDias { get; set; }

        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbDspSolicitacoesEmpenho> TbDspSolicitacoesEmpenhos { get; set; }
        public virtual ICollection<TbLicCotacaoIten> TbLicCotacaoItens { get; set; }
        public virtual ICollection<TbLicLicitaco> TbLicLicitacos { get; set; }
    }
}
