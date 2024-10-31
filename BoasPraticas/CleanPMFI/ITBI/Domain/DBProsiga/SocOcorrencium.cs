using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class SocOcorrencium
    {
        public long OcorId { get; set; }
        public long? PasseId { get; set; }
        public DateTime? OcorDataRetirada { get; set; }
        public long? ConId { get; set; }
        public DateTime? OcorPasseDataValidade { get; set; }
        public string? OcorPasseSituacao { get; set; }
        public string? OcorPassePeriodo { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual SocPasse? Passe { get; set; }
    }
}
