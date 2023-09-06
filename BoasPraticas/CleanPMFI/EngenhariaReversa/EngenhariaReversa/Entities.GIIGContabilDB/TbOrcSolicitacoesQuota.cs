using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcSolicitacoesQuota
    {
        public TbOrcSolicitacoesQuota()
        {
            TbOrcQuotasOrcamentaria = new HashSet<TbOrcQuotasOrcamentaria>();
        }

        public int IdSolicitacao { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public string? CdOrgao { get; set; }
        public string? CdUnidade { get; set; }
        public int? IdFonte { get; set; }
        public int? IdRecurso { get; set; }
        public short? IdGrupo { get; set; }
        public DateTime? DtSolicitacao { get; set; }
        public decimal? VlSolicitado { get; set; }
        public string? DsHistorico { get; set; }
        public string? DsSituacao { get; set; }
        public DateTime? DtParecer { get; set; }
        public string? DsParecer { get; set; }
        public string? DsLoginParecer { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbOrcQuotasOrcamentaria> TbOrcQuotasOrcamentaria { get; set; }
    }
}
