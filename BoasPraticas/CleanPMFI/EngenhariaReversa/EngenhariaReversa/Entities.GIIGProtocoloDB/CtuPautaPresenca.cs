using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class CtuPautaPresenca
    {
        public int Id { get; set; }
        public string DataHora { get; set; } = null!;
        public int IdPauta { get; set; }
        public int IdUsuario { get; set; }
    }
}
