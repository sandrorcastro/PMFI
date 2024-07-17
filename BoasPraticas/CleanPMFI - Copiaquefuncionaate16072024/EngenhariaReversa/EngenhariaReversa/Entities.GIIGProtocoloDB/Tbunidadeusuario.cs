using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class Tbunidadeusuario
    {
        public int Idunidadeusuario { get; set; }
        public short UnidId { get; set; }
        public int Idusuario { get; set; }
        public bool Flativo { get; set; }
        public int Idusuarioinclusao { get; set; }
        public DateTime Dtinclusao { get; set; }
        public int? Idusuarioexclusao { get; set; }
        public DateTime? Dtexclusao { get; set; }
    }
}
