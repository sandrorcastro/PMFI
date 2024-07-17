using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaAviso
    {
        public int CoavId { get; set; }
        public int? ConsId { get; set; }
        public short? UnidId { get; set; }
        public DateTime? CoavData { get; set; }
        public string? CoavAviso { get; set; }
        public short? FuncId { get; set; }

        public virtual TabConsultum? Cons { get; set; }
        public virtual TabFuncionario? Func { get; set; }
        public virtual TabUnidade? Unid { get; set; }
    }
}
