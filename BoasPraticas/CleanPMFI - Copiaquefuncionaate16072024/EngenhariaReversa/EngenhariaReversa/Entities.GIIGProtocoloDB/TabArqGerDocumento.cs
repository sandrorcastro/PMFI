using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabArqGerDocumento
    {
        public TabArqGerDocumento()
        {
            TabArqGerArquivos = new HashSet<TabArqGerArquivo>();
        }

        public int DocumentoId { get; set; }
        public string DocumentoNome { get; set; } = null!;

        public virtual ICollection<TabArqGerArquivo> TabArqGerArquivos { get; set; }
    }
}
