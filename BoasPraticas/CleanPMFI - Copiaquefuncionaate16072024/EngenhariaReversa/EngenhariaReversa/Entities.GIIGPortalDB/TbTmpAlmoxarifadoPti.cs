using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpAlmoxarifadoPti
    {
        public int? Id { get; set; }
        public string? Descricao { get; set; }
        public string? Produto { get; set; }
        public decimal? Quantidade { get; set; }
        public string? Unidade { get; set; }
        public decimal? ValorTotal { get; set; }
        public decimal? ValorUnitario { get; set; }
    }
}
