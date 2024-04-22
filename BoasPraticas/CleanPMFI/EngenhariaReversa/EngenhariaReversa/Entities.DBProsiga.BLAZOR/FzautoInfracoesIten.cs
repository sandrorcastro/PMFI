using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FzautoInfracoesIten
    {
        public FzautoInfracoesIten()
        {
            Fzdivida = new HashSet<Fzdivida>();
        }

        /// <summary>
        /// Código da infração.
        /// </summary>
        public long InfrId { get; set; }
        /// <summary>
        /// Número do auto de infração.
        /// </summary>
        public long AutiId { get; set; }
        /// <summary>
        /// Código de identificação da taxa.
        /// </summary>
        public int? TxId { get; set; }
        /// <summary>
        /// Valor da taxa a ser cobrada, caso o usuário não informe, colocar o valor default da taxa.
        /// </summary>
        public decimal AuItValor { get; set; }
        /// <summary>
        /// Observações sobre a infração.
        /// </summary>
        public string AuItObs { get; set; } = null!;

        public virtual FzautoInfraco Auti { get; set; } = null!;
        public virtual Fzinfraco Infr { get; set; } = null!;
        public virtual Fztaxa? Tx { get; set; }
        public virtual ICollection<Fzdivida> Fzdivida { get; set; }
    }
}
