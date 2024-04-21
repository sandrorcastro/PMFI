using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class Fzinfraco
    {
        public Fzinfraco()
        {
            FzautoInfracoesItens = new HashSet<FzautoInfracoesIten>();
        }

        public long InfrId { get; set; }
        /// <summary>
        /// Número da lei de infrações.
        /// </summary>
        public string LeiNumAno { get; set; } = null!;
        /// <summary>
        /// Artigo 
        /// </summary>
        public string InfrArtigo { get; set; } = null!;
        /// <summary>
        /// Descrição do Artigo.
        /// </summary>
        public string InfrDescrArtigo { get; set; } = null!;

        public virtual Fzlei LeiNumAnoNavigation { get; set; } = null!;
        public virtual ICollection<FzautoInfracoesIten> FzautoInfracoesItens { get; set; }
    }
}
