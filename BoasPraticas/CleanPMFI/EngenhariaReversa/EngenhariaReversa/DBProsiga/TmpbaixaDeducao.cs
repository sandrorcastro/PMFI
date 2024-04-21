using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TmpbaixaDeducao
    {
        public int? BaixaId { get; set; }
        public string? NmBaixa { get; set; }
        public int? IdDeducao { get; set; }
        public string? NmDeducao { get; set; }
    }
}
