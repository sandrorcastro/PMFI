using System;
using System.Collections.Generic;

namespace Domain.Entities.NFSEDB
{
    public partial class NfseTblEmpresaContrato
    {
        public NfseTblEmpresaContrato()
        {
            NfseTblEmpresaContratosAnexos = new HashSet<NfseTblEmpresaContratosAnexo>();
            NfseTblEmpresaContratosServicos = new HashSet<NfseTblEmpresaContratosServico>();
        }

        public int Idempcont { get; set; }
        public int Idempresa { get; set; }
        public string Sttomcpfcnpj { get; set; } = null!;
        public string Sttomrazaosocial { get; set; } = null!;
        public string? Sttomtelefone { get; set; }
        public string? Stresponsavel { get; set; }
        public string? Stendcep { get; set; }
        public int? Idendcidade { get; set; }
        public string? Stendlogr { get; set; }
        public string? Nuendnumero { get; set; }
        public string? Stendcomplemento { get; set; }
        public string? Stendbairro { get; set; }
        public string Stdescricao { get; set; } = null!;
        public string? Idusuario { get; set; }
        public string Nunumerocont { get; set; } = null!;
        public string? Stunidadeeconomica { get; set; }

        public virtual NfseTblEmpresa IdempresaNavigation { get; set; } = null!;
        public virtual NfseTblCidade? IdendcidadeNavigation { get; set; }
        public virtual ICollection<NfseTblEmpresaContratosAnexo> NfseTblEmpresaContratosAnexos { get; set; }
        public virtual ICollection<NfseTblEmpresaContratosServico> NfseTblEmpresaContratosServicos { get; set; }
    }
}
