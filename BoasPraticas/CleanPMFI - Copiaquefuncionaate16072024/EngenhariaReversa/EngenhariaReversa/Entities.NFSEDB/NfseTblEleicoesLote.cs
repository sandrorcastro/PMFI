using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblEleicoesLote
    {
        public int Id { get; set; }
        public DateTime Dtgeracao { get; set; }
        public string Stusuario { get; set; } = null!;
        public int Nuremessa { get; set; }
        public int Nulote { get; set; }
        public int? Nuremessacorrec { get; set; }
        public string? Nuloteremcorrec { get; set; }
        public int Nuprotocolo { get; set; }
        public byte[]? Bnarquivo { get; set; }
        public string? Sttipoarquivo { get; set; }
    }
}
