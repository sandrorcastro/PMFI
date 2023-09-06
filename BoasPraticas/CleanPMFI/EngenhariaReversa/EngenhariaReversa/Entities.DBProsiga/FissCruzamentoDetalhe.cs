using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class FissCruzamentoDetalhe
    {
        public int Iddet { get; set; }
        public short? Id { get; set; }
        public string? Session { get; set; }
        public short? Mes { get; set; }
        public short? Ano { get; set; }
        public int? Total { get; set; }
    }
}
