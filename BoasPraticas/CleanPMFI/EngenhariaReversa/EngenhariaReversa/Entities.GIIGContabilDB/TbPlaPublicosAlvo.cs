using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaPublicosAlvo
    {
        public TbPlaPublicosAlvo()
        {
            TbPlaIndicadoresMovimentos = new HashSet<TbPlaIndicadoresMovimento>();
            TbPlaProgramasObjetivosMeta = new HashSet<TbPlaProgramasObjetivosMeta>();
        }

        public int IdPublicoAlvo { get; set; }
        public string? DsPublicoAlvo { get; set; }
        public short? IdTipoPublicoAlvo { get; set; }

        public virtual ICollection<TbPlaIndicadoresMovimento> TbPlaIndicadoresMovimentos { get; set; }
        public virtual ICollection<TbPlaProgramasObjetivosMeta> TbPlaProgramasObjetivosMeta { get; set; }
    }
}
