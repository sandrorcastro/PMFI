using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbConsultaPreviaAux
    {
        public int? EmprCme { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public int? IdZoneamento { get; set; }
        public string? NomeZoneamento { get; set; }
        public string? SiglaZoneamento { get; set; }
        public string? OrigemZoneamento { get; set; }
    }
}
