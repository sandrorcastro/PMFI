using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicRegimesExecuco
    {
        public TbLicRegimesExecuco()
        {
            TbCntContratos = new HashSet<TbCntContrato>();
            IdClassificacaoObjetos = new HashSet<TbLicClassificacoesObjeto>();
        }

        public short IdRegimeExecucao { get; set; }
        public string? DsRegimeExecucao { get; set; }
        public string? FlPadraoTce { get; set; }
        public bool? FlAtivo { get; set; }
        public short? CdTc { get; set; }
        public string? TpObjeto { get; set; }

        public virtual ICollection<TbCntContrato> TbCntContratos { get; set; }

        public virtual ICollection<TbLicClassificacoesObjeto> IdClassificacaoObjetos { get; set; }
    }
}
