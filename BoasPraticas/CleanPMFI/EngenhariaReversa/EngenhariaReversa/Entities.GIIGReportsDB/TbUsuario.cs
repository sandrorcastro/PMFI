using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGReportsDB
{
    public partial class TbUsuario
    {
        public string DsLogin { get; set; } = null!;
        public string? NmUsuario { get; set; }
        public byte[]? DsSenha { get; set; }
        public bool? FlAtivo { get; set; }
        public bool FlDba { get; set; }
        public string? DsEmail { get; set; }
    }
}
