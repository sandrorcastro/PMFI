using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribProcTemplate
    {
        public int TempleId { get; set; }
        public string TempleTitulo { get; set; } = null!;
        public string TempleDescricao { get; set; } = null!;
        public byte[] TempleConteudo { get; set; } = null!;
        public string TempleExtensao { get; set; } = null!;
    }
}
