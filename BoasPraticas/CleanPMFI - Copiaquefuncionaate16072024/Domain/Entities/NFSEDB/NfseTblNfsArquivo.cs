using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblNfsArquivo
    {
        public int Idnfsarquivo { get; set; }
        public byte[] Binarquivo { get; set; } = null!;
        public int Idcontribuinte { get; set; }
        public DateTime Dtenvio { get; set; }
        public string Ststatus { get; set; } = null!;
        public string? Idusuario { get; set; }
        public string? Sterros { get; set; }
    }
}
