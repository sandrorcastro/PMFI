using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivAtividadeGrauRiscoPergunta
    {
        public string Atividade { get; set; } = null!;
        public short SetorId { get; set; }
        public int Idpergunta { get; set; }
        public int Idresposta { get; set; }
        public int? Idrisco { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual Tbtribativpergunta IdperguntaNavigation { get; set; } = null!;
        public virtual Tbtribativresposta IdrespostaNavigation { get; set; } = null!;
        public virtual Tbtribgraurisco? IdriscoNavigation { get; set; }
        public virtual TribAtivSetorLicenciamento Setor { get; set; } = null!;
    }
}
