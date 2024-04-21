using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Tbtribtipoempresa
    {
        public Tbtribtipoempresa()
        {
            Tbtribtipoempresadocumentos = new HashSet<Tbtribtipoempresadocumento>();
            TribAtivAtividadeDocumentos = new HashSet<TribAtivAtividadeDocumento>();
            TribAtivAtividadePergunta = new HashSet<TribAtivAtividadePergunta>();
        }

        public short Idtipoempresa { get; set; }
        public string Dstipoempresa { get; set; } = null!;
        public string? Dslegislacao { get; set; }
        public string? Dsinformacao { get; set; }
        public bool? Flinscricaoobrigatorio { get; set; }
        public bool? Flzoneamentoobrigatorio { get; set; }
        public bool? Fldomiciliotributario { get; set; }

        public virtual ICollection<Tbtribtipoempresadocumento> Tbtribtipoempresadocumentos { get; set; }
        public virtual ICollection<TribAtivAtividadeDocumento> TribAtivAtividadeDocumentos { get; set; }
        public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; }
    }
}
