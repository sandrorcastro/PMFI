using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AutoNumAnoNumero
    {
        /// <summary>
        /// Pode ser o nome da tabela ou algo que queira controlar.
        /// </summary>
        public string AutTipo { get; set; } = null!;
        public short AutAno { get; set; }
        public long AutNumero { get; set; }
    }
}
