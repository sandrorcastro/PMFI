using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGAlvaraConstrucaoDB
{
    public partial class TabSolicitaco
    {
        public TabSolicitaco()
        {
            TabSolicitacaoAtividades = new HashSet<TabSolicitacaoAtividade>();
        }

        public int SoliId { get; set; }
        public int PessId { get; set; }
        public string SoliInscricaoImobiliaria { get; set; } = null!;
        public short ZozoId { get; set; }
        public short ZousId { get; set; }
        public decimal SoliAreaConstrucao { get; set; }
        public int ProcId { get; set; }
        public DateTime SoliData { get; set; }

        public virtual TabPessoa Pess { get; set; } = null!;
        public virtual ICollection<TabSolicitacaoAtividade> TabSolicitacaoAtividades { get; set; }
    }
}
