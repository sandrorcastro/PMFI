using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbDspTiposEstornoEmpenho
    {
        public TbDspTiposEstornoEmpenho()
        {
            TbDspEstornosEmpenhos = new HashSet<TbDspEstornosEmpenho>();
        }

        public short IdTipoEstornoEmpenho { get; set; }
        public string? DsTipoEstornoEmpenho { get; set; }
        public bool? FlRap { get; set; }

        public virtual ICollection<TbDspEstornosEmpenho> TbDspEstornosEmpenhos { get; set; }
    }
}
