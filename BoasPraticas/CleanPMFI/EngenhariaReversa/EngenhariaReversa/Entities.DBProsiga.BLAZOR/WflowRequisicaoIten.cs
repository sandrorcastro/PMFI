using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class WflowRequisicaoIten
    {
        public long RequiId { get; set; }
        public int WflowItemId { get; set; }
        public long? Quantidade { get; set; }

        public virtual WflowRequisicao Requi { get; set; } = null!;
        public virtual WflowItem WflowItem { get; set; } = null!;
    }
}
