using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TipoProcesso
    {
        public TipoProcesso()
        {
            FluxoProcessos = new HashSet<FluxoProcesso>();
            Processos = new HashSet<Processo>();
            TribTipoTributosTipoProcessos = new HashSet<TribTipoTributosTipoProcesso>();
            DocProDocs = new HashSet<Documento>();
        }

        public int TipoProId { get; set; }
        public string? TipoProNome { get; set; }
        /// <summary>
        /// dias previstos para a tramitação do processo
        /// </summary>
        public int? TipoProDiasTramite { get; set; }
        public int? TipoProPermanencia { get; set; }

        public virtual ICollection<FluxoProcesso> FluxoProcessos { get; set; }
        public virtual ICollection<Processo> Processos { get; set; }
        public virtual ICollection<TribTipoTributosTipoProcesso> TribTipoTributosTipoProcessos { get; set; }

        public virtual ICollection<Documento> DocProDocs { get; set; }
    }
}
