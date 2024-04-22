using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class Abastecimento
    {
        public long AbastecimentoId { get; set; }
        public long? AbVeiculoId { get; set; }
        public int? AbNumAutoriz { get; set; }
        public DateTime? AbData { get; set; }
        public decimal? AbQuilometragem { get; set; }
        public decimal? AbQtdeLitros { get; set; }
        public decimal? AbVlrAbastec { get; set; }

        public virtual Veiculo? AbVeiculo { get; set; }
    }
}
