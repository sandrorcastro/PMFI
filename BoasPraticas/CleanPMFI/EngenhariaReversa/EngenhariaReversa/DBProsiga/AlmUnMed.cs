using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class AlmUnMed
    {
        public AlmUnMed()
        {
            AlmItens = new HashSet<AlmIten>();
            MoveisItens = new HashSet<MoveisIten>();
            ProdRurNotaFiscalItens = new HashSet<ProdRurNotaFiscalIten>();
            ProdRurProducaos = new HashSet<ProdRurProducao>();
            TbObrIntervencaos = new HashSet<TbObrIntervencao>();
            TribTipoPublicidades = new HashSet<TribTipoPublicidade>();
        }

        public int UnMedId { get; set; }
        public string? UnMedNome { get; set; }
        public string? UnMedSigla { get; set; }

        public virtual ICollection<AlmIten> AlmItens { get; set; }
        public virtual ICollection<MoveisIten> MoveisItens { get; set; }
        public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; }
        public virtual ICollection<ProdRurProducao> ProdRurProducaos { get; set; }
        public virtual ICollection<TbObrIntervencao> TbObrIntervencaos { get; set; }
        public virtual ICollection<TribTipoPublicidade> TribTipoPublicidades { get; set; }
    }
}
