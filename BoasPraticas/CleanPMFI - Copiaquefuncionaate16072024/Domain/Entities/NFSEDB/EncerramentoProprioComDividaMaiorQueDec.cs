using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class EncerramentoProprioComDividaMaiorQueDec
    {
        public decimal? VlDeclarado { get; set; }
        public int Idencerramento { get; set; }
        public byte Numescompetencia { get; set; }
        public short Nuanocompetencia { get; set; }
        public string Sttiporecolhimento { get; set; } = null!;
        public string? Stim { get; set; }
        public byte Idregime { get; set; }
        public decimal? TotalDivida { get; set; }
        public long? PrimeiraDivida { get; set; }
    }
}
