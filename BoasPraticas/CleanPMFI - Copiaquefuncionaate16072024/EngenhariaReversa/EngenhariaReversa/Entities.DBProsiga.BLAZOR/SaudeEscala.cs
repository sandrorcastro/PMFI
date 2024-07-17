using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeEscala
    {
        public SaudeEscala()
        {
            SaudeAgendaXxxxxxes = new HashSet<SaudeAgendaXxxxxx>();
            SaudeEscalaUnidadeSaudes = new HashSet<SaudeEscalaUnidadeSaude>();
            IdDiaSemanas = new HashSet<DiaSemana>();
        }

        public int IdEscala { get; set; }
        public long IdFuncionario { get; set; }
        public long IdCategoria { get; set; }
        public int IdunidadeSaude { get; set; }
        public DateTime DataInicioEscala { get; set; }
        public DateTime? DataFimEscala { get; set; }
        public DateTime HoraInicioEscala { get; set; }
        public DateTime? HoraFimEscala { get; set; }
        public string? Status { get; set; }
        public int? NroAtendimentos { get; set; }
        public int NroRetornos { get; set; }
        public string? Obs { get; set; }
        public DateTime? Data { get; set; }
        public string? Usuario { get; set; }

        public virtual SaudeServidorCategProf Id { get; set; } = null!;
        public virtual UnidadeSaude IdunidadeSaudeNavigation { get; set; } = null!;
        public virtual ICollection<SaudeAgendaXxxxxx> SaudeAgendaXxxxxxes { get; set; }
        public virtual ICollection<SaudeEscalaUnidadeSaude> SaudeEscalaUnidadeSaudes { get; set; }

        public virtual ICollection<DiaSemana> IdDiaSemanas { get; set; }
    }
}
