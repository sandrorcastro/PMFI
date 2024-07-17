using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpAlmoxarifado
    {
        public int? IdFonteDados { get; set; }
        public short? IdEmpresa { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? Descricao { get; set; }
        public string? Produto { get; set; }
        public decimal? Quantidade { get; set; }
        public string? Unidade { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorUnitario { get; set; }
    }
}
