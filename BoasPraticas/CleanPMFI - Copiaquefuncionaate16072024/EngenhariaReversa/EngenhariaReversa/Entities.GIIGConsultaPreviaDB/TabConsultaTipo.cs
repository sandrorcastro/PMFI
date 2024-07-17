using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabConsultaTipo
    {
        public short TipoId { get; set; }
        public string? TipoTexto1 { get; set; }
        public string? TipoTexto2 { get; set; }
        public string? TipoTitulo { get; set; }
        public string? TipoRodape { get; set; }
        public string? TextoCompTitulo { get; set; }
        public string? TextoCompRodape { get; set; }
    }
}
