using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class AlmSaida
    {
        public AlmSaida()
        {
            AlmSaidasItens = new HashSet<AlmSaidasIten>();
        }

        public long SaidaId { get; set; }
        public DateTime? SaiData { get; set; }
        /// <summary>
        /// Servidor requisitante
        /// </summary>
        public long? ServidorId { get; set; }
        /// <summary>
        /// Divisão destino da requisicao
        /// </summary>
        public long? DivId { get; set; }
        public int? SaiTipoSaidaId { get; set; }
        public string? SaiObserv { get; set; }
        /// <summary>
        /// Usuario que esta atendendo a Requisitante
        /// </summary>
        public string? UsuId { get; set; }

        public virtual AlmTipoSaidum? SaiTipoSaida { get; set; }
        public virtual ICollection<AlmSaidasIten> AlmSaidasItens { get; set; }
    }
}
