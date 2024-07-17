using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class LocBoleto
    {
        public LocBoleto()
        {
            LocBaixas = new HashSet<LocBaixa>();
            Lblocacaos = new HashSet<Locacao>();
        }

        public string BolNossoNumero { get; set; } = null!;
        public int? BolConvenioId { get; set; }
        public decimal? BolVlrDivida { get; set; }
        public decimal? BolVlrCorrM { get; set; }
        public decimal? BolVlrMulta { get; set; }
        public decimal? BolVlrJuros { get; set; }
        public DateTime? BolVencimento { get; set; }
        public DateTime? BolDataLimite { get; set; }
        public string? BolLinhaDigitavel { get; set; }
        public string? BolCodBarra { get; set; }
        public string? BolTecUltAlt { get; set; }
        public DateTime? BolDtUltAlt { get; set; }

        public virtual ConvenioBanco? BolConvenio { get; set; }
        public virtual ICollection<LocBaixa> LocBaixas { get; set; }

        public virtual ICollection<Locacao> Lblocacaos { get; set; }
    }
}
