using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DesifTarifasServicosInstituicao
    {
        public int Idtarserins { get; set; }
        public int Iddeclaracao { get; set; }
        public string Stidtarifa { get; set; } = null!;
        public string? Stdesctarifa { get; set; }
        public string Stsubtitulo { get; set; } = null!;
    }
}
