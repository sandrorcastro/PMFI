using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class EncerramentoDividaMenor
    {
        public decimal Vltotal { get; set; }
        public int Idconta { get; set; }
        public int Idencerramento { get; set; }
        public byte Numescompetencia { get; set; }
        public short Nuanocompetencia { get; set; }
        public string Sttiporecolhimento { get; set; } = null!;
        public string? Stim { get; set; }
        public byte Idregime { get; set; }
        public int? QtdeNfse { get; set; }
        public decimal? TotalDivida { get; set; }
        public long? PrimeiraDivida { get; set; }
    }
}
