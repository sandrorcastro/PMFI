using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Feriado
    {
        public int FerId { get; set; }
        public DateTime FerData { get; set; }
        public string FerTipo { get; set; } = null!;
        public string FerDescricao { get; set; } = null!;
        public string FerStatus { get; set; } = null!;
    }
}
