using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TempLimpezaPublica
    {
        public long? EdificacaoId { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        public decimal? Area { get; set; }
    }
}
