using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class HabAtendimento
    {
        public HabAtendimento()
        {
            HabDocApresentados = new HashSet<HabDocApresentado>();
            HabOpcaoMoradia = new HashSet<HabOpcaoMoradium>();
            HabProblemasAtendimentos = new HashSet<HabProblemasAtendimento>();
        }

        public int AtendimentoId { get; set; }
        public long? ConId { get; set; }
        public int? TipoAtendimentoId { get; set; }
        /// <summary>
        /// Normal, Grávida, Idoso
        /// </summary>
        public string? TipoContribuinte { get; set; }
        public int? IdRegiao { get; set; }
        /// <summary>
        /// Quantas Pessoas habitam na moradia
        /// </summary>
        public int? PessoasMoradia { get; set; }
        public DateTime? DtPrevAtendimento { get; set; }
        public DateTime? DtAtendimento { get; set; }
        /// <summary>
        /// Agendado, Atendido,Ausente
        /// </summary>
        public string? Situacao { get; set; }
        public string? UsuId { get; set; }
        public string? Observacao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? InscricaoImobiliaria { get; set; }
        /// <summary>
        /// Data que o contribuinte escolheu aquele lote para  utilização.
        /// </summary>
        public DateTime? DtUltAltAnexLote { get; set; }

        public virtual Contribuinte? Con { get; set; }
        public virtual Regio? IdRegiaoNavigation { get; set; }
        public virtual HabTipoAtendimento? TipoAtendimento { get; set; }
        public virtual Usuario? Usu { get; set; }
        public virtual ICollection<HabDocApresentado> HabDocApresentados { get; set; }
        public virtual ICollection<HabOpcaoMoradium> HabOpcaoMoradia { get; set; }
        public virtual ICollection<HabProblemasAtendimento> HabProblemasAtendimentos { get; set; }
    }
}
