using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivAtividadeDocumento
    {
        public string Atividade { get; set; } = null!;
        public short Idtipoempresa { get; set; }
        public short IdDocumento { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual TribAtivDocumento IdDocumentoNavigation { get; set; } = null!;
        public virtual Tbtribtipoempresa IdtipoempresaNavigation { get; set; } = null!;
    }
}
