using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblFormHelpImg
    {
        public int Idform { get; set; }
        public int Idimg { get; set; }
        public string? NmImagem { get; set; }
        public byte[]? Imhelp { get; set; }
    }
}
