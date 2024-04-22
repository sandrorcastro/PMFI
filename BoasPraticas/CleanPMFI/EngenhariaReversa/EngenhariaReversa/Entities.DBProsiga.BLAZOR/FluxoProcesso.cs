using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class FluxoProcesso
    {
        /// <summary>
        /// Identificação do Fluxo de Processos
        /// </summary>
        public long FluxoProcessoId { get; set; }
        /// <summary>
        /// Identificação do tipo de processo
        /// </summary>
        public int? FptipoProcesso { get; set; }
        /// <summary>
        /// Sequencia da etapa em relação ao fluxo do tipo de processo
        /// </summary>
        public int? Fpsequencia { get; set; }
        /// <summary>
        /// Setor origem daquela etapa do fluxo do processo
        /// </summary>
        public int? FpdivEtapa { get; set; }
        /// <summary>
        /// Ação a ser tomada nesta etapa do fluxo
        /// </summary>
        public string? FpacaoEtapa { get; set; }
        /// <summary>
        /// Dias de permanencia do processo nessa etapa.
        /// </summary>
        public int? FptempoTramitacao { get; set; }

        public virtual Diviso? FpdivEtapaNavigation { get; set; }
        public virtual TipoProcesso? FptipoProcessoNavigation { get; set; }
    }
}
