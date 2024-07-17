using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribQuadra
    {
        public TribQuadra()
        {
            TribQuadraLogradTributos = new HashSet<TribQuadraLogradTributo>();
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
            TribTerrenos = new HashSet<TribTerreno>();
            Tribquadradivergencia = new HashSet<Tribquadradivergencium>();
        }

        public int QuadraId { get; set; }
        public string? QuadraCodLocal { get; set; }
        public string QuadraCodLocalGeo { get; set; } = null!;
        /// <summary>
        /// Situação da conferência cadastral: [O]K ou [D]ivergente.
        /// </summary>
        public string? Flsituacaoconferencia { get; set; }
        /// <summary>
        /// Obervação para a conferência da quadra.
        /// </summary>
        public string? Dsobservacao { get; set; }
        /// <summary>
        /// ID do usuário (RP) que fez a revisão.
        /// </summary>
        public int? Idusuariorevisao { get; set; }

        public virtual ICollection<TribQuadraLogradTributo> TribQuadraLogradTributos { get; set; }
        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
        public virtual ICollection<Tribquadradivergencium> Tribquadradivergencia { get; set; }
    }
}
