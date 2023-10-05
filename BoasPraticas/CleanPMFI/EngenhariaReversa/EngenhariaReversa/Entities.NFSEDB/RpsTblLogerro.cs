using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class RpsTblLogerro
    {
        public int Idlogerros { get; set; }
        public long RpsNumeprot { get; set; }
        public string? RpsNumerps { get; set; }
        public DateTime Dtdatahora { get; set; }
        public string Stmsgerro { get; set; } = null!;
        public string? Stcodigoerro { get; set; }
    }
}
