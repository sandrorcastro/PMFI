using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeFarmaRequisicaoMedic
    {
        public SaudeFarmaRequisicaoMedic()
        {
            SaudeFarmaRequisicaoItems = new HashSet<SaudeFarmaRequisicaoItem>();
        }

        public long IdRequisicao { get; set; }
        public DateTime? Data { get; set; }
        public long? IdEstoque { get; set; }
        public long? IdAlmox { get; set; }
        public string? Usuario { get; set; }

        public virtual ICollection<SaudeFarmaRequisicaoItem> SaudeFarmaRequisicaoItems { get; set; }
    }
}
