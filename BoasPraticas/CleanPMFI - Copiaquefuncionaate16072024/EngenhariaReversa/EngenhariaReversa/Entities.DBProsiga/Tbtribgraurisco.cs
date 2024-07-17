using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class Tbtribgraurisco
    {
        public Tbtribgraurisco()
        {
            Tbconsultapreviagrauriscoresposta = new HashSet<Tbconsultapreviagrauriscoresposta>();
            Tbconsultapreviagrauriscos = new HashSet<Tbconsultapreviagraurisco>();
            TribAtivAtividadeGrauRiscoPergunta = new HashSet<TribAtivAtividadeGrauRiscoPergunta>();
            TribAtivAtividadeGrauRiscos = new HashSet<TribAtivAtividadeGrauRisco>();
        }

        public int Idrisco { get; set; }
        public string? Dsrisco { get; set; }
        public int? Nrprioridade { get; set; }

        public virtual ICollection<Tbconsultapreviagrauriscoresposta> Tbconsultapreviagrauriscoresposta { get; set; }
        public virtual ICollection<Tbconsultapreviagraurisco> Tbconsultapreviagrauriscos { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRiscoPergunta> TribAtivAtividadeGrauRiscoPergunta { get; set; }
        public virtual ICollection<TribAtivAtividadeGrauRisco> TribAtivAtividadeGrauRiscos { get; set; }
    }
}
