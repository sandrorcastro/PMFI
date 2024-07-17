using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class EncerramentoSemDividum
    {
        public int Idencerramento { get; set; }
        public byte Numescompetencia { get; set; }
        public short Nuanocompetencia { get; set; }
        public decimal? Total { get; set; }
        public int? Iddivida { get; set; }
        public byte Idregime { get; set; }
        public string? Stnome { get; set; }
        public string? Stcpfcnpj { get; set; }
        public string? Stim { get; set; }
        public string? Stsituacao { get; set; }
    }
}
