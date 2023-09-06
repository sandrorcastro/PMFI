using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class DetalhesManutencaoMovEq
    {
        public long DetId { get; set; }
        public int? DetCompServId { get; set; }
        public long? DetManId { get; set; }
        public string? DetDescricao { get; set; }
        public int? DetQtde { get; set; }
        public decimal? DetVlrTotal { get; set; }

        public virtual ComponentesServico? DetCompServ { get; set; }
        public virtual ManutencaoMoveisEquipamento? DetMan { get; set; }
    }
}
