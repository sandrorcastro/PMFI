using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class DesifPlanoGeralContasComentado
    {
        public int Idpgcc { get; set; }
        public int Iddeclaracao { get; set; }
        public string Idconta { get; set; } = null!;
        public string Stnome { get; set; } = null!;
        public string? Stdescconta { get; set; }
        public string? Stcontasupe { get; set; }
        public int Idcontacosif { get; set; }
        public string Stcodtribdesif { get; set; } = null!;
    }
}
