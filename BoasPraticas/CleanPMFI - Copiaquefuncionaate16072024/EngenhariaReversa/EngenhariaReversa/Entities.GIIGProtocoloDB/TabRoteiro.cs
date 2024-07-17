using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabRoteiro
    {
        public TabRoteiro()
        {
            Atris = new HashSet<TabAtributo>();
        }

        public short RoteId { get; set; }
        public short? AssuId { get; set; }
        public byte? RoteOrdem { get; set; }
        public short? UnidId { get; set; }
        public byte? RoteTempoEstimado { get; set; }
        public string? RoteParecerPadrao { get; set; }
        public string? RoteTarefas { get; set; }
        public bool? RoteTempoEspecifico { get; set; }

        public virtual TabAssunto? Assu { get; set; }
        public virtual TabUnidade? Unid { get; set; }

        public virtual ICollection<TabAtributo> Atris { get; set; }
    }
}
