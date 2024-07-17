using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribTipoTributosGrupo
    {
        public TribTipoTributosGrupo()
        {
            TbDivTipoCreditos = new HashSet<TbDivTipoCredito>();
            TribTipoTributos = new HashSet<TribTipoTributo>();
        }

        public int TrGrId { get; set; }
        public string? TrGrDescricao { get; set; }
        public bool? TrGrGeraCreditoInscricao { get; set; }
        public bool? TrGrGeraLctoCreditoInscricao { get; set; }

        public virtual ICollection<TbDivTipoCredito> TbDivTipoCreditos { get; set; }
        public virtual ICollection<TribTipoTributo> TribTipoTributos { get; set; }
    }
}
