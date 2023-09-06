using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribQuadraLogradTributo
    {
        public int QuadraId { get; set; }
        public int LogradId { get; set; }
        public int TipoTribId { get; set; }
        public short AnoCalculo { get; set; }
        public string? UsuarioInclusao { get; set; }
        public DateTime? DataInclusao { get; set; }
        /// <summary>
        /// Nome da maquina que fez a baixa.
        /// </summary>
        public string? HostMaquina { get; set; }

        public virtual TribQuadra Quadra { get; set; } = null!;
        public virtual TribTipoTributo TipoTrib { get; set; } = null!;
        public virtual TribQuadraLograd TribQuadraLograd { get; set; } = null!;
    }
}
