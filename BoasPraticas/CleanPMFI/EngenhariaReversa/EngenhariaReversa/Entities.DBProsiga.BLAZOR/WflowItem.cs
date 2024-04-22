using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class WflowItem
    {
        public WflowItem()
        {
            WflowRequisicaoItens = new HashSet<WflowRequisicaoIten>();
        }

        public int WflowItemId { get; set; }
        public string? WflowItemDescr { get; set; }

        public virtual ICollection<WflowRequisicaoIten> WflowRequisicaoItens { get; set; }
    }
}
