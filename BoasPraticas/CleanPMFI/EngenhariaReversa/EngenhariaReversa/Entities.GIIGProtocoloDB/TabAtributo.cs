using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabAtributo
    {
        public TabAtributo()
        {
            TabAtributoMovimentos = new HashSet<TabAtributoMovimento>();
            TabAtributoProcessos = new HashSet<TabAtributoProcesso>();
            Assus = new HashSet<TabAssunto>();
            Rotes = new HashSet<TabRoteiro>();
        }

        public int AtriId { get; set; }
        public string? AtriNome { get; set; }
        public string? AtriTipo { get; set; }
        public short? AtriTamanho { get; set; }
        public string? AtriDescricao { get; set; }

        public virtual ICollection<TabAtributoMovimento> TabAtributoMovimentos { get; set; }
        public virtual ICollection<TabAtributoProcesso> TabAtributoProcessos { get; set; }

        public virtual ICollection<TabAssunto> Assus { get; set; }
        public virtual ICollection<TabRoteiro> Rotes { get; set; }
    }
}
