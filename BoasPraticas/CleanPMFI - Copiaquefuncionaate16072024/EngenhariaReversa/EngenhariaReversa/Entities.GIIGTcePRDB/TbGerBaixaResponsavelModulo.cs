using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGTcePRDB
{
    public partial class TbGerBaixaResponsavelModulo
    {
        public int IdBaixa { get; set; }
        public int? IdResponsavel { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtBaixa { get; set; }
        public string? DsMotivo { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbGerResponsavelModulo? IdResponsavelNavigation { get; set; }
    }
}
