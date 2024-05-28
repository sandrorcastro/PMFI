using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AutoNumAnoNumero
    {
        /// <summary>
        /// Pode ser o nome da tabela ou algo que queira controlar.
        /// </summary>
        public string AutTipo { get; set; } 
        public short AutAno { get; set; }
        public long AutNumero { get; set; }
    }
}
