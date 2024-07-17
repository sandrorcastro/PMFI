using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class HabTipoAtendimento
    {
        public HabTipoAtendimento()
        {
            HabAtendimentos = new HashSet<HabAtendimento>();
            Documentos = new HashSet<HabDocumento>();
        }

        public int TipoAtendimentoId { get; set; }
        /// <summary>
        /// Aquisicao Casa Própria, etc
        /// </summary>
        public string? NmAtendimento { get; set; }
        public string? Observacao { get; set; }

        public virtual ICollection<HabAtendimento> HabAtendimentos { get; set; }

        public virtual ICollection<HabDocumento> Documentos { get; set; }
    }
}
