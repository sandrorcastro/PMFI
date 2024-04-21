using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TbtribZonaZoneamentoAtividadePergunta
    {
        /// <summary>
        /// ID do Zoneamento
        /// </summary>
        public short ZozoId { get; set; }
        /// <summary>
        /// Código da Atividade
        /// </summary>
        public string Atividade { get; set; } = null!;
        /// <summary>
        /// ID da pergunta.
        /// </summary>
        public int Idpergunta { get; set; }
        /// <summary>
        /// ID da resposta
        /// </summary>
        public int Idresposta { get; set; }
        /// <summary>
        /// Tipo da liberação.
        /// </summary>
        public short ZotlId { get; set; }
        /// <summary>
        /// Ordem da pergunta para atividade informada.
        /// </summary>
        public short? Nrordem { get; set; }
        /// <summary>
        /// Após respondido a pergunta, qual ação deve ser tomada. Avança ou Encerra o questionário.
        /// </summary>
        public string Flacao { get; set; } = null!;
        public bool Flexigedocumentacao { get; set; }

        public virtual TribAtivAtividade AtividadeNavigation { get; set; } = null!;
        public virtual Tbtribativpergunta IdperguntaNavigation { get; set; } = null!;
        public virtual Tbtribativresposta IdrespostaNavigation { get; set; } = null!;
        public virtual TribZonaTipoLiberacao Zotl { get; set; } = null!;
        public virtual TribZonaZoneamento Zozo { get; set; } = null!;
    }
}
