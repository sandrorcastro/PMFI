using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbOrcAudienciaPublica
    {
        public int IdAudiencia { get; set; }
        public string? DsTitulo { get; set; }
        public string? DsAssunto { get; set; }
        public string? DsGestores { get; set; }
        public DateTime? DtAudiencia { get; set; }
        public short? NrAno { get; set; }
        public short? IdEmpresa { get; set; }
    }
}
