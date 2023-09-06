using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabDocumentoTipo
    {
        public TabDocumentoTipo()
        {
            TabAnexos = new HashSet<TabAnexo>();
            TabDocumentoTipoAssuntos = new HashSet<TabDocumentoTipoAssunto>();
            TabProtocolos = new HashSet<TabProtocolo>();
        }

        public int TipoDocId { get; set; }
        public string? TipoDocNome { get; set; }
        public string TipoDocFlAtivo { get; set; } = null!;
        /// <summary>
        /// Indica se pode ser enviado mais de uma vez o mesmo arquivo para o documento.
        /// </summary>
        public bool? Flmultiplosarquivos { get; set; }
        public byte[]? Bnmodelo { get; set; }
        public string? Nmarquivo { get; set; }
        public string? Contenttype { get; set; }

        public virtual ICollection<TabAnexo> TabAnexos { get; set; }
        public virtual ICollection<TabDocumentoTipoAssunto> TabDocumentoTipoAssuntos { get; set; }
        public virtual ICollection<TabProtocolo> TabProtocolos { get; set; }
    }
}
