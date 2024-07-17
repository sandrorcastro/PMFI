using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblFiss
    {
        public int Idfiss { get; set; }
        public int Idcontribuinte { get; set; }
        public int Idmunicipioestabelecimento { get; set; }
        public string? Stresponsavel { get; set; }
        public string Sttipodocumento { get; set; } = null!;
        public int Nunumero { get; set; }
        public DateTime Dtdata { get; set; }
        public string Issretido { get; set; } = null!;
        public decimal Vltotal { get; set; }
        public decimal Vlbasecalculoissqn { get; set; }
        public decimal Aliquota { get; set; }
        public decimal Vlissqn { get; set; }
        public int Iddivida { get; set; }
    }
}
