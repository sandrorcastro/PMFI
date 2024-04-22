using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class VwConsultapreviaListadocumento
    {
        public string Atividade { get; set; } = null!;
        public short SetorId { get; set; }
        public short Iddocumento { get; set; }
        public string? SetorNome { get; set; }
        public string? Dsdocumento { get; set; }
    }
}
