using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class PerguntasZoneamento
    {
        public int Idtabela { get; set; }
        public string? Codigo { get; set; }
        public string? Atividade { get; set; }
        public string? P1 { get; set; }
        public int? IdP1 { get; set; }
        public string? P2 { get; set; }
        public int? IdP2 { get; set; }
    }
}
