using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabModelo
    {
        public TabModelo()
        {
            TabModeloAssuntos = new HashSet<TabModeloAssunto>();
        }

        public int ModeId { get; set; }
        public string? ModeNome { get; set; }
        public string? ModeDescricao { get; set; }
        public string? ModeModelo { get; set; }
        public string? ModeVersao { get; set; }

        public virtual ICollection<TabModeloAssunto> TabModeloAssuntos { get; set; }
    }
}
