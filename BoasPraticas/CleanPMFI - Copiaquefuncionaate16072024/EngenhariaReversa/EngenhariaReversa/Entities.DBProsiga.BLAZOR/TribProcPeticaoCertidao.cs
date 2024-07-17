using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProcPeticaoCertidao
    {
        public long ProcPetId { get; set; }
        public long CertidaoDaid { get; set; }
        public long? IdVersaoCda { get; set; }

        public virtual TribCertidaoDum CertidaoDa { get; set; } = null!;
        public virtual TribProcPeticao ProcPet { get; set; } = null!;
    }
}
