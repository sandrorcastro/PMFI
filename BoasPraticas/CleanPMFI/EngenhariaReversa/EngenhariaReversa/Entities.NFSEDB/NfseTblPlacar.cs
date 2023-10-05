using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblPlacar
    {
        public DateTime? Dtcarga { get; set; }
        public int? Numsolicitaramcredencial { get; set; }
        public int? Numautorizadaemissao { get; set; }
        public int? Numnfseemitidas { get; set; }
        public int? Numtomadorescadastro { get; set; }
    }
}
