using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcDescentralizacoesCredito
    {
        public TbOrcDescentralizacoesCredito()
        {
            TbOrcDescentralizacoesCreditosDotacos = new HashSet<TbOrcDescentralizacoesCreditosDotaco>();
        }

        public int IdDescentralizacao { get; set; }
        public short? IdEmpresa { get; set; }
        public short? NrAno { get; set; }
        public DateTime? DtDescentralizacao { get; set; }
        public string? DsTipo { get; set; }
        public string? DsHistorico { get; set; }
        public string? NrConvenio { get; set; }
        public DateTime? DtEvento { get; set; }
        public DateTime? DtPublicacao { get; set; }
        public DateTime? DtAnalise { get; set; }
        public string? DsSituacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual ICollection<TbOrcDescentralizacoesCreditosDotaco> TbOrcDescentralizacoesCreditosDotacos { get; set; }
    }
}
