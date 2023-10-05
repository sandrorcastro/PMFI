using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifCosif
    {
        public int Idcontacosif { get; set; }
        public DateTime Dtcriacao { get; set; }
        public DateTime? Dtextinsao { get; set; }
        public int? Idcontasup { get; set; }
        public string Stnomeconta { get; set; } = null!;
        public string Stdescfuncao { get; set; } = null!;
    }
}
