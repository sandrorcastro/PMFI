using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class ManutencaoVeiculo
    {
        public ManutencaoVeiculo()
        {
            DetalhesManutencaos = new HashSet<DetalhesManutencao>();
        }

        public long ManutencaoId { get; set; }
        public long? ManVeiculoId { get; set; }
        public long? ManVfornecedorId { get; set; }
        public DateTime? ManVdata { get; set; }
        public string? ManVdescricao { get; set; }
        public string? ManVsituacao { get; set; }

        public virtual Veiculo? ManVeiculo { get; set; }
        public virtual Contribuinte? ManVfornecedor { get; set; }
        public virtual ICollection<DetalhesManutencao> DetalhesManutencaos { get; set; }
    }
}
