using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivAtividadePergunta
    {
        public string Atividade { get; set; } = null!;
        public short Idtipoempresa { get; set; }
        public int Idpergunta { get; set; }
        public int Idresposta { get; set; }
        public short Iddocumento { get; set; }

        public virtual TribAtivDocumento IddocumentoNavigation { get; set; } = null!;
        public virtual Tbtribativpergunta IdperguntaNavigation { get; set; } = null!;
        public virtual Tbtribativresposta IdrespostaNavigation { get; set; } = null!;
        public virtual Tbtribtipoempresa IdtipoempresaNavigation { get; set; } = null!;
    }
}
