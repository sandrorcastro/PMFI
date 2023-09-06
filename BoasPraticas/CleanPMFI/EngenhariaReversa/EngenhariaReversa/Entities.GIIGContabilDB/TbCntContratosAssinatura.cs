using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbCntContratosAssinatura
    {
        public int IdContrato { get; set; }
        public int IdPessoa { get; set; }
        public DateTime? DtRegistro { get; set; }

        public virtual TbCntContrato IdContratoNavigation { get; set; } = null!;
        public virtual TbGerPessoa IdPessoaNavigation { get; set; } = null!;
    }
}
