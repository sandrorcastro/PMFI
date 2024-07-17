using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class NfseTblServico
    {
        public NfseTblServico()
        {
            GuiaAvulsas = new HashSet<GuiaAvulsa>();
            NfseTblEmpresaContratosServicos = new HashSet<NfseTblEmpresaContratosServico>();
            NfseTblEmpresaServicoDeducaos = new HashSet<NfseTblEmpresaServicoDeducao>();
            NfseTblEmpresaServicos = new HashSet<NfseTblEmpresaServico>();
            NfseTblNaturezaOperacaoServicos = new HashSet<NfseTblNaturezaOperacaoServico>();
            NfseTblTipoDescontos = new HashSet<NfseTblTipoDesconto>();
        }

        public string Idservico { get; set; } = null!;
        public string? Stdescricao { get; set; }
        public decimal? Staliquota { get; set; }
        public string Strecolhemuni { get; set; } = null!;
        public string? Stsofrededucao { get; set; }
        public string? Stvetado { get; set; }
        public string? Stobrigaretencaonomunicipio { get; set; }
        public string? Stobrigaretencaofora { get; set; }
        public string? Stbaselegal { get; set; }

        public virtual ICollection<GuiaAvulsa> GuiaAvulsas { get; set; }
        public virtual ICollection<NfseTblEmpresaContratosServico> NfseTblEmpresaContratosServicos { get; set; }
        public virtual ICollection<NfseTblEmpresaServicoDeducao> NfseTblEmpresaServicoDeducaos { get; set; }
        public virtual ICollection<NfseTblEmpresaServico> NfseTblEmpresaServicos { get; set; }
        public virtual ICollection<NfseTblNaturezaOperacaoServico> NfseTblNaturezaOperacaoServicos { get; set; }
        public virtual ICollection<NfseTblTipoDesconto> NfseTblTipoDescontos { get; set; }
    }
}
