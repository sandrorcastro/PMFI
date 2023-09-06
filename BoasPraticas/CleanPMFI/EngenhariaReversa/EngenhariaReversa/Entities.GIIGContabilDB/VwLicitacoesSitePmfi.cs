using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class VwLicitacoesSitePmfi
    {
        public short? Ano { get; set; }
        public string? Modalidade { get; set; }
        public int? Numero { get; set; }
        public string Objeto { get; set; } = null!;
        public DateTime? DataAbertura { get; set; }
        public string? HoraAbertura { get; set; }
        public int? Faltam { get; set; }
        public string? Situacao { get; set; }
    }
}
