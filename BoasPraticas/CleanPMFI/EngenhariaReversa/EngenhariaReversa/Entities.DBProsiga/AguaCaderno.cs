using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class AguaCaderno
    {
        public int CadernoId { get; set; }
        public string? Nome { get; set; }
        public int? Distrito { get; set; }
    }
}
