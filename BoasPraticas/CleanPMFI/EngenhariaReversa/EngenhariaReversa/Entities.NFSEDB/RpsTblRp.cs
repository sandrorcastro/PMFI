using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class RpsTblRp
    {
        public long RpsIdloterps { get; set; }
        public long RpsNumeprot { get; set; }
        public DateTime RpsDataenvio { get; set; }
        public DateTime? RpsDataprocessamento { get; set; }
        public int RpsNumerolote { get; set; }
        public string RpsCnpjprestador { get; set; } = null!;
        public string? RpsIm { get; set; }
        public int RpsQtderps { get; set; }
        public byte[] RpsLoterps { get; set; } = null!;
        public int RpsSituacaoLote { get; set; }
        public long? RpsProtocoloantigo { get; set; }
    }
}
