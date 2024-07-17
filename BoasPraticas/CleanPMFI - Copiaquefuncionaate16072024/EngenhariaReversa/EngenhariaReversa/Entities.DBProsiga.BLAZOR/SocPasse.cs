using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SocPasse
    {
        public SocPasse()
        {
            SocComposicaoPasses = new HashSet<SocComposicaoPasse>();
            SocOcorrencia = new HashSet<SocOcorrencium>();
        }

        public long PasseId { get; set; }
        public DateTime? PasseDataValidade { get; set; }
        public DateTime? PasseDataCadastro { get; set; }
        public string? PasseAcompanhante { get; set; }
        public int? LocId { get; set; }
        public long? TpassId { get; set; }
        public string? PasseSituacao { get; set; }
        public DateTime? PasseDataSituacao { get; set; }
        /// <summary>
        /// Tipos: Manhã, Tarde, Noite, Integral, Manhã/Tarde, Manhã/Noite e Tarde/Noite.
        /// </summary>
        public string PassePeriodo { get; set; } = null!;

        public virtual Localizacao? Loc { get; set; }
        public virtual SocTipoPasse? Tpass { get; set; }
        public virtual ICollection<SocComposicaoPasse> SocComposicaoPasses { get; set; }
        public virtual ICollection<SocOcorrencium> SocOcorrencia { get; set; }
    }
}
