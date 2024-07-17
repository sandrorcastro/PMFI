using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribComprovanteSitEmpresa
    {
        public long CompId { get; set; }
        public string CompTitulo { get; set; } = null!;
        public string CompTexto { get; set; } = null!;
        public string CompSitEmpr { get; set; } = null!;
        public long CompCmc { get; set; }
        public string CompCnpjcpf { get; set; } = null!;
        public string CompRazSocial { get; set; } = null!;
        public string CompNomeFant { get; set; } = null!;
        public string CompEndereco { get; set; } = null!;
        public string CompBairro { get; set; } = null!;
        public string CompCidade { get; set; } = null!;
        public string CompUf { get; set; } = null!;
        public DateTime CompAbertInscr { get; set; }
        public string CompEmprAtiv { get; set; } = null!;
        public string CompEmprAtivDenom { get; set; } = null!;
        public long CompMovId { get; set; }
        public DateTime CompMovData { get; set; }
        public string CompMovMotivo { get; set; } = null!;
        public int CompMovAnoProt { get; set; }
        public long CompMovNumProt { get; set; }
        public string CompMovProtAnt { get; set; } = null!;
        public string CompMovObs { get; set; } = null!;
        public DateTime CompData { get; set; }
        public string CompUsuario { get; set; } = null!;
    }
}
