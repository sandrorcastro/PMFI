using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGConsultaPreviaDB
{
    public partial class TabDocumento
    {
        public TabDocumento()
        {
            TabConsultaDocumentos = new HashSet<TabConsultaDocumento>();
            TabDocumentoCnaes = new HashSet<TabDocumentoCnae>();
            TabDocumentoCnaetipoContribuintes = new HashSet<TabDocumentoCnaetipoContribuinte>();
            IdTipoContribuintes = new HashSet<TabTipoContribuinte>();
        }

        public int DocuId { get; set; }
        public string? DocuNome { get; set; }
        public string? DocuObrigatorio { get; set; }

        public virtual ICollection<TabConsultaDocumento> TabConsultaDocumentos { get; set; }
        public virtual ICollection<TabDocumentoCnae> TabDocumentoCnaes { get; set; }
        public virtual ICollection<TabDocumentoCnaetipoContribuinte> TabDocumentoCnaetipoContribuintes { get; set; }

        public virtual ICollection<TabTipoContribuinte> IdTipoContribuintes { get; set; }
    }
}
