using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Fztaxa
    {
        public Fztaxa()
        {
            FzautoInfracoesItens = new HashSet<FzautoInfracoesIten>();
            Fzdivida = new HashSet<Fzdivida>();
            FztipoVists = new HashSet<FztipoVistorium>();
        }

        public int TxId { get; set; }
        public string? TxNome { get; set; }
        public decimal? TxCoeficiente { get; set; }
        public int? TxReferId { get; set; }
        /// <summary>
        /// Código de identificação da receita contábil.
        /// </summary>
        public string? CodReceita { get; set; }

        public virtual Fzreferencia? TxRefer { get; set; }
        public virtual ICollection<FzautoInfracoesIten> FzautoInfracoesItens { get; set; }
        public virtual ICollection<Fzdivida> Fzdivida { get; set; }

        public virtual ICollection<FztipoVistorium> FztipoVists { get; set; }
    }
}
