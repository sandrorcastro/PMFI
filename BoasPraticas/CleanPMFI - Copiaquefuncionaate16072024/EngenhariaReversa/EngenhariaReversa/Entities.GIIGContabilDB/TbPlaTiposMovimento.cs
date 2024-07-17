using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaTiposMovimento
    {
        public TbPlaTiposMovimento()
        {
            TbPlaAcoesMetasMovimentos = new HashSet<TbPlaAcoesMetasMovimento>();
            TbPlaAcoesMovimentos = new HashSet<TbPlaAcoesMovimento>();
            TbPlaIndicadoresMovimentos = new HashSet<TbPlaIndicadoresMovimento>();
            TbPlaProgramasMovimentos = new HashSet<TbPlaProgramasMovimento>();
        }

        public short IdTipoMovimento { get; set; }
        public string? DsTipoMovimento { get; set; }

        public virtual ICollection<TbPlaAcoesMetasMovimento> TbPlaAcoesMetasMovimentos { get; set; }
        public virtual ICollection<TbPlaAcoesMovimento> TbPlaAcoesMovimentos { get; set; }
        public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; }
        public virtual ICollection<TbPlaProgramasMovimento> TbPlaProgramasMovimentos { get; set; }
    }
}
