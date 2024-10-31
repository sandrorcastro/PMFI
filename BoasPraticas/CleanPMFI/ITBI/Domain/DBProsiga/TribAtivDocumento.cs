using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivDocumento
    {
        public TribAtivDocumento()
        {
            Tbconsultapreviadocumentos = new HashSet<Tbconsultapreviadocumento>();
            Tbtribtipoempresadocumentos = new HashSet<Tbtribtipoempresadocumento>();
            TribAtivAtividadeDocumentos = new HashSet<TribAtivAtividadeDocumento>();
            TribAtivAtividadePergunta = new HashSet<TribAtivAtividadePergunta>();
            TribAtivDocumentosDispensadoIddocumentoNavigations = new HashSet<TribAtivDocumentosDispensado>();
            TribAtivDocumentosDispensadoIddocumentodispensadoNavigations = new HashSet<TribAtivDocumentosDispensado>();
        }

        public short Iddocumento { get; set; }
        public string Dsdocumento { get; set; } = null!;
        public short SetorId { get; set; }
        /// <summary>
        /// Nome do documento que deverá ser apresentado ao Município.
        /// </summary>
        public string? Nmdocumento { get; set; }
        public int? Idautodeclaracao { get; set; }
        public bool? Flobrigatorio { get; set; }

        public virtual ICollection<Tbconsultapreviadocumento> Tbconsultapreviadocumentos { get; set; }
        public virtual ICollection<Tbtribtipoempresadocumento> Tbtribtipoempresadocumentos { get; set; }
        public virtual ICollection<TribAtivAtividadeDocumento> TribAtivAtividadeDocumentos { get; set; }
        public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; }
        public virtual ICollection<TribAtivDocumentosDispensado> TribAtivDocumentosDispensadoIddocumentoNavigations { get; set; }
        public virtual ICollection<TribAtivDocumentosDispensado> TribAtivDocumentosDispensadoIddocumentodispensadoNavigations { get; set; }
    }
}
