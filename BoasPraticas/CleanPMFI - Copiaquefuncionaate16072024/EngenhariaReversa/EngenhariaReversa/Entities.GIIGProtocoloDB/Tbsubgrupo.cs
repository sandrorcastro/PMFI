using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class Tbsubgrupo
    {
        public int Idsubgrupo { get; set; }
        public string Nmsubgrupo { get; set; } = null!;
        public int Idgrupo { get; set; }
    }
}
