using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class UnidadeSaude
    {
        public UnidadeSaude()
        {
            SaudeAgendaVagas = new HashSet<SaudeAgendaVaga>();
            SaudeAutorizaAcessos = new HashSet<SaudeAutorizaAcesso>();
            SaudeEscalaUnidadeSaudes = new HashSet<SaudeEscalaUnidadeSaude>();
            SaudeEscalas = new HashSet<SaudeEscala>();
            SaudePsfs = new HashSet<SaudePsf>();
        }

        public int IdUnidadeSaude { get; set; }
        public string? NomeUnidadeSaude { get; set; }
        public string? RazaoSocial { get; set; }
        public int? IdTipoUnidade { get; set; }
        public int? IdEndereco { get; set; }
        public string? NuPredial { get; set; }
        public string? Complemento { get; set; }
        public int? IdDistritoSanitario { get; set; }
        public int? IdEsferaAdministrativa { get; set; }
        public int? IdNaturezaOrganizacao { get; set; }
        public int? IdTipoPrestador { get; set; }
        public string? Cnpj { get; set; }
        public string? IdCnes { get; set; }
        public long? LocalId { get; set; }

        public virtual ICollection<SaudeAgendaVaga> SaudeAgendaVagas { get; set; }
        public virtual ICollection<SaudeAutorizaAcesso> SaudeAutorizaAcessos { get; set; }
        public virtual ICollection<SaudeEscalaUnidadeSaude> SaudeEscalaUnidadeSaudes { get; set; }
        public virtual ICollection<SaudeEscala> SaudeEscalas { get; set; }
        public virtual ICollection<SaudePsf> SaudePsfs { get; set; }
    }
}
