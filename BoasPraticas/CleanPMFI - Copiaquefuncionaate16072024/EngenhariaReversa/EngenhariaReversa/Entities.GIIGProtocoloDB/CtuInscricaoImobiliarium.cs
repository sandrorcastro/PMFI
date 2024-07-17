using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class CtuInscricaoImobiliarium
    {
        public int Id { get; set; }
        public int IdProcesso { get; set; }
        public string InscricaoImobiliaria { get; set; } = null!;
        public int Ativo { get; set; }
    }
}
