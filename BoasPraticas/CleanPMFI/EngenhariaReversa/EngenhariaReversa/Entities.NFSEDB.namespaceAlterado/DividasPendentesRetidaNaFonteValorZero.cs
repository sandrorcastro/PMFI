using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class DividasPendentesRetidaNaFonteValorZero
    {
        public decimal Vltotal { get; set; }
        public int TipoTribId { get; set; }
        public string? TipoTribNome { get; set; }
        public int TipoBxId { get; set; }
        public string? TipoBxNome { get; set; }
        public int Idconta { get; set; }
        public int? Iddivida { get; set; }
        public int Idencerramento { get; set; }
        public long Divempid { get; set; }
    }
}
