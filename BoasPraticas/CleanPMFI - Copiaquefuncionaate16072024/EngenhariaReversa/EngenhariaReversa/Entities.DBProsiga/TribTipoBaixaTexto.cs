using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTipoBaixaTexto
    {
        public int BaTeId { get; set; }
        public int TipoBxId { get; set; }
        public long TextoId { get; set; }
        public short? AnoDivida { get; set; }

        public virtual TribTexto Texto { get; set; } = null!;
        public virtual TribTipoBaixa TipoBx { get; set; } = null!;
    }
}
