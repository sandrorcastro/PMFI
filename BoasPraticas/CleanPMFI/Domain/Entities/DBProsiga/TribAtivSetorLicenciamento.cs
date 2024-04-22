using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribAtivSetorLicenciamento
    {
        public TribAtivSetorLicenciamento()
        {
            Tbconsultapreviagrauriscoresposta = new HashSet<Tbconsultapreviagrauriscoresposta>();
            Tbconsultapreviagrauriscos = new HashSet<Tbconsultapreviagraurisco>();
            TribAtivAtividadeGrauRiscoPergunta = new HashSet<TribAtivAtividadeGrauRiscoPergunta>();
            TribAtivAtividadeGrauRiscos = new HashSet<TribAtivAtividadeGrauRisco>();
        }

        public short SetorId { get; set; }
        public string? SetorNome { get; set; }
        /// <summary>
        /// Assunto que será usado para criação do Protocolo Digital
        /// </summary>
        public int? AssuntoId { get; set; }
        public int? UnidadeId { get; set; }
        /// <summary>
        /// Assunto que será usado para criação do Protocolo Digital quando se tratar de MEI Domicilio Tributário
        /// </summary>
        public int? AssuntoIdmeidomicTrib { get; set; }
        public int? AssuntoIdmeiestab { get; set; }

        public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRisco> TribAtivAtividadeGrauRiscos { get; set; }
    }
}
