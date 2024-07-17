using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class GuiaAvulsa
    {
        public GuiaAvulsa()
        {
            GuiaAvulsaAnexos = new HashSet<GuiaAvulsaAnexo>();
        }

        public long Id { get; set; }
        public string Resdocumento { get; set; } = null!;
        public string Resnome { get; set; } = null!;
        public string Rescep { get; set; } = null!;
        public string Reslogradouro { get; set; } = null!;
        public int? Resnumpredial { get; set; }
        public string Resbairro { get; set; } = null!;
        public string? Rescomplemento { get; set; }
        public string? Restelefone { get; set; }
        public int Residcidade { get; set; }
        public string? Resemail { get; set; }
        public string Doctprecolhimento { get; set; } = null!;
        public int Docidcidade { get; set; }
        public string Docresponsavel { get; set; } = null!;
        public string Doctipo { get; set; } = null!;
        public long Docnumero { get; set; }
        public DateTime Docdata { get; set; }
        public decimal Docvlservico { get; set; }
        public decimal Docvlbasecalculo { get; set; }
        public decimal Docaliquota { get; set; }
        public decimal Docvlissqn { get; set; }
        public decimal? Docvldeducao { get; set; }
        public long Docdividaid { get; set; }
        public string Docsituacao { get; set; } = null!;
        public string Docidservico { get; set; } = null!;
        public string? Documentoadicional { get; set; }
        public string? Nomeadicional { get; set; }
        public string? Resmotivocancelamento { get; set; }

        public virtual NfseTblServico DocidservicoNavigation { get; set; } = null!;
        public virtual ICollection<GuiaAvulsaAnexo> GuiaAvulsaAnexos { get; set; }
    }
}
