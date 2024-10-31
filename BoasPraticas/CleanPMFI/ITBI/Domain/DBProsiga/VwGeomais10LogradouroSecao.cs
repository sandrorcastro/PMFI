using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VwGeomais10LogradouroSecao
    {
        public int CdLogradouro { get; set; }
        public string? CdSecao { get; set; }
        public string CdLadoSecao { get; set; } = null!;
        public string? CdDistrito { get; set; }
        public string? CdSetor { get; set; }
        public string CdBairro { get; set; } = null!;
        public decimal? VlMetroQuadrado { get; set; }
        public string NrCep { get; set; } = null!;
        public string Zona { get; set; } = null!;
    }
}
