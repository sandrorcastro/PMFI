using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbTmpContasCorrente
    {
        public int Id { get; set; }
        public int? IdCc { get; set; }
        public string? NrCc { get; set; }
        public string? NmCc { get; set; }
        public string? Agencia { get; set; }
        public string? Banco { get; set; }
        public int? IdcontaContabil { get; set; }
    }
}
