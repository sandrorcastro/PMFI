using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribCmoficio
    {
        public int OficioId { get; set; }
        public int OficioNumero { get; set; }
        public short OficioAno { get; set; }
        public long? EdificacaoId { get; set; }
        public int? EdiId { get; set; }
        public string OficioTipo { get; set; } = null!;
        public DateTime OficioData { get; set; }

        public virtual TribEditalLanc? Edi { get; set; }
        public virtual TribEdificaco? Edificacao { get; set; }
    }
}
