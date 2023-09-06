using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGSystemDB
{
    public partial class TbSegFormulariosComentario
    {
        public int IdComentario { get; set; }
        public short IdForm { get; set; }
        public DateTime? DtComentario { get; set; }
        public string? DsLogin { get; set; }
        public string? DsComentario { get; set; }
        public string? DsResposta { get; set; }
    }
}
