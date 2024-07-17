using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicClassificacoesObjeto
    {
        public TbLicClassificacoesObjeto()
        {
            TbDspEmpenhos = new HashSet<TbDspEmpenho>();
            TbDspItens = new HashSet<TbDspIten>();
            TbLicLimites = new HashSet<TbLicLimite>();
            IdRegimeExecucaos = new HashSet<TbLicRegimesExecuco>();
        }

        public short IdClassificacaoObjeto { get; set; }
        public string? DsClassificacaoObjeto { get; set; }
        public string? FlPadraoTce { get; set; }
        public string? DsSigla { get; set; }
        public string? FlUsaEmpenho { get; set; }
        public short? CdTc { get; set; }
        public bool? FlAtivo { get; set; }

        public virtual ICollection<TbDspEmpenho> TbDspEmpenhos { get; set; }
        public virtual ICollection<TbDspIten> TbDspItens { get; set; }
        public virtual ICollection<TbLicLimite> TbLicLimites { get; set; }

        public virtual ICollection<TbLicRegimesExecuco> IdRegimeExecucaos { get; set; }
    }
}
