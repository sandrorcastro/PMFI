using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbLicModelosDocto
    {
        public TbLicModelosDocto()
        {
            TbCntTiposContratos = new HashSet<TbCntTiposContrato>();
            TbLicClausulas = new HashSet<TbLicClausula>();
            TbLicLicitacoesDocumentos = new HashSet<TbLicLicitacoesDocumento>();
        }

        public short IdModelo { get; set; }
        public short? IdEmpresa { get; set; }
        public string? NmModelo { get; set; }
        public short? IdTipoDocumento { get; set; }

        public virtual TbLicTiposDocumento? IdTipoDocumentoNavigation { get; set; }
        public virtual ICollection<TbCntTiposContrato> TbCntTiposContratos { get; set; }
        public virtual ICollection<TbLicClausula> TbLicClausulas { get; set; }
        public virtual ICollection<TbLicLicitacoesDocumento> TbLicLicitacoesDocumentos { get; set; }
    }
}
