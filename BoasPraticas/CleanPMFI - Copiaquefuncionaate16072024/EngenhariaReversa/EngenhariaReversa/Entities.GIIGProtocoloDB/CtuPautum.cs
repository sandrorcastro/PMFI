using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class CtuPautum
    {
        public int Id { get; set; }
        public string CodPauta { get; set; } = null!;
        public string? DataHoraCriado { get; set; }
        public string? Ata { get; set; }
        public int Ativo { get; set; }
        public string? DataReuniao { get; set; }
        public int? Finalizado { get; set; }
    }
}
