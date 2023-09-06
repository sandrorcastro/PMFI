using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbtribativpergunta
    {
        public Tbtribativpergunta()
        {
            Tbconsultapreviadocumentoresposta = new HashSet<Tbconsultapreviadocumentoresposta>();
            Tbconsultapreviagrauriscoresposta = new HashSet<Tbconsultapreviagrauriscoresposta>();
            Tbconsultapreviazoneamentoresposta = new HashSet<Tbconsultapreviazoneamentoresposta>();
            TbtribZonaZoneamentoAtividadePergunta = new HashSet<TbtribZonaZoneamentoAtividadePergunta>();
            TribAtivAtividadeGrauRiscoPergunta = new HashSet<TribAtivAtividadeGrauRiscoPergunta>();
            TribAtivAtividadePergunta = new HashSet<TribAtivAtividadePergunta>();
        }

        /// <summary>
        /// Identificação do registro.
        /// </summary>
        public int Idpergunta { get; set; }
        /// <summary>
        /// Descrição da pergunta
        /// </summary>
        public string? Dspergunta { get; set; }
        /// <summary>
        /// Número da pergunta (Se houver)
        /// </summary>
        public int? Nrpergunta { get; set; }
        /// <summary>
        /// Indica que a pergunta será exibida quando o resultado da Consulta Prévia der PROIBIDO.
        /// </summary>
        public bool? Flperguntacnaeproibido { get; set; }
        public string? Dssecretaria { get; set; }
        public string? CoIdentificadorPergunta { get; set; }

        public virtual ICollection<Tbconsultapreviadocumentoresposta> Tbconsultapreviadocumentoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviazoneamentoresposta> Tbconsultapreviazoneamentoresposta { get; set; }
        public virtual ICollection<TbtribZonaZoneamentoAtividadePergunta> TbtribZonaZoneamentoAtividadePergunta { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; }
        public virtual ICollection<TribAtivAtividadePergunta> TribAtivAtividadePergunta { get; set; }
    }
}
