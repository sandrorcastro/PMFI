using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribEquipamento
    {
        public TribEquipamento()
        {
            Edificacaos = new HashSet<TribEdificaco>();
        }

        public int EquipId { get; set; }
        public string? EquipNome { get; set; }
        public decimal? EquipFator { get; set; }
        public int? EquipPontos { get; set; }

        public virtual ICollection<TribEdificaco> Edificacaos { get; set; }
    }
}
